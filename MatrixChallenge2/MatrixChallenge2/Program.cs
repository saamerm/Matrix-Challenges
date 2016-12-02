using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixChallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, cols;
            //Matrix1
            Console.WriteLine("MATRIX 1!");
            Console.WriteLine("How many rows would you like?");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("How many columns would you like?");
            cols = int.Parse(Console.ReadLine());
            float[,] mat1 = new float[rows, cols]; //https://msdn.microsoft.com/en-us/library/2yd9wwz4.aspx 2D array init.
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine("Please enter the value of element at {0}, {1}", i, j);
                    mat1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is as follows: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(mat1[i, j] + " ");
                }
                Console.WriteLine();
            }
            //Matrix 2
            Console.WriteLine("MATRIX 2!");

            //Console.WriteLine("How many rows would you like?");
            //rows = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many columns would you like?");
            //cols = int.Parse(Console.ReadLine());
            float[,] mat2 = new float[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine("Please enter the value of element at {0}, {1}", i, j);
                    mat2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is as follows: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(mat2[i, j] + " ");
                }
                Console.WriteLine();
            }
            //Addition
            //Matrix 3
            Console.WriteLine("MATRIX 3 = MATRIX 1 + MATRIX 2!");
            float[,] mat3 = new float[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    mat3[i, j] = mat1[i, j] + mat2[i, j];
                }
            }
            Console.WriteLine("The matrix is as follows: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(mat3[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
