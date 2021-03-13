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
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());


            brandManager.Add(new Brand {BrandId=1, BrandName= "Volkswagen" });
            brandManager.Add(new Brand { BrandId = 2, BrandName = "Renault" });

            colorManager.Add(new Color { ColorId = 1, ColorName = "Kırmızı" });
            colorManager.Add(new Color { ColorId = 2, ColorName = "Mavi" });
            colorManager.Add(new Color { ColorId = 3, ColorName = "Yeşil" });



            carManager.Add(new Car {  BrandId = 1, ColorId = 1, ModelYear = "Passat", UnitPrice = 200000, Description = "Marka Volkswagen, rengi kırmızı" });
            carManager.Add(new Car {  BrandId = 1, ColorId = 2, ModelYear = "Golf", UnitPrice = 130000, Description = "Marka Volksvagen, rengi mavi" });
            carManager.Add(new Car {  BrandId = 1, ColorId = 2, ModelYear = "Transporter", UnitPrice = 150000, Description = "Marka Volkswagen rengi mavi" });
            carManager.Add(new Car {  BrandId = 2, ColorId = 3, ModelYear = "Captur", UnitPrice = 212500, Description = "Marka Renault rengi yeşil" });
            carManager.Add(new Car {  BrandId = 2, ColorId = 3, ModelYear = "Symbol", UnitPrice = 141000, Description = "Marka Renault rengi yeşil" });
            carManager.Add(new Car {  BrandId =2, ColorId =1, ModelYear = "Clio",UnitPrice=180000,Description="Renk : Kırmızı Marka: Renault"});
            carManager.Delete(new Car { Id = 8 });


            foreach (var result in carManager.GetAll())
            {
                Console.WriteLine(result.ModelYear);
            }
            Console.WriteLine("---------------------------");
            foreach (var result2 in brandManager.GetAll())
            {
                Console.WriteLine(result2.BrandName);
            }
            Console.WriteLine("---------------------------");

            foreach (var result3 in colorManager.GetAll())
            {
                Console.WriteLine(result3.ColorName);
            }
            Console.WriteLine("---------------------------");

            foreach (var result4 in carManager.GetByBrandId(2))
            {
                
                Console.WriteLine(result4.ModelYear);

            }
        }
    }
}
