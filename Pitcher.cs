using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Pitcher
    {

        public int cups = 10;
        public void NewPitcher(Recipe recipe, Inventory inventory)
        {
            //inventory.lemons.RemoveRange(0, recipe.amtOfLemons);
            //inventory.sugarCubes.RemoveRange(0, recipe.amtOfSugar);
            //inventory.iceCubes.RemoveRange(0, recipe.amtOfIceCubes);
            //cups = 10;

            do
            {
                inventory.lemons.RemoveRange(0, recipe.amtOfLemons); inventory.sugarCubes.RemoveRange(0, recipe.amtOfSugar); inventory.iceCubes.RemoveRange(0, recipe.amtOfIceCubes);
            } while ((recipe.amtOfLemons <= inventory.lemons.Count) && (recipe.amtOfSugar <= inventory.sugarCubes.Count) && (recipe.amtOfIceCubes <= inventory.iceCubes.Count));
        }

    }
}
