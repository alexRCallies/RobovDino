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
        public int energy;
        public int health;
        public int attackPower;
        public int defensePower;
        public int evasionPower;
        public int teamValue;
        public Dinosaurs(string name, int energy, int health, int attackPower, int defensePower, int evasionPower, int teamValue)
        {
            this.name = name;
            this.energy = energy;
            this.health = health;
            this.attackPower = attackPower;
            this.defensePower = defensePower;
            this.evasionPower = evasionPower;
            this.teamValue = teamValue;

        }

    }
}
