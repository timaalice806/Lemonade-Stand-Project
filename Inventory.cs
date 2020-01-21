using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{ 
    public class Inventory
    {
        public List<Lemon> lemons;
        public List<IceCube> iceCubes = new List<IceCube>() {};
        public List<Cups> cups = new List<Cups>() {};
        public List<SugarCubes> sugarCubes = new List<SugarCubes>() {};

        public Inventory()
        {
            lemons = new List<Lemon>();
        }

    }
}
