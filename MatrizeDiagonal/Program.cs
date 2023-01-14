using System;

namespace MatrizeDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(numbers[j]);
                }
            }

            Console.Write("Main diagonal: ");

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();
            Console.Write("Negative nubers = ");

            int negative = 0;

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (mat[i, j] < 0)
                    {
                        negative++;
                    }
                }
            }

            Console.Write(negative);
        }
    }
}