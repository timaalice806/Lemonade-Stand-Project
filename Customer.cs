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
        public int probabilityOfBuying;
        public void initCustomers(Random random)
        {
            List<string> names = new List<string>() { "Annalee", "Kendra", "Coy", "Cecily", "Russell", "Tom", "Chris", "Donny", "Gerry", "Berniece", "Zeph", "Serrena", "Essie", "Gordie", "Kent", "Lovell", "Cy", "Merrick", "Reuben", "Judd" };

            Random random1 = new Random();
            int name = random1.Next(21);
            int count = random1.Next(1, 20);
            Weather weather = new Weather();
            
            for (int i = 0; i < count; i++)
            {
                name = random1.Next(20);
                probabilityOfBuying = random1.Next(1, 9);
                Console.WriteLine($"customer: {names[name]}");
                CustomerProbabiltyFunc(weather);
            }
            Console.ReadLine();
        }
        public void CustomerProbabiltyFunc(Weather weather)
        {
            if(weather.temperature >= 60 && weather.temperature <= 70)
            {
                if(probabilityOfBuying == 1 && probabilityOfBuying == 2)
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
                if (probabilityOfBuying == 1 && probabilityOfBuying == 2 && probabilityOfBuying == 3 && probabilityOfBuying == 4)
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
                if (probabilityOfBuying == 1 && probabilityOfBuying == 2 && probabilityOfBuying == 3 && probabilityOfBuying == 4 && probabilityOfBuying == 5 && probabilityOfBuying == 6)
                {
                    Console.WriteLine("there is a 75% chance of purchasing");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("...2");
                }
            }


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
