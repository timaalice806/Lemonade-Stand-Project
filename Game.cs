using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Game
    {
        Player player = new Player();
        Day day1;
        public int currentDay;


        public Game()
        {
            day1 = new Day(player);
        }
       

        public void GameInit()
        {
            Console.WriteLine("Lemonade Stand Game 2020\nPress ENTER To Play");
            Console.ReadLine();
            Console.Clear();
        
            Console.WriteLine("Instructions are as follows:\n1. Game must be a minimum of 7 days \n");
            day1.DayInit(player);
        }
    }
}
