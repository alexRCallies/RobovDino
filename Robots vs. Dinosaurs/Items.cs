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
        
        public int addHealth;
        public int shopPrice;

        public Items(string name, int addAttack, int addHealth, int shopPrice)
        {
            this.name = name;
            this.addAttack = addAttack;
            
            this.addHealth = addHealth;
            this.shopPrice = shopPrice;
            

        }

        public void GiveItem(Robot robots)
        {
            string giveItem = Console.ReadLine();
            if(giveItem == name + " " + robots.name )
            {
                robots.attackPower += addAttack;
                robots.health += addHealth;
                
            }
        }
    }
}
