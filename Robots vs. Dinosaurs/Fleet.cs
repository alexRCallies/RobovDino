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

                if (answer == "1 2")
                {
                    fleet[1].attackPower += playerItem[0].addAttack;
                    fleet[1].health += playerItem[0].addHealth;
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

                if (answer == "1 3")
                {
                    fleet[2].attackPower += playerItem[0].addAttack;
                    fleet[2].health += playerItem[0].addHealth;
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

                if (answer == "1 4")
                {
                    fleet[3].attackPower += playerItem[0].addAttack;
                    fleet[3].health += playerItem[0].addHealth;
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

                if (answer == "1 5")
                {
                    fleet[4].attackPower += playerItem[0].addAttack;
                    fleet[4].health += playerItem[0].addHealth;
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

                if (answer == "1 6")
                {
                    fleet[5].attackPower += playerItem[0].addAttack;
                    fleet[5].health += playerItem[0].addHealth;
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

                if (answer == "1 7")
                {
                    fleet[6].attackPower += playerItem[0].addAttack;
                    fleet[6].health += playerItem[0].addHealth;
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

                if (answer == "1 10")
                {
                    fleet[9].attackPower += playerItem[0].addAttack;
                    fleet[9].health += playerItem[0].addHealth;
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
                if (answer == "2 1")
                {
                    fleet[0].attackPower += playerItem[1].addAttack;
                    fleet[0].health += playerItem[1].addHealth;
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

                if (answer == "2 2")
                {
                    fleet[1].attackPower += playerItem[1].addAttack;
                    fleet[1].health += playerItem[1].addHealth;
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

                if (answer == "2 3")
                {
                    fleet[2].attackPower += playerItem[1].addAttack;
                    fleet[2].health += playerItem[1].addHealth;
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

                if (answer == "2 4")
                {
                    fleet[3].attackPower += playerItem[1].addAttack;
                    fleet[3].health += playerItem[1].addHealth;
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

                if (answer == "2 5")
                {
                    fleet[4].attackPower += playerItem[1].addAttack;
                    fleet[4].health += playerItem[1].addHealth;
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

                if (answer == "2 8")
                {
                    fleet[7].attackPower += playerItem[1].addAttack;
                    fleet[7].health += playerItem[1].addHealth;
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

                if (answer == "2 9")
                {
                    fleet[8].attackPower += playerItem[1].addAttack;
                    fleet[8].health += playerItem[1].addHealth;
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

                if (answer == "2 10")
                {
                    fleet[9].attackPower += playerItem[1].addAttack;
                    fleet[9].health += playerItem[1].addHealth;
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
                if (answer == "3 1")
                {
                    fleet[0].attackPower += playerItem[2].addAttack;
                    fleet[0].health += playerItem[2].addHealth;
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

                if (answer == "3 2")
                {
                    fleet[1].attackPower += playerItem[2].addAttack;
                    fleet[1].health += playerItem[2].addHealth;
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

                if (answer == "3 8")
                {
                    fleet[7].attackPower += playerItem[2].addAttack;
                    fleet[7].health += playerItem[2].addHealth;
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

        public void BeginAttack(List<Dinosaur> pack)
        {
            foreach (Robot robot in fleet)
            {
                Console.WriteLine("");
                Console.WriteLine($"Name: { robot.name + "/  Health/" + robot.health + "/  Attack/" + robot.attackPower + "/  Evasion/" + robot.evasionPower + "/  costs/" + robot.teamValue}");
                Console.WriteLine("");
            }
            foreach (Dinosaur dino in pack)
            {
                Console.WriteLine("");
                Console.WriteLine($"Name: { dino.name + "/  Health/" + dino.health + "/  Attack/" + dino.attackPower + "/  Evasion/" + dino.evasion + "/  Costs/" + dino.teamValue}");
                Console.WriteLine("");
            }
            string choice = Console.ReadLine();
            Herd herd = new Herd();

            if (choice == "1 1")
            {
                fleet[0].Attack(pack[0]);
                if (pack[0].health <= 0)
                {

                    Console.WriteLine(pack[0].name + " Has Fallen...");
                    pack.RemoveAt(0);
                }
            }
            if (choice == "1 2")
            {
                fleet[0].Attack(pack[1]);
                if (pack[1].health <= 0)
                {

                    Console.WriteLine(pack[1].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "1 3")
            {
                fleet[0].Attack(pack[2]);
                if (pack[2].health <= 0)
                {

                    Console.WriteLine(pack[2].name + " Has Fallen...");
                    pack.RemoveAt(2);
                }
            }
            if (choice == "1 4")
            {
                fleet[0].Attack(pack[3]);
                if (pack[3].health <= 0)
                {

                    Console.WriteLine(pack[3].name + " Has Fallen...");
                    pack.RemoveAt(3);
                }
            }
            if (choice == "1 5")
            {
                fleet[0].Attack(pack[4]);
                if (pack[4].health <= 0)
                {

                    Console.WriteLine(pack[4].name + " Has Fallen...");
                    pack.RemoveAt(4);
                }
            }
            if (choice == "1 6")
            {
                fleet[0].Attack(pack[5]);
                if (pack[5].health <= 0)
                {

                    Console.WriteLine(pack[5].name + " Has Fallen...");
                    pack.RemoveAt(5);
                }
            }
            if (choice == "1 7")
            {
                fleet[0].Attack(pack[6]);
                if (pack[6].health <= 0)
                {

                    Console.WriteLine(pack[6].name + " Has Fallen...");
                    pack.RemoveAt(6);
                }
            }
            if (choice == "1 8")
            {
                fleet[0].Attack(pack[7]);
                if (pack[7].health <= 0)
                {

                    Console.WriteLine(pack[7].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "1 9")
            {
                fleet[0].Attack(pack[8]);
                if (pack[8].health <= 0)
                {

                    Console.WriteLine(pack[8].name + " Has Fallen...");
                    pack.RemoveAt(8);
                }
            }
            if (choice == "1 10")
            {
                fleet[0].Attack(pack[9]);
                if (pack[9].health <= 0)
                {

                    Console.WriteLine(pack[9].name + " Has Fallen...");
                    pack.RemoveAt(9);
                }
            }
            if (choice == "2 1")
            {
                fleet[1].Attack(pack[0]);
                if (pack[0].health <= 0)
                {

                    Console.WriteLine(pack[0].name + " Has Fallen...");
                    pack.RemoveAt(0);
                }
            }
            if (choice == "2 2")
            {
                fleet[1].Attack(pack[1]);
                if (pack[1].health <= 0)
                {

                    Console.WriteLine(pack[1].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "2 3")
            {
                fleet[1].Attack(pack[2]);
                if (pack[2].health <= 0)
                {

                    Console.WriteLine(pack[2].name + " Has Fallen...");
                    pack.RemoveAt(2);
                }
            }
            if (choice == "2 4")
            {
                fleet[1].Attack(pack[3]);
                if (pack[3].health <= 0)
                {

                    Console.WriteLine(pack[3].name + " Has Fallen...");
                    pack.RemoveAt(3);
                }
            }
            if (choice == "2 5")
            {
                fleet[1].Attack(pack[4]);
                if (pack[4].health <= 0)
                {

                    Console.WriteLine(pack[4].name + " Has Fallen...");
                    pack.RemoveAt(4);
                }
            }
            if (choice == "2 6")
            {
                fleet[1].Attack(pack[5]);
                if (pack[5].health <= 0)
                {

                    Console.WriteLine(pack[5].name + " Has Fallen...");
                    pack.RemoveAt(5);
                }
            }
            if (choice == "2 7")
            {
                fleet[1].Attack(pack[6]);
                if (pack[6].health <= 0)
                {

                    Console.WriteLine(pack[6].name + " Has Fallen...");
                    pack.RemoveAt(6);
                }
            }
            if (choice == "2 8")
            {
                fleet[1].Attack(pack[7]);
                if (pack[7].health <= 0)
                {

                    Console.WriteLine(pack[7].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "2 9")
            {
                fleet[1].Attack(pack[8]);
                if (pack[8].health <= 0)
                {

                    Console.WriteLine(pack[8].name + " Has Fallen...");
                    pack.RemoveAt(8);
                }
            }
            if (choice == "2 10")
            {
                fleet[1].Attack(pack[9]);
                if (pack[9].health <= 0)
                {

                    Console.WriteLine(pack[9].name + " Has Fallen...");
                    pack.RemoveAt(9);
                }

            }
            if (choice == "3 1")
            {
                fleet[2].Attack(pack[0]);
                if (pack[0].health <= 0)
                {

                    Console.WriteLine(pack[0].name + " Has Fallen...");
                    pack.RemoveAt(0);
                }
            }
            if (choice == "3 2")
            {
                fleet[2].Attack(pack[1]);
                if (pack[1].health <= 0)
                {

                    Console.WriteLine(pack[1].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "3 3")
            {
                fleet[2].Attack(pack[2]);
                if (pack[2].health <= 0)
                {

                    Console.WriteLine(pack[2].name + " Has Fallen...");
                    pack.RemoveAt(2);
                }
            }
            if (choice == "3 4")
            {
                fleet[2].Attack(pack[3]);
                if (pack[3].health <= 0)
                {

                    Console.WriteLine(pack[3].name + " Has Fallen...");
                    pack.RemoveAt(3);
                }
            }
            if (choice == "3 5")
            {
                fleet[2].Attack(pack[4]);
                if (pack[4].health <= 0)
                {

                    Console.WriteLine(pack[4].name + " Has Fallen...");
                    pack.RemoveAt(4);
                }
            }
            if (choice == "3 6")
            {
                fleet[2].Attack(pack[5]);
                if (pack[5].health <= 0)
                {

                    Console.WriteLine(pack[5].name + " Has Fallen...");
                    pack.RemoveAt(5);
                }
            }
            if (choice == "3 7")
            {
                fleet[2].Attack(pack[6]);
                if (pack[6].health <= 0)
                {

                    Console.WriteLine(pack[6].name + " Has Fallen...");
                    pack.RemoveAt(6);
                }
            }
            if (choice == "3 8")
            {
                fleet[2].Attack(pack[7]);
                if (pack[7].health <= 0)
                {

                    Console.WriteLine(pack[7].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "3 9")
            {
                fleet[2].Attack(pack[8]);
                if (pack[8].health <= 0)
                {

                    Console.WriteLine(pack[8].name + " Has Fallen...");
                    pack.RemoveAt(8);
                }
            }
            if (choice == "3 10")
            {
                fleet[2].Attack(pack[9]);
                if (pack[9].health <= 0)
                {

                    Console.WriteLine(pack[9].name + " Has Fallen...");
                    pack.RemoveAt(9);
                }

            }
            if (choice == "4 1")
            {
                fleet[3].Attack(pack[0]);
                if (pack[0].health <= 0)
                {

                    Console.WriteLine(pack[0].name + " Has Fallen...");
                    pack.RemoveAt(0);
                }
            }
            if (choice == "4 2")
            {
                fleet[3].Attack(pack[1]);
                if (pack[1].health <= 0)
                {

                    Console.WriteLine(pack[1].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "4 3")
            {
                fleet[3].Attack(pack[2]);
                if (pack[2].health <= 0)
                {

                    Console.WriteLine(pack[2].name + " Has Fallen...");
                    pack.RemoveAt(2);
                }
            }
            if (choice == "4 4")
            {
                fleet[3].Attack(pack[3]);
                if (pack[3].health <= 0)
                {

                    Console.WriteLine(pack[3].name + " Has Fallen...");
                    pack.RemoveAt(3);
                }
            }
            if (choice == "4 5")
            {
                fleet[3].Attack(pack[4]);
                if (pack[4].health <= 0)
                {

                    Console.WriteLine(pack[4].name + " Has Fallen...");
                    pack.RemoveAt(4);
                }
            }
            if (choice == "4 6")
            {
                fleet[3].Attack(pack[5]);
                if (pack[5].health <= 0)
                {

                    Console.WriteLine(pack[5].name + " Has Fallen...");
                    pack.RemoveAt(5);
                }
            }
            if (choice == "4 7")
            {
                fleet[3].Attack(pack[6]);
                if (pack[6].health <= 0)
                {

                    Console.WriteLine(pack[6].name + " Has Fallen...");
                    pack.RemoveAt(6);
                }
            }
            if (choice == "4 8")
            {
                fleet[3].Attack(pack[7]);
                if (pack[7].health <= 0)
                {

                    Console.WriteLine(pack[7].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "4 9")
            {
                fleet[3].Attack(pack[8]);
                if (pack[8].health <= 0)
                {

                    Console.WriteLine(pack[8].name + " Has Fallen...");
                    pack.RemoveAt(8);
                }
            }
            if (choice == "4 10")
            {
                fleet[3].Attack(pack[9]);
                if (pack[9].health <= 0)
                {

                    Console.WriteLine(pack[9].name + " Has Fallen...");
                    pack.RemoveAt(9);
                }

            }
            if (choice == "5 1")
            {
                fleet[4].Attack(pack[0]);
                if (pack[0].health <= 0)
                {

                    Console.WriteLine(pack[0].name + " Has Fallen...");
                    pack.RemoveAt(0);
                }
            }
            if (choice == "5 2")
            {
                fleet[4].Attack(pack[1]);
                if (pack[1].health <= 0)
                {

                    Console.WriteLine(pack[1].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "5 3")
            {
                fleet[4].Attack(pack[2]);
                if (pack[2].health <= 0)
                {

                    Console.WriteLine(pack[2].name + " Has Fallen...");
                    pack.RemoveAt(2);
                }
            }
            if (choice == "5 4")
            {
                fleet[4].Attack(pack[3]);
                if (pack[3].health <= 0)
                {

                    Console.WriteLine(pack[3].name + " Has Fallen...");
                    pack.RemoveAt(3);
                }
            }
            if (choice == "5 5")
            {
                fleet[4].Attack(pack[4]);
                if (pack[4].health <= 0)
                {

                    Console.WriteLine(pack[4].name + " Has Fallen...");
                    pack.RemoveAt(4);
                }
            }
            if (choice == "5 6")
            {
                fleet[4].Attack(pack[5]);
                if (pack[5].health <= 0)
                {

                    Console.WriteLine(pack[5].name + " Has Fallen...");
                    pack.RemoveAt(5);
                }
            }
            if (choice == "5 7")
            {
                fleet[4].Attack(pack[6]);
                if (pack[6].health <= 0)
                {

                    Console.WriteLine(pack[6].name + " Has Fallen...");
                    pack.RemoveAt(6);
                }
            }
            if (choice == "5 8")
            {
                fleet[4].Attack(pack[7]);
                if (pack[7].health <= 0)
                {

                    Console.WriteLine(pack[7].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "5 9")
            {
                fleet[4].Attack(pack[8]);
                if (pack[8].health <= 0)
                {

                    Console.WriteLine(pack[8].name + " Has Fallen...");
                    pack.RemoveAt(8);
                }
            }
            if (choice == "5 10")
            {
                fleet[4].Attack(pack[9]);
                if (pack[9].health <= 0)
                {

                    Console.WriteLine(pack[9].name + " Has Fallen...");
                    pack.RemoveAt(9);
                }

            }
            if (choice == "6 1")
            {
                fleet[5].Attack(pack[0]);
                if (pack[0].health <= 0)
                {

                    Console.WriteLine(pack[0].name + " Has Fallen...");
                    pack.RemoveAt(0);
                }
            }
            if (choice == "6 2")
            {
                fleet[5].Attack(pack[1]);
                if (pack[1].health <= 0)
                {

                    Console.WriteLine(pack[1].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "6 3")
            {
                fleet[5].Attack(pack[2]);
                if (pack[2].health <= 0)
                {

                    Console.WriteLine(pack[2].name + " Has Fallen...");
                    pack.RemoveAt(2);
                }
            }
            if (choice == "6 4")
            {
                fleet[5].Attack(pack[3]);
                if (pack[3].health <= 0)
                {

                    Console.WriteLine(pack[3].name + " Has Fallen...");
                    pack.RemoveAt(3);
                }
            }
            if (choice == "6 5")
            {
                fleet[5].Attack(pack[4]);
                if (pack[4].health <= 0)
                {

                    Console.WriteLine(pack[4].name + " Has Fallen...");
                    pack.RemoveAt(4);
                }
            }
            if (choice == "6 6")
            {
                fleet[5].Attack(pack[5]);
                if (pack[5].health <= 0)
                {

                    Console.WriteLine(pack[5].name + " Has Fallen...");
                    pack.RemoveAt(5);
                }
            }
            if (choice == "6 7")
            {
                fleet[5].Attack(pack[6]);
                if (pack[6].health <= 0)
                {

                    Console.WriteLine(pack[6].name + " Has Fallen...");
                    pack.RemoveAt(6);
                }
            }
            if (choice == "6 8")
            {
                fleet[5].Attack(pack[7]);
                if (pack[7].health <= 0)
                {

                    Console.WriteLine(pack[7].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "6 9")
            {
                fleet[5].Attack(pack[8]);
                if (pack[8].health <= 0)
                {

                    Console.WriteLine(pack[8].name + " Has Fallen...");
                    pack.RemoveAt(8);
                }
            }
            if (choice == "6 10")
            {
                fleet[5].Attack(pack[9]);
                if (pack[9].health <= 0)
                {

                    Console.WriteLine(pack[9].name + " Has Fallen...");
                    pack.RemoveAt(9);
                }

            }
            if (choice == "7 1")
            {
                fleet[6].Attack(pack[0]);
                if (pack[0].health <= 0)
                {

                    Console.WriteLine(pack[0].name + " Has Fallen...");
                    pack.RemoveAt(0);
                }
            }
            if (choice == "7 2")
            {
                fleet[6].Attack(pack[1]);
                if (pack[1].health <= 0)
                {

                    Console.WriteLine(pack[1].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "7 3")
            {
                fleet[6].Attack(pack[2]);
                if (pack[2].health <= 0)
                {

                    Console.WriteLine(pack[2].name + " Has Fallen...");
                    pack.RemoveAt(2);
                }
            }
            if (choice == "7 4")
            {
                fleet[6].Attack(pack[3]);
                if (pack[3].health <= 0)
                {

                    Console.WriteLine(pack[3].name + " Has Fallen...");
                    pack.RemoveAt(3);
                }
            }
            if (choice == "7 5")
            {
                fleet[6].Attack(pack[4]);
                if (pack[4].health <= 0)
                {

                    Console.WriteLine(pack[4].name + " Has Fallen...");
                    pack.RemoveAt(4);
                }
            }
            if (choice == "7 6")
            {
                fleet[6].Attack(pack[5]);
                if (pack[5].health <= 0)
                {

                    Console.WriteLine(pack[5].name + " Has Fallen...");
                    pack.RemoveAt(5);
                }
            }
            if (choice == "7 7")
            {
                fleet[6].Attack(pack[6]);
                if (pack[6].health <= 0)
                {

                    Console.WriteLine(pack[6].name + " Has Fallen...");
                    pack.RemoveAt(6);
                }
            }
            if (choice == "7 8")
            {
                fleet[6].Attack(pack[7]);
                if (pack[7].health <= 0)
                {

                    Console.WriteLine(pack[7].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "7 9")
            {
                fleet[6].Attack(pack[8]);
                if (pack[8].health <= 0)
                {

                    Console.WriteLine(pack[8].name + " Has Fallen...");
                    pack.RemoveAt(8);
                }
            }
            if (choice == "7 10")
            {
                fleet[6].Attack(pack[9]);
                if (pack[9].health <= 0)
                {

                    Console.WriteLine(pack[9].name + " Has Fallen...");
                    pack.RemoveAt(9);
                }

            }
            if (choice == "8 1")
            {
                fleet[7].Attack(pack[0]);
                if (pack[0].health <= 0)
                {

                    Console.WriteLine(pack[0].name + " Has Fallen...");
                    pack.RemoveAt(0);
                }
            }
            if (choice == "8 2")
            {
                fleet[7].Attack(pack[1]);
                if (pack[1].health <= 0)
                {

                    Console.WriteLine(pack[1].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "8 3")
            {
                fleet[7].Attack(pack[2]);
                if (pack[2].health <= 0)
                {

                    Console.WriteLine(pack[2].name + " Has Fallen...");
                    pack.RemoveAt(2);
                }
            }
            if (choice == "8 4")
            {
                fleet[7].Attack(pack[3]);
                if (pack[3].health <= 0)
                {

                    Console.WriteLine(pack[3].name + " Has Fallen...");
                    pack.RemoveAt(3);
                }
            }
            if (choice == "8 5")
            {
                fleet[7].Attack(pack[4]);
                if (pack[4].health <= 0)
                {

                    Console.WriteLine(pack[4].name + " Has Fallen...");
                    pack.RemoveAt(4);
                }
            }
            if (choice == "8 6")
            {
                fleet[7].Attack(pack[5]);
                if (pack[5].health <= 0)
                {

                    Console.WriteLine(pack[5].name + " Has Fallen...");
                    pack.RemoveAt(5);
                }
            }
            if (choice == "8 7")
            {
                fleet[7].Attack(pack[6]);
                if (pack[6].health <= 0)
                {

                    Console.WriteLine(pack[6].name + " Has Fallen...");
                    pack.RemoveAt(6);
                }
            }
            if (choice == "8 8")
            {
                fleet[7].Attack(pack[7]);
                if (pack[7].health <= 0)
                {

                    Console.WriteLine(pack[7].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "8 9")
            {
                fleet[7].Attack(pack[8]);
                if (pack[8].health <= 0)
                {

                    Console.WriteLine(pack[8].name + " Has Fallen...");
                    pack.RemoveAt(8);
                }
            }
            if (choice == "8 10")
            {
                fleet[7].Attack(pack[9]);
                if (pack[9].health <= 0)
                {

                    Console.WriteLine(pack[9].name + " Has Fallen...");
                    pack.RemoveAt(9);
                }

            }
            if (choice == "9 1")
            {
                fleet[8].Attack(pack[0]);
                if (pack[0].health <= 0)
                {

                    Console.WriteLine(pack[0].name + " Has Fallen...");
                    pack.RemoveAt(0);
                }
            }
            if (choice == "9 2")
            {
                fleet[8].Attack(pack[1]);
                if (pack[1].health <= 0)
                {

                    Console.WriteLine(pack[1].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "9 3")
            {
                fleet[8].Attack(pack[2]);
                if (pack[2].health <= 0)
                {

                    Console.WriteLine(pack[2].name + " Has Fallen...");
                    pack.RemoveAt(2);
                }
            }
            if (choice == "9 4")
            {
                fleet[8].Attack(pack[3]);
                if (pack[3].health <= 0)
                {

                    Console.WriteLine(pack[3].name + " Has Fallen...");
                    pack.RemoveAt(3);
                }
            }
            if (choice == "9 5")
            {
                fleet[8].Attack(pack[4]);
                if (pack[4].health <= 0)
                {

                    Console.WriteLine(pack[4].name + " Has Fallen...");
                    pack.RemoveAt(4);
                }
            }
            if (choice == "9 6")
            {
                fleet[8].Attack(pack[5]);
                if (pack[5].health <= 0)
                {

                    Console.WriteLine(pack[5].name + " Has Fallen...");
                    pack.RemoveAt(5);
                }
            }
            if (choice == "9 7")
            {
                fleet[8].Attack(pack[6]);
                if (pack[6].health <= 0)
                {

                    Console.WriteLine(pack[6].name + " Has Fallen...");
                    pack.RemoveAt(6);
                }
            }
            if (choice == "9 8")
            {
                fleet[8].Attack(pack[7]);
                if (pack[7].health <= 0)
                {

                    Console.WriteLine(pack[7].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "9 9")
            {
                fleet[8].Attack(pack[8]);
                if (pack[8].health <= 0)
                {

                    Console.WriteLine(pack[8].name + " Has Fallen...");
                    pack.RemoveAt(8);
                }
            }
            if (choice == "9 10")
            {
                fleet[8].Attack(pack[9]);
                if (pack[9].health <= 0)
                {

                    Console.WriteLine(pack[9].name + " Has Fallen...");
                    pack.RemoveAt(9);
                }

            }
            if (choice == "10 1")
            {
                fleet[9].Attack(pack[0]);
                if (pack[0].health <= 0)
                {

                    Console.WriteLine(pack[0].name + " Has Fallen...");
                    pack.RemoveAt(0);
                }
            }
            if (choice == "10 2")
            {
                fleet[9].Attack(pack[1]);
                if (pack[1].health <= 0)
                {

                    Console.WriteLine(pack[1].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "10 3")
            {
                fleet[9].Attack(pack[2]);
                if (pack[2].health <= 0)
                {

                    Console.WriteLine(pack[2].name + " Has Fallen...");
                    pack.RemoveAt(2);
                }
            }
            if (choice == "10 4")
            {
                fleet[9].Attack(pack[3]);
                if (pack[3].health <= 0)
                {

                    Console.WriteLine(pack[3].name + " Has Fallen...");
                    pack.RemoveAt(3);
                }
            }
            if (choice == "10 5")
            {
                fleet[9].Attack(pack[4]);
                if (pack[4].health <= 0)
                {

                    Console.WriteLine(pack[4].name + " Has Fallen...");
                    pack.RemoveAt(4);
                }
            }
            if (choice == "10 6")
            {
                fleet[9].Attack(pack[5]);
                if (pack[5].health <= 0)
                {

                    Console.WriteLine(pack[5].name + " Has Fallen...");
                    pack.RemoveAt(5);
                }
            }
            if (choice == "10 7")
            {
                fleet[9].Attack(pack[6]);
                if (pack[6].health <= 0)
                {

                    Console.WriteLine(pack[6].name + " Has Fallen...");
                    pack.RemoveAt(6);
                }
            }
            if (choice == "10 8")
            {
                fleet[9].Attack(pack[7]);
                if (pack[7].health <= 0)
                {

                    Console.WriteLine(pack[7].name + " Has Fallen...");
                    pack.RemoveAt(1);
                }
            }
            if (choice == "10 9")
            {
                fleet[9].Attack(pack[8]);
                if (pack[8].health <= 0)
                {

                    Console.WriteLine(pack[8].name + " Has Fallen...");
                    pack.RemoveAt(8);
                }
            }
            if (choice == "10 10")
            {
                fleet[9].Attack(pack[9]);
                if (pack[9].health <= 0)
                {

                    Console.WriteLine(pack[9].name + " Has Fallen...");
                    pack.RemoveAt(9);
                }

            }
        }
    }
}
        

