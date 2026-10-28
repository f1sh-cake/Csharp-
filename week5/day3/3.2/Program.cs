namespace _3._2
{
    internal class Program
    {
        class GameCharacter
        {
            private readonly int id;
            public int Id
            {
                get
                {
                    return id;
                }
            }

            private string name;
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("姓名不能为空", nameof(value));
                    }
                    name = value.Trim();
                }
            }

            private int level;
            public int Level
            {
                get
                {
                    return level;
                }
                set
                {
                    if (value < 1 || value > 100)
                    {
                        throw new ArgumentOutOfRangeException("等级无法小于1", nameof(value));
                    }
                    level = value;
                }
            }

            private int health;

            public int Health
            {
                get
                {
                    return health;
                }
                private set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("生命值不能为负数", nameof(value));
                    }
                    else if (value > 100)
                    {
                        throw new ArgumentOutOfRangeException("生命值不嫩超过生命上限", nameof(value));
                    }
                    health = value;
                }

            }

            private int attack;
            public int Attack
            {
                get
                {
                    return attack;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("攻击力不能为负数", nameof(value));
                    }
                    attack = value;
                }
            }

            private int defense;
            public int Defense
            {
                get
                {
                    return defense;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("防御力不能为负数", nameof(value));
                    }
                    defense = value;
                }

            }


            public GameCharacter(
                int id,
                string name,
                int level,
                int health,
                int attack,
                int defense)
            {
                this.id = id;
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

            public void Train()
            {
                this.Level = Math.Min(Level + 1, 100);
                this.Health = Math.Min(this.Health + 10, 100);
                this.Attack += 2;
            }

            //受到伤害处理
            public void TakeDamage(int damage)
            {
                if(damage<0)
                {
                    throw new ArgumentOutOfRangeException("收到的伤害不能为负数", nameof(damage));
                }
                this.Health  = Math.Max(this.Health-damage, 0);
            }

            //接受治疗处理
            public void Heal(int amount)
            {
                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException("治疗量不能为负数",nameof(amount));
                }
                this.Health = Math.Min(this.Health+amount, 100);
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
            GameCharacter[] party = new GameCharacter[3];

            party[0] = new GameCharacter(1, "A");
            party[1] = new GameCharacter(2, "B");
            party[2] = new GameCharacter(3, "C");

            party[0].TakeDamage(30);
            party[0].TakeDamage(100);
            Console.WriteLine(party[0].GetSummary());

            party[0].Train();

            party[1].Train();

            Console.WriteLine($"训练前队伍总战力：{GetTotalPower(party)}");
        }
    }
}
