using System;
using System.Collections.Generic;

namespace InterfaceAndInheritance
{
    public abstract class Vehicle
    {
        //abstract gjør at man ikke kan new'e opp en klasse, kjøretøy er en beskrivelse 
        // har noe (betyr objekt orientering) er noe (betyr at den arver)
        // garasje har en liste med kjøretøy bil og motorsykkel er et kjøretøy
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Wheels { get; set; }

        //public List<Vehicle> Garage = new List<Vehicle>();
        //public Motorcycle Motorcycle { get; set; }
        //public Car Car { get; set; }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
            
        }
        public Vehicle()
        {
        }

        //public void AddCarToGarage(string Brand, string Model)
      

        
        //public void WhatVehicle()
        //{

        //    Console.WriteLine("Velg \'1\' for bil, eller \'2\' for Motorsykkel");
        //    var choice = Convert.ToInt32(Console.ReadLine());
        //    if (choice == 1)
        //    {

        //        Car = new Car("ford", "Mustang");
        //        Car.Information();
        //    }

        //    if (choice == 2)
        //    {
        //        Motorcycle = new Motorcycle("Ducati", "Streetfighter");
        //        Motorcycle.Information();
        //    }
        //}

        //public void GoForARide()
        //{
        //    Console.WriteLine("Do you want to go for a ride?");
        //    var choice = Console.ReadLine();

        //}
    }
}