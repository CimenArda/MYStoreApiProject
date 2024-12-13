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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _ContactDal;

        public ContactManager(IContactDal ContactDal)
        {
            _ContactDal = ContactDal;
        }

        public void TDelete(int id)
        {
            _ContactDal.Delete(id);
        }

        public List<Contact> TGetAllList()
        {
            return _ContactDal.GetAllList();
        }

        public Contact TGetById(int id)
        {
            return _ContactDal.GetById(id);
        }

        public void TInsert(Contact entity)
        {
            _ContactDal.Insert(entity);
        }

        public void TUpdate(Contact entity)
        {
            _ContactDal.Update(entity);
        }
    }
}
