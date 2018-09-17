﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Shop
    {
     
        List<Weapon> Weapons { get; set; }
        List<Armor> Armors { get; set; }
        List<Potion> Potions { get; set; }
        public Game game { get; set; }

        public Shop(Game game)
        {
            this.Weapons = new List<Weapon>();
            this.Armors = new List<Armor>();
            this.Potions = new List<Potion>();


            var weapon1 = new Weapon("Axe", 12,3,4,1 );
            var weapon2 = new Weapon("Blasxe", 10,6,7,2 );
            var weapon3 = new Weapon("Sword", 20, 7, 8,3);

            var Armor1 = new Armor("Wooden Armor",5,15,10);
            var Armor2 = new Armor("Metal Armor",6,20,9);

            var Potion1= new Potion(7, "Healing potion", 17, 12);

            this.game = game;
            this.Weapons.Add(weapon1);
            this.Weapons.Add(weapon2);
            this.Weapons.Add(weapon3);

            this.Armors.Add(Armor1);
            this.Armors.Add(Armor2);

            this.Potions.Add(Potion1);
        }
        public void Menu()
        {
            Console.WriteLine("***Welcome to my shop! What would you like to do***?");
            Console.WriteLine("1. Buy Item");
            Console.WriteLine("2. Sell Item");
            Console.WriteLine("3. Return to game menu");



            var input1 = Console.ReadLine();

            if (input1 == "1")
            {
                this.ShowInventory();
            }
            else if (input1 == "2")
            {
                this.BuyfromUser();
            }
            else if (input1 == "3")
            {
                this.game.Main();
            }
            
 
        }

        public void ShowInventory()
        {
            Console.WriteLine("1) weapons");
            Console.WriteLine("2) armors");
            Console.WriteLine("3) potions");
            Console.WriteLine("4) return back to menu");

            var selectedInventory1 = Console.ReadLine();

            if(selectedInventory1 == "1")
            {
               foreach(var c in this.Weapons)
                {
                    Console.WriteLine(this.Weapons.IndexOf(c) + c.Name + " costs " + c.OrigionalValue + " Gold");
                }

                Console.WriteLine("4) Return back to menu");

                var  selectedInventory2 = Console.ReadLine();


            }








        } 

        public void BuyfromUser()
        {


            Console.WriteLine("Please choose item to sell: ");
            Console.WriteLine("1) Weapons");
            Console.WriteLine("2) Armors");
            Console.WriteLine("3) Potions");
            Console.WriteLine("4) Return to main menu");

            var soldItem = Console.ReadLine();


        }

    }

   
}
