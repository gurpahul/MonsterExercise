﻿namespace OOP_RPG
{
    public class Potion : Item
    {
        public Potion(int hp, string name, int originalvalue, int resellvalue)
        {
            this.HP = hp;
            this.Name = name;
            this.OrigionalValue = originalvalue;
            this.ResellValue = resellvalue;

        }

        public int HP { get; set; }
        public string Name { get; set; }
        public int OrigionalValue { get; set; }
        public int ResellValue { get; set; }

        
    }
    
    

}
