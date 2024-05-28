using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Hero
    {
        public int hp {  get; set; } 
        public int damage { get; set; }

        public Hero(int hp, int damage)
        {
            this.hp = hp;
            this.damage = damage;
        }

        public void Attack(Monstr monstr)
        {
            monstr.hp -= damage;
            Console.WriteLine("Герой атакує монстра ");
        }
    }
}
