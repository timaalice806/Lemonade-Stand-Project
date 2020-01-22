using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Game
    {
        //MEMBER VARIABLES (GAME HAS A..)

        Player player = new Player();
        Day day1;
        public int currentDay;

        public Game()
        {
            day1 = new Day(player);
        }

        //MEMBER MEMTHOD (GAME CAN DO..)

        public void GameInit()
        {
            Console.WriteLine("Lemonade Stand Game 2020\nPress ENTER To Play");
            Console.ReadLine();
            Console.Clear();
       

            Console.WriteLine("INSTRUCTIONS ARE AS FOLLOWS:\nYour goal is to make as much money as you can in 7 days by selling lemondade at your lemonade stand.\nBuy cups, lemons, sugar and ice cubes.Your customers will purchasse based on the weather and conditions.\nAt the end of the week see how you have made, play again and try and beat your score.");
            Console.WriteLine("");
            day1.DayInit(player);
        }
    }
}
