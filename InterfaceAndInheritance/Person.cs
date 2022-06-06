using System;

namespace InterfaceAndInheritance
{
    public class Person

    {
        public string Name { get; set; }
        public int BankAccount = 100;
        public Garage Garage;
        public Opponent Opponent;
        public int PlayerChoice = 0;

        public Person()
        {
            Garage = new Garage();
        }
        public void WhatIsTheName()
        {
            Console.Write("Hei. Hva er navnet ditt?");
            Name = Console.ReadLine();
            Console.WriteLine($"Hei {Name}");
            Console.WriteLine($"Din Konto beholdning: {BankAccount}$");
        }

        public void PersonsChoice()
        {
            Console.WriteLine("Velg 1 for å se garasje.\r\nVelg 2 for å finne en tilfeldig motstander til et race \r\nVelg 3 for å kjøpe nytt kjøretøy.\r\nVelg 4 for å selge kjøretøy.\r\nVelg 5 for å ta deg en kjøretur");
            
            PlayerChoice = Convert.ToInt32(Console.ReadLine());
        }

        public void FindOpponent()
        {
            Opponent = new Opponent();
            Console.WriteLine($"Your opponent is: {Opponent.OpponentNameIs} and he is driving a {Opponent.OpponentsGarage.OpponentChoseThisCar.Brand} {Opponent.OpponentsGarage.OpponentChoseThisCar.Model}");}

        }

}