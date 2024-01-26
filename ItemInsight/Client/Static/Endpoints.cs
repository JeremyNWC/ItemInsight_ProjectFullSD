using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemInsight.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string ConsumersEndpoint = $"{Prefix}/consumers";
        public static readonly string ProducersEndpoint = $"{Prefix}/producers";
        public static readonly string ProductsEndpoint = $"{Prefix}/products";
        public static readonly string ReviewsEndpoint = $"{Prefix}/reviews";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
    }
}
