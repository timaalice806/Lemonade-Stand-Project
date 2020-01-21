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


        public bool CustomerProbabiltyFunc()
        {
            if (tempPref >= 75 && tempPref <= 95)
            {
                return customerProbilityOfBuying = true;
            }
            else
            {
                return customerProbilityOfBuying = false;
            }
        }
    }
}

