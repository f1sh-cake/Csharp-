namespace _2._2
{
    internal class Program
    {
        class GameCharacter
        {
            public int Id { get; set; }

            public string Name { get; set; } = "";

            public int Level { get; set; }

            public int Health { get; set; }

            public int Attack { get; set; }

            public int Defense { get; set; }


            public GameCharacter(
                int id,
                string name,
                int level,
                int health,
                int attack,
                int defense)                                 
            {
                this.Id = id;
                this.Name = name;
                this.Level = level;
                this.Health = health;
                this.Attack = attack;
                this.Defense = defense;
            }
            public GameCharacter(int id, string name)
                : this(id, name, 1, 100, 10, 5)
            {
            }

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
                string status = IsAlive ? "存活" : "倒下";
                return $"#{Id} {Name} Lv.{Level} 生命:{Health} " +
                       $"战力:{Power} {status}";
            }
        }

        static void PrintParty(GameCharacter[] party)
        {
            foreach (GameCharacter character in party)
            {
                Console.WriteLine(character.GetSummary());
            }
        }


        static int GetTotalPower(GameCharacter[] party)
        {
            int sum = 0;
            foreach (GameCharacter x in party)
            {
                sum += x.Power;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            GameCharacter veteran = new GameCharacter(1, "gzy", 1, 100, 10, 5);
            GameCharacter recruit = new GameCharacter(2, "zq");
            Console.WriteLine(veteran.GetSummary());
            Console.WriteLine(recruit.GetSummary());
        }
    }
}
