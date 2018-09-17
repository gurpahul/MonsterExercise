using System;
namespace OOP_RPG
{
    public class Weapon : Item
    {
       

        public Weapon(string name, int strength, int originalvalue, int resellvalue, int index) {
            this.Name = name;
            this.Strength = strength;
            this.OrigionalValue = originalvalue;
            this.ResellValue = resellvalue;
            this.Index = index;
        }
        
        public string Name { get; set; }
        public int Strength { get; set; }
        public int OrigionalValue { get; set; }
        public  int ResellValue { get; set; }
        public int Index { get; set; }
    }
}