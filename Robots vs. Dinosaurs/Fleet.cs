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
        
        Player2 player2 = new Player2();
        public List<Robot> fleet = new List<Robot>();
        public List<Items> playerItem = new List<Items>();
        public List<Robot> robots = new List<Robot>();
        public List<Items> shop = new List<Items>();
        public Fleet()
        {
            minionBot = new Robot("Minion Bot", 200, 100, 1, 1, 1);
            warriorBot = new Robot("Warrior Bot", 350, 100, 3, 3, 2);
            shieldBot = new Robot("Shield Bot", 600, 75, 1, 2, 3);
            robBot = new Robot("Rob-Bot", 1200, 350, 1, 4, 6);

            robots.Add(minionBot);
            robots.Add(warriorBot);
            robots.Add(shieldBot);
            robots.Add(robBot);
            sword = new Items("Sword", 100, 0, 1);
            repairKit = new Items("Repair Kit", 0, 150, 1);
           

            shop.Add(sword);

            shop.Add(repairKit);
           
        }





        public void ConstructFleet(List<Robot> robots)
        {
            Console.WriteLine(player2.name + " Construct Your Fleet to Meet the Herd");
            Console.WriteLine("");
            Console.WriteLine("Robots");
            foreach (Robot robot in robots)
            {
                Console.WriteLine("");
                Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
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
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
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
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
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
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
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
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
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
                Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
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
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
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
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
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
        public void EquipItems()
        {
            Console.WriteLine(player2.name + " Equip Your Items.");
            int counter = 3;
            

            foreach (Items item in playerItem)

            {
                Console.WriteLine("");
                Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                Console.WriteLine("");
            }
            Console.WriteLine("Robots");
            foreach (Robot robot in fleet)
            {
                Console.WriteLine("");
                Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                Console.WriteLine("");
            }
            Console.WriteLine("Type the number of the item of where it is on the list from top to bottom, following the position of the robot on the list.");
            Console.WriteLine("1 1 would equip the first item to the first robot, 1 2 would be first item second item");
            
            do
            {
                string answer = Console.ReadLine();
                if (answer == "1 1")
                {
                    fleet[0].attackPower += playerItem[0].addAttack;
                    fleet[0].health += playerItem[0].addHealth;
                    playerItem.RemoveAt(0);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "1 2")
                {
                    fleet[1].attackPower += playerItem[0].addAttack;
                    fleet[1].health += playerItem[0].addHealth;
                    playerItem.RemoveAt(0);
                    counter -=  1;
                   
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }

                }

                if (answer == "1 3")
                {
                    fleet[2].attackPower += playerItem[0].addAttack;
                    fleet[2].health += playerItem[0].addHealth;
                    playerItem.RemoveAt(0);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "1 4")
                {
                    fleet[3].attackPower += playerItem[0].addAttack;
                    fleet[3].health += playerItem[0].addHealth;
                    playerItem.RemoveAt(0);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "1 5")
                {
                    fleet[4].attackPower += playerItem[0].addAttack;
                    fleet[4].health += playerItem[0].addHealth;
                    playerItem.RemoveAt(0);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "1 6")
                {
                    fleet[5].attackPower += playerItem[0].addAttack;
                    fleet[5].health += playerItem[0].addHealth;
                    playerItem.RemoveAt(0);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "1 7")
                {
                    fleet[6].attackPower += playerItem[0].addAttack;
                    fleet[6].health += playerItem[0].addHealth;
                    playerItem.RemoveAt(0);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "1 8")
                {
                    fleet[7].attackPower += playerItem[0].addAttack;
                    fleet[7].health += playerItem[0].addHealth;
                    playerItem.RemoveAt(0);
                    counter -= 1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "1 9")
                {
                    fleet[8].attackPower += playerItem[0].addAttack;
                    fleet[8].health += playerItem[0].addHealth;
                    playerItem.RemoveAt(0);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "1 10")
                {
                    fleet[9].attackPower += playerItem[0].addAttack;
                    fleet[9].health += playerItem[0].addHealth;
                    playerItem.RemoveAt(0);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }
                if (answer == "2 1")
                {
                    fleet[0].attackPower += playerItem[1].addAttack;
                    fleet[0].health += playerItem[1].addHealth;
                    playerItem.RemoveAt(1);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "2 2")
                {
                    fleet[1].attackPower += playerItem[1].addAttack;
                    fleet[1].health += playerItem[1].addHealth;
                    playerItem.RemoveAt(1);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }

                }

                if (answer == "2 3")
                {
                    fleet[2].attackPower += playerItem[1].addAttack;
                    fleet[2].health += playerItem[1].addHealth;
                    playerItem.RemoveAt(1);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "2 4")
                {
                    fleet[3].attackPower += playerItem[1].addAttack;
                    fleet[3].health += playerItem[1].addHealth;
                    playerItem.RemoveAt(1);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "2 5")
                {
                    fleet[4].attackPower += playerItem[1].addAttack;
                    fleet[4].health += playerItem[1].addHealth;
                    playerItem.RemoveAt(1);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "2 6")
                {
                    fleet[5].attackPower += playerItem[1].addAttack;
                    fleet[5].health += playerItem[1].addHealth;
                    playerItem.RemoveAt(1);
                    counter -= 1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "2 7")
                {
                    fleet[6].attackPower += playerItem[1].addAttack;
                    fleet[6].health += playerItem[1].addHealth;
                    playerItem.RemoveAt(1);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "2 8")
                {
                    fleet[7].attackPower += playerItem[1].addAttack;
                    fleet[7].health += playerItem[1].addHealth;
                    playerItem.RemoveAt(1);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "2 9")
                {
                    fleet[8].attackPower += playerItem[1].addAttack;
                    fleet[8].health += playerItem[1].addHealth;
                    playerItem.RemoveAt(1);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "2 10")
                {
                    fleet[9].attackPower += playerItem[1].addAttack;
                    fleet[9].health += playerItem[1].addHealth;
                    playerItem.RemoveAt(1);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }
                if (answer == "3 1")
                {
                    fleet[0].attackPower += playerItem[2].addAttack;
                    fleet[0].health += playerItem[2].addHealth;
                    playerItem.RemoveAt(2);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "3 2")
                {
                    fleet[1].attackPower += playerItem[2].addAttack;
                    fleet[1].health += playerItem[2].addHealth;
                    playerItem.RemoveAt(2);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }

                }

                if (answer == "3 3")
                {
                    fleet[2].attackPower += playerItem[2].addAttack;
                    fleet[2].health += playerItem[2].addHealth;
                    playerItem.RemoveAt(2);
                    counter -= 1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "3 4")
                {
                    fleet[3].attackPower += playerItem[2].addAttack;
                    fleet[3].health += playerItem[2].addHealth;
                    playerItem.RemoveAt(2);
                    counter -= counter - 1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "3 5")
                {
                    fleet[4].attackPower += playerItem[2].addAttack;
                    fleet[4].health += playerItem[2].addHealth;
                    playerItem.RemoveAt(2);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "3 6")
                {
                    fleet[5].attackPower += playerItem[2].addAttack;
                    fleet[5].health += playerItem[2].addHealth;
                    playerItem.RemoveAt(2);
                    counter -= 1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "3 7")
                {
                    fleet[6].attackPower += playerItem[2].addAttack;
                    fleet[6].health += playerItem[2].addHealth;
                    playerItem.RemoveAt(2);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "3 8")
                {
                    fleet[7].attackPower += playerItem[2].addAttack;
                    fleet[7].health += playerItem[2].addHealth;
                    playerItem.RemoveAt(2);
                    counter -=  1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "3 9")
                {
                    fleet[8].attackPower += playerItem[2].addAttack;
                    fleet[8].health += playerItem[2].addHealth;
                    playerItem.RemoveAt(2);
                    counter -= 1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }

                if (answer == "3 10")
                {
                    fleet[9].attackPower += playerItem[2].addAttack;
                    fleet[9].health += playerItem[2].addHealth;
                    playerItem.RemoveAt(2);
                    counter -= 1;
                    if (counter < 0)
                    {
                        Console.WriteLine("Items Equipt");
                    }
                    foreach (Items item in playerItem)

                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: " + item.name + "/  Increase Attack/" + item.addAttack + "/  Increase Health/" + item.addHealth + "/  Costs/" + item.shopPrice);
                        Console.WriteLine("");
                    }
                    foreach (Robot robot in fleet)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                        Console.WriteLine("");
                    }
                }
            }
            while (counter != 0);
            Console.WriteLine("Items equipt");
        }
    }
}
        

