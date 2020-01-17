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
        Customer customer = new Customer();
        
        //VARIABLES (GAME HAS A..)

        public int currentDay;

        //MEMBER MEMTHOD (CAN DO)

        public void GameInit()
        {
            Console.WriteLine("Lemonade Stand Game 2020\nPress ENTER To Play");
            Console.ReadLine();
            Console.Clear();
        
            Console.WriteLine("Instructions are as follows:\n1. Game must be a minimum of 7 days \n");
            Console.ReadLine();

            List<string> days = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            foreach (string day in days)
            {
                if (day == "Sunday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    customer.initCustomers();
                }
                else if (day == "Monday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    customer.initCustomers();
                }
                else if (day == "Tuesday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    customer.initCustomers();
                }
                else if (day == "Wednesday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    customer.initCustomers();
                }
                else if (day == "Thursday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    customer.initCustomers();
                }
                else if (day == "Friday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    customer.initCustomers();
                }
                else if (day == "Saturday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    customer.initCustomers();
                }
            }
           
        }

        public void PlayGame()
        {

        }
    }
}
