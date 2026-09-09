namespace _5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a sentense with ' ':");
            string s = Console.ReadLine();
            string[] sp = s.Split(' ');
            Console.WriteLine($"first is {sp[0]}");
            Console.WriteLine($"last is {sp[sp.Length-1]}");
        }
    }
}
