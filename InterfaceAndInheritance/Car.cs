using System;
using Microsoft.VisualBasic;

namespace InterfaceAndInheritance
{
    public class Car : Vehicle
    {
        public Car(string brand, string model) : base(brand, model)
        {
            Wheels = 4;
        }

        public void Information()
        {
            Console.WriteLine($"Du har valgt å kjøre med en {Wheels} hjulet {Brand} {Model}");
        }
    }
}