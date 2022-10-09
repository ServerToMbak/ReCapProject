using System;
using Business.Concrete;
using DataAccess.Cocnrete.EntityFramework;
using DataAccess.Cocnrete.InMemory;
using Entities.Concrete;

namespace ConsoleUı // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { BrandId = 20, ColorId = 4, ModelYear = 2019, DailyPrice = 539, Description = "Hyundai i20" };
            Car car2 = new Car { BrandId = 1003, ColorId = 1, DailyPrice = 659, ModelYear = 2020, Description = "Renault Megan" };
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car1);
            //var result = carManager.GetAll();
            //Console.WriteLine(result.Message);
            //foreach (var item in result.Data)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}