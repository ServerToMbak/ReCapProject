using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car {CarId=1,ColorId=1, DailyPrice=10000,ModelYear=2000,Description="dasdasd",BrandId=1},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);           
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId== car.CarId);

            _cars.Remove(carToDelete);    
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int brandId)
        {
           return   _cars.Where(p => p.BrandId == brandId).ToList();
        }

        public Car GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarToUpdate.DailyPrice=car.DailyPrice;
            CarToUpdate.ModelYear=car.ModelYear; 
            CarToUpdate.ColorId=car.ColorId;
            CarToUpdate.Description=car.Description;
            CarToUpdate.BrandId = car.BrandId;
        }
    }
}
