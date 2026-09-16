namespace _6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //猜数字游戏（while 循环版，带重玩功能）。
            //要求：随机 1 - 100，每次提示"大了/小了"，猜对后显示猜的次数，并询问是否再来一局。

            bool isAgain = true;

            Random rand = new Random();

            while (isAgain)
            {
                int secret = rand.Next(1, 101);
                Console.Write("请开始猜数（1-100）:");

                for(int i = 1; ;i++)
                {
                    int guess = int.Parse(Console.ReadLine());

                    if (guess > secret) Console.WriteLine("大了");
                    else if (guess < secret) Console.WriteLine("小了");
                    else
                    {
                        Console.WriteLine("答对了");
                        Console.WriteLine($"猜了{i}次");
                        break;
                    }
                }

                Console.Write("还玩吗？(y or n):");
                char answer = Convert.ToChar(Console.ReadLine());
                if (answer =='n')
                {
                    isAgain = false;
                }

            }
        }
    }
}
