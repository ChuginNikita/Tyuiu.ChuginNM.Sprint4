using Tyuiu.ChuginNM.Sprint4.Task2.V26.Lib;

namespace Tyuiu.ChuginNM.Sprint4.Task2.V26 {
    class Program
    {
        public static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Чугин Н. М. | АСОиУб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Чугин Никита Максимович | АСОиУб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение                         *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            Random ran = new Random();
            int[] array = new int[14];
            for (int i = 0; i < 14; i++)
            {
                array.Append(ran.Next(1, 8));
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(array));
        }
    }

}