using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{ 
    public class Monster
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalHP { get; set; }
        public int CurrentHP { get; set; }
        public int Gold { get; set; }

        public Monster(string name, int strength, int defence, int hp)
        {
            this.Name = name;
            this.Strength = strength;
            this.Defense = defence;
            this.OriginalHP = hp;
            this.CurrentHP = hp;
            this.Gold = 5;


        }

    }
}