namespace _1._3
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
            foreach(GameCharacter x in party)
            {
                sum += x.Power;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            GameCharacter[] party = new GameCharacter[3];
            for (int i = 0; i < party.Length; i++)
            {
                party[i] = new GameCharacter();
            }

            //party[0]数据
            party[0].Id = 1;
            party[0].Name = "gzy";
            party[0].Level = 61;
            party[0].Health = 100;
            party[0].Attack = 80;
            party[0].Defense = 90;

            //party[1]数据
            party[1].Id = 2;
            party[1].Name = "zq";
            party[1].Level = 60;
            party[1].Health = 90;
            party[1].Attack = 90;
            party[1].Defense = 80;

            //party[2]数据
            party[2].Id = 3;
            party[2].Name = "fdh";
            party[2].Level = 60;
            party[2].Health = 88;
            party[2].Attack = 86;
            party[2].Defense = 91;

            PrintParty(party);

            GameCharacter b = party[2];
            b.Attack = 0;

            Console.WriteLine($"队伍总战力为{GetTotalPower(party)}");

        }
    }
}
