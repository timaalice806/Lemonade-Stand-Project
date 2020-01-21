using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Game
    {
        public Player player = new Player();
        Day day1 = new Day();
        //Weather weather = new Weather();
        //Customer customer = new Customer();
        //Random random = new Random();
        //Store store = new Store();

        //VARIABLES (GAME HAS A..)

        public int currentDay;

        //MEMBER MEMTHOD (CAN DO)

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
