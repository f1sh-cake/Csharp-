namespace _6._3
{
    internal class Program
    {
        // 字符串反转
        static string ReverseText(string s)
        {
            char[] chars = s.ToCharArray();

            int i = 0;
            int j = chars.Length - 1;

            while (i < j)
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;

                i++;
                j--;
            }

            return new string(chars);
        }

        // 回文判断：发现不同立即返回 false
        static bool IsPalindrome(string s)
        {
            s = s.Replace(" ", "").ToLower();

            int i = 0;
            int j = s.Length - 1;

            while (i < j)
            {
                if (s[i] != s[j])
                    return false;

                i++;
                j--;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("输入一个英文句子：");
            string s = Console.ReadLine();

            if (IsPalindrome(s))
                Console.WriteLine("是回文");
            else
                Console.WriteLine("不是回文");
        }
    }
}