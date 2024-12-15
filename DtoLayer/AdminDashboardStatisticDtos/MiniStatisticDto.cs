using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.AdminDashboardStatisticDtos
{
    public class MiniStatisticDto
    {
        public int ContactCount { get; set; }
        public int CategoryCount { get; set; }
        public int ProductCount { get; set; }
        public string MaxPriceProductName { get; set; }
    }
}
