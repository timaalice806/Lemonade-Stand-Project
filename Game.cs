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
        Day day1 = new Day();
        Weather weather = new Weather();
        Customer customer = new Customer("", 6);
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

            List<string> days = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            foreach (string day in days)
            {
                if (day == "Sunday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();                   
                    store.sellAllItems(player);
                    day1.initRandomCustomer();
                    day1.CustomerProbabiltyFunc(weather);
                    Console.WriteLine($"Welcome to {day}. Do you need more lemons today, please enter yes or no");

                    string playerInput = Console.ReadLine();
                    if(playerInput == "yes" || playerInput == "y")
                    {
                        store.sellLemons(player);
                    }else if(playerInput == "no" || playerInput == "n"){
                        Console.WriteLine("Press ENTER to continue");
                        customer.initCustomers(random);
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
                    store.sellAllItems(player);
                    customer.initCustomers(random);

                }
                else if (day == "Tuesday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    store.sellAllItems(player);
                    customer.initCustomers(random);

                }
                else if (day == "Wednesday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();                   
                    store.sellAllItems(player);
                    customer.initCustomers(random);

                }
                else if (day == "Thursday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();                   
                    store.sellAllItems(player);
                    customer.initCustomers(random);

                }
                else if (day == "Friday")
                {
                    weather.WeatherSelector();
                    weather.TempSelector();
                    store.sellAllItems(player);
                    customer.initCustomers(random);

                }
                else if (day == "Saturday")
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
