using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemInsight.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        public string? ConsumerReview { get; set; }
        [Required]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public double? Rating { get; set; }
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }
}
