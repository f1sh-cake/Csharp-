namespace _6._1挑战
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //猜数字游戏（while 循环版，带重玩功能）。
            //要求：随机 1 - 100，每次提示"大了/小了"，猜对后显示猜的次数，并询问是否再来一局。
            //plus:给猜数字游戏加一个"最多猜 7 次"的限制。用超过 7 次还没猜对，就提示失败并公布答案，然后结束这一局。
            bool isAgain = true;

            Random rand = new Random();

            while (isAgain)
            {
                int secret = rand.Next(1, 101);
                Console.Write("请开始猜数（1-100）:");

                int i = 1;
                for (; i<=7; i++)
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
                
                if(i>=8)
                {
                    Console.WriteLine($"超过七次，挑战失败！答案是{secret}");
                }

                Console.Write("还玩吗？(y or n):");
                char answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'n')
                {
                    isAgain = false;
                }

            }
        }
    }
}
