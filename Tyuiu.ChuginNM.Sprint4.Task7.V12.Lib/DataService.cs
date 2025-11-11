using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChuginNM.Sprint4.Task7.V12.Lib
{
    public class DataService : ISprint4Task7V12
    {
        public int Calculate(int n, int m, string value)
        { 
            int[,] array = new int[n, m];


            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }

            int res = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        res += array[i, j];
                    }
                }
            }

            return res;
        }
    }
}
