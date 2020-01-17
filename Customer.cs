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
        public void initCustomers(Random random)
        {
            List<string> names = new List<string>() { "Annalee", "Kendra", "Coy", "Cecily", "Russell", "Tom", "Chris", "Donny", "Gerry", "Berniece", "Zeph", "Serrena", "Essie", "Gordie", "Kent", "Lovell", "Cy", "Merrick", "Reuben", "Judd" };

            int count = random.Next(1, 20);
            

            for (int i = 0; i < count; i++)
            {

                name = random.Next(20);
                Console.WriteLine($"customer: {names[name]}");    
            }
            Console.ReadLine();
        }
    }
}
