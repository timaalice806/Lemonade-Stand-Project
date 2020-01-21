using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Day
    {
        Weather weather = new Weather();
        Customer customer = new Customer();
        Store store = new Store();
        List<Customer> customers = new List<Customer>();
        Player player = new Player();
        Pitcher pitcher = new Pitcher();
        public void initRandomCustomerList()
        {        
            Random random = new Random();
            int numofcustomers = random.Next(20);
            for (int i = 0; i < numofcustomers; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
                Console.WriteLine(customer.name.ToString());
                Console.ReadLine();
            }  
        }

        public void customersPurchase()
        {
            foreach (Customer customer in customers)
            {
                if (customer.customerProbilityOfBuying == true)
                {
                    player.wallet.cash += 3;
                    player.pitcher.cups -= 1;

                }
                else
                {

                }
            }
        }
        public void DayInit(Player player)
        {
            List<string> dayOfTheWeek = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            foreach (string weekDay in dayOfTheWeek)
            {
                if (weekDay == "Sunday")
                {
                    Console.WriteLine($"Welcome to {weekDay}");
                    weather.WeatherSelector();
                    weather.TempSelector();
                    store.sellAllItems(player);
                    initRandomCustomerList();
                    customer.CustomerProbabiltyFunc();

                    //string playerInput = Console.ReadLine();
                    //if (playerInput == "yes" || playerInput == "y")
                    //{
                    //    store.sellAllItems(player);
                    //}
                    //else if (playerInput == "no" || playerInput == "n")
                    //{
                    //    Console.WriteLine("Press ENTER to continue");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Please enter either yes or no, y or n.");
                    //    Console.ReadLine();
                    //}
                }
                else if (weekDay == "Monday")
                {
                    Console.WriteLine($"Welcome to {weekDay}");
                    weather.WeatherSelector();
                    weather.TempSelector();
                    store.sellAllItems(player);
                    initRandomCustomerList();
                    customer.CustomerProbabiltyFunc();
                }
                else if (weekDay == "Tuesday")
                {
                    Console.WriteLine($"Welcome to {weekDay}");
                    weather.WeatherSelector();
                    weather.TempSelector();
                    store.sellAllItems(player);
                    customer.CustomerProbabiltyFunc();
                }
                else if (weekDay == "Wednesday")
                {
                    Console.WriteLine($"Welcome to {weekDay}");
                    weather.WeatherSelector();
                    weather.TempSelector();
                    store.sellAllItems(player);
                    customer.CustomerProbabiltyFunc();

                }
                else if (weekDay == "Thursday")
                {
                    Console.WriteLine($"Welcome to {weekDay}");
                    weather.WeatherSelector();
                    weather.TempSelector();
                    store.sellAllItems(player);
                    customer.CustomerProbabiltyFunc();
                }
                else if (weekDay == "Friday")
                {
                    Console.WriteLine($"Welcome to {weekDay}");
                    weather.WeatherSelector();
                    weather.TempSelector();
                    store.sellAllItems(player);
                    customer.CustomerProbabiltyFunc();
                }
                else if (weekDay == "Saturday")
                {
                    Console.WriteLine($"Welcome to {weekDay}");
                    weather.WeatherSelector();
                    weather.TempSelector();
                    store.sellAllItems(player);
                    customer.CustomerProbabiltyFunc();
                }
            }
        }
    }
}
