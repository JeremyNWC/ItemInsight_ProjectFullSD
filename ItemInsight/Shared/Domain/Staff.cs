using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemInsight.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }

        public string Password { get; set;}

    }
}
