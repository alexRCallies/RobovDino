using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Player1
    {
        string name;
        public int recruitPoints;
        
      

        public Player1()
        {
            this.name = "Player 1";
            this.recruitPoints = 20;


        }
        public void PlayerOneName()
        {
            name = Console.ReadLine();
        }

    }

}



