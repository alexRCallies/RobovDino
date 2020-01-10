using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Dinosaurs
    {
        public string name;
        
        public int health;
        public int attackPower;
        public int defensePower;
        public int evasion;
        public int teamValue;
        public int critChance;
        public Dinosaurs(string name, int health, int attackPower, int defensePower, int evasion, int critChance, int teamValue)
        {
            this.name = name;
            
            this.health = health;
            this.attackPower = attackPower;
            this.defensePower = defensePower;
            this.evasion = evasion;
            this.critChance = critChance;
            this.teamValue = teamValue;

        }

    }
}
