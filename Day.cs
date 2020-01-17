using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Day
    {
        Weather weather;
        int customers;
        
        public void initDay()
        {
            Random random = new Random();
            customers = random.Next();
        }
    }
}
