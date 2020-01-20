using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Game
    {
<<<<<<< HEAD

        Player player;
=======
        Player player = new Player();
>>>>>>> 62df35674b8f93fb04165ef3ab99d091a1725ab9
        Weather weather = new Weather();
        Customer customer = new Customer();
        Random random = new Random();
        Store store = new Store();
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
                    customer.initCustomers(random);
                    store.sellLemons(player);
                    Console.WriteLine("Do you need more lemons today, please enter yes or no");
                    string playerInput = Console.ReadLine();
                    if(playerInput == "yes" || playerInput == "y")
                    {
                        store.sellLemons(player);
                    }else if(playerInput == "no" || playerInput == "n"){
                        Console.WriteLine("Press ENTER to continue");
                    }
                    else
                    {
                        Console.WriteLine("Please enter either yes or no, y or n.");
                        Console.ReadLine();
                    }
                    
                }
                else if (day == "Monday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    customer.initCustomers(random);
                    
                }
                else if (day == "Tuesday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    customer.initCustomers(random);
                    store.sellLemons();
                }
                else if (day == "Wednesday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    customer.initCustomers(random);
                    store.sellLemons();
                }
                else if (day == "Thursday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    customer.initCustomers(random);
                    store.sellLemons();
                }
                else if (day == "Friday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    customer.initCustomers(random);
                    store.sellLemons();
                }
                else if (day == "Saturday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    customer.initCustomers(random);
                    store.sellLemons();

                }
            }
           
        }

        public void PlayGame()
        {

        }
    }
}
