using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace InterfaceAndInheritance
{
    public class Opponent : Names
    {
        public Random random;
        public OpponentGarage OpponentsGarage;
        public Names Names;
        public string OpponentNameIs { get; set; }

        public Opponent()
        {
            Names = new Names();
            OpponentsGarage = new OpponentGarage();
            OpponentsGarage.OpponentChoosesARandomCarInHisGarage();
            GetARandomName();
        }
        public void GetARandomName()
        {
            random = new Random();
            var tall = random.Next(Names.OpponentsListOfNames.Count);
            OpponentNameIs = Names.OpponentsListOfNames[tall].OpponentNames;
        }
    }
}