using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemInsight.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        public string? ConsumerReview { get; set; }
        public string? Category { get; set; }
        public double? Rating { get; set; }
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
