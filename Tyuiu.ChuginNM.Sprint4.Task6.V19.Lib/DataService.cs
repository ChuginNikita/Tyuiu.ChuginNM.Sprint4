using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChuginNM.Sprint4.Task6.V19.Lib
{
    public class DataService : ISprint4Task6V19
    {
        public int Calculate(string[] array)
        {
            int res = 0;
            foreach (var a in array)
            {
                if (a.Length > 5) { res++; }
            }
            return res;
        }
    }
}
