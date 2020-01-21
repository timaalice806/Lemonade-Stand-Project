using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Customer
    {
        public string name;
        public bool customerProbilityOfBuying;
        public List<string> names = new List<string>() { "Annalee", "Kendra", "Coy", "Cecily", "Russell", "Tom", "Chris", "Donny", "Gerry", "Berniece", "Zeph", "Serrena", "Essie", "Gordie", "Kent", "Lovell", "Cy", "Merrick", "Reuben", "Judd" };
        public int tempPref;
        Wallet wallet;
        Customer customer;
        Pitcher pitcher;

        public Customer()
        {
            Random rng = new Random();
            tempPref = rng.Next(55, 95);
            name = names[rng.Next(0, names.Count)];
            customerProbilityOfBuying = false;
            CustomerProbabiltyFunc();

        }
<<<<<<< HEAD
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
=======

        public bool CustomerProbabiltyFunc()
        {
            if (tempPref >= 75 && tempPref <= 95)
>>>>>>> 6413f185db47c0dae7f5c227aae3e2053311d1d3
            {
                return customerProbilityOfBuying = true;

            }else
            {
                return customerProbilityOfBuying = false;
            }

            
        }
    }
}

