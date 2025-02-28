using System;

namespace OOP_Course.Linear_System_
{
    internal class LinearSystem : MyArray
    {

        public LinearSystem() 
        {
            Console.WriteLine("===================== Note =====================");
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("NOTE : after equal consider column add to matrix");
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("=================================================");
            Console.WriteLine();

            double[,] matrix;

            matrix = CreateArray();

            if (matrix.GetLength(0) == matrix.GetLength(1) - 1)
            {

                double[,] results = new double[3, 0];

                results = SolveSystem(matrix);

                double x = results[0, 0];
                double y = results[1, 0];
                double z = results[2, 0];
                Console.WriteLine("=========== System Solved ===========");
                Console.WriteLine("Results : ");
                Console.WriteLine($"X : {x}");
                Console.WriteLine($"Y : {y}");
                Console.WriteLine($"Z : {z}");
                Console.WriteLine("============ End ============");

            }
            else
                Console.WriteLine("......Invalid!......\nThe matrix must be square..!");
        }

        private double[,] SolveSystem(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            double[,] results = new double[rows, 1]; // 3x1

            double[,] newMatrix = new double[rows, cols - 1]; // 3x3


            double[,] equals = new double[rows, 1]; // 3x1

            HigherMatrix(matrix);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    newMatrix[i, j] =matrix[i, j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                equals[i, 0] = matrix[i, cols -1];
            }

            for(int j = newMatrix.GetLength(1) - 1;j >= 0;j--)
            {
                results[j,0] = 0;
                for (int k = rows - 1; k >= 0; k--)
                {
                    if (k == j)
                        continue;
                    results[j, 0] += -newMatrix[j, k] * results[k, 0] ; 
                }
                results[j, 0] += equals[j, 0];
                results[j, 0] /= newMatrix[j, j];
            }

            return results;
        }
    }
}
