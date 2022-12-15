using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> cars = new List<Car> { 
            new Car {CarId=1,BrandId=1,ColorId=1,DailyPrice=200,ModelYear=2010, Description="2010 Model Siyah Bmw" },
            new Car {CarId=2,BrandId=1,ColorId=2,DailyPrice=250,ModelYear=2009, Description="2009 Model Beyaz Bmw" },
            new Car {CarId=3,BrandId=2,ColorId=2,DailyPrice=300,ModelYear=2015, Description="2015 Model Beyaz Mersedes" },
            new Car {CarId=4,BrandId=2,ColorId=1,DailyPrice=500,ModelYear=2020, Description="2020 Model Siyah Mersedes" }};

        public void Add(Car entity)
        {
            cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            var deleteCar = cars.SingleOrDefault(p=>p.CarId==entity.CarId);
            cars.Remove(deleteCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return cars;
        }

        public List<CarDetialDto> GetCarDetial()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            var updateCar = cars.SingleOrDefault(p => p.CarId == entity.CarId);
            updateCar.BrandId = entity.BrandId;
            updateCar.ColorId = entity.ColorId;
            updateCar.DailyPrice = entity.DailyPrice;
            updateCar.Description = entity.Description;
        }
    }
}
