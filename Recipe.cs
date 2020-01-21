using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Recipe
    {
        //MEMBER VARIABLES (RECIPE HAS A..)
        public int amtOfLemons;
        public int amtOfSugar;
        public int amtOfIceCubes;
        public int pitcher;
        public int pricePerCup = 3;

        //CONSTRUCTOR (DEFAULT RECIPE) 
        public Recipe (int amtOfLemons, int amtOfSugar, int amtOfIceCubes, int pitcher)
        {
            this.amtOfLemons = 4;
            this.amtOfSugar = 2;
            this.amtOfIceCubes = 10;
            this.pitcher = 1;
        }
        //MEMBER METHODS (RECIPE CAN MAKE A..)
        public void MakePitcher()
        {
            int defaultPitcher = amtOfLemons + amtOfSugar + amtOfIceCubes;
            Console.WriteLine($"The the default recipe includes {amtOfLemons} lemons, {amtOfSugar} and {amtOfIceCubes} ice cubes to make 1 pitcher of lemonade, 10 cups per {pitcher} pitcher");
            Console.ReadLine();
        }
    }
}
