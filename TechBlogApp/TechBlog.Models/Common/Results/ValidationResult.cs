using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBlog.Models.Common.Results
{
    public record ValidationResult(IEnumerable<string> errors)
    {
        public ValidationResult(string error) : this(new[] { error })
        {

        }
    }
}
