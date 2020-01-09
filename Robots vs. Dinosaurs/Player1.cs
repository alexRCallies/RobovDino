using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Player1
    {
        public string name = Console.ReadLine();
        public int recruitPoints;
        Dinosaurs raptor = new Dinosaurs("Raptor", 5, 100, 100, 75, 6, 8, 1);
        Dinosaurs giga = new Dinosaurs("Giganotasaurus", 2, 350, 200, 20, 8, 5, 5);
        Dinosaurs anky = new Dinosaurs("Ankylosaurus", 3, 300, 30, 200, 9, 8, 4);
        Dinosaurs ptera = new Dinosaurs("Pteranadon", 5, 50, 150, 25, 4, 4, 2);
        Dinosaurs packleader = new Dinosaurs("Dino Rider", 4, 150, 150, 150, 5, 3, 3);
        List<Dinosaurs> pack = new List<Dinosaurs>();


        public Player1()
        {

            this.recruitPoints = 20;


        }

        public void RecruitHerd(List<Dinosaurs> herd)
        {
            Console.WriteLine(name + " summon your herd.");
            Console.WriteLine("");
            Console.WriteLine("Dinosaurs");
            foreach (Dinosaurs dino in herd)
            {
                Console.WriteLine("");
                Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Energy/" + dino.energy + "/  Attack/" + dino.attackPower + "/  Defense/" + dino.defensePower + "/  Evasion/" + dino.evasionPower + "/  Costs/" + dino.teamValue}");
                Console.WriteLine("");
            }
            Console.WriteLine("You have: "+recruitPoints+" Recruit Points.");
            
            do
            {
                string recruit = Console.ReadLine();
                if (recruit == raptor.name)
                {
                    pack.Add(raptor);
                    recruitPoints -= raptor.teamValue;
                    if(recruitPoints <= 0)
                    {
                        pack.Remove(raptor);
                        recruitPoints += raptor.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(recruitPoints);
                        Console.WriteLine("");
                    }

                   
                    foreach (Dinosaurs dino in pack)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Energy/" + dino.energy + "/  Attack/" + dino.attackPower + "/  Defense/" + dino.defensePower + "/  Evasion/" + dino.evasionPower + "/  Costs/" + dino.teamValue}");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: " + recruitPoints);
                }
                if (recruit == giga.name)
                {
                    pack.Add(giga);
                    recruitPoints -= giga.teamValue;
                    if (recruitPoints <= 0)
                    {
                        pack.Remove(giga);
                        recruitPoints += giga.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(recruitPoints);
                        Console.WriteLine("");
                    }

                    foreach (Dinosaurs dino in pack)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Energy/" + dino.energy + "/  Attack/" + dino.attackPower + "/  Defense/" + dino.defensePower + "/  Evasion/" + dino.evasionPower + "/  Costs/" + dino.teamValue}");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: "+recruitPoints);
                }
                if (recruit == anky.name)
                {
                    pack.Add(anky);
                    recruitPoints -= anky.teamValue;
                    if (recruitPoints <= 0)
                    {
                        pack.Remove(anky);
                        recruitPoints += anky.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(recruitPoints);
                        Console.WriteLine("");
                    }

                    foreach (Dinosaurs dino in pack)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Energy/" + dino.energy + "/  Attack/" + dino.attackPower + "/  Defense/" + dino.defensePower + "/  Evasion/" + dino.evasionPower + "/  Costs/" + dino.teamValue}");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: " + recruitPoints);
                }
                if(recruit == ptera.name)
                {
                    pack.Add(ptera);
                    recruitPoints -= ptera.teamValue;
                    if (recruitPoints <= 0)
                    {
                        pack.Remove(ptera);
                        recruitPoints += ptera.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(recruitPoints);
                        Console.WriteLine("");
                    }

                    foreach (Dinosaurs dino in pack)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Energy/" + dino.energy + "/  Attack/" + dino.attackPower + "/  Defense/" + dino.defensePower + "/  Evasion/" + dino.evasionPower + "/  Costs/" + dino.teamValue}");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: " + recruitPoints);
                }
                if(recruit == packleader.name)
                {
                    pack.Add(packleader);
                    recruitPoints -= packleader.teamValue;
                    if (recruitPoints <= 0)
                    {
                        pack.Remove(packleader);
                        recruitPoints += packleader.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(recruitPoints);
                        Console.WriteLine("");
                    }
                    foreach (Dinosaurs dino in pack)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Energy/" + dino.energy + "/  Attack/" + dino.attackPower + "/  Defense/" + dino.defensePower + "/  Evasion/" + dino.evasionPower + "/  Costs/" + dino.teamValue}");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: "+recruitPoints);
                    
                }

            }
            while (recruitPoints != 0);
            Console.WriteLine("");
            Console.WriteLine("Your Herd has answered your call!");
            Console.WriteLine("");
            
        }

    }

}



