using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Entities.DTOsIDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<CarDto>> GetCarDto();
        IDataResult<CarDetailDto> GetCarDetail(int carId);
        IDataResult <List<Car>> GetAll();
        IDataResult<List<CarDto>> GetAllByColorId(int id);
        IDataResult<List<CarDto>> GetAllByBrandId(int id);
        IDataResult<Car> GetById (int id);
        IResult Update(Car car);
        IResult Add(Car car);
        IResult Delete(Car car);
    }
}
