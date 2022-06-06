using System;

namespace InterfaceAndInheritance
{
    public class Control_Panel
    {
        //Motorcycle Mc = new Motorcycle("Honda", "CB800");
        public Control_Panel()
        {
            var personConsole = new Person();
            var opponent = new Opponent();

            personConsole.WhatIsTheName();
            personConsole.PersonsChoice();
            if(personConsole.PlayerChoice == 1) personConsole.Garage.SeeGarage();
            if (personConsole.PlayerChoice == 2) personConsole.FindOpponent();
            //personConsole.Garage.SeeGarage();

            //personConsole.Garage.AddVehicleToGarage();

            //var ferrari = new Car("Ferrari","italia");
            //personConsole.Garage.AddVehicleToGarage(ferrari);

            //var VehicleConsole = new Vehicle();

            //VehicleConsole.AddCarToGarage();
            //VehicleConsole.AddCarToGarage("Aston Martin", "DB2");


            //if(personConsole.PlayerChoice == 1) VehicleConsole.SeeGarage();
            //if (personConsole.PlayerChoice == 2) ;
            //if (personConsole.PlayerChoice == 3) ;
            //if (personConsole.PlayerChoice == 4) ;
            //VehicleConsole.WhatVehicle();
            //VehicleConsole.GoForARide();



        }

        //public void WhatVehicle()
        //{

        //    Console.WriteLine("Velg \'1\' for bil, eller \'2\' for Motorsykkel");
        //    var choice = Convert.ToInt32(Console.ReadLine());
        //    if (choice == 1)
        //    {

        //        new Car("ford", "Mustang");
        //    }

        //    if (choice == 2)
        //    {
        //        Motorcycle Motorcycle = new Motorcycle("Ducati", "Streetfighter");
        //        //Motorcycle motorcycle = new Motorcycle();
        //        Motorcycle.Information();
        //    }
        //}

        //var trond = new Person("TrondErik", new Motorcycle("Ducati", "Streetfighter", 1300));

        //Console.WriteLine(trond.Vehicle.Wheels);

        //Console.WriteLine("What brand?");
        //var brand = Console.ReadLine();

        //Console.WriteLine("What model?");
        //var model = Console.ReadLine();

        //Console.WriteLine("How fast are you driving");
        //int speed = Convert.ToInt32(Console.ReadLine());

        //Car car = new Car(brand, model, speed);
        ////Motorcycle motorcycle = new Motorcycle("Ducati", "StreetFighter", 120);
        //car.Information();
        ////motorcycle.Information();
        //car.AddSpeed(15);
        ////car.Information();
        ////motorcycle.ReduceSpeed();
        ////motorcycle.Information();
    }
}