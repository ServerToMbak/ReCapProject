using Business.Abstract;
using Business.Constanrs;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
             if(car.DailyPrice>0 && car.Description.Length>2)
             {
                _carDal.Add(car);   
                return new SuccessResult(Messages.CarAdded);
             }
           return new ErrorResult(Messages.CarCouldntAdded);
        }

        public IResult delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult("Silindi");
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);  
           
        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(b => b.BrandId == id));
        }

        public IDataResult<List<Car>> GetAllByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId==id));
        }

        public IDataResult<Car> getDetails(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }
    }
}
