using Tyuiu.ChuginNM.Sprint4.Task1.V5.Lib;

namespace Tyuiu.ChuginNM.Sprint4.Task1.V5
{
    class Program
    {
        static void Main(string[] args) 
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Чугин Н. М. | АСОиУб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Чугин Никита Максимович | АСОиУб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение                         *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[15];

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Введите {i} значение массива:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(array));
        }
    }
}