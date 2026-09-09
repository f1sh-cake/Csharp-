namespace _6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入一个三位数（如 123），输出倒序后的数（321）。
            Console.Write("enter a three-digit num:");
            int num =int.Parse(Console.ReadLine());

            int a = num / 100;
            int b = num % 100 / 10;
            int c = num % 10;

            Console.WriteLine($"倒序后为：{c}{b}{a}");
        }
    }
}
