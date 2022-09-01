using BuisnessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Delete(Contact p)
        {
            _contactDal.Delete(p);
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> GetListAll()
        {
            return _contactDal.GetListAll();
        }

        public void Insert(Contact p)
        {
            _contactDal.Insert(p);
        }

        public void Update(Contact p)
        {
            _contactDal.Update(p);
        }
    }
}
