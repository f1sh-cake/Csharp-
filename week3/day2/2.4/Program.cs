namespace _2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //把练习 1 的 3x3 矩阵转置输出：t[i, j] = m[j, i]
            //进阶（可选）：用 bool 标志位判断这个矩阵是不是对称矩阵（即 m[i, j] == m[j, i] 全部成立），一旦找到不相等就 break

            //原矩阵
            int[,] m = new int[3, 3];

            //输入数据
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"第{i + 1}行，第{j + 1}列:");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //打印
            Console.WriteLine("转置后：");
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write($"{m[j, i],4}");
                }
                Console.WriteLine();
            }

            //判断是否为对称矩阵
            bool isSymmetric = true;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = i + 1; j < m.GetLength(1); j++)
                {
                    if (m[i, j] != m[j, i])
                    {
                        isSymmetric = false;
                        break;
                    }
                }
                if (!isSymmetric) break;

            }
            Console.WriteLine(isSymmetric ? "is symmetric" : "is not symmetric");

        }
    }
}


