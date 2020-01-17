using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Customer
    {
        public int name;
        public void initCustomers()
        {
            List<string> names = new List<string>() { "Annalee", "Kendra", "Coy", "Cecily", "Russell", "Tom", "Chris", "Donny", "Gerry", "Berniece", "Zeph", "Serrena", "Essie", "Gordie", "Kent", "Lovell", "Cy", "Merrick", "Reuben", "Judd" };

            Random random = new Random();
            name = random.Next(21);

            for (int i = 0; i < name; i++)
            {
                Console.WriteLine($"customer: {names[name]}");    
            }
            Console.ReadLine();
        }
    }
}
