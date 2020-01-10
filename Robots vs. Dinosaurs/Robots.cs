using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Robots
    {
        public string name;
        public int health;
        
        public int attackPower;
        public int defensePower;
        public int evasionPower;
        public int critChance;
        public int teamValue;

        public Robots(string name, int health, int attackPower, int defensePower, int evasionPower, int critChance, int teamValue)
        {
            this.name = name;
            this.health = health;
            
            this.attackPower = attackPower;
            this.defensePower = defensePower;
            this.evasionPower = evasionPower;
            this.critChance = critChance;
            this.teamValue = teamValue;

        }
    }
}
