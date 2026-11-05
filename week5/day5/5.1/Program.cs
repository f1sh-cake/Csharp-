namespace _5._1
{
    internal class Program
    {
        class Student
        {
            private readonly int studentId;
            public int StudentId
            {
                get
                {
                    return studentId;
                }
            }
            private string name = "";
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException(nameof(value), "姓名不能为空");
                    }
                    name = value.Trim();
                }
            }

            private int score;
            public int Score
            {
                get
                {
                    return score;
                }
                set
                {
                    if (value > 100 || value < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(value), "分数0-100内");
                    }
                    score = value;
                }
            }

            public bool IsPass
            {
                get
                {
                    return score >= 60;
                }
            }

            public string GetGrade()
            {
                if (score >= 90) return "A";
                else if (score >= 80) return "B";
                else if (score >= 70) return "C";
                else if (score >= 60) return "D";
                else return "F";
            }

            public Student(int studentId, string name, int score)
            {
                this.studentId = studentId;
                Name = name;
                Score = score;
            }
        }

        static void Main(string[] args)
        {
            Student stu = new Student(1001, "  张三  ", 95);

            Console.WriteLine(stu.StudentId);
            Console.WriteLine(stu.Name);
            Console.WriteLine(stu.Score);
            Console.WriteLine(stu.IsPass);
            Console.WriteLine(stu.GetGrade());
        }
    }
}
