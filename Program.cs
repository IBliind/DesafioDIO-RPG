using System;
using System.Collections.Generic;
using RPG.src.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, "Knight");
            WhiteWizard whitewizard = new WhiteWizard("Jenica", 23, "White Wizard");
            BlackWizard blackWizard = new BlackWizard("Topapa", 42, "Black Wizard");
            Ninja ninja = new Ninja("Wedge", 42,"Ninja");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(whitewizard.Heal(7, arus.Name));
            Console.WriteLine(blackWizard.Fireball(20));
            Console.WriteLine(ninja.Attack());
        }
    }
}
