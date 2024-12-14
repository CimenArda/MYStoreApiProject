using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _ProductDal;

        public ProductManager(IProductDal ProductDal)
        {
            _ProductDal = ProductDal;
        }

        public void TDelete(int id)
        {
            _ProductDal.Delete(id);
        }

        public List<Product> TGetAllList()
        {
            return _ProductDal.GetAllList();
        }

        public Product TGetById(int id)
        {
            return _ProductDal.GetById(id);
        }

        public List<Product> TGetProductsWithCategory()
        {
           return _ProductDal.GetProductsWithCategory();
        }

        public void TInsert(Product entity)
        {
            _ProductDal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            _ProductDal.Update(entity);
        }
    }
}
