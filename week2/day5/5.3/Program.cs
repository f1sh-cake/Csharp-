namespace _5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //判断一个数是不是素数
            int n = 0;
            bool isPrime = true;

            Console.Write("enter a int:");
            n = int.Parse(Console.ReadLine());

            if (n <= 1)
            {
                isPrime = false;
            }
            else
            {
                for(int i = 2; i<=Math.Sqrt(n);i++)
                {
                    if(n%i==0)
                    {
                        isPrime=false;
                        break;
                    }
                }
            }

            if(isPrime)
            {
                Console.WriteLine($"{n} is a prime");
            }
            else
            {
                Console.WriteLine($"{n} is not a prime");
            }
        }
    }
}
