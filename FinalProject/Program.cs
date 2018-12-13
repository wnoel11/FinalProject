using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {

            int myHeroPowerLevel = 900;
            int myOtherHeroPowerLevel = 10;
            int mythirdHeroPowerLevel = 750;
            Hero myHero = new Hero("Thor ", myHeroPowerLevel, "Fly, Thunder");
            Hero myOtherHero = new Hero("Flash ", "Zoom", "Human", "Speed", true);
            Hero thirdHero = new Hero("Wonder Woman ", "All bad people", "Amazonian", "Stength, Speed, Fly");

            /*
               Problem 7:
               Each Hero must:
                - ChargePower (as much as you want)
                - Investigate
                - FightCrime (at least one must win. at least one must not win)
                - Fly (at least one superhero should be able to fly)
                - Climb
           */

            myHero.ChargePower(myHeroPowerLevel);
            myHero.Investigate();
            myHero.FightCrime("KeyBank");
            myHero.Fly();
            myHero.Climb(10);


            myOtherHero.ChargePower(myOtherHeroPowerLevel);
            myOtherHero.Investigate();
            myOtherHero.FightCrime("KeyBank");
            myOtherHero.Fly();
            myOtherHero.Climb(10);

            thirdHero.ChargePower(mythirdHeroPowerLevel);
            thirdHero.Investigate();
            thirdHero.FightCrime("KeyBank");
            thirdHero.Fly();
            thirdHero.Climb(10);

            Console.ReadLine();
        }
    }
}
