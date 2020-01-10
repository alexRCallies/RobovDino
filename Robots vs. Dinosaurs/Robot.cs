using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Robot
    {
        public string name;
        public int health;
        
        public int attackPower;
       
        public int evasionPower;
        public int critChance;
        public int teamValue;

        public Robot(string name, int health, int attackPower,  int evasionPower, int critChance, int teamValue)
        {
            this.name = name;
            this.health = health;
            
            this.attackPower = attackPower;
            
            this.evasionPower = evasionPower;
            this.critChance = critChance;
            this.teamValue = teamValue;

        }

        public void Attack(Dinosaur dinos)
        {
            Random hitRoll = new Random();
            int hit = hitRoll.Next(1, 11);
            Random critRoll = new Random();
            int crit = critRoll.Next(1, 11);
            if (hit > dinos.evasion)
            {
                if (crit > critChance)
                {
                    dinos.health -= (attackPower * 2);
                    Console.WriteLine("CRITCAL HIT!!!");
                }
                else
                {
                   dinos.health -= attackPower;
                    Console.WriteLine("SUCCESFUL HIT");
                }
            }


        }
    }
}
