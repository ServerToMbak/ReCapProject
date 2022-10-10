﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOsIDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Cocnrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RecapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetaiLS()
        {
            using(RecapContext context=new RecapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join color in context.Colors on c.ColorId equals color.Id
                               

                             select new CarDetailDto
                             {
                                 BrandName = b.BrandName,
                                 CarName = c.Description,
                                 DailyPrice = c.DailyPrice,
                                 ColorName = color.ColorName,
                                        
                             };
                return result.ToList();
            }
        }
    }
}