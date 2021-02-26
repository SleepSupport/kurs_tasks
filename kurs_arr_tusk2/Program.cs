using System;

namespace kurs_arr_tusk2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrMaxSearch = new int[3, 3];
            int maxElement;
            Console.WriteLine("Выберите вариант инициализации массива:\n1-Случайные числа (рандом от 0 до 100)\n2-Ввод вручную с клавиатуры");

            byte choose = Convert.ToByte(Console.ReadLine());
            if(choose==1)
            {
                Random r = new Random();
                for (int i = 0; i < arrMaxSearch.GetLength(0); i++)
                {
                    for (int j = 0; j < arrMaxSearch.GetLength(1); j++)
                    {
                        arrMaxSearch[i, j] = r.Next(0, 101);
                    }
                }
            }
            if(choose==2)
            {
                for (int i = 0; i < arrMaxSearch.GetLength(0); i++)
                {
                    for (int j = 0; j < arrMaxSearch.GetLength(1); j++)
                    {

                        arrMaxSearch[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            Console.WriteLine("----------------Печать массива----------------");
            for (int i = 0; i < arrMaxSearch.GetLength(0); i++)
            {
                for (int j = 0; j < arrMaxSearch.GetLength(1); j++)
                {

                    Console.Write(arrMaxSearch[i, j]+"\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arrMaxSearch.GetLength(0); i++)
            {
                maxElement = arrMaxSearch[i,0];
                for (int j = 0; j < arrMaxSearch.GetLength(1); j++)
                {

                    if (maxElement<arrMaxSearch[i,j])
                    {
                        maxElement = arrMaxSearch[i, j];
                    }
                }
                Console.WriteLine($"максимальный элемент {i} строки: {maxElement}");
            }
        }
    }
}
