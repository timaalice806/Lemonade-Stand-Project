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
        public int predictedForecast;
       

        //CONSTRUCTOR (DEFAULT)

        public Weather()
        {
            
        }
        //MEMBER METHODS (WEATHER CAN DO..)
        public void WeatherSelector()
        {
            List<string> weatherConditions = new List<string> () {"sunny", "cloudy", "rainy"};
            Random random = new Random();
            condition = random.Next(3);

            Console.WriteLine($"current condition: {weatherConditions[condition]}"); 
        }
        public void TempSelector()
        {
            Random random = new Random();
            temperature = random.Next(5, 11) *10 + 5;
            Random random2 = new Random();
            predictedForecast = random.Next(-15, 15);
            {
                Console.WriteLine($"current temperature: {temperature} and the predicted forcast for tomorrow is {temperature + predictedForecast}");
            }
        }

    }
}
