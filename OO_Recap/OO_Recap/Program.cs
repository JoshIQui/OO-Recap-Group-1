using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Recap
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates the three child objects of game companies
            AAA bigGames = new AAA("New York", "Big Games", 1000, 2005, "John", "Superman 65", "Playstation", 70, 5000.00, "Bad games");
            Indie littleGames = new Indie("California", "Little Games", 5000, 2012, "Jimmy", "Scape", "PC", 1, 500, 20);
            _3rd_Party_Dev masonStudios = new _3rd_Party_Dev("Wisconsin", "Mason Studios", 50, 1998, "Jason", "Dog Simulator", "PC", 20, 500, "Activision");

            //Uses the parent methods
            bigGames.MakeGame("E.T. 2: Electric Boogaloo");
            littleGames.HireEmployee(2);
            Console.WriteLine();
            masonStudios.FireEmployee(3);
            Console.WriteLine();

            //Uses child-specific methods
            bigGames.Liquidate("Tim");
            Console.WriteLine();
            littleGames.StartCampaign();
            Console.WriteLine();
            masonStudios.ChangePublisher("bigGames");
            Console.WriteLine();
        }
    }
}
