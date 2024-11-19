//Write a program in C# Sharp for addition of two Matrices of same size.

namespace CCAD16_Assignment3_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the size of the matrix (less than 5): ");
            int matrixSize = Convert.ToInt32(Console.ReadLine());

            //edge case
            if (matrixSize <= 0 || matrixSize > 5)
            {
                Console.WriteLine("Please enter a number greater than 0 and less than 5");
                return;
            }

            //initializing matrices
            int[,] firstMatrix = new int[matrixSize, matrixSize];
            int[,] secondMatrix = new int[matrixSize, matrixSize];
            int[,] addedMatrix = new int[matrixSize, matrixSize];

            //first matrix loop and element input
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write($"element - [{i}][{j}]");
                    firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //second matrix loop and element input
            Console.WriteLine("Input elements in the second matrix:");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write($"element - [{i}][{j}] : ");
                    secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //added matrix loop while adding matrix together
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    addedMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            //next few are printing out the matrices
            Console.WriteLine("\nThe First matrix is:");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write(firstMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nThe Second matrix is:");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write(secondMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nThe Addition of two matrices is:");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write(addedMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
