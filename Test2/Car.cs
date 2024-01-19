using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal class Car
    {
        public int vin;
        public string brand;
        public string model;

        public Car(int vin2, string brand2, string model2) {
            this.vin = vin2;
            this.brand = brand2;
            this.model = model2;
        }


        public Car() { }

        public Car(string brand, string model) { 

            this.brand = brand;
            this.model = model;
        }


    }
}

