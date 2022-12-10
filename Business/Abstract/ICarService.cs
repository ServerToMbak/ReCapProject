﻿using Core.Utilities.Results;
using Entities.Concrete;
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
        IDataResult<List<CarDetailDto>> GetDetails();
        IDataResult <List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByColorId(int id);
        IDataResult <List<Car>> GetAllByBrandId(int id);
        IDataResult<Car> GetById (int id);
        IResult Update(Car car);
        IResult Add(Car car);
        IResult Delete(Car car);
    }
}
