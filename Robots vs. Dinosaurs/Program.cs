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

            Items sword = new Items("Sword", 100, -50, 0, 1);
            Items shield = new Items("Shield", -50, 100, 0, 1);
            Items repairKit = new Items("Repair Kit", 0, 0, 150, 2);
            Items bomb = new Items("Bomb", 200, -75, -200, 3);
            List<Items> shop = new List<Items>();
            shop.Add(sword);
            shop.Add(shield);
            shop.Add(repairKit);
            shop.Add(bomb);

            Dinosaurs raptor = new Dinosaurs("Raptor",  100, 100, 75, 4, 8, 1);
            Dinosaurs giga = new Dinosaurs("Giganotasaurus",  350, 200, 20, 2, 5, 5);
            Dinosaurs anky = new Dinosaurs("Ankylosaurus", 300, 30, 200, 1, 8, 4);
            Dinosaurs ptera = new Dinosaurs("Pteranadon",  50, 150, 25, 6, 4, 2);
            Dinosaurs packleader = new Dinosaurs("Dino Rider",  150, 150, 150, 5, 3, 3);
            List<Dinosaurs> herd = new List<Dinosaurs>();
            herd.Add(raptor);
            herd.Add(giga);
            herd.Add(anky);
            herd.Add(ptera);
            herd.Add(packleader);
            //player1.RecruitHerd(herd);
            Console.WriteLine("");
            Console.WriteLine("");
              
           
            Console.WriteLine("Robots");

            Robots minionBot = new Robots("Minion Bot" ,100, 100, 100, 1, 1, 1);
            Robots warriorBot = new Robots("Warrior Bot" ,150, 100, 200, 3, 3, 2);
            Robots shieldBot = new Robots("Shield Bot", 200, 10, 200, 1, 2, 3);
            Robots robBot = new Robots("Rob-Bot",600, 350, 50, 1, 4, 8);
            List<Robots> robots = new List<Robots>();
            robots.Add(minionBot);
            robots.Add(warriorBot);
            robots.Add(shieldBot);
            robots.Add(robBot);
            // player2.ConstructFleet(robots);
            // player2.PurchaseItems(shop);
            Console.WriteLine("Prepare For BATTLE!");
           


            


               

            Console.ReadLine();
        }
    }
}
