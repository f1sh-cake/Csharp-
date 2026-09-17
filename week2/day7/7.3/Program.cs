namespace _7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-石头，2-剪刀，3-布，0-退出

            Random rand = new Random();

            int count = 0;
            int win = 0;
            int lose = 0;
            int draw = 0;
            double winRate = 0;

            while (true)
            {
                Console.Write("请出手(1-石头，2-剪刀，3-布，0-退出)：");
                int player = int.Parse(Console.ReadLine());

                if (player == 0)
                    break;

                if (player < 1 || player > 3)
                {
                    Console.WriteLine("输入无效");
                    continue;
                }

                int computer = rand.Next(1, 4);

                Console.Write("玩家：");
                switch (player)
                {
                    case 1:
                        Console.WriteLine("石头");
                        break;
                    case 2:
                        Console.WriteLine("剪刀");
                        break;
                    case 3:
                        Console.WriteLine("布");
                        break;
                }

                Console.Write("电脑：");
                switch (computer)
                {
                    case 1:
                        Console.WriteLine("石头");
                        break;
                    case 2:
                        Console.WriteLine("剪刀");
                        break;
                    case 3:
                        Console.WriteLine("布");
                        break;
                }

                if (player == computer)
                {
                    draw++;
                    Console.WriteLine("平局");
                }
                else if ((player == 1 && computer == 2) ||
                         (player == 2 && computer == 3) ||
                         (player == 3 && computer == 1))
                {
                    win++;
                    Console.WriteLine("玩家胜");
                }
                else
                {
                    lose++;
                    Console.WriteLine("电脑胜");
                }

                count++;
            }

            if (count == 0) winRate = 0;
            else winRate = (double)win / count;
            Console.WriteLine($"共玩了{count}把，赢{win}把，输{lose}把，平{draw}把，胜率为{winRate:P2}");
        }
    }
}