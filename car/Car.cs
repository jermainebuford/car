using System;
using System.Collections.Generic;
using System.Text;

namespace car
{
    public class Car
    {
        public Car (string make, string model, string year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public void PrintCar()
        {
            Console.WriteLine($"Make :  {Make}  Model :  {Model}  Year {Year}" );
        }
    }
}
