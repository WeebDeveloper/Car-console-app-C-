using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_console_app.Classes
{
    class Garage
    {
     public List<Car>carList = new List<Car>();

        //Constructor
        public Garage(List<Car> aCarList)
        {
            carList = aCarList;
        }

        public string AddToGarage(Car newCar)
        {
            carList.Add(newCar);
            return $"You added a {newCar.Year} {newCar.Make} {newCar.Model} to your garage! {carList.Count} Cars in garage: {carList}.";
        }
    }
}
