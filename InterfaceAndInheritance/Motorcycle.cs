using System;

namespace InterfaceAndInheritance
{
    public class Motorcycle : Vehicle
    {
        
        public Motorcycle (string brand, string model) : base (brand, model)
        {
            Wheels = 2;
        }

        

        public void Information()
        {
            Console.WriteLine($"Du har valgt å kjøre med en {Wheels} hjulet {Brand} {Model}");
        }
    }
}