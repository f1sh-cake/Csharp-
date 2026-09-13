namespace _1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //输入用户名和密码，和预设的用户名、密码比较，输出"登录成功"或"登录失败"。
            string userName = "fishcake";
            string password = "123852";
            
            Console.Write("enter the userName:");
            string userName1 = Console.ReadLine();
            Console.Write("enter the password:");
            string password1 = Console.ReadLine();

            if (userName1 == userName && password1 == password) Console.WriteLine("登陆成功");
            else Console.WriteLine("登录失败");
        }
    }
}
