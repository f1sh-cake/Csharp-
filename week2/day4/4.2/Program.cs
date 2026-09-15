namespace _4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //用 do-while 做「输入密码，错误则重试」的程序（自己预设一个正确密码）。
            string correctPassword = "123852";
            string inputPassword;

            do
            {
                Console.Write("enter the password:");
                inputPassword = Console.ReadLine();
                if (inputPassword != correctPassword)
                    Console.WriteLine("输入错误！");
            } while (inputPassword != correctPassword);
            Console.WriteLine("输入正确！");
        }
    }
}
