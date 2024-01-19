using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test2
{
    class Program

    {


        public static void Main(string[] args)
        {


            Car car1 = new Car(123, "Tesla", "Model S");

            Car car2 = new Car(456, "Tesla", "Model X");

            Car car3 = new Car();

            car3.vin = 333;
            car3.brand = "BMW 1";
            car3.model = "777";


            Car car4 = new Car("Audi", "Q8");
            car4.vin = 001;


            Car[] cars = { car1, car2, car3 };


            int i = 1;

            foreach (Car car in cars) {
              
                Console.WriteLine("Car Number: " + i);
                Console.WriteLine("VIN CODE: " + car.vin);
                Console.WriteLine("Brand: " + car.brand);
                Console.WriteLine("Model: " + car.model);
                i++;


                Console.WriteLine("_______________");
            }













        }
    }


}

    
