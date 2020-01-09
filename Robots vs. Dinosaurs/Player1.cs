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
        Dinosaurs raptor = new Dinosaurs("Raptor", 5, 100, 100, 75, 4, 2);
        Dinosaurs giga = new Dinosaurs("Giganotasaurus", 2, 350, 200, 20, 2, 5);
        Dinosaurs anky = new Dinosaurs("Ankylosaurus", 3, 300, 30, 200, 1, 4);
        Dinosaurs ptera = new Dinosaurs("Pteranadon", 5, 50, 150, 25, 6, 2);
        Dinosaurs packleader = new Dinosaurs("Dino Rider", 4, 150, 150, 150, 5, 3);
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



