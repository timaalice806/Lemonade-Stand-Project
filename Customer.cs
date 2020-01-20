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

            Random random1 = new Random();
            int name = random1.Next(21);
            int count = random1.Next(1, 20);

            for (int i = 0; i < count; i++)
            {
                name = random1.Next(20);
                Console.Write($"{names[name]}{", "}");
            }
            Console.ReadLine();
        }
        public void CustomerProbabiltyFunc(Weather weather)
        {
            //if weather condition = sunny
            //probabilty of potential customers is the highest (15-20)

            // if temp is high (85-95)
            //probabilty of a potential customer buying lemoande is high (60%>)

            //if weather condition = cloudy
            //probabilty of potential customers is average (10-15)

            // if temp is medium (70-85)
            //probabilty of a potential customer buying lemoande is medium (40%-60%)

            //if weather condition = rainy
            //probabilty of potential customers is the lowest (<10)

            // if temp is low (<70)
            //probabilty of a potential customer buying lemoande is low (<40%)
        }
    }
}
