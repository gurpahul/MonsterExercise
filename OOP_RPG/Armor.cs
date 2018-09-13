using System;
namespace OOP_RPG
{
    public class Armor : Item
    {
        public Armor(string name, int defense, int originalvalue, int resellvalue) {
            this.Name = name;
            this.Defense = defense;
            this.OrigionalValue = originalvalue;
            this.ResellValue = resellvalue;
        }
        
        public string Name { get; set; }
        public int Defense { get; set; }
        public int OrigionalValue { get; set; }
        public int ResellValue { get; set; }
    }
}