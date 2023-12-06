using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int sizearr = Convert.ToInt32(Console.ReadLine()); // ввод пользовательского числа и конвертация в тип данных int из string
            int[] nums = new int[sizearr]; // создание массива размерностью которое указал пользователь

            int curRepeat = 0; // переменная для счета текущих повторений
            int maxRepeat = 0; // переменная для счета наибольшее число повторений
            int valueRepeat = 0; // переменная для записи наиболее часто встречающегося числа
            int omoreValue = 0; // переменная для записи наиболее часто встречающегося числа

            for (int i = 1; i < sizearr+1; i++) // цикл ввода чисел в массив
            {
                Console.Write("Введите " + i + " элемент массива: ");
                nums[i-1] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int el in nums) // ввывод массива в консоль для удобства
            {
                Console.Write(el + " ");
            }

            for (int i = 0; i < sizearr; i++) // цикл проверки каждого числа со следующим число в массиве
            {
                for (int j = i; j < sizearr; j++)
                {
                    if (nums[i] == nums[j]) // если элемент i из первого цикла совпадает с числом со второго цикла счетчик увеличивается на 1
                    {
                        curRepeat++; // счетчик текущих повторений
                    }
                }            

                if (curRepeat > maxRepeat) // если счетчик текущих повторений больше максимального счетчика повторений, то в данном блоке кода происходит перезапись
                {
                    maxRepeat = curRepeat; // перезапись счетчика макс. повторений
                    valueRepeat = nums[i]; // сохранение повторяющего числа
                   
                }
                
                if (maxRepeat == curRepeat) // если у счетчика максимальных повторений столько же повторений как у счетчика текущих повторений
                {
                    omoreValue = nums[i]; // сохранение повторяющего числа
                }
                curRepeat = 0; // обнуление счетчика для перехода на проверку след. числа в первом цикле

            }
            if ((valueRepeat < omoreValue) & (maxRepeat != 1)) Console.WriteLine("\nНаиболее встречающееся число " + valueRepeat); // проверка на мин число из 2-ух повторяющихся
            else if ((omoreValue < valueRepeat) & (omoreValue != 0)) Console.WriteLine("\nНаиболее встречающееся число " + omoreValue);
            else if (maxRepeat == 1) Console.WriteLine("\nПовторяющихся чисел нет!"); 
            else Console.WriteLine("\nНаиболее встречающееся число " + valueRepeat); // вывод числа если в массиве одно повторяющее число


        }
    }
}
