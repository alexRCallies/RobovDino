using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Battle
    {
        Herd herd = new Herd();
        Fleet fleet = new Fleet();
        
        public void RunBattle()
        {
            herd.RecruitHerd(herd.herdList);
        }
    }
}
