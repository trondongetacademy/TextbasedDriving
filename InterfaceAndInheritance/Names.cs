using System;
using System.Collections.Generic;

namespace InterfaceAndInheritance
{
    public class Names  //-- ?
    {
        public string OpponentNames { get; set; }
        public List<Names> OpponentsListOfNames;
        public Names(string name)
        {
            OpponentNames = name;
        }

        public Names()
        {
            OpponentsListOfNames = new List<Names>();
            OpponentsListOfNames.Add(new Names("Terje"));
            OpponentsListOfNames.Add(new Names("Asbjørn"));
            OpponentsListOfNames.Add(new Names("Lene"));
            OpponentsListOfNames.Add(new Names("Thomas"));
            OpponentsListOfNames.Add(new Names("Bernt"));
            OpponentsListOfNames.Add(new Names("Thorbjørn"));
            OpponentsListOfNames.Add(new Names("Ole"));
            OpponentsListOfNames.Add(new Names("Kristian"));
            OpponentsListOfNames.Add(new Names("Hans"));
            OpponentsListOfNames.Add(new Names("Jens"));
            OpponentsListOfNames.Add(new Names("Morten"));
            OpponentsListOfNames.Add(new Names("Jarle"));


        }
    }
}

    
