using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemInsight.Shared.Domain
{
    public class Product : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Category { get; set; }
        public double? Cost { get; set; }
    }
}
