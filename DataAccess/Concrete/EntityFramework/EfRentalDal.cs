using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Entities.DTOsIDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Cocnrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RecapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRental()
        {
            using (RecapContext context = new RecapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join r in context.Rentals on c.Id equals r.CarId
                             join cs in context.Customers on r.CustomerId equals cs.Id
                             join u in context.Users on cs.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 FirstName =u.FirstName,
                                 LastName =u.LastName,
                                 Id= r.Id,
                                 BrandName= b.BrandName,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate,

                             };
                return result.ToList();
            }
        }
    }
}
