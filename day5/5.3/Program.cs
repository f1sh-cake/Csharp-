namespace _5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a word:");
            string word = Console.ReadLine();

            Console.WriteLine($"前三个字符为{word.Substring(0,3)}");
        }
    }
}
