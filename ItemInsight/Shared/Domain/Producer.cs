using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemInsight.Shared.Domain
{
    public class Producer : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? CompanyName { get; set; }
        public string? ContactNo { get; set; }
        public string? Email { get; set; }

    }
}
