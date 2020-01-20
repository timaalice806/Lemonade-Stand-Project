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
<<<<<<< HEAD
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
=======
        Inventory inventory;
        public Wallet wallet;
        Recipe recipe;
        Pitcher pitcher;
>>>>>>> 748dbe0c762b7e3e10b79aa61226537b15e90b31

        public Player()
        {
            wallet = new Wallet();
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
