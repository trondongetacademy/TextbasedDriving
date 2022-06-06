using System;
using System.Collections.Generic;

namespace InterfaceAndInheritance
{
    public class OpponentGarage
    {
        public List<OpponentsVehicles> OpponentsVehicles;
        public Random Random;
        public OpponentsVehicles OpponentChoseThisCar;

        public OpponentGarage()
        {
            OpponentsVehicles = new List<OpponentsVehicles>();
            AddOpponentsCars();
        }

        public void AddOpponentsCars()
        {
            OpponentsVehicles.Add(new OpponentsVehicles("Toyota", "Yaris"));
            OpponentsVehicles.Add(new OpponentsVehicles("Saab", "9-3"));
        }
        public void OpponentChoosesARandomCarInHisGarage()
        {
            for (var i = 0; i < OpponentsVehicles.Count; i++)
            {
                var cars  = OpponentsVehicles[i];
            }
            Random= new Random();
            var tall = Random.Next(0, 2);
            OpponentChoseThisCar = OpponentsVehicles[tall];
        }
    }
}