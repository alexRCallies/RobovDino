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
                    fleet.RemoveAt(0);
                }
            }
            if (choice == "1 2")
            {
                pack[0].Attack(fleet[1]);
                if (fleet[1].health <= 0)
                {

                    Console.WriteLine(fleet[1].name + " Has Fallen...");
                    fleet.RemoveAt(1);
                }
            }
            if (choice == "1 3")
            {
                pack[0].Attack(fleet[2]);
                if (fleet[2].health <= 0)
                {

                    Console.WriteLine(fleet[2].name + " Has Fallen...");
                    fleet.RemoveAt(2);
                }
            }
            if (choice == "1 4")
            {
                pack[0].Attack(fleet[3]);
                if (fleet[3].health <= 0)
                {

                    Console.WriteLine(fleet[3].name + " Has Fallen...");
                    fleet.RemoveAt(3);
                }
            }
            if (choice == "1 5")
            {
                pack[0].Attack(fleet[4]);
                if (fleet[4].health <= 0)
                {

                    Console.WriteLine(fleet[4].name + " Has Fallen...");
                    fleet.RemoveAt(4);
                }
            }
            if (choice == "1 6")
            {
                pack[0].Attack(fleet[5]);
                if (fleet[5].health <= 0)
                {

                    Console.WriteLine(fleet[5].name + " Has Fallen...");
                    fleet.RemoveAt(5);
                }
            }
            if (choice == "1 7")
            {
                pack[0].Attack(fleet[6]);
                if (fleet[6].health <= 0)
                {

                    Console.WriteLine(fleet[6].name + " Has Fallen...");
                    fleet.RemoveAt(6);
                }
            }
            if (choice == "1 8")
            {
                pack[0].Attack(fleet[7]);
                if (fleet[7].health <= 0)
                {

                    Console.WriteLine(fleet[7].name + " Has Fallen...");
                    fleet.RemoveAt(7);
                }
            }
            if (choice == "1 9")
            {
                pack[0].Attack(fleet[8]);
                if (fleet[8].health <= 0)
                {

                    Console.WriteLine(fleet[8].name + " Has Fallen...");
                    fleet.RemoveAt(8);
                }
            }
            if (choice == "1 10")
            {
                pack[0].Attack(fleet[9]);
                if (fleet[9].health <= 0)
                {

                    Console.WriteLine(fleet[9].name + " Has Fallen...");
                    fleet.RemoveAt(9);
                }
            }
            if (choice == "2 1")
            {
                pack[1].Attack(fleet[0]);
                if (fleet[0].health <= 0)
                {

                    Console.WriteLine(fleet[0].name + " Has Fallen...");
                    fleet.RemoveAt(0);
                }
            }
            if (choice == "2 2")
            {
                pack[1].Attack(fleet[1]);
                if (fleet[1].health <= 0)
                {

                    Console.WriteLine(fleet[1].name + " Has Fallen...");
                    fleet.RemoveAt(1);
                }
            }
            if (choice == "2 3")
            {
                pack[1].Attack(fleet[2]);
                if (fleet[2].health <= 0)
                {

                    Console.WriteLine(fleet[2].name + " Has Fallen...");
                    fleet.RemoveAt(2);
                }
            }
            if (choice == "2 4")
            {
                pack[1].Attack(fleet[3]);
                if (fleet[3].health <= 0)
                {

                    Console.WriteLine(fleet[3].name + " Has Fallen...");
                    fleet.RemoveAt(3);
                }
            }
            if (choice == "2 5")
            {
                pack[1].Attack(fleet[4]);
                if (fleet[4].health <= 0)
                {

                    Console.WriteLine(fleet[4].name + " Has Fallen...");
                    fleet.RemoveAt(4);
                }
            }
            if (choice == "2 6")
            {
                pack[1].Attack(fleet[5]);
                if (fleet[5].health <= 0)
                {

                    Console.WriteLine(fleet[5].name + " Has Fallen...");
                    fleet.RemoveAt(5);
                }
            }
            if (choice == "2 7")
            {
                pack[1].Attack(fleet[6]);
                if (fleet[6].health <= 0)
                {

                    Console.WriteLine(fleet[6].name + " Has Fallen...");
                    fleet.RemoveAt(6);
                }
            }
            if (choice == "2 8")
            {
                pack[1].Attack(fleet[7]);
                if (fleet[7].health <= 0)
                {

                    Console.WriteLine(fleet[7].name + " Has Fallen...");
                    fleet.RemoveAt(7);
                }
            }
            if (choice == "2 9")
            {
                pack[1].Attack(fleet[8]);
                if (fleet[8].health <= 0)
                {

                    Console.WriteLine(fleet[8].name + " Has Fallen...");
                    fleet.RemoveAt(8);
                }
            }
            if (choice == "2 10")
            {
                pack[1].Attack(fleet[9]);
                if (fleet[9].health <= 0)
                {

                    Console.WriteLine(fleet[9].name + " Has Fallen...");
                    fleet.RemoveAt(9);
                }
            }
            if (choice == "3 1")
            {
                pack[2].Attack(fleet[0]);
                if (fleet[0].health <= 0)
                {

                    Console.WriteLine(fleet[0].name + " Has Fallen...");
                    fleet.RemoveAt(0);
                }
            }
            if (choice == "3 2")
            {
                pack[2].Attack(fleet[1]);
                if (fleet[1].health <= 0)
                {

                    Console.WriteLine(fleet[1].name + " Has Fallen...");
                    fleet.RemoveAt(1);
                }
            }
            if (choice == "3 3")
            {
                pack[2].Attack(fleet[2]);
                if (fleet[2].health <= 0)
                {

                    Console.WriteLine(fleet[2].name + " Has Fallen...");
                    fleet.RemoveAt(2);
                }
            }
            if (choice == "3 4")
            {
                pack[2].Attack(fleet[3]);
                if (fleet[3].health <= 0)
                {

                    Console.WriteLine(fleet[3].name + " Has Fallen...");
                    fleet.RemoveAt(3);
                }
            }
            if (choice == "3 5")
            {
                pack[2].Attack(fleet[4]);
                if (fleet[4].health <= 0)
                {

                    Console.WriteLine(fleet[4].name + " Has Fallen...");
                    fleet.RemoveAt(4);
                }
            }
            if (choice == "3 6")
            {
                pack[2].Attack(fleet[5]);
                if (fleet[5].health <= 0)
                {

                    Console.WriteLine(fleet[5].name + " Has Fallen...");
                    fleet.RemoveAt(5);
                }
            }
            if (choice == "3 7")
            {
                pack[2].Attack(fleet[6]);
                if (fleet[6].health <= 0)
                {

                    Console.WriteLine(fleet[6].name + " Has Fallen...");
                    fleet.RemoveAt(6);
                }
            }
            if (choice == "3 8")
            {
                pack[2].Attack(fleet[7]);
                if (fleet[7].health <= 0)
                {

                    Console.WriteLine(fleet[7].name + " Has Fallen...");
                    fleet.RemoveAt(7);
                }
            }
            if (choice == "3 9")
            {
                pack[2].Attack(fleet[8]);
                if (fleet[8].health <= 0)
                {

                    Console.WriteLine(fleet[8].name + " Has Fallen...");
                    fleet.RemoveAt(8);
                }
            }
            if (choice == "3 10")
            {
                pack[2].Attack(fleet[9]);
                if (fleet[9].health <= 0)
                {

                    Console.WriteLine(fleet[9].name + " Has Fallen...");
                    fleet.RemoveAt(9);
                }
            }
            if (choice == "4 1")
            {
                pack[3].Attack(fleet[0]);
                if (fleet[0].health <= 0)
                {

                    Console.WriteLine(fleet[0].name + " Has Fallen...");
                    fleet.RemoveAt(0);
                }
            }
            if (choice == "4 2")
            {
                pack[3].Attack(fleet[1]);
                if (fleet[1].health <= 0)
                {

                    Console.WriteLine(fleet[1].name + " Has Fallen...");
                    fleet.RemoveAt(1);
                }
            }
            if (choice == "4 3")
            {
                pack[3].Attack(fleet[2]);
                if (fleet[2].health <= 0)
                {

                    Console.WriteLine(fleet[2].name + " Has Fallen...");
                    fleet.RemoveAt(2);
                }
            }
            if (choice == "4 4")
            {
                pack[3].Attack(fleet[3]);
                if (fleet[3].health <= 0)
                {

                    Console.WriteLine(fleet[3].name + " Has Fallen...");
                    fleet.RemoveAt(3);
                }
            }
            if (choice == "4 5")
            {
                pack[3].Attack(fleet[4]);
                if (fleet[4].health <= 0)
                {

                    Console.WriteLine(fleet[4].name + " Has Fallen...");
                    fleet.RemoveAt(4);
                }
            }
            if (choice == "4 6")
            {
                pack[3].Attack(fleet[5]);
                if (fleet[5].health <= 0)
                {

                    Console.WriteLine(fleet[5].name + " Has Fallen...");
                    fleet.RemoveAt(5);
                }
            }
            if (choice == "4 7")
            {
                pack[3].Attack(fleet[6]);
                if (fleet[6].health <= 0)
                {

                    Console.WriteLine(fleet[6].name + " Has Fallen...");
                    fleet.RemoveAt(6);
                }
            }
            if (choice == "4 8")
            {
                pack[3].Attack(fleet[7]);
                if (fleet[7].health <= 0)
                {

                    Console.WriteLine(fleet[7].name + " Has Fallen...");
                    fleet.RemoveAt(7);
                }
            }
            if (choice == "4 9")
            {
                pack[3].Attack(fleet[8]);
                if (fleet[8].health <= 0)
                {

                    Console.WriteLine(fleet[8].name + " Has Fallen...");
                    fleet.RemoveAt(8);
                }
            }
            if (choice == "4 10")
            {
                pack[3].Attack(fleet[9]);
                if (fleet[9].health <= 0)
                {

                    Console.WriteLine(fleet[9].name + " Has Fallen...");
                    fleet.RemoveAt(9);
                }
            }
            if (choice == "5 1")
            {
                pack[4].Attack(fleet[0]);
                if (fleet[0].health <= 0)
                {

                    Console.WriteLine(fleet[0].name + " Has Fallen...");
                    fleet.RemoveAt(0);
                }
            }
            if (choice == "5 2")
            {
                pack[4].Attack(fleet[1]);
                if (fleet[1].health <= 0)
                {

                    Console.WriteLine(fleet[1].name + " Has Fallen...");
                    fleet.RemoveAt(1);
                }
            }
            if (choice == "5 3")
            {
                pack[4].Attack(fleet[2]);
                if (fleet[2].health <= 0)
                {

                    Console.WriteLine(fleet[2].name + " Has Fallen...");
                    fleet.RemoveAt(2);
                }
            }
            if (choice == "5 4")
            {
                pack[4].Attack(fleet[3]);
                if (fleet[3].health <= 0)
                {

                    Console.WriteLine(fleet[3].name + " Has Fallen...");
                    fleet.RemoveAt(3);
                }
            }
            if (choice == "5 5")
            {
                pack[4].Attack(fleet[4]);
                if (fleet[4].health <= 0)
                {

                    Console.WriteLine(fleet[4].name + " Has Fallen...");
                    fleet.RemoveAt(4);
                }
            }
            if (choice == "5 6")
            {
                pack[4].Attack(fleet[5]);
                if (fleet[5].health <= 0)
                {

                    Console.WriteLine(fleet[5].name + " Has Fallen...");
                    fleet.RemoveAt(5);
                }
            }
            if (choice == "5 7")
            {
                pack[4].Attack(fleet[6]);
                if (fleet[6].health <= 0)
                {

                    Console.WriteLine(fleet[6].name + " Has Fallen...");
                    fleet.RemoveAt(6);
                }
            }
            if (choice == "5 8")
            {
                pack[4].Attack(fleet[7]);
                if (fleet[7].health <= 0)
                {

                    Console.WriteLine(fleet[7].name + " Has Fallen...");
                    fleet.RemoveAt(7);
                }
            }
            if (choice == "5 9")
            {
                pack[4].Attack(fleet[8]);
                if (fleet[8].health <= 0)
                {

                    Console.WriteLine(fleet[8].name + " Has Fallen...");
                    fleet.RemoveAt(8);
                }
            }
            if (choice == "5 10")
            {
                pack[4].Attack(fleet[9]);
                if (fleet[9].health <= 0)
                {

                    Console.WriteLine(fleet[9].name + " Has Fallen...");
                    fleet.RemoveAt(9);
                }
            }
            if (choice == "6 1")
            {
                pack[5].Attack(fleet[0]);
                if (fleet[0].health <= 0)
                {

                    Console.WriteLine(fleet[0].name + " Has Fallen...");
                    fleet.RemoveAt(0);
                }
            }
            if (choice == "6 2")
            {
                pack[5].Attack(fleet[1]);
                if (fleet[1].health <= 0)
                {

                    Console.WriteLine(fleet[1].name + " Has Fallen...");
                    fleet.RemoveAt(1);
                }
            }
            if (choice == "6 3")
            {
                pack[5].Attack(fleet[2]);
                if (fleet[2].health <= 0)
                {

                    Console.WriteLine(fleet[2].name + " Has Fallen...");
                    fleet.RemoveAt(2);
                }
            }
            if (choice == "6 4")
            {
                pack[5].Attack(fleet[3]);
                if (fleet[3].health <= 0)
                {

                    Console.WriteLine(fleet[3].name + " Has Fallen...");
                    fleet.RemoveAt(3);
                }
            }
            if (choice == "6 5")
            {
                pack[5].Attack(fleet[4]);
                if (fleet[4].health <= 0)
                {

                    Console.WriteLine(fleet[4].name + " Has Fallen...");
                    fleet.RemoveAt(4);
                }
            }
            if (choice == "6 6")
            {
                pack[5].Attack(fleet[5]);
                if (fleet[5].health <= 0)
                {

                    Console.WriteLine(fleet[5].name + " Has Fallen...");
                    fleet.RemoveAt(5);
                }
            }
            if (choice == "6 7")
            {
                pack[5].Attack(fleet[6]);
                if (fleet[6].health <= 0)
                {

                    Console.WriteLine(fleet[6].name + " Has Fallen...");
                    fleet.RemoveAt(6);
                }
            }
            if (choice == "6 8")
            {
                pack[5].Attack(fleet[7]);
                if (fleet[7].health <= 0)
                {

                    Console.WriteLine(fleet[7].name + " Has Fallen...");
                    fleet.RemoveAt(7);
                }
            }
            if (choice == "6 9")
            {
                pack[5].Attack(fleet[8]);
                if (fleet[8].health <= 0)
                {

                    Console.WriteLine(fleet[8].name + " Has Fallen...");
                    fleet.RemoveAt(8);
                }
            }
            if (choice == "6 10")
            {
                pack[5].Attack(fleet[9]);
                if (fleet[9].health <= 0)
                {

                    Console.WriteLine(fleet[9].name + " Has Fallen...");
                    fleet.RemoveAt(9);
                }
            }
            if (choice == "7 1")
            {
                pack[6].Attack(fleet[0]);
                if (fleet[0].health <= 0)
                {

                    Console.WriteLine(fleet[0].name + " Has Fallen...");
                    fleet.RemoveAt(0);
                }
            }
            if (choice == "7 2")
            {
                pack[6].Attack(fleet[1]);
                if (fleet[1].health <= 0)
                {

                    Console.WriteLine(fleet[1].name + " Has Fallen...");
                    fleet.RemoveAt(1);
                }
            }
            if (choice == "7 3")
            {
                pack[6].Attack(fleet[2]);
                if (fleet[2].health <= 0)
                {

                    Console.WriteLine(fleet[2].name + " Has Fallen...");
                    fleet.RemoveAt(2);
                }
            }
            if (choice == "7 4")
            {
                pack[6].Attack(fleet[3]);
                if (fleet[3].health <= 0)
                {

                    Console.WriteLine(fleet[3].name + " Has Fallen...");
                    fleet.RemoveAt(3);
                }
            }
            if (choice == "7 5")
            {
                pack[6].Attack(fleet[4]);
                if (fleet[4].health <= 0)
                {

                    Console.WriteLine(fleet[4].name + " Has Fallen...");
                    fleet.RemoveAt(4);
                }
            }
            if (choice == "7 6")
            {
                pack[6].Attack(fleet[5]);
                if (fleet[5].health <= 0)
                {

                    Console.WriteLine(fleet[5].name + " Has Fallen...");
                    fleet.RemoveAt(5);
                }
            }
            if (choice == "7 7")
            {
                pack[6].Attack(fleet[6]);
                if (fleet[6].health <= 0)
                {

                    Console.WriteLine(fleet[6].name + " Has Fallen...");
                    fleet.RemoveAt(6);
                }
            }
            if (choice == "7 8")
            {
                pack[6].Attack(fleet[7]);
                if (fleet[7].health <= 0)
                {

                    Console.WriteLine(fleet[7].name + " Has Fallen...");
                    fleet.RemoveAt(7);
                }
            }
            if (choice == "7 9")
            {
                pack[6].Attack(fleet[8]);
                if (fleet[8].health <= 0)
                {

                    Console.WriteLine(fleet[8].name + " Has Fallen...");
                    fleet.RemoveAt(8);
                }
            }
            if (choice == "7 10")
            {
                pack[6].Attack(fleet[9]);
                if (fleet[9].health <= 0)
                {

                    Console.WriteLine(fleet[9].name + " Has Fallen...");
                    fleet.RemoveAt(9);
                }
            }
            if (choice == "8 1")
            {
                pack[7].Attack(fleet[0]);
                if (fleet[0].health <= 0)
                {

                    Console.WriteLine(fleet[0].name + " Has Fallen...");
                    fleet.RemoveAt(0);
                }
            }
            if (choice == "8 2")
            {
                pack[7].Attack(fleet[1]);
                if (fleet[1].health <= 0)
                {

                    Console.WriteLine(fleet[1].name + " Has Fallen...");
                    fleet.RemoveAt(1);
                }
            }
            if (choice == "8 3")
            {
                pack[7].Attack(fleet[2]);
                if (fleet[2].health <= 0)
                {

                    Console.WriteLine(fleet[2].name + " Has Fallen...");
                    fleet.RemoveAt(2);
                }
            }
            if (choice == "8 4")
            {
                pack[7].Attack(fleet[3]);
                if (fleet[3].health <= 0)
                {

                    Console.WriteLine(fleet[3].name + " Has Fallen...");
                    fleet.RemoveAt(3);
                }
            }
            if (choice == "8 5")
            {
                pack[7].Attack(fleet[4]);
                if (fleet[4].health <= 0)
                {

                    Console.WriteLine(fleet[4].name + " Has Fallen...");
                    fleet.RemoveAt(4);
                }
            }
            if (choice == "8 6")
            {
                pack[7].Attack(fleet[5]);
                if (fleet[5].health <= 0)
                {

                    Console.WriteLine(fleet[5].name + " Has Fallen...");
                    fleet.RemoveAt(5);
                }
            }
            if (choice == "8 7")
            {
                pack[7].Attack(fleet[6]);
                if (fleet[6].health <= 0)
                {

                    Console.WriteLine(fleet[6].name + " Has Fallen...");
                    fleet.RemoveAt(6);
                }
            }
            if (choice == "8 8")
            {
                pack[7].Attack(fleet[7]);
                if (fleet[7].health <= 0)
                {

                    Console.WriteLine(fleet[7].name + " Has Fallen...");
                    fleet.RemoveAt(7);
                }
            }
            if (choice == "8 9")
            {
                pack[7].Attack(fleet[8]);
                if (fleet[8].health <= 0)
                {

                    Console.WriteLine(fleet[8].name + " Has Fallen...");
                    fleet.RemoveAt(8);
                }
            }
            if (choice == "8 10")
            {
                pack[7].Attack(fleet[9]);
                if (fleet[9].health <= 0)
                {

                    Console.WriteLine(fleet[9].name + " Has Fallen...");
                    fleet.RemoveAt(9);
                }
            }
            if (choice == "9 1")
            {
                pack[8].Attack(fleet[0]);
                if (fleet[0].health <= 0)
                {

                    Console.WriteLine(fleet[0].name + " Has Fallen...");
                    fleet.RemoveAt(0);
                }
            }
            if (choice == "9 2")
            {
                pack[8].Attack(fleet[1]);
                if (fleet[1].health <= 0)
                {

                    Console.WriteLine(fleet[1].name + " Has Fallen...");
                    fleet.RemoveAt(1);
                }
            }
            if (choice == "9 3")
            {
                pack[8].Attack(fleet[2]);
                if (fleet[2].health <= 0)
                {

                    Console.WriteLine(fleet[2].name + " Has Fallen...");
                    fleet.RemoveAt(2);
                }
            }
            if (choice == "9 4")
            {
                pack[8].Attack(fleet[3]);
                if (fleet[3].health <= 0)
                {

                    Console.WriteLine(fleet[3].name + " Has Fallen...");
                    fleet.RemoveAt(3);
                }
            }
            if (choice == "9 5")
            {
                pack[8].Attack(fleet[4]);
                if (fleet[4].health <= 0)
                {

                    Console.WriteLine(fleet[4].name + " Has Fallen...");
                    fleet.RemoveAt(4);
                }
            }
            if (choice == "9 6")
            {
                pack[8].Attack(fleet[5]);
                if (fleet[5].health <= 0)
                {

                    Console.WriteLine(fleet[5].name + " Has Fallen...");
                    fleet.RemoveAt(5);
                }
            }
            if (choice == "9 7")
            {
                pack[8].Attack(fleet[6]);
                if (fleet[6].health <= 0)
                {

                    Console.WriteLine(fleet[6].name + " Has Fallen...");
                    fleet.RemoveAt(6);
                }
            }
            if (choice == "9 8")
            {
                pack[8].Attack(fleet[7]);
                if (fleet[7].health <= 0)
                {

                    Console.WriteLine(fleet[7].name + " Has Fallen...");
                    fleet.RemoveAt(7);
                }
            }
            if (choice == "9 9")
            {
                pack[8].Attack(fleet[8]);
                if (fleet[8].health <= 0)
                {

                    Console.WriteLine(fleet[8].name + " Has Fallen...");
                    fleet.RemoveAt(8);
                }
            }
            if (choice == "9 10")
            {
                pack[8].Attack(fleet[9]);
                if (fleet[9].health <= 0)
                {

                    Console.WriteLine(fleet[9].name + " Has Fallen...");
                    fleet.RemoveAt(9);
                }
            }
            if (choice == "10 1")
            {
                pack[9].Attack(fleet[0]);
                if (fleet[0].health <= 0)
                {

                    Console.WriteLine(fleet[0].name + " Has Fallen...");
                    fleet.RemoveAt(0);
                }
            }
            if (choice == "10 2")
            {
                pack[9].Attack(fleet[1]);
                if (fleet[1].health <= 0)
                {

                    Console.WriteLine(fleet[1].name + " Has Fallen...");
                    fleet.RemoveAt(1);
                }
            }
            if (choice == "10 3")
            {
                pack[9].Attack(fleet[2]);
                if (fleet[2].health <= 0)
                {

                    Console.WriteLine(fleet[2].name + " Has Fallen...");
                    fleet.RemoveAt(2);
                }
            }
            if (choice == "10 4")
            {
                pack[9].Attack(fleet[3]);
                if (fleet[3].health <= 0)
                {

                    Console.WriteLine(fleet[3].name + " Has Fallen...");
                    fleet.RemoveAt(3);
                }
            }
            if (choice == "10 5")
            {
                pack[9].Attack(fleet[4]);
                if (fleet[4].health <= 0)
                {

                    Console.WriteLine(fleet[4].name + " Has Fallen...");
                    fleet.RemoveAt(4);
                }
            }
            if (choice == "10 6")
            {
                pack[9].Attack(fleet[5]);
                if (fleet[5].health <= 0)
                {

                    Console.WriteLine(fleet[5].name + " Has Fallen...");
                    fleet.RemoveAt(5);
                }
            }
            if (choice == "10 7")
            {
                pack[9].Attack(fleet[6]);
                if (fleet[6].health <= 0)
                {

                    Console.WriteLine(fleet[6].name + " Has Fallen...");
                    fleet.RemoveAt(6);
                }
            }
            if (choice == "10 8")
            {
                pack[9].Attack(fleet[7]);
                if (fleet[7].health <= 0)
                {

                    Console.WriteLine(fleet[7].name + " Has Fallen...");
                    fleet.RemoveAt(7);
                }
            }
            if (choice == "10 9")
            {
                pack[9].Attack(fleet[8]);
                if (fleet[8].health <= 0)
                {

                    Console.WriteLine(fleet[8].name + " Has Fallen...");
                    fleet.RemoveAt(8);
                }
            }
            if (choice == "10 10")
            {
                pack[9].Attack(fleet[9]);
                if (fleet[9].health <= 0)
                {

                    Console.WriteLine(fleet[9].name + " Has Fallen...");
                    fleet.RemoveAt(9);
                }
            }
            if (choice == "End")
            {
                Console.WriteLine("The Herd has scattered.");
                Console.WriteLine("The Fleet Claims Victory this Day!");
                Console.WriteLine("Please close out application");
            }
            Console.ReadLine();
        }
    }
}
