using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Course
{
    internal class MyArray
    {
        public double[,] CreateArray()
        {
            Console.Write("Enter number of rows : ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of cols : ");
            int cols = int.Parse(Console.ReadLine());

            Console.WriteLine("============================================");
            Console.WriteLine("========== input values to matrix ==========");
            Console.WriteLine("============================================");

            double[,] matrix = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"matrix({i + 1},{j + 1}): ");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            return matrix;
        }

        public void PrintArray(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }        
        }

        public double DetermineHigherMatrix33(double[,] matrix)
        {
            // إذا كانت المصفوفة مثلثية (علوية أو سفلية)، فإن المحدد هو حاصل ضرب العناصر القطرية.
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            double deterimine =1;
   
            for (int i = 0; i < rows; i++)
            {
                    deterimine *= matrix[i, i];
            }
                
            return deterimine;
        }
        public double Deterimine22(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            double detrimin = matrix[0,0] * matrix[1,1] - matrix[0,1] * matrix[1,0];
            return detrimin;
        }
        ////////////////// Error !! ///////////////////
        //public double[,] adjoint(double[,] matrix)
        //{
        //    int rows = matrix.GetLength(0);

        //    double[,] adjMatrix =(double[,])matrix.Clone();

        //    for (int i = 0;i < rows;i++)
        //    {
        //        for(int j = 0; j < rows;j++)
        //        {
        //            adjMatrix[i,i] = matrix[i,j];
        //        }
        //    }

        //    return adjMatrix;
        //}

        //public double[,] InverseMatrix33(double[,] matrix)
        //{
        //    int rows = matrix.GetLength(0);

        //    double[,] inverseMatrix = (double[,])matrix.Clone();
        //    HigherMatrix(matrix);

        //    double determine = DetermineHigherMatrix33(matrix);

        //    matrix = adjoint(matrix);

        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < rows; j++)
        //        {
        //            inverseMatrix[i, j] = matrix[i, j] / determine;
        //        }
        //    }
        //    matrix = inverseMatrix;
        //    return matrix;
        //}

        public double[,] HigherMatrix(double[,] matrix)
        {
            double alpha;
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);


            for (int i = 0; i < rows; i++)
            {

                for (int j = i + 1; j < cols - 1; j++)
                {
                    if (matrix[i, i] == 0)  // Avoid division by zero
                        continue;

                    alpha = -matrix[j, i] / matrix[i, i];

                    for (int k = 0; k < cols; k++)
                        matrix[j, k] += alpha * matrix[i, k];
                }

            }
            return matrix;
        }
    }
}
