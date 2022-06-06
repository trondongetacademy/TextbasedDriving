using System;

namespace InterfaceAndInheritance
{
    public class OpponentsVehicles
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        //public int wheels { get; set; }

        public OpponentsVehicles(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        
    }
}