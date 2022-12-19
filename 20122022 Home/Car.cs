using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace _20122022_Home
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public double FuelFor1Km;
        public double CurrentFuel;
        public double Millage;


        public void Drive(int onekm)
        {
            Millage += onekm;
            Console.WriteLine(Millage);
            FuelFor1Km += onekm;
            CurrentFuel -= FuelFor1Km;
            Console.WriteLine(CurrentFuel);
            if (CurrentFuel < FuelFor1Km )
            {
                Console.WriteLine("Benzin yoxdu");


            }
            else { Console.WriteLine("Sur Getsin"); }

           
        }




    }

}

