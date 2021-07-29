using System;
using System.Collections.Generic;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание списка "num"
            List<int> num = new List<int> { 6, 4, 5, 1, 8, 9, 7, 2, 3, 6, 4 };
            //Удаление четных элементов
            for (int i = 0; i < num.Count; i++)
            {
                int check = num[i];
                if (check % 2 != 0)
                {
                    num.RemoveAt(i);
                    i = i - 1;
                }

            }
            //Сортировка по возрастанию
            for (int i = 0; i < num.Count - 1; i++)
            {
                for (int j = 0; j < num.Count - i - 1; j++)
                {
                    if (num[j + 1] > num[j])
                    {
                        int temp = num[j + 1];
                        num[j + 1] = num[j];
                        num[j] = temp;
                    }
                }
            }
            //Вывод результат
            for (int i = 0; i < num.Count; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}
