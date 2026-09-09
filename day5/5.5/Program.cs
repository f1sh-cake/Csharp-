namespace _5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a sentence:");
            string s = Console.ReadLine();
            string[] sp = s.Split(' ');
            Console.WriteLine($"number of words is {sp.Length}");
        }
    }
}
