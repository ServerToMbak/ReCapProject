using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Cocnrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
             if(car.DailyPrice>0 && car.Description.Length>2)
             {
                _carDal.Add(car);   
             }
            else
            {
                Console.WriteLine("Daily price can not be empty and Description con not be less than 2 words");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();  
           
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(b => b.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId==id);
        }

        public Car getDetails(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }
    }
}
