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
        public int pricePerCup = 1;
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

                Console.WriteLine("You don't have enough money for that, please try a different amount.");

                Console.WriteLine("You are broke, please leave immediately or security will be notified.");

            }
        }
        public void sellSugarCubes(Player player) 
        {
            Console.WriteLine("How many sugar cubes would you like to buy? You currently have" + player.wallet.cash + ".00 to spend:");
            int userInput = int.Parse(Console.ReadLine());
            priceSugarCubes = priceSugarCubes * userInput;
            if (player.wallet.cash >= priceSugarCubes)
            {
                Console.WriteLine(" You are buying" + userInput + " sugar cubes, for a total price of " + priceSugarCubes + ".");
                player.wallet.cash -= priceSugarCubes;
                Console.WriteLine("You now have " + player.wallet.cash + " in your wallet.");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("You don't have enough money for that, please try a different amount");
            }
        }
        public void sellBagOfIceCubes(Player player) 
        {
            Console.WriteLine("How many bags of ice cubes would you like to buy? You currently have " + player.wallet.cash + ".00 to spend:");
            int userInput = int.Parse(Console.ReadLine());
            priceBagOfIceCubes = priceBagOfIceCubes * userInput;
            if (player.wallet.cash >= priceBagOfIceCubes)
            {
                Console.WriteLine("You are buying " + userInput + " bags of ice cubes, for a total price of " + priceBagOfIceCubes + ".");
                player.wallet.cash -= priceBagOfIceCubes;
                Console.WriteLine(" You now have " + player.wallet.cash + " in you wallet.");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine(" You don't have enough money for that, please try a different amount.");
            }
        }
        public void sellCups(Player player) 
        {
            Console.WriteLine("How many cups would you like to buy? You currently have " + player.wallet.cash + ".00");
            int userInput = int.Parse(Console.ReadLine());
            pricePerCup = pricePerCup * userInput;
            if (player.wallet.cash >= pricePerCup)
            {
                Console.WriteLine("You are buying " + userInput + " cups, for a total price of " + pricePerCup + ".");
                player.wallet.cash -= pricePerCup;
                Console.WriteLine("You now have" + player.wallet.cash + ".00");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("You don't have enough money for that, please try a different amount.");
            }
        }

    }
}
