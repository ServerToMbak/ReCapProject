using Business.Abstract;
using Business.Constanrs;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Entities.DTOsIDto;
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
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            
                _carDal.Add(car);   
                return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);  
          
        }
        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CarDto>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<CarDto>>(_carDal.GetCarsByBrandId(id));
        }

        public IDataResult<List<CarDto>> GetAllByColorId(int id)
        {
            return new SuccessDataResult<List<CarDto>>(_carDal.GetCarsByColorId(id));
        }

        public IDataResult<List<CarDto>> GetCarDto()
        {
            return new SuccessDataResult<List<CarDto>>(_carDal.GetCars());
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult();
        }

        public IDataResult<CarDetailDto> GetCarDetail(int carId)
        {

            return new SuccessDataResult<CarDetailDto>(_carDal.GetCarDetailDto(carId));
        }
    }
}
