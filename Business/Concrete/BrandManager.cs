using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _BrandDal;
        public BrandManager(IBrandDal BrandDal)
        {
           BrandDal= _BrandDal;
        }
        public List<Brand> GetAll()
        {
            return _BrandDal.GetAll();
        }
    }
}
