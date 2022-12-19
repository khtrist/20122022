using System;
using System.IO;
using System.Reflection;
using System.Xml.Schema;

namespace _20122022_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //var Mileage = double.Parse(Console.ReadLine());
            //var onekm = double.Parse(Console.ReadLine());
            //var totallitres = int.Parse(Console.ReadLine());


            //Console.WriteLine(Mileage);


            Car car1 = new Car
            {
                Brand = "Mercedes",
                Model = "E200",
                FuelFor1Km = 1,
                CurrentFuel = 100,
                Millage = 0
            };
            car1.Drive(30);


            static void NamPrice(Notebook[] laptops)
            {
                Notebook laptop = new Notebook
                {
                    Name = "Laptop",
                    BrandName = "Huawei",
                    Price = 100

                };
                Notebook laptop1 = new Notebook
                {
                    Name = "Laptop",
                    BrandName = "Asus",
                    Price = 250

                };

                Notebook laptop2 = new Notebook
                {
                    Name = "Laptop",
                    BrandName = "Acer",
                    Price = 350

                };

                Notebook laptop3 = new Notebook
                {
                    Name = "Laptop",
                    BrandName = "HP",
                    Price = 200

                };
                Console.WriteLine("Minimum Qiymeti daxil edin");
                var MinPriceStr = Console.ReadLine();
                var MinPrice = Convert.ToInt32(MinPriceStr);
                Console.WriteLine("Minimum Qiymeti daxil edin");
                var MaxPriceStr = Console.ReadLine();
                var MaxPrice = Convert.ToInt32(MaxPriceStr);
                var NamPrice = "";

                Notebook[] Laptops = { laptop, laptop1, laptop2, laptop3 };

                for (int i = 0; i < laptops.Length; i++)
                {
                    if (laptops[i].Price > MinPrice)
                    {
                        Console.WriteLine(laptops[i].BrandName);
                    }
                    if (laptops[i].Price < MaxPrice)
                    {
                        Console.WriteLine(laptops[i].BrandName);
                    }
                }
                
            }







        }

    }
}
