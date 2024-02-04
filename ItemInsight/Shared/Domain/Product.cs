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
        public double? Cost { get; set; }
        public string? ProductImage { get; set; }
        public int ProducerId { get; set; }
        public virtual Producer? Producer { get; set; }
        public int ListingId { get; set; }
        public virtual Listing? Listing { get; set; }
    }
}
