﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Customer
    {
        public string name;
        public int probabilityOfBuying;
        public List<string> names = new List<string>() { "Annalee", "Kendra", "Coy", "Cecily", "Russell", "Tom", "Chris", "Donny", "Gerry", "Berniece", "Zeph", "Serrena", "Essie", "Gordie", "Kent", "Lovell", "Cy", "Merrick", "Reuben", "Judd" };


        public Customer()
        {

        }
        public void initCustomers()
        {
<<<<<<< HEAD
            Random random1 = new Random();

            int name = random1.Next(21);

            int count = random1.Next(1, 20);



            for (int i = 0; i < count; i++)
            {
                name = random1.Next(20);

                Console.Write($"{names[name]}{", "}");

            }
            Console.ReadLine();

=======
            Customer customer;

>>>>>>> 47b64cf85a9268915619d7883863dbbf6b58d5df
        }
        public void CustomerProbabiltyFunc(Weather weather)
        {          
            if (weather.temperature >= 60 && weather.temperature <= 70)
            {
                if ((probabilityOfBuying == 1) || (probabilityOfBuying == 2))
                {
                    Console.WriteLine("there is a 25% chance of purchasing");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("...");
                }
            }
            else if (weather.temperature >= 71 && weather.temperature <= 80)
            {
                if ((probabilityOfBuying == 1) || (probabilityOfBuying == 2) || (probabilityOfBuying == 3) || (probabilityOfBuying == 4))
                {
                    Console.WriteLine("there is a 50% chance of purchasing");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("...1");
                }
            }
            else if (weather.temperature >= 81 && weather.temperature <= 90)
            {
                if ((probabilityOfBuying == 1) || (probabilityOfBuying == 2) || (probabilityOfBuying == 3) || (probabilityOfBuying == 4) || (probabilityOfBuying == 5) || (probabilityOfBuying == 6))
                {
                    Console.WriteLine("there is a 75% chance of purchasing");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("...2");
                }
            }
        }
    }
}

