using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadingEdgeServer.Models.SQL.StoredProcedures
{
    public class SP_COAForOpeningBalance
    {
        public Guid? AssetsCOAId { get; set; }
        public Guid? ProjectId { get; set; }
        public string? AssetsCOANumber { get; set; }
        public string? AssetsCOAName { get; set; }
        public double? AssetsOpeningBalance { get; set; }
        public string? AssetsHierarchy { get; set; }
        public string? AssetsCOAType { get; set; }
        public bool? AssetsReadOnly { get; set; }
        public Guid? LiabilitiesCOAId { get; set; }
        public string? LiabilitiesCOANumber { get; set; }
        public string? LiabilitiesCOAName { get; set; }
        public double? LiabilitiesOpeningBalance { get; set; }
        public string? LiabilitiesHierarchy { get; set; }
        public string? LiabilitiesCOAType { get; set; }
        public bool? LiabilitiesReadOnly { get; set; }
    }
}
