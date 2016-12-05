using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, cols;
            
            #region header
            var psh = "+----------------------------------------------+\n" +
            "|                                              |\n" +
            "|    XXX                 X                     |\n" +
            "|    XX XXXX              X                    |\n" +
            "|    XX    XX            XX                    |\n" +
            "|    X     XX           XX                     |\n" +
            "|    X     XX  XXX       X                     |\n" +
            "|    XX    XX  XX XXX     X XXXXXXX            |\n" +
            "|    XXXXXXX   XX         XXX     XX           |\n" +
            "|    X          XXXX      XX       X           |\n" +
            "|    X             XXX    XX       X           |\n" +
            "|    X         X     XX    X       X           |\n" +
            "|    X         XXXXXXXX   XX       X   X X X X |\n" +
            "|   X                                          |\n" +
            "|                                              |\n" +
            "+ ---------------------------------------------+" +
            "";
            var wylat = @"
                 ||                  
  ....  ... ... ...    ... .   ...   
.|...||  '|..'   ||   || ||  .|  '|. 
||        .|.    ||    |''   ||   || 
 '|...' .|  ||. .||.  '||||.  '|..|' 
                     .|....'         
                                     
            ";
            #endregion
            Console.ForegroundColor = ConsoleColor.Yellow ;
            Console.WriteLine(psh);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(wylat);
            #region Matrix 1 input
            //Matrix1
            Console.WriteLine("MATRIX 1!");
            Console.WriteLine("How many rows would you like?");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("How many columns would you like?");
            cols = int.Parse(Console.ReadLine());
            int[,] mat1 =new int[rows,cols]; //https://msdn.microsoft.com/en-us/library/2yd9wwz4.aspx 2D array init.
            for (int i=0; i<rows; i++)
            {
                for (int j=0; j<cols; j++)
                {
                    Console.WriteLine("Please enter the value of element at {0}, {1}", i,j);
                    mat1[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is as follows: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write( mat1[i,j] + " ");
                }
                Console.WriteLine();
            }
            #endregion

            #region Matrix 2 input
            //Matrix 2
            Console.WriteLine("MATRIX 2!");

            //Console.WriteLine("How many rows would you like?");
            //rows = int.Parse(Console.ReadLine());
            //Console.WriteLine("How many columns would you like?");
            //cols = int.Parse(Console.ReadLine());
            int[,] mat2 = new int[rows, cols]; //https://msdn.microsoft.com/en-us/library/2yd9wwz4.aspx 2D array init.
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
            #endregion

            #region Addition & Output
            //Addition & Output to
            //Matrix 3
            Console.WriteLine("MATRIX 3 = MATRIX 1 + MATRIX 2!");
            int[,] mat3 = new int[rows, cols]; //https://msdn.microsoft.com/en-us/library/2yd9wwz4.aspx 2D array init.
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    mat3[i, j] = mat1[i, j]+ mat2[i, j];
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
            #endregion
        }
    }
}
