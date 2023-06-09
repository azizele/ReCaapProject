﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{  Id=1,BrandId=1, ColorId=1, ModelYear=1990, DailyPrice=250000, Description="AUDİ" },
                new Car{  Id=2,BrandId=1, ColorId=3, ModelYear=1995, DailyPrice=300000, Description="AUDİ" },
                new Car{  Id=3,BrandId=2, ColorId=5, ModelYear=2000, DailyPrice=350000, Description="BMW" },
                new Car{  Id=4,BrandId=2, ColorId=7, ModelYear=2023, DailyPrice=1000000, Description="BMW " },
                new Car{  Id=5,BrandId=2, ColorId=1, ModelYear=2022, DailyPrice=1000000, Description="BMW " }
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
