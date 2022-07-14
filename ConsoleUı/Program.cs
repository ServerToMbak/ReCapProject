using System;
using Business.Concrete;
using DataAccess.Cocnrete.EntityFramework;
using DataAccess.Cocnrete.InMemory;

namespace ConsoleUı // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
                foreach (var car in carManager.GetAll())
                {
                    Console.WriteLine(car.Id);
                }; 
        }
    }
}