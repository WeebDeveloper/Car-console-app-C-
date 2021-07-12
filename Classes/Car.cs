using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_console_app
{
    class Car
    {

        

        private int year;
        public int carCount = 0;

        public string Make
        { get; private set; }

        public string Model
        { get; private set; }

        public double Mpg
        {get; private set;}

        public double Gas
        { get; set; }

        //constructor
        public Car(int aYear, string aMake, string aModel, double aMpg, double aGas)
        {
            Year = aYear;
            Make = aMake;
            Model = aModel;
            Mpg = aMpg;
            Gas = aGas;
            //add 1 to carCount every time a new car is created
            carCount++;
        }

        //checks for yearmodels beyond current year
        public int Year
        {
            get { return year; }
            private set {
                if (value > DateTime.Now.Year + 1 || //catch that allows late model vehicles
                    value < 1885) 
                {
                    year = 0;
                }
                else
                {
                    year = value;
                }
            }
        }



        public string CarStats()
        {
            if (Year <= 1990 && Year != 0)
            {
                return $"Your car is a {Year} {Make} {Model}. What a Classic!";
            } 
            else if (Year == 0)
            {
               return $"The {Make} {Model} was inputted with an invalid Model Year.";
            } 
            else
            {
                return $"Your car is a {Year} {Make} {Model}";
            }
        }

        // example
             public bool GasMileageCalc(double milesTravelled)
            {
                double driveDistance = this.Gas * this.Mpg;
                if (driveDistance < milesTravelled)
                {
                Console.WriteLine($"Your {this.Make} {this.Model} doesn't have enough enough gas!");
                return false;
                    
                }
                else
                {
                    this.Gas = Math.Round(this.Gas - (milesTravelled / this.Mpg), 2);
                    
                    Console.WriteLine($"You have {this.Gas} gallons of gas left in your {this.Make} {this.Model}!");
                    return true;
            }
            }
    }
}

