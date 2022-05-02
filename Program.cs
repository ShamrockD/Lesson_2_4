using System;

namespace Lesson_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lesson 2.4
            // 4. Последовательность. 2 балла + 1 возможный доп.
            // Нужно написать программу(использую циклы, пояснить выбор вашего цикла), чтобы она выводила следующую последовательность 7 14 21 28 35 42 49 56 63 70 77 84 91 98


            int firstNumber = 7;
            for(int i = 0; firstNumber < 100; i++)
            {
                Console.WriteLine(firstNumber);
                firstNumber += 7;
                
            }

            // Выбрал данный тип цикла как самый удобный и простой для меня в данной ситуации.
        }
    }
}
