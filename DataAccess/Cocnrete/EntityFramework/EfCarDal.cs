using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Cocnrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return new List<Car>
            {
                new Car{CarId=1},new Car{CarId=2},
            };
        }

        public List<Car> GetByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
