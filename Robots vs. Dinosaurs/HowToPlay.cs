using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class HowToPlay
    {
        public HowToPlay()
        {

        }

        public void Instructions()
        {
            Console.WriteLine("How To Play:");
            Console.WriteLine("Players will take turn attacking each other.");
            Console.WriteLine("First player who loses all their units, is defeated");
            Console.WriteLine("To attack, begin by typing / ATTACK / on your turn");
            Console.WriteLine("The Fleet Commander, to use items type / ITEMS /");
            Console.WriteLine("The Pack Master, to use abilities type /  SPECIAL /");
           
        }
    }
}
