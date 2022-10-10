using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOsIDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Cocnrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {Id=1,ColorId=1, DailyPrice=10000,ModelYear=2000,Description="dasdasd",BrandId=1},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);           
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id== car.Id);

            _cars.Remove(carToDelete);    
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

      

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }



        public List<CarDetailDto> GetCarDetaiLS()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.DailyPrice=car.DailyPrice;
            CarToUpdate.ModelYear=car.ModelYear; 
            CarToUpdate.ColorId=car.ColorId;
            CarToUpdate.Description=car.Description;
            CarToUpdate.BrandId = car.BrandId;
        }
    }
}
