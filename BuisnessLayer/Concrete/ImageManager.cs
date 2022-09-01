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
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;

        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public void Delete(Image p)
        {
            _imageDal.Delete(p);
        }

        public Image GetById(int id)
        {
            return _imageDal.GetById(id);
        }

        public List<Image> GetListAll()
        {
            return _imageDal.GetListAll();
        }

        public void Insert(Image p)
        {
            _imageDal.Insert(p);
        }

        public void Update(Image p)
        {
            _imageDal.Update(p);
        }
    }
}
