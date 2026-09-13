namespace _5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a word:");
            string word = Console.ReadLine();

            Console.WriteLine($"to upper is {word.ToUpper()}");
            Console.WriteLine($"to lower is {word.ToLower()}");
        }
    }
}
