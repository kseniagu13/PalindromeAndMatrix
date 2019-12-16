using System;


namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix =
            {
                new int[] {1,2,3}, //row 0
                new int[] {4,5,6}, //row 1
                new int[] {7,8,9}, //row 2
            };

            Console.WriteLine(matrix[1][1]); //vastus 5

            //Main diagonal 1,5,9
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.Write(matrix[i][i]); //159  [0][0], [1,1], [2,2]
            }
            Console.WriteLine();

            //Secondary diagonal 3, 5, 7

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.Write(matrix[i][matrix.Length - 1 - i]); //357  [0][2], [1][1], [2][0]
            }
            Console.WriteLine();


            //Get diagonals: a) 7,5,3 [2][0], [1][1], [0][2]
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.Write(matrix[matrix.Length - 1 - i][i]);
            }
            Console.WriteLine();

            //Get diagonals b) 9, 5, 1 [2][2], [1][1], [0][0]

            for (int i = matrix.Length - 1; i >=0; i--)
            {
                Console.Write(matrix[i][i]);
            }
            //951 teistmoodi
            Console.WriteLine();

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.Write(matrix[matrix.Length - 1 - i][matrix.Length - 1 - i]);
            }

            
        }
    


    } 
}
