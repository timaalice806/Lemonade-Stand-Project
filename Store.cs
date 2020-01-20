using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Store
    {
        public int priceLemon = 1;
        public int priceSugarCubes = 1;
        public int priceBagOfIceCubes = 10;
        public int priceCupPrices = 1;
        Player player = new Player();

        public void sellLemons(Player player)
        {
            Console.WriteLine($"How many lemons would you like to buy, you currently have ${player.wallet.cash}.00 to spend: ");
            int userInput = int.Parse(Console.ReadLine());
            priceLemon = priceLemon * userInput; 
            if(player.wallet.cash >= priceLemon)
            {
                Console.WriteLine($"You are buying {userInput} lemon, for a total price of {priceLemon} ");
                player.wallet.cash -= priceLemon;
                Console.WriteLine($"You now have {player.wallet.cash} in your wallet");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You are broke, please leave immediately or security will be notified.");
            }
        }
    }
}
