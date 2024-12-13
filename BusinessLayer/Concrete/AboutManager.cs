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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _AboutDal;

        public AboutManager(IAboutDal AboutDal)
        {
            _AboutDal = AboutDal;
        }

      

        public void TDelete(int id)
        {
            _AboutDal.Delete(id);
        }

        public List<About> TGetAllList()
        {
            return _AboutDal.GetAllList();
        }

        public About TGetById(int id)
        {
            return _AboutDal.GetById(id);
        }

        public void TInsert(About entity)
        {
            _AboutDal.Insert(entity);
        }

        public void TUpdate(About entity)
        {
            _AboutDal.Update(entity);
        }
    }
}
