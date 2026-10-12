namespace _6._3
{
    internal class Program
    {
        //字符串反转 + 回文判断：`ReverseText` 与 `IsPalindrome`，用带空格和大写的句子测回文

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

        static bool IsPalindrome(string s)
        {
            s = s.Replace(" ", "").ToLower();
            return (ReverseText(s) == s);
        }

        static void Main(string[] args)
        {
            Console.Write("输入一个英文句子：");
            string s = Console.ReadLine();
            if (IsPalindrome(s)) Console.WriteLine("是回文");
            else Console.WriteLine("不是回文");
        }
    }
}
