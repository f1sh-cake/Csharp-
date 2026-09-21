using System.Text;

namespace _3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入一句话和位移量 shift（校验 1–25）
            //每个字符：小写字母用(char)('a' + (c - 'a' + shift) % 26)，大写同理用 'A'，其它字符（空格、标点、中文）原样保留
            //用 StringBuilder 拼接结果并输出
            //进阶：再写解密（位移量取 26 - shift），验证加密再解密能还原

            Console.Write("输入一句话：");
            string s = Console.ReadLine();

            bool isRight = true;
            int shift = 0;

            do
            {
                Console.Write("请输入偏移量：");
                shift = int.Parse(Console.ReadLine());
                if (shift < 1 || shift > 25)
                {
                    Console.Write("输入错误，");
                    isRight = false;
                }
                else isRight = true;
            } while (!isRight);


            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            foreach (char x in s)
            {
                if (x >= 'a' && x <= 'z')
                {
                    char newx = (char)('a' + (x - 'a' + shift) % 26);
                    sb1.Append(newx);
                }
                else if (x >= 'A' && x <= 'Z')
                {
                    char newx = (char)('A' + (x - 'A' + shift) % 26);
                    sb1.Append(newx);
                }
                else sb1.Append(x);
            }

            string result = sb1.ToString();

            Console.WriteLine($"加密后为{result}");

            //解密
            foreach (char x in result)
            {
                if (x >= 'a' && x <= 'z')
                {
                    char newx = (char)('a' + (x - 'a' + 26 - shift) % 26);
                    sb2.Append(newx);
                }
                else if (x >= 'A' && x <= 'Z')
                {
                    char newx = (char)('A' + (x - 'A' + 26 - shift) % 26);
                    sb2.Append(newx);
                }
                else sb2.Append(x);
            }

            string origin = sb2.ToString();
            Console.WriteLine($"还原后为{origin}");
            if (origin == s)
            {
                Console.WriteLine("成功");
            }
            else Console.WriteLine("失败");
        }
    }
}
