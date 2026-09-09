namespace _5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a word:");
            string s = Console.ReadLine();

            Console.WriteLine($"swapping the first and the last is {s[s.Length - 1]}{s.Substring(1, s.Length - 2)}{s[0]}");
        }
    }
}
