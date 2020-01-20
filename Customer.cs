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

<<<<<<< HEAD
            Random random = new Random();
            int name = random.Next(21);
=======
            int count = random.Next(1, 20);
            
>>>>>>> 748dbe0c762b7e3e10b79aa61226537b15e90b31

            for (int i = 0; i < count; i++)
            {

<<<<<<< HEAD
=======
                name = random.Next(20);
>>>>>>> 748dbe0c762b7e3e10b79aa61226537b15e90b31
                Console.WriteLine($"customer: {names[name]}");    
            }
            Console.ReadLine();
        }
    }
}
