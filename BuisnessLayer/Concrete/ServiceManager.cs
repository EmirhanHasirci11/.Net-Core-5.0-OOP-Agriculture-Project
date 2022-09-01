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
   public class ServiceManager:IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Delete(Service p)
        {
            _serviceDal.Delete(p);
        }

        public Service GetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> GetListAll()
        {
            return _serviceDal.GetListAll();
        }

        public void Insert(Service p)
        {
            _serviceDal.Insert(p);
        }

        public void Update(Service p)
        {
            _serviceDal.Update(p);
        }
    }
}
