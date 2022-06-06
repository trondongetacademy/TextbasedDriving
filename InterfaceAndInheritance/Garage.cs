using System.Collections.Generic;
using System;

namespace InterfaceAndInheritance
{
    public class Garage
    {
        public List<Vehicle> ListWithVehicles;
       // public Vehicle Vechicle;

        public Garage()
        {
            ListWithVehicles = new List<Vehicle>();
            AddCarToGarage();
        }

        public void AddCarToGarage()
        {
            ListWithVehicles.Add(new Car("Aston Martin", "DB2"));
        }

        //public void AddVehicleToGarage(string brand, string model, string typeOfVehicle)
        //{
        //    if (typeOfVehicle.toLowerCase() == "car") new Car(brand, model);
        //}

        //public void AddVehicleToGarage(Vehicle kjøretøy)
        //{
        //    ListWithVehicles.Add(kjøretøy);
        //}

        //public void AddVehicleToGarage()
        //{
        //    ListWithVehicles.Add( new Vehicle("",""));
        //}

        

        public void SeeGarage()
        {
            foreach (var inGarage in ListWithVehicles)
            {
                Console.WriteLine($"Du har i din garasje, en {inGarage.Brand} {inGarage.Model}");
            }
        }

    }
}