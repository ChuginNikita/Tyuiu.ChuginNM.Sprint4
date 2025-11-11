using System.Diagnostics.CodeAnalysis;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChuginNM.Sprint4.Task3.V17.Lib
{
    public class DataService : ISprint4Task3V17
    {
        public int Calculate(int[,] array)
        {
            int sum = 0;

            sum = array[0, 3] + array[1, 3] + array[2, 3] + array[3, 3] + array[4, 3];

            return sum;
        }
    }
}
