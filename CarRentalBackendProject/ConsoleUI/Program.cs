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
            var result = carManager.GetCarDetails();
            foreach (var carDetailsDto in result.Data)
            {
                if (result.Success) 
                {
                    Console.WriteLine(carDetailsDto.BrandName + " " + carDetailsDto.CarName );
                }
                else 
                {
                    Console.WriteLine(result.Message);
                }
            }
        }
    }
}
