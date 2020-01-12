using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Battle battle = new Battle();

            battle.RunTeamSelect();
            Console.ReadLine();
        }
    }
}
