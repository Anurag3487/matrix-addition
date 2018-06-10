using System;

namespace MatrixAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixAddition();
        }
        public static void MatrixAddition()
        {
            Console.WriteLine("Please enter the number of rows and columns of the matrix:\n");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int[,] A = new int[10, 10];
            Console.WriteLine("Enter the first matrix");
            for(int i=0; i<x; i++)
            {
                for(int j=0;j<y;j++)
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The first matrix is:\n");
            for(int a=0;a<x;a++)
            {
                for(int b=0;b<y;b++)
                {
                    Console.Write(A[a, b] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Enter the second matrix");
            int[,] B = new int[10, 10];
            for(int i=0;i<x;i++)
            {
                for(int j=0;j<y;j++)
                {
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The second matrix is:\n");
            for(int a=0;a<x;a++)
            {
                for(int b=0;b<y;b++)
                {
                    Console.Write(B[a, b] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Addition of the matrices is:\n");
            int[,] C = new int[10, 10];
            for(int i=0;i<x;i++)
            {
                for(int j=0;j<y;j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(C[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
