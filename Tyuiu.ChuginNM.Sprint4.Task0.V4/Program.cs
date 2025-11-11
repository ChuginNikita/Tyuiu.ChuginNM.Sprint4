using Tyuiu.ChuginNM.Sprint4.Task0.V4.Lib;

namespace Tyuiu.ChuginNM.Sprint4.Task0.V4
{
    class Program
    {
        static void Main(string[] args) 
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Чугин Н. М. | АСОиУб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Чугин Никита Максимович | АСОиУб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* значениями от 0 до 9, подсчитать произведение четных элементов массива. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* {5, 3, 7, 1, 3, 9, 8, 7, 9, 4}                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");
            int[] array = [5, 3, 7, 1, 3, 9, 8, 7, 9, 4];
            ds.GetMultEvenArrEl(array);
        }
    }

}