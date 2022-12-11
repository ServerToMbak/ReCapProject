using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
        public List<CarDto> GetCars()
        {
            using(RecapContext context=new RecapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join color in context.Colors on c.ColorId equals color.Id
                            
                               

                             select new CarDto
                             {
                                 
                                 BrandName = b.BrandName,
                                 CarName = c.Description,
                                 DailyPrice = c.DailyPrice,
                                 ColorName = color.ColorName,
                                 Description= c.Description,
                                 ModelYear= c.ModelYear,
                                 
                                        
                             };
                return result.ToList();
            }
        }

        public CarDetailDto GetCarDetailDto(int id)
        {
            using (RecapContext context = new RecapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join color in context.Colors on c.ColorId equals color.Id
                             where c.Id == id



                             select new CarDetailDto
                             {
                                 BrandName = b.BrandName,
                                 CarName = c.Description,
                                 DailyPrice = c.DailyPrice,
                                 ColorName = color.ColorName,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear,
                                 CarImages=context.CarImages.Where(ci=>ci.CarId==c.Id).ToList(),


                             };
                return result.SingleOrDefault();
            }
        }

        public List<CarDto> GetCarsByBrandId(int id)
        {
            using (RecapContext context = new RecapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join cl in context.Colors on c.ColorId equals cl.Id
                             where b.BrandId == id


                             select new CarDto
                             {

                                 BrandName = b.BrandName,
                                 CarName = c.Description,
                                 DailyPrice = c.DailyPrice,
                                 ColorName = cl.ColorName,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear,


                             };
                return result.ToList();
            }
        }

        public List<CarDto> GetCarsByColorId(int id)
        {
            using (RecapContext context = new RecapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join cl in context.Colors on c.ColorId equals cl.Id
                             where cl.Id== id


                             select new CarDto
                             {

                                 BrandName = b.BrandName,
                                 CarName = c.Description,
                                 DailyPrice = c.DailyPrice,
                                 ColorName = cl.ColorName,
                                 Description = c.Description,
                                 ModelYear = c.ModelYear,


                             };
                return result.ToList();
            }
        }
    }
}
