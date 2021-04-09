using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var carDetailsDto in carManager.GetCarDetails())
            {
                //Console.WriteLine(carDetailsDto.BrandName);
                //Console.WriteLine(carDetailsDto.CarName);
                //Console.WriteLine(carDetailsDto.CarId);
                //Console.WriteLine(carDetailsDto.DailyPrice);
                //Console.WriteLine("-------------------");
                //Console.WriteLine(car.Id);
                //Console.WriteLine(car.Name);
                //Console.WriteLine(car.BrandId);
                //Console.WriteLine(car.ColorId);
                //Console.WriteLine(car.DailyPrice);
                //Console.WriteLine(car.Description);
                //Console.WriteLine("---------------------");
            }
        }
    }
}
