using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            //read matrix size
            long matrixSize = long.Parse(Console.ReadLine());
            //create matrix
            long[,] matrix = new long[matrixSize, matrixSize];

            //read the input - N(matrixsize) lines
            for (long rows = 0; rows < matrixSize; rows++)
            {
                var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                //add array values to the matrix
                for (long cols = 0; cols < matrixSize; cols++)
                {
                    matrix[rows, cols] = input[cols];
                }
                //Calculate diagonals
            }
            long leftDiagonal = 0;
            long rightDiagonal = 0;

            for (long cols = 0; cols < matrixSize; cols++)
            {
                leftDiagonal += matrix[cols, cols];
                rightDiagonal += matrix[cols, matrixSize - cols - 1];
                //         Console.WriteLine("[{0}, {1}] = {2}", cols, matrixSize-cols-1, matrix[cols][matrixSize - cols - 1]);
            }

            var result = Math.Abs(leftDiagonal - rightDiagonal);
            Console.WriteLine(result);
        }
    }
}
