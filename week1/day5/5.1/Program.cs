namespace _5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a word:");
            string s = Console.ReadLine();
            
            int length = s.Length;
            char front = s[0];
            char last = s[s.Length - 1];

            Console.WriteLine($"长度为{length}");
            Console.WriteLine($"首字母为{front}");
            Console.WriteLine($"尾字母为{last}");
        }
    }
}
