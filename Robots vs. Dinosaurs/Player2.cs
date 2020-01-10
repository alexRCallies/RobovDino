using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs.Dinosaurs
{
    class Player2
    {
        public string name = Console.ReadLine();
        public int recruitPoints;
        public int shopPoints;
        
        Robots minionBot = new Robots("Minion Bot",  100, 100, 100, 1, 1, 1);
        Robots warriorBot = new Robots("Warrior Bot",  150, 100, 200, 3, 3, 2);
        Robots shieldBot = new Robots("Shield Bot",  200, 10, 200, 1, 2, 3);
        Robots robBot = new Robots("Rob-Bot",  1000, 350, 75, 1, 4, 8);
        Items sword = new Items("Sword", 100, -50, 0, 1);
        Items shield = new Items("Shield", -50, 100, 0, 1);
        Items repairKit = new Items("Repair Kit", 0, 0, 150, 2);
        Items bomb = new Items("Bomb", 200, -75, -200, 3);
        List<Robots> fleet = new List<Robots>();
        List<Items> playerItem = new List<Items>();
        public Player2()
        {

            this.recruitPoints = 15;
            this.shopPoints = 10;
        }
        public void ConstructFleet(List<Robots> robots)
        {
            Console.WriteLine(name + " Construct Your Fleet to Meet the Herd");
            Console.WriteLine("");
            Console.WriteLine("Robots");
            foreach (Robots robot in robots)
            {
                Console.WriteLine("");
                Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health  + "/  Attack/" + robot.attackPower + "/  Defense/" + robot.defensePower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                Console.WriteLine("");
            }
            Console.WriteLine("You have: " + recruitPoints + " Recruit Points.");
            do
            {
                string recruit = Console.ReadLine();
                if (recruit == minionBot.name)
                {
                    fleet.Add(minionBot);
                    recruitPoints -= minionBot.teamValue;
                    if (recruitPoints < 0)
                    {
                        fleet.Remove(minionBot);
                        recruitPoints += minionBot.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(recruitPoints);
                        Console.WriteLine("");
                    }


                    foreach (Robots robot in fleet)
                    {
                       
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Defense/" + robot.defensePower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                       
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: " + recruitPoints);
                }
                if (recruit == warriorBot.name)
                {
                    fleet.Add(warriorBot);
                    recruitPoints -= warriorBot.teamValue;
                    if (recruitPoints < 0)
                    {
                        fleet.Remove(warriorBot);
                        recruitPoints += warriorBot.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(recruitPoints);
                        Console.WriteLine("");
                    }

                    foreach (Robots robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health  + "/  Attack/" + robot.attackPower + "/  Defense/" + robot.defensePower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: " + recruitPoints);
                }
                if (recruit == shieldBot.name)
                {
                    fleet.Add(shieldBot);
                    recruitPoints -= shieldBot.teamValue;
                    if (recruitPoints < 0)
                    {
                       fleet.Remove(shieldBot);
                        recruitPoints += shieldBot.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(recruitPoints);
                        Console.WriteLine("");
                    }

                    foreach (Robots robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health  + "/  Attack/" + robot.attackPower + "/  Defense/" + robot.defensePower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: " + recruitPoints);
                }
                if (recruit == robBot.name)
                {
                    fleet.Add(robBot);
                    recruitPoints -= robBot.teamValue;
                    if (recruitPoints < 0)
                    {
                        fleet.Remove(robBot);
                        recruitPoints += robBot.teamValue;
                        Console.WriteLine("Not Enough Recruitment Points");
                        Console.WriteLine(recruitPoints);
                        Console.WriteLine("");
                    }

                    foreach (Robots robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health  + "/  Attack/" + robot.attackPower + "/  Defense/" + robot.defensePower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Recruit Points Left: " + recruitPoints);
                }
               

            }
            while (recruitPoints != 0);
            Console.WriteLine("");
            Console.WriteLine("Your Fleet has Been Built!");
            Console.WriteLine("");
        }

        public void PurchaseItems(List<Items> shop)
        {
            Console.WriteLine(name + " Purchase the Tools Required for Abosolute Victory");
            Console.WriteLine("Items");
            Console.WriteLine("");
            foreach(Items item in shop)
            {
                Console.WriteLine("");
                Console.WriteLine($"Name: " +item.name+"/  Increase Attack/" + item.addAttack+"/  Increase Defense/" + item.addDefense+"/  Increase Health/" +item.addHealth+"/  Costs/"+ item.shopPrice);
                Console.WriteLine("");
            }
            Console.WriteLine("You have, " +shopPoints+" Shop Points");
            do
            {
                string buy = Console.ReadLine();
                if (buy == sword.name)
                {
                    playerItem.Add(sword);
                    shopPoints -= sword.shopPrice;
                    if (shopPoints < 0)
                    {
                        playerItem.Remove(sword);
                        shopPoints += sword.shopPrice;
                        Console.WriteLine("Not Enough Shop Points");
                        Console.WriteLine(shopPoints);
                        Console.WriteLine("");
                    }


                    foreach (Items item in playerItem)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Defense/" + item.addDefense + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("You Have " +shopPoints+" Left");
                    Console.WriteLine("");
                }
                if (buy == shield.name)
                {
                    playerItem.Add(shield);
                    shopPoints -= shield.shopPrice;
                    if (shopPoints < 0)
                    {
                        playerItem.Remove(shield);
                        shopPoints += shield.shopPrice;
                        Console.WriteLine("Not Enough Shop Points");
                        Console.WriteLine(shopPoints);
                        Console.WriteLine("");
                    }


                    foreach (Items item in playerItem)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Defense/" + item.addDefense + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("You Have " + shopPoints + " Left");
                    Console.WriteLine("");
                }
                if (buy == repairKit.name)
                {
                    playerItem.Add(repairKit);
                    shopPoints -= repairKit.shopPrice;
                    if (shopPoints < 0)
                    {
                        playerItem.Remove(repairKit);
                        shopPoints += repairKit.shopPrice;
                        Console.WriteLine("Not Enough Shop Points");
                        Console.WriteLine(shopPoints);
                        Console.WriteLine("");
                    }

                    foreach (Items item in playerItem)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Defense/" + item.addDefense + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("You Have " + shopPoints + " Left");
                    Console.WriteLine("");
                }
                if (buy == bomb.name)
                {
                    playerItem.Add(bomb);
                    shopPoints -= bomb.shopPrice;
                    if (shopPoints < 0)
                    {
                        playerItem.Remove(bomb);
                        shopPoints += bomb.shopPrice;
                        Console.WriteLine("Not Enough Shop Points");
                        Console.WriteLine(shopPoints);
                        Console.WriteLine("");
                    }
                    foreach (Items item in playerItem)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Defense/" + item.addDefense + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("You Have " + shopPoints + " Left");
                    Console.WriteLine("");
                }
            }
            while (shopPoints != 0);
            Console.WriteLine("");
            Console.WriteLine("You Have Assembled your WMDs");
            Console.WriteLine("");
        }
    }
}
