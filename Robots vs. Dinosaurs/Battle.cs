﻿using System;
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
        Intro intro = new Intro();

        public void RunTeamSelect ()
        {
            intro.RunIntro();
            herd.RecruitHerd(herd.herdList);
            fleet.ConstructFleet(fleet.robots);
            fleet.PurchaseItems(fleet.shop);
            fleet.EquipItems();
            
            herd.BeginHerdAttack(fleet.fleet);
            fleet.BeginAttack(herd.pack);
            herd.BeginHerdAttack(fleet.fleet);
            fleet.BeginAttack(herd.pack);
            herd.BeginHerdAttack(fleet.fleet);
            fleet.BeginAttack(herd.pack);
            herd.BeginHerdAttack(fleet.fleet);
            fleet.BeginAttack(herd.pack);
            herd.BeginHerdAttack(fleet.fleet);
            fleet.BeginAttack(herd.pack);
            herd.BeginHerdAttack(fleet.fleet);
            fleet.BeginAttack(herd.pack);
            herd.BeginHerdAttack(fleet.fleet);
            fleet.BeginAttack(herd.pack);
            herd.BeginHerdAttack(fleet.fleet);
            fleet.BeginAttack(herd.pack);
            herd.BeginHerdAttack(fleet.fleet);
            fleet.BeginAttack(herd.pack);
            herd.BeginHerdAttack(fleet.fleet);
            fleet.BeginAttack(herd.pack);
            herd.BeginHerdAttack(fleet.fleet);
            fleet.BeginAttack(herd.pack);
            herd.BeginHerdAttack(fleet.fleet);
            fleet.BeginAttack(herd.pack);
            herd.BeginHerdAttack(fleet.fleet);
            fleet.BeginAttack(herd.pack);
            herd.BeginHerdAttack(fleet.fleet);
            fleet.BeginAttack(herd.pack);
            herd.BeginHerdAttack(fleet.fleet);
            fleet.BeginAttack(herd.pack);




        }

    }
}
