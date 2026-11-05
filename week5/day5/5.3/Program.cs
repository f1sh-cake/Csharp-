namespace _5._3
{
    using System;

    class LibraryBook
    {
        private readonly string title;
        private readonly string author;

        private bool isBorrowed = false;
        private string borrowedBy = "";

        public string Title { get { return title; } }
        public string Author { get { return author; } }
        public bool IsBorrowed { get { return isBorrowed; } }
        public string BorrowedBy { get { return borrowedBy; } }


        public LibraryBook(string title, string author)
        {
            //书名为空，抛出异常
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("书名不能为空", nameof(title));
            }

            //作者为空，抛出异常
            if (string.IsNullOrWhiteSpace(author))
            {
                throw new ArgumentException("作者不能为空", nameof(author));
            }

            this.title = title.Trim();
            this.author = author.Trim();

        }
        public bool TryBorrow(string borrower)
        {
            //借阅者姓名为空时，返回false
            if (string.IsNullOrWhiteSpace(borrower)) return false;

            //已借出返回false
            if (isBorrowed) return false;

            borrowedBy = borrower.Trim();
            isBorrowed = true;

            return true;
        }

        public bool ReturnBook()
        {
            //没有被借出
            if (!isBorrowed) return false;

            isBorrowed = false;
            borrowedBy = "";
            return true;
        }

        public string GetSummary()
        {
            string status = "";
            if (isBorrowed) status = $"已借出,借阅人为{borrowedBy}";
            else status = "在馆";

            return $"{Title}/{status}";
        }
    }

    class Program
    {
        static void Main()
        {
            LibraryBook book = new LibraryBook("三体", "刘慈欣");

            // 1. 查看初始状态
            Console.WriteLine("===== 初始状态 =====");
            Console.WriteLine(book.GetSummary());
            Console.WriteLine($"是否借出：{book.IsBorrowed}");
            Console.WriteLine($"借阅者：{book.BorrowedBy}");

            // 2. 尝试使用空姓名借书
            Console.WriteLine("\n===== 空姓名借书 =====");
            Console.WriteLine($"借书结果：{book.TryBorrow(" ")}");
            Console.WriteLine(book.GetSummary());

            // 3. 正常借书
            Console.WriteLine("\n===== 正常借书 =====");
            Console.WriteLine($"借书结果：{book.TryBorrow("星海")}");
            Console.WriteLine(book.GetSummary());

            // 4. 已借出的书再次借阅
            Console.WriteLine("\n===== 重复借书 =====");
            Console.WriteLine($"借书结果：{book.TryBorrow("黑鸦")}");
            Console.WriteLine(book.GetSummary());

            // 5. 正常还书
            Console.WriteLine("\n===== 正常还书 =====");
            Console.WriteLine($"还书结果：{book.ReturnBook()}");
            Console.WriteLine(book.GetSummary());

            // 6. 重复还书
            Console.WriteLine("\n===== 重复还书 =====");
            Console.WriteLine($"还书结果：{book.ReturnBook()}");
            Console.WriteLine(book.GetSummary());

            // 7. 还书后再次借阅
            Console.WriteLine("\n===== 再次借书 =====");
            Console.WriteLine($"借书结果：{book.TryBorrow("黑鸦")}");
            Console.WriteLine(book.GetSummary());
        }
    }
}
