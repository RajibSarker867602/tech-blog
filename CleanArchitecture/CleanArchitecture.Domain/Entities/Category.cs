using CleanArchitecture.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    [Table("Categories")]
    public class Category : Entity
    {
        public string Name { get; set; }
        public string? Code { get; set; }
    }
}
