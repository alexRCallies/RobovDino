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
        public int powerLevel;
        public int attackPower;
        public int defensePower;
        public int evasionPower;
        public int teamValue;

        public Robots(string name, int powerLevel, int health, int attackPower, int defensePower, int evasionPower, int teamValue)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.attackPower = attackPower;
            this.defensePower = defensePower;
            this.evasionPower = evasionPower;
            this.teamValue = teamValue;

        }
    }
}
