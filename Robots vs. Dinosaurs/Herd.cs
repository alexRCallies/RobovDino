using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Herd
    {
        Player1 player1 = new Player1();
        Dinosaurs raptor = new Dinosaurs("Raptor", 100, 100, 75, 4, 2, 1);
        Dinosaurs giga = new Dinosaurs("Giganotasaurus", 350, 200, 20, 2, 5, 5);
        Dinosaurs anky = new Dinosaurs("Ankylosaurus", 300, 100, 200, 1, 2, 3);
        Dinosaurs ptera = new Dinosaurs("Pteranadon", 50, 150, 25, 6, 6, 2);
        Dinosaurs packleader = new Dinosaurs("Dino Rider", 150, 150, 150, 5, 7, 4);
        List<Dinosaurs> pack = new List<Dinosaurs>();

        public void RecruitHerd(List<Dinosaurs> herd)
        {
            Console.WriteLine("Player 1 summon your herd.");
            Console.WriteLine("");
            Console.WriteLine("Dinosaurs");
            foreach (Dinosaurs dino in herd)
            {
                Console.WriteLine("");
                Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Attack/" + dino.attackPower + "/  Defense/" + dino.defensePower + "/  Evasion/" + dino.evasion + "/  Crit Chance/" + dino.critChance + "/  Costs/" + dino.teamValue}");
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


                    foreach (Dinosaurs dino in pack)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Attack/" + dino.attackPower + "/  Defense/" + dino.defensePower + "/  Evasion/" + dino.evasion + "/  Crit Chance/" + dino.critChance + "/  Costs/" + dino.teamValue}");
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

                    foreach (Dinosaurs dino in pack)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Attack/" + dino.attackPower + "/  Defense/" + dino.defensePower + "/  Evasion/" + dino.evasion + "/  Costs/" + dino.teamValue}");
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

                    foreach (Dinosaurs dino in pack)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Attack/" + dino.attackPower + "/  Defense/" + dino.defensePower + "/  Evasion/" + dino.evasion + "/  Costs/" + dino.teamValue}");
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

                    foreach (Dinosaurs dino in pack)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Attack/" + dino.attackPower + "/  Defense/" + dino.defensePower + "/  Evasion/" + dino.evasion + "/  Costs/" + dino.teamValue}");
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
                    foreach (Dinosaurs dino in pack)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Attack/" + dino.attackPower + "/  Defense/" + dino.defensePower + "/  Evasion/" + dino.evasion + "/  Costs/" + dino.teamValue}");
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
    }
}
