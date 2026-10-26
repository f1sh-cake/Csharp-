namespace _1._2
{
    internal class Program
    {
        class GameCharacter
        {
            public int Id { get; set; }

            public int Level { get; set; }

            public int Health { get; set; }

            public int Attack { get; set; }

            public int Defense { get; set; }



            public string Name { get; set; } = "";

            public int Power
            {
                get
                {
                    return Attack * 2 + Defense;
                }
            }

            public bool IsAlive
            {
                get
                {
                    return Health > 0;
                }
            }

            public string GetSummary()
            {
                string status = IsAlive?"存活":"倒下";
                return $"#{Id} {Name} Lv.{Level} 生命:{Health} " +
                       $"战力:{Power} {status}";
            }
        }
        static void Main(string[] args)
        {
            GameCharacter hero = new GameCharacter();
            GameCharacter alay = new GameCharacter();
            
            //hero数据
            hero.Id = 1;
            hero.Name = "gzy";
            hero.Level = 61;
            hero.Health = 100;
            hero.Attack = 80;
            hero.Defense = 90;
            
            //allay数据
            alay.Id = 2;
            alay.Name = "zq";
            alay.Level = 60;
            alay.Health = 90;
            alay.Attack = 90;
            alay.Defense = 80;

            Console.WriteLine(hero.GetSummary());
            Console.WriteLine(alay.GetSummary());

        }
    }
}
