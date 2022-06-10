using System;

namespace car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstCar = new Car("telsa", "model s", "2020" );
            var secondcar = new Car("lexus", "mars", "2020");
            var thirdcar = new Car("ford", "mustang", "2020");

            firstCar.PrintCar();
            secondcar.PrintCar();
            thirdcar.PrintCar();
        }
    }
}
