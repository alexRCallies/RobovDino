using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Intro
    {
        public Intro()
        {

        }

        public void RunIntro()
        {
            Console.WriteLine("Welcome Commanders to the Robots vs. Dinosaurs Simulator");
            Console.WriteLine("In this experience you will face off against each other to see who will come out victorious.");
            Console.WriteLine("Player One, you will be controlling the Herd, a pack of savage creatures defending your homeland.");
            Console.WriteLine("Player Two, you will be commanding the Fleet, a squadron of highly advanced military grade A.I. machines");
            Console.WriteLine("To recruit type the name of the unit exactly as it says.");
            Console.WriteLine("The Herd will attack first");
            Console.WriteLine("To attack type the number of where your unit is on the list followed by the location of the opposing unit on their list.");
            Console.WriteLine("For example 1 1 would be your first unit attacks the enemies first unit");
            Console.WriteLine("Once a unnit is gone the next in line will take its position");
            Console.WriteLine("Once all units are destroyed, losde please type 'End'");
            Console.ReadLine();
        }
    }
}
