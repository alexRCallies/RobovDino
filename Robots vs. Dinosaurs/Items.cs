using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Items
    {
       public string name;
        public int addAttack;
        public int addDefense;
        public int addHealth;
        public int shopPrice;

        public Items(string name, int addAttack, int addDefense, int addHealth, int shopPrice)
        {
            this.name = name;
            this.addAttack = addAttack;
            this.addDefense = addDefense;
            this.addHealth = addHealth;
            this.shopPrice = shopPrice;
            

        }
    }
}
