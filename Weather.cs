using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Weather
    {
        //VARIABLES (WEATHER HAS A..)
        public int condition;
        public int temperature;
        public string predictedForecast;
       

        //CONSTRUCTOR (DEFAULT)

        public Weather()
        {
            
        }

        public void WeatherSelector()
        {
            List<string> weatherConditions = new List<string> () { "sunny", "cloudy", "rainy" };
            Random random = new Random();
            condition = random.Next(3);

                Console.WriteLine($"current condition: {weatherConditions[condition]}"); 
     
            Console.ReadLine();
        }

        public void TempSelector()
        {
            Random random = new Random();
            temperature = random.Next(60, 90);
            {
                Console.WriteLine(temperature);
            }
        }
    }
}
