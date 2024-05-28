using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Monstr
    {
        public int hp { get; set; }
        public int damage { get; set; }

        public Monstr(int hp, int damage)
        {
            this.hp = hp;
            this.damage = damage;
        }

        public void Attack(Hero hero)
        {
            hero.hp -= damage;
            Console.WriteLine("Монстр наніс урон герою ");
        }
    }
}
