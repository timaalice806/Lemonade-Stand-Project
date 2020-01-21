using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{ 
    public class Inventory
    {
<<<<<<< HEAD
<<<<<<< HEAD
        List<String> iceCubes = new List<string>() { };
        List<String> cups = new List<string>() { };
        List<String> sugarCubes = new List<string>() {};
        List<Lemon> lemons = new List<Lemon>();
=======
        public List<String> lemons = new List<string>() {};
        public List<String> iceCubes = new List<string>() {};
        public List<String> cups = new List<string>() {};
        public List<String> sugarCubes = new List<string>() {};
>>>>>>> 47b64cf85a9268915619d7883863dbbf6b58d5df
=======
        public List<Lemon> lemons;
        public List<IceCube> iceCubes = new List<IceCube>() {};
        public List<Cups> cups = new List<Cups>() {};
        public List<SugarCubes> sugarCubes = new List<SugarCubes>() {};

        public Inventory()
        {
            lemons = new List<Lemon>();
        }

>>>>>>> 6413f185db47c0dae7f5c227aae3e2053311d1d3
    }
}
