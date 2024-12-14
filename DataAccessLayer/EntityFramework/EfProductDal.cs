using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(StoreContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategory()
        {
            var StoreContext = new StoreContext();

            var values = StoreContext.Products.Include(x => x.Category).ToList();
            return values;
        }
    }
}
