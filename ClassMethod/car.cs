using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethod
{
    class car:vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;
        public double PossibleWay;
        public car(int year,string color,string brand,string model,double FuelCapapacity,double FuelFor1km,double currentFuel ) :base(year,color)
        
        {
            this.Brand = brand;
            this.Model = model;
            this.FuelCapacity = FuelCapacity;
            this.FuelFor1Km = FuelFor1Km;
            this.CurrentFuel = currentFuel;

         
          
        }
        public  void Getinfo()
        {
            Console.WriteLine($" {year} {color} {Brand} {Model} {FuelCapacity} {FuelFor1Km } {CurrentFuel}");
        }


    }
}

