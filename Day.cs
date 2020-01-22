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
        Recipe recipe = new Recipe(4, 2, 40, 1);
        Customer customer = new Customer();
        Store store = new Store();
        List<Customer> customers = new List<Customer>();
        Player player;
        Pitcher pitcher = new Pitcher();
        Inventory inventory = new Inventory();
        public void initRandomCustomerList()
        {        

            Random random = new Random();
            int numofcustomers = random.Next(20);
            for (int i = 0; i < numofcustomers; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
                
                Console.WriteLine($"{ customer.name.ToString()}{" "}{" "}{customer.tempPref} {customer.customerProbilityOfBuying}");
                Console.ReadLine();
            }    
        }
        public Day(Player rng)
        {
            player = rng;
        }
        public void customersPurchase()
        {
            foreach (Customer customer in customers)
            {
                if (customer.customerProbilityOfBuying == true)
                {
                    if(pitcher.cups == 0)
                    {
                        Console.WriteLine("You've run out of lemonade for the day");
                    }
                    player.wallet.cash += player.recipe.pricePerCup;
                    player.pitcher.cups -= 1;

                    Console.WriteLine($"${player.wallet.cash}.00 cash on hand, {player.pitcher.cups} cups remaining");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("No sale");
                }
            }
        }
        public void DayInit(Player player)
        {
            List<string> dayOfTheWeek = new List<string>() { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            foreach (string weekDay in dayOfTheWeek)
            {
                Console.WriteLine($"Welcome to {weekDay}");
                weather.WeatherSelector();
                weather.TempSelector();
                store.sellAllItems(player);
                initRandomCustomerList();
                customer.CustomerProbabiltyFunc();
                recipe.MakePitcher();
                customersPurchase();
            }
        }
    }
}
