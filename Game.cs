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

        Weather weather = new Weather();
        Customer customer = new Customer("");
        Day day1 = new Day();
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

            List<string> dayOfTheWeek = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            foreach (string weekDay in dayOfTheWeek)
            {
                if (weekDay == "Sunday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();                   
                    store.sellAllItems(player);
                    day1.initRandomCustomer();
                    Console.WriteLine("Do you need more lemons today, please enter yes or no");
                    string playerInput = Console.ReadLine();
                    if(playerInput == "yes" || playerInput == "y")
                    {
                        
                    }else if(playerInput == "no" || playerInput == "n"){
                        Console.WriteLine("Press ENTER to continue");
                    }
                    else
                    {
                        Console.WriteLine("Please enter either yes or no, y or n.");
                        Console.ReadLine();
                    }
                    customer.initCustomers(random);

                }
                else if (weekDay == "Monday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    store.sellAllItems(player);
                    customer.initCustomers(random);

                }
                else if (weekDay == "Tuesday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    store.sellAllItems(player);
                    customer.initCustomers(random);

                }
                else if (weekDay == "Wednesday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();                   
                    store.sellAllItems(player);
                    customer.initCustomers(random);

                }
                else if (weekDay == "Thursday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();                   
                    store.sellAllItems(player);
                    customer.initCustomers(random);

                }
                else if (weekDay == "Friday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    store.sellAllItems(player);
                    customer.initCustomers(random);

                }
                else if (weekDay == "Saturday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    store.sellAllItems(player);
                    customer.initCustomers(random);

                }
            }
           
        }

        public void PlayGame()
        {

        }
    }
}
