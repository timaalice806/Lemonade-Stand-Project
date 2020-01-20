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
        Inventory inventory;
        public Wallet wallet;
        Recipe recipe;
        Pitcher pitcher;

        public Player()
        {
            wallet = new Wallet();
        }
           
        


    }
}
