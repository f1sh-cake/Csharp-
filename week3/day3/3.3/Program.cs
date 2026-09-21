namespace _3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入一句话
            //用 foreach 统计：字母个数、数字个数、空格个数、其它字符个数
            //输出四类个数 + 总字符数（s.Length），并自校验"四类之和 == 总字符数"

            Console.Write("输入一句话:");
            string s = Console.ReadLine();

            int letters = 0;
            int digits = 0;
            int blanks = 0;
            int others = 0;

            foreach(char x in s)
            {
                if(x>='a'&&x<='z'||x>='A'&&x<='Z') letters++;
                else if(x>='0'&&x<='9') digits++;
                else if(x == ' ')blanks++;
                else others++;
            }

            Console.WriteLine($"字母个数为{letters}");
            Console.WriteLine($"数字个数为{digits}");
            Console.WriteLine($"空格个数为{blanks}");
            Console.WriteLine($"其他字符个数为{others}");
            Console.WriteLine($"总字符数为{s.Length}");

            if(s.Length == letters+digits+blanks+others)
            {
                Console.WriteLine("校验成功！");
            }
        }
    }
}
