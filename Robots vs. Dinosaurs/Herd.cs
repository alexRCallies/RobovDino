using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Herd
    {
        Player1 player1;
        Dinosaur raptor;
        Dinosaur giga; 
        Dinosaur anky;
        Dinosaur ptera; 
        Dinosaur packleader;
         public List<Dinosaur> pack = new List<Dinosaur>();
        public List<Dinosaur> herdList = new List<Dinosaur>();
        public Herd()
        {
            raptor = new Dinosaur("Raptor", 200, 100, 4, 2, 1);
            giga = new Dinosaur("Giganotasaurus", 850, 400, 2, 10, 5);
             anky = new Dinosaur("Ankylosaurus", 1100, 100, 1, 2, 3);
             ptera = new Dinosaur("Pteranadon", 100, 150, 6, 6, 2);
             packleader = new Dinosaur("Dino Rider", 400, 300, 5, 7, 4);
          
            herdList.Add(raptor);
            herdList.Add(giga);
            herdList.Add(anky);
            herdList.Add(ptera);
            herdList.Add(packleader);
            player1 = new Player1();
            
        }




        public void RecruitHerd(List<Dinosaur> herd)
        {
           
            Console.WriteLine("Player 1 summon your herd.");
            Console.WriteLine("");
            Console.WriteLine("Dinosaurs");
            foreach (Dinosaur dino in herd)
            {
                Console.WriteLine("");
                Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Attack/" + dino.attackPower + "/  Evasion/" + dino.evasion + "/  Crit Chance/" + dino.critChance + "/  Costs/" + dino.teamValue}");
                Console.WriteLine("");
            }
            Console.WriteLine("You have: " + player1.recruitPoints + " Recruit Points.");

            do
            {
                string recruit = Console.ReadLine();
                if (recruit == raptor.name)
                {
                    pack.Add(raptor);
                    player1.recruitPoints -= raptor.teamValue;
                    if (player1.recruitPoints < 0)
                    {
                        pack.Remove(raptor);
                        player1.recruitPoints += raptor.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(player1.recruitPoints);
                        Console.WriteLine("");
                    }


                    foreach (Dinosaur dino in pack)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Attack/" + dino.attackPower  + "/  Evasion/" + dino.evasion + "/  Crit Chance/" + dino.critChance + "/  Costs/" + dino.teamValue}");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: " + player1.recruitPoints);
                }
                if (recruit == giga.name)
                {
                    pack.Add(giga);
                    player1.recruitPoints -= giga.teamValue;
                    if (player1.recruitPoints < 0)
                    {
                        pack.Remove(giga);
                        player1.recruitPoints += giga.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(player1.recruitPoints);
                        Console.WriteLine("");
                    }

                    foreach (Dinosaur dino in pack)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Attack/" + dino.attackPower + "/  Evasion/" + dino.evasion + "/  Costs/" + dino.teamValue}");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: " + player1.recruitPoints);
                }
                if (recruit == anky.name)
                {
                    pack.Add(anky);
                    player1.recruitPoints -= anky.teamValue;
                    if (player1.recruitPoints < 0)
                    {
                        pack.Remove(anky);
                        player1.recruitPoints += anky.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(player1.recruitPoints);
                        Console.WriteLine("");
                    }

                    foreach (Dinosaur dino in pack)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Attack/" + dino.attackPower  + "/  Evasion/" + dino.evasion + "/  Costs/" + dino.teamValue}");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: " + player1.recruitPoints);
                }
                if (recruit == ptera.name)
                {
                    pack.Add(ptera);
                    player1.recruitPoints -= ptera.teamValue;
                    if (player1.recruitPoints < 0)
                    {
                        pack.Remove(ptera);
                        player1.recruitPoints += ptera.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(player1.recruitPoints);
                        Console.WriteLine("");
                    }

                    foreach (Dinosaur dino in pack)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Attack/" + dino.attackPower  + "/  Evasion/" + dino.evasion + "/  Costs/" + dino.teamValue}");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: " + player1.recruitPoints);
                }
                if (recruit == packleader.name)
                {
                    pack.Add(packleader);
                    player1.recruitPoints -= packleader.teamValue;
                    if (player1.recruitPoints < 0)
                    {
                        pack.Remove(packleader);
                        player1.recruitPoints += packleader.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(player1.recruitPoints);
                        Console.WriteLine("");
                    }
                    foreach (Dinosaur dino in pack)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Attack/" + dino.attackPower  + "/  Evasion/" + dino.evasion + "/  Costs/" + dino.teamValue}");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: " + player1.recruitPoints);

                }

            }
            while (player1.recruitPoints != 0);
            Console.WriteLine("");
            Console.WriteLine("Your Herd has answered your call!");
            Console.WriteLine("");
            
        }

        public void BeginHerdAttack(List<Robot> fleet)
        {
            foreach (Dinosaur dino in pack)
            {
                Console.WriteLine("");
                Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Attack/" + dino.attackPower + "/  Evasion/" + dino.evasion + "/  Costs/" + dino.teamValue}");
                Console.WriteLine("");
            }
            foreach (Robot robot in fleet)
            {
                Console.WriteLine("");
                Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                Console.WriteLine("");
            }
            Console.WriteLine("Begin Ypur Attack");
            string choice = Console.ReadLine();
            Fleet fleet1 = new Fleet();
            if (choice == "1 1")
            {
                pack[0].Attack(fleet[0]);
                if (fleet[0].health <= 0)
                {

                    Console.WriteLine(fleet[0].name + " Has Fallen...");
                    pack.RemoveAt(0);
                }
            }
        }
    }
}
