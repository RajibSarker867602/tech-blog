using LeadingEdgeServer.Models.Enum;
using LeadingEdgeServer.Models.Utilities;

namespace LeadingEdgeServer.Models.Response.Security.SerialNo
{
    public class FeatureSerialResponseDto
    {
        public Guid Id { get; set; }
        public Guid ProjectId { get; set; }
        public SecurityFeatureEnum FeatureId { get; set; }
        public string? Prefix { get; set; }
        public long? SerialNo { get; set; }
        public string FeatureSerialNo => AppUtilities.GenerateEntityAutoGenCode(Prefix, SerialNo ?? 0);
    }
}
