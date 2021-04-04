using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{ Id=1,BrandId=1,ColorId=1,ModelYear=2021,
                    DailyPrice=200,Description="Jaguar 2021 sedane"},
                new Car{ Id=2,BrandId=2,ColorId=2,ModelYear=2020,
                    DailyPrice=200,Description="Volvo 2020 4x4"},
                new Car{ Id=3,BrandId=3,ColorId=2,ModelYear=2019,
                    DailyPrice=200,Description="Range Rover"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException(); // WRL
        }

        public Car GetById(int id)
        {
            Car wantedCar = _cars.SingleOrDefault(c => c.Id == id);
            return wantedCar;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId= car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
        }
    }
}
