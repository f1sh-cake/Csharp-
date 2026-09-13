namespace _5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a sentence with an odd number of letters:");
            string s = Console.ReadLine();
            Console.WriteLine($"the middle letter is {s[s.Length / 2]}");
        }
    }
}
