using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    public class Player
    {
        public string name;

        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;

        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            pitcher = new Pitcher();
            recipe = new Recipe(4,2,1,1);
        }

        public void GetRecipe()
        {

        }

        public void GoToStore()
        {

        }

        public void PurchaseInventory()
        {

        }

        public void SellLemonade()
        {

        }

        public void CalcProfitsAndLosses()
        {

        }
    }
}
