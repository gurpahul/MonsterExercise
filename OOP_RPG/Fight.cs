using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_RPG
{
    public class Fight
    {
        List<Monster> Monsters { get; set; }
        public Game game { get; set; }
        public Hero hero { get; set; }
        public Monster monster { get; set; }

        public Fight(Hero hero, Game game) {
            this.Monsters = new List<Monster>();
            this.hero = hero;
            this.game = game;
            this.AddMonster("Squid", 9, 8, 20);
            this.AddMonster("Judo", 6, 7, 19);
            this.AddMonster("Lancer", 11, 3, 18);
            this.AddMonster("Charger", 6, 6, 20);
            var lastmonster = (from c in this.Monsters select c).Last();
            var secondmonster = this.Monsters[1];
            var RandoMonster = this.Monsters.OrderBy(p => Guid.NewGuid()).FirstOrDefault();
            var firstMon20 = this.Monsters.Where(p => p.OriginalHP < 20).First();
            var firstWithstrength = this.Monsters.Where(c => c.Strength >= 11).First();
            var enemy = this.Monsters[0];
            this.monster = RandoMonster;
        }




        public void AddMonster(string name, int strength, int defense, int hp) { // meethod 
             var monster = new Monster(name, strength, defense,  hp);
            this.Monsters.Add(monster);
        }
        
        public void Start() {
            Console.WriteLine("You've encountered a " + monster.Name + "! " + monster.Strength + " Strength/" + monster.Defense + " Defense/" +
            monster.CurrentHP + " HP. What will you do?");
            Console.WriteLine("1. Fight");
            var input = Console.ReadLine();
            if (input == "1") {
                this.HeroTurn();
            }
            else { 
                this.game.Main();
            }
        }
        
        public void HeroTurn(){
           var compare = hero.Strength - monster.Defense;
           int damage;
           
           if(compare <= 0) {
               damage = 1;
                monster.CurrentHP -= damage;
           }
           else{
               damage = compare;
                monster.CurrentHP -= damage;
           }
           Console.WriteLine("You did " + damage + " damage!");
           
           if(monster.CurrentHP <= 0){
               this.Win();
           }
           else
           {
               this.MonsterTurn();
           }
           
        }
        
        public void MonsterTurn(){
           
           int damage;
           var compare = monster.Strength - hero.Defense;
           if(compare <= 0) {
               damage = 1;
               hero.CurrentHP -= damage;
           }
           else{
               damage = compare;
               hero.CurrentHP -= damage;
           }
           Console.WriteLine(monster.Name + " does " + damage + " damage!");
           if(hero.CurrentHP <= 0){
               this.Lose();
           }
           else
           {
               this.Start();
           }
        }
        
        public void Win() {
            Console.WriteLine(monster.Name + " has been defeated! You win the battle!");
            hero.Gold += monster.Gold;
            Console.WriteLine();
             game.Main();

        }
        
        public void Lose() {
            Console.WriteLine("You've been defeated! :( GAME OVER.");
            return;
        }
        
    }
    
}