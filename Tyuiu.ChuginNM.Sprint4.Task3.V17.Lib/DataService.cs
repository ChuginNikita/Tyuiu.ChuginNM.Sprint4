using System.Diagnostics.CodeAnalysis;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChuginNM.Sprint4.Task3.V17.Lib
{
    public class DataService : ISprint4Task3V17
    {
        public int Calculate(int[,] array)
        {
            int sum = 0;

            sum = array[3, 0] + array[3, 1];

            return sum;
        }
    }
}
