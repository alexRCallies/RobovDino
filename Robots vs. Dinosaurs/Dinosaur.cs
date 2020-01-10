using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Dinosaur
    {
        public string name;
        
        public int health;
        public int attackPower;
        
        public int evasion;
        public int teamValue;
        public int critChance;
        public Dinosaur(string name, int health, int attackPower, int evasion, int critChance, int teamValue)
        {
            this.name = name;
            
            this.health = health;
            this.attackPower = attackPower;
            
            this.evasion = evasion;
            this.critChance = critChance;
            this.teamValue = teamValue;

        }
        public void Attack(Robot robots)
        {
            Random hitRoll = new Random();
            int hit = hitRoll.Next(1, 11);
            Random critRoll = new Random();
            int crit = critRoll.Next(1, 11);
            if(hit > robots.evasionPower)
            {
                if(crit > critChance)
                {
                    robots.health -= (attackPower * 2);
                    Console.WriteLine("CRITCAL HIT!!!");
                }
                else
                {
                    robots.health -= attackPower;
                    Console.WriteLine("SUCCESFUL HIT");
                }
            }


        }
    }
}
