namespace _6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //不用第三个变量交换两个数
            Console.Write("enter first num:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("enter second num:");
            int num2 = int.Parse(Console.ReadLine());

            num1 = num1 - num2;
            num2 = num2 + num1;
            num1 = num2 - num1;

            Console.WriteLine($"after swapping:num1:{num1},num2:{num2}");
        }
    }
}
