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
        List<Customer> customers = new List<Customer>();

        public void initRandomCustomerList()
        {
            Random random = new Random();
            int numofcustomers = random.Next(20);
            for (int i = 0; i < numofcustomers; i++)
            {
                customers.Add(new Customer());
            }
            //foreach (Customer customer in customers)
            //{
            //    customer.initCustomers
            //}
          
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
        public void initDay()
        {

        }
    }
}
