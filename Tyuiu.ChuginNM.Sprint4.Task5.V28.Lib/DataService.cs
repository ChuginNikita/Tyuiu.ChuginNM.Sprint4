using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChuginNM.Sprint4.Task5.V28.Lib
{
    public class DataService : ISprint4Task5V28
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = (matrix[i, j] < 0) ? 0 : matrix[i, j];
                }
            }

            return matrix;
        }
    }
}
