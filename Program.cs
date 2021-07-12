using System;
using System.Collections.Generic;

namespace Car_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            //object Car takes manufacture year, vehicle make, and model as args
            Car myCar = new Car(1969, "Corvette", "Stingray", 15.0, 25.0);
            Car momsCar = new Car(2022, "Jeep", "Grand Cherokee", 24.5, 30.25);
            Car invalidCar = new Car(2023, "Fake", "MadeUpCar", 69.8, 300);
            //Garage myGarage = new Garage();
            

            Console.WriteLine(myCar.CarStats());
            Console.WriteLine(momsCar.CarStats());
            Console.WriteLine(invalidCar.CarStats());
            momsCar.GasMileageCalc(69);
            myCar.GasMileageCalc(6000);


            /* Console.WriteLine(myGarage.AddToGarage(myCar));
             Console.WriteLine(myGarage.AddToGarage(momsCar)); */

        }
    }
}
