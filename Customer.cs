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
        public int probabilityOfBuying;
        public List<string> names = new List<string>() { "Annalee", "Kendra", "Coy", "Cecily", "Russell", "Tom", "Chris", "Donny", "Gerry", "Berniece", "Zeph", "Serrena", "Essie", "Gordie", "Kent", "Lovell", "Cy", "Merrick", "Reuben", "Judd" };

        public Customer(string name)
        {
            this.name = name;
           
        }
        public void initCustomers(Random random)
        {
            Random random1 = new Random();
            int name = random1.Next(21);

            int count = random1.Next(1, 20);
            Weather weather = new Weather();
        }
        
    }
}
