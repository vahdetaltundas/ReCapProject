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

            //Cartest();

            CarManager carManager = new CarManager(new EfCarDal());
            foreach(var car in carManager.GetCarDetials())
            {
                Console.WriteLine("{0}--{1}--{2}--{3}",car.BrandName,car.ColorName,car.DailyPrice,car.CarName);
            }


            
        }

        private static void Cartest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            /*foreach (var car in carManager.GelAll())
            {
                Console.WriteLine(car.Description);
            }*/
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 200, ModelYear = 2010, Description = "Bmw" });
            carManager.Add(new Car { BrandId = 2, ColorId = 2, DailyPrice = 250, ModelYear = 2010, Description = "Bmw" });
            carManager.Add(new Car { BrandId = 3, ColorId = 3, DailyPrice = 260, ModelYear = 2010, Description = "Bmw" });
        }
    }
}
