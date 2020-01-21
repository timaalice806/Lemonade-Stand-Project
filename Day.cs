using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {

      
        

        Weather weather = new Weather();
        public int customers;
        public int probabilityOfBuying;
        Customer customer = new Customer();
        
        public void initRandomCustomer()
        {
            Random random = new Random();
            customers = random.Next(20);
            for(int j = 0; j < customers; j++)
            {
                for (int i = 0; i < customer.names.Count; i++)
                {
                    int nameIndex = random.Next(1, 20);

                    probabilityOfBuying = random.Next(8);

                    Console.WriteLine($"{customer.names[nameIndex]} {" "} {probabilityOfBuying}");
                }
                Console.ReadLine();
            }  
        }
        public void initRandomCustomer()
        {
            Random random = new Random();
            

            for(int i = 0; i < customer.names.Count; i++)
            {
                
                int nameIndex = random.Next(20);

               
                probabilityOfBuying = random.Next(1, 9);

                Console.WriteLine($"customer: {customer.names[nameIndex]} {probabilityOfBuying}");
                Console.ReadLine();
            }
        }


        public void CustomerProbabiltyFunc(Weather weather)
        {
            //CustomerProbabiltyFunc(weather);
            if (weather.temperature >= 60 && weather.temperature <= 70)
            {
                if (customer.probabilityOfBuying == 1 && customer.probabilityOfBuying == 2)
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
