using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using NLog.Extensions.Logging;
using System.Text;
using TechBlog.Models.Hubs;

namespace TechBlog.Models.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        /// <summary>
        /// Enable application CORS policies
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static WebApplicationBuilder AddAppCORSPolicies(this WebApplicationBuilder builder)
        {
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: "all", policy =>
                {
                    policy.AllowAnyHeader();
                    policy.AllowAnyMethod();
                    policy.AllowAnyOrigin();
                    //policy.WithOrigins(new string[] { "http://localhost:4200/", "" });
                });
            });
            return builder;
        }

        /// <summary>
        /// Add application authenticaiton with Jwt Authentication
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static WebApplicationBuilder AddAppAuthentication(this WebApplicationBuilder builder)
        {
            builder.Services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(c =>
            {
                c.RequireHttpsMetadata = false;
                c.SaveToken = true;
                c.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("Jwt:Key").Value)),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    //ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
                c.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context =>
                    {
                        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                        {
                            context.Response.Headers.Add("IS-TOKEN-EXPIRED", "true");
                        }
                        return Task.CompletedTask;
                    }
                };
            });

            return builder;
        }

        /// <summary>
        /// Application swagger configurations
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static WebApplicationBuilder AddAppSwaggerGen(this WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("TechBlogAPI", new()
                {
                    Title = "Tech Blog API",
                    Version = "1",
                    Description = "Through this API documentations, you'll get the API list of Tech Blog API",
                    Contact = new()
                    {
                        Name = "Tech Buzz Ltd",
                        Email = "rajibsarker320@gmail.com",
                        Url = new Uri("https://rajibsarker320.blogspot.com/")
                    },
                });
                options.AddSecurityDefinition(name: "Bearer", securityScheme: new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    In = ParameterLocation.Header,
                    Description = "Enter the Bearer Authorization string as following: `Bearer Generated-Token`"
                });
                options.AddSecurityRequirement(securityRequirement: new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });

                // enabling the xml comments for api documentation
                //var xmlCommentsFileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //var xmlCommentsFilePath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFileName);
                //options.IncludeXmlComments(xmlCommentsFilePath);

                // write document comments for swagger
                List<string> xmlFiles = Directory.GetFiles(AppContext.BaseDirectory, "*.xml", SearchOption.TopDirectoryOnly).ToList();
                foreach (string fileName in xmlFiles)
                {
                    string xmlFilePath = Path.Combine(AppContext.BaseDirectory, fileName);
                    if (File.Exists(xmlFilePath))
                        options.IncludeXmlComments(xmlFilePath, includeControllerXmlComments: true);
                }
            });

            return builder;
        }

        /// <summary>
        /// Application signalR configurations
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static WebApplicationBuilder AddAppSignalR(this WebApplicationBuilder builder)
        {
            builder.Services.AddSignalR().AddHubOptions<MessageHub>(options =>
            {
                options.EnableDetailedErrors = true;
                options.EnableDetailedErrors = true;
                //options.KeepAliveInterval = TimeSpan.FromMinutes(15);
                //options.ClientTimeoutInterval = TimeSpan.FromMinutes(30);

                options.KeepAliveInterval = TimeSpan.FromSeconds(30);
                options.ClientTimeoutInterval = TimeSpan.FromMinutes(1);
            }).AddJsonProtocol(options =>
            {
                //options.PayloadSerializerSettings.ContractResolver =
                //      new DefaultContractResolver();
                options.PayloadSerializerOptions.PropertyNamingPolicy = null;
            });

            return builder;
        }

        /// <summary>
        /// Configure application newtonsoftjson with filters
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static WebApplicationBuilder AddAppAddNewtonsoftJson(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers(configure =>
            {
                configure.ReturnHttpNotAcceptable = true;
                configure.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status400BadRequest));
                configure.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status406NotAcceptable));
                configure.Filters.Add(new ProducesResponseTypeAttribute(StatusCodes.Status500InternalServerError));
                configure.Filters.Add(new ConsumesAttribute("Application/json"));   // for input request accept header
                configure.Filters.Add(new ProducesAttribute("Application/json"));   // for output response accept header
            }).AddNewtonsoftJson(options =>
            {
                //options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            }).AddXmlDataContractSerializerFormatters();
            builder.Services.Configure<FormOptions>(x =>
            {
                x.ValueCountLimit = int.MaxValue;
                x.ValueLengthLimit = int.MaxValue;
                x.MemoryBufferThreshold = Int32.MaxValue;
                x.MultipartBodyLengthLimit = long.MaxValue;
            });

            return builder;
        }

        /// <summary>
        /// Configure application session
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static WebApplicationBuilder AddAppSession(this WebApplicationBuilder builder)
        {
            builder.Services.AddSession(options =>
            {
                //options.IdleTimeout = TimeSpan.FromHours(1);
                options.IdleTimeout = TimeSpan.FromMinutes(int.Parse(builder.Configuration.GetSection("Jwt:Access_Token_ExpireTime_In_Minutes").Value));
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            return builder;
        }

        public static WebApplicationBuilder AddAppRouteGuard(this WebApplicationBuilder builder)
        {
            return builder;
        }

        /// <summary>
        /// Configure application logging with NLog
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static WebApplicationBuilder AddAppNLog(this WebApplicationBuilder builder)
        {
            builder.WebHost.ConfigureLogging((hostingContext, logging) =>
            {
                logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                logging.AddConsole();
                logging.AddDebug();
                logging.AddEventSourceLogger();
                logging.AddNLog();
            });
            return builder;
        }
    }
}