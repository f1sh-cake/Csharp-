using System.Reflection.Metadata;

namespace _5._2
{
    internal class Program
    {
        class BankAccount
        {
            private readonly string accountNum="";
            public string AccountNum
            {
                get
                {
                    return accountNum;
                }
            }

            private decimal balance;
            public decimal Balance
            {
                get
                {
                    return balance;
                }
                private set
                {
                    if(value<0m)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value),"余额不可能为负数");
                    }
                    balance = value;
                }
            }
            
            public BankAccount(string accountNum,decimal balance)
            {
                if(string.IsNullOrWhiteSpace(accountNum))
                {
                    throw new ArgumentException("账号不能为空", nameof(accountNum));
                }
                this.accountNum = accountNum.Trim();

                Balance = balance;
            }

            public void Deposit(decimal money)
            {
                if(money<=0m)
                {
                    throw new ArgumentOutOfRangeException(nameof(money), "存款金额必须大于0");
                }
                Balance += money;
            }

            public bool TryWithdraw(decimal money)
            {
                if(money <=0m)
                {
                    throw new ArgumentOutOfRangeException(nameof(money),"取款金额必须为正数");
                }
                if(money >Balance)
                {
                    Console.WriteLine("余额不足");
                    return false;
                }
                Balance -= money;
                return true;
            }

            public void ShowBalance()
            {
                Console.WriteLine($"当前余额为{Balance}元");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
