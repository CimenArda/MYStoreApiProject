using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.ProductDtos
{
    public class UpdateProductDto
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }

        public int CategoryID { get; set; }
    }
}
