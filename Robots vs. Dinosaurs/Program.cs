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
            Console.WriteLine("Player 1:(Enter Name)");
            Console.WriteLine("You will control the Herd");
            Console.WriteLine("");
            Player1 player1 = new Player1();
            Console.WriteLine("");
            Console.WriteLine("Player 2:(Enter Name)");
            Console.WriteLine("You will control the Fleet");
            Console.WriteLine("");
            Player2 player2 = new Player2();

            Console.WriteLine("DINOSAURS VS. ROBOTS");
            Console.WriteLine("");


            Dinosaurs raptor = new Dinosaurs("Raptor", 5, 100, 100, 75, 4, 2);
            Dinosaurs giga = new Dinosaurs("Giganotasaurus", 2, 350, 200, 20, 2, 5);
            Dinosaurs anky = new Dinosaurs("Ankylosaurus", 3, 300, 30, 200, 1, 4);
            Dinosaurs ptera = new Dinosaurs("Pteranadon", 5, 50, 150, 25, 6, 2);
            Dinosaurs packleader = new Dinosaurs("Dino Rider", 4, 150, 150, 150, 5, 3);
            List<Dinosaurs> herd = new List<Dinosaurs>();
            herd.Add(raptor);
            herd.Add(giga);
            herd.Add(anky);
            herd.Add(ptera);
            herd.Add(packleader);
            player1.RecruitHerd(herd);
            //Console.WriteLine("Dinosaurs");
            //foreach (Dinosaurs dino in herd)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Energy/" + dino.energy + "/  Attack/" + dino.attackPower + "/  Defense/" + dino.defensePower + "/  Evasion/" + dino.evasionPower + "/  Costs/" + dino.teamValue}");
            //}
            //Console.WriteLine("");
            Console.WriteLine("Robots");

            Robots minionBot = new Robots("Minion Bot", 1, 25, 100, 50, 1, 1);
            Robots warriorBot = new Robots("Warrior Bot", 5, 150, 100, 200, 3, 3);
            Robots shieldBot = new Robots("Shield Bot", 3, 200, 10, 200, 1, 3);
            Robots robBot = new Robots("Rob-Bot", 2, 300, 350, 0, 1, 6);
            List<Robots> robots = new List<Robots>();
            robots.Add(minionBot);
            robots.Add(warriorBot);
            robots.Add(shieldBot);
            robots.Add(robBot);
            foreach(Robots robot in robots)
             {
                Console.WriteLine("");
                Console.WriteLine($"Name: { robot.name+"/  Health/"+robot.health+"/  Power/"+robot.powerLevel+"/  Attack/"+robot.attackPower+"/  Defense/"+robot.defensePower+"/  Evasion/"+robot.evasionPower+"/  costs/"+robot.teamValue}");
            }


               

            Console.ReadLine();
        }
    }
}
