using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Fleet
    {
        Robot minionBot;
        Robot warriorBot;
        Robot shieldBot;
        Robot robBot;
        Items sword;
        Items repairKit;
        Items bomb;
        Player2 player2 = new Player2();
        List<Robot> fleet = new List<Robot>();
        List<Items> playerItem = new List<Items>();

        public Fleet()
        {
            minionBot = new Robot("Minion Bot", 200, 100, 1, 1, 1);
             warriorBot = new Robot("Warrior Bot", 350, 100, 3, 3, 2);
            shieldBot = new Robot("Shield Bot", 600, 75, 1, 2, 3);
             robBot = new Robot("Rob-Bot", 1200, 350, 1, 4, 8);
            List<Robot> robots = new List<Robot>();
            robots.Add(minionBot);
            robots.Add(warriorBot);
            robots.Add(shieldBot);
            robots.Add(robBot);
            sword = new Items("Sword", 100, 0, 1);
            repairKit = new Items("Repair Kit", 0, 150, 2);
            bomb = new Items("Bomb", 200, -200, 3);
            List<Items> shop = new List<Items>();
            shop.Add(sword);

            shop.Add(repairKit);
            shop.Add(bomb);
        }





        public void ConstructFleet(List<Robot> robots)
        {
            Console.WriteLine(player2.name + " Construct Your Fleet to Meet the Herd");
            Console.WriteLine("");
            Console.WriteLine("Robots");
            foreach (Robot robot in robots)
            {
                Console.WriteLine("");
                Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower +  "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                Console.WriteLine("");
            }
            Console.WriteLine("You have: " + player2.recruitPoints + " Recruit Points.");
            do
            {
                string recruit = Console.ReadLine();
                if (recruit == minionBot.name)
                {
                    fleet.Add(minionBot);
                    player2.recruitPoints -= minionBot.teamValue;
                    if (player2.recruitPoints < 0)
                    {
                        fleet.Remove(minionBot);
                        player2.recruitPoints += minionBot.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(player2.recruitPoints);
                        Console.WriteLine("");
                    }


                    foreach (Robot robot in fleet)
                    {

                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower  + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");

                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: " + player2.recruitPoints);
                }
                if (recruit == warriorBot.name)
                {
                    fleet.Add(warriorBot);
                    player2.recruitPoints -= warriorBot.teamValue;
                    if (player2.recruitPoints < 0)
                    {
                        fleet.Remove(warriorBot);
                        player2.recruitPoints += warriorBot.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(player2.recruitPoints);
                        Console.WriteLine("");
                    }

                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower  + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: " + player2.recruitPoints);
                }
                if (recruit == shieldBot.name)
                {
                    fleet.Add(shieldBot);
                    player2.recruitPoints -= shieldBot.teamValue;
                    if (player2.recruitPoints < 0)
                    {
                        fleet.Remove(shieldBot);
                        player2.recruitPoints += shieldBot.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(player2.recruitPoints);
                        Console.WriteLine("");
                    }

                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower  + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: " + player2.recruitPoints);
                }
                if (recruit == robBot.name)
                {
                    fleet.Add(robBot);
                    player2.recruitPoints -= robBot.teamValue;
                    if (player2.recruitPoints < 0)
                    {
                        fleet.Remove(robBot);
                        player2.recruitPoints += robBot.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(player2.recruitPoints);
                        Console.WriteLine("");
                    }

                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower  + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: " + player2.recruitPoints);
                }


            }
            while (player2.recruitPoints != 0);
            Console.WriteLine("");
            Console.WriteLine("Your Fleet has Been Built!");
            Console.WriteLine("");
        }
        public void PurchaseItems(List<Items> shop)
        {
            Console.WriteLine(player2.name + " Purchase the Tools Required for Abosolute Victory");
            Console.WriteLine("Items");
            Console.WriteLine("");
            foreach (Items item in shop)
            {
                Console.WriteLine("");
                Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack +  "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                Console.WriteLine("");
            }
            Console.WriteLine("You have, " + player2.shopPoints + " Shop Points");
            do
            {
                string buy = Console.ReadLine();
                if (buy == sword.name)
                {
                    playerItem.Add(sword);
                    player2.shopPoints -= sword.shopPrice;
                    if (player2.shopPoints < 0)
                    {
                        playerItem.Remove(sword);
                        player2.shopPoints += sword.shopPrice;
                        Console.WriteLine("Not Enough Shop Points");
                        Console.WriteLine(player2.shopPoints);
                        Console.WriteLine("");
                    }


                    foreach (Items item in playerItem)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack +  "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("You Have " + player2.shopPoints + " Left");
                    Console.WriteLine("");
                }
                
                
                if (buy == repairKit.name)
                {
                    playerItem.Add(repairKit);
                    player2.shopPoints -= repairKit.shopPrice;
                    if (player2.shopPoints < 0)
                    {
                        playerItem.Remove(repairKit);
                        player2.shopPoints += repairKit.shopPrice;
                        Console.WriteLine("Not Enough Shop Points");
                        Console.WriteLine(player2.shopPoints);
                        Console.WriteLine("");
                    }

                    foreach (Items item in playerItem)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack +  "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("You Have " + player2.shopPoints + " Left");
                    Console.WriteLine("");
                }
                if (buy == bomb.name)
                {
                    playerItem.Add(bomb);
                    player2.shopPoints -= bomb.shopPrice;
                    if (player2.shopPoints < 0)
                    {
                        playerItem.Remove(bomb);
                        player2.shopPoints += bomb.shopPrice;
                        Console.WriteLine("Not Enough Shop Points");
                        Console.WriteLine(player2.shopPoints);
                        Console.WriteLine("");
                    }
                    foreach (Items item in playerItem)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack +  "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("You Have " + player2.shopPoints + " Left");
                    Console.WriteLine("");
                }
            }
            while (player2.shopPoints != 0);
            Console.WriteLine("");
            Console.WriteLine("You Have Assembled your WMDs");
            Console.WriteLine("");
        }
        
    }
}
