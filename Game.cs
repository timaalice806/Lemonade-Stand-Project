using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Game
    {
        Player player;
        Weather weather = new Weather();

        //VARIABLES (GAME HAS A..)

        public int currentDay;

        //MEMBER MEMTHOD (CAN DO)

        public void GameInit()
        {
            Console.WriteLine("Lemonade Stand Game 2020 \n Press ENTER To Play");
            Console.ReadLine();
            Console.Clear();
        
            Console.WriteLine("Instructions are as follows: \n 1. Game must be a minimum of 7 days \n");
            Console.ReadLine();

            weather.WeatherSelector();
            weather.TempSelector();
        }

        public void PlayGame()
        {

        }
    }
}
