using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Store
    {
        Player player = new Player();
        public int priceLemon = 1;
        public int priceSugarCubes = 1;
        public int priceBagOfIceCubes = 4;
        public int pricePerCup = 1;

        public void sellAllItems(Player player)
        {
            sellLemons(player);
            sellSugarCubes(player);
            sellCups(player);
            sellBagOfIceCubes(player);
        }

        public void sellLemons(Player player)
        {
            Console.WriteLine("");
            Console.WriteLine($"How many lemons would you like to buy, you currently have ${player.wallet.cash}.00 to spend: ");
            int userInput = int.Parse(Console.ReadLine());
            int totalLemonCost = priceLemon * userInput;
            if (player.wallet.cash >= totalLemonCost)
            {
                Console.WriteLine($"You are buying {userInput} lemon, for a total price of {totalLemonCost} ");
                player.wallet.cash -= totalLemonCost;
                Console.WriteLine($"You now have {player.wallet.cash} in your wallet");
<<<<<<< HEAD
                
=======

                for (int i = 0; i < userInput; i++)
                {
                    player.inventory.lemons.Add("lemon");
                    Console.WriteLine($"You've added {userInput} lemons to your inventory");
                }

>>>>>>> 47b64cf85a9268915619d7883863dbbf6b58d5df
            }
            else {
                Console.WriteLine("You don't have enough money to make that purchase, please try a different amount.");
                sellLemons(player);
            }         
        }

        public void sellSugarCubes(Player player)
        {
            Console.WriteLine("");
            Console.WriteLine($"How many sugar cubes would you like to buy, you currently have ${player.wallet.cash}.00 to spend: ");
            int userInput = int.Parse(Console.ReadLine());
            int totalSugarCost = priceSugarCubes * userInput;
            if (player.wallet.cash >= totalSugarCost)
            {
                Console.WriteLine($"You are buying {userInput} sugar cubes, for a total price of {totalSugarCost} ");
                player.wallet.cash -= totalSugarCost;
                Console.WriteLine($"You now have {player.wallet.cash} in your wallet");
                for (int i = 0; i < userInput; i++)
                {
                    SugarCubes sugarCube = new SugarCubes();
                    player.inventory.sugarCubes.Add("sugar cubes");
                }

            }
            else {
                Console.WriteLine("You don't have enough money for that, please try a different amount");
                sellSugarCubes(player);
            }       
        }
        public void sellBagOfIceCubes(Player player)
        {
            Console.WriteLine("");
            Console.WriteLine("How many bags of ice cubes would you like to buy? You currently have " + player.wallet.cash + ".00 to spend:");
            int userInput = int.Parse(Console.ReadLine());
            priceBagOfIceCubes = priceBagOfIceCubes * userInput;
            if (player.wallet.cash >= priceBagOfIceCubes)
            {
                Console.WriteLine("You are buying " + userInput + " bags of ice cubes, for a total price of " + priceBagOfIceCubes + ".");
                player.wallet.cash -= priceBagOfIceCubes;
                Console.WriteLine(" You now have " + player.wallet.cash + " in you wallet.");
                for (int i = 0; i < userInput; i++)
                {
                    IceCube ice = new IceCube();
                    player.inventory.iceCubes.Add("ice cubes");
                }

            }
            else
            {
                Console.WriteLine(" You don't have enough money for that, please try a different amount.");
                sellBagOfIceCubes(player);
            }
        }
        public void sellCups(Player player)
        {
            Console.WriteLine("");
            Console.WriteLine("How many cups would you like to buy? You currently have " + player.wallet.cash + ".00");
            int userInput = int.Parse(Console.ReadLine());
            pricePerCup = pricePerCup * userInput;
            if (player.wallet.cash >= pricePerCup)
            {
                Console.WriteLine("You are buying " + userInput + " cups, for a total price of " + pricePerCup + ".");
                player.wallet.cash -= pricePerCup;
                Console.WriteLine("You now have " + player.wallet.cash + ".00");
                for (int i = 0; i < userInput; i++)
                {
                    Cups cup = new Cups();
                    player.inventory.cups.Add("cups");
                }
            }
            else
            {
                Console.WriteLine("You don't have enough money for that, please try a different amount.");
                sellCups(player);
            }
        }
    }
}
