using Game;

class Program
{
    static void Main(string[] args)
    {    
        Random random = new Random();

        Hero hero = new Hero(100, 20);

        List<Monstr> monsters = new List<Monstr>();
        {
            monsters.Add(new MonsterTwo());
            monsters.Add(new MonsterThree());
        };

        Monstr monstr = monsters[random.Next(monsters.Count)];

        while(hero.hp > 0 && monstr.hp > 0)
        {
            hero.Attack(monstr);

            if(monstr.hp <= 0)
            {
                Console.WriteLine("Герой переміг ");
                break;
            }

            monstr.Attack(hero);

            if(hero.hp <= 0)
            {
                Console.WriteLine("Монстр переміг ");
                break;
            }
        }
    }
}