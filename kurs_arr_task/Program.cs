using System;

namespace kurs_arr_task
{
    class Program
    {
        static void Main()
        {
            int[] arrSortTest = new int[6];
            Console.WriteLine("Введите значение массива int на 6 значений");
            for (int i = 0; i < arrSortTest.Length; i++)
            {
                    arrSortTest[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-----------Печать массива до сортировки---------");
            foreach (int a in arrSortTest)
            {
                Console.WriteLine(a);
            }
            Array.Sort(arrSortTest);
            Array.Reverse(arrSortTest);
            Console.WriteLine("-----------Печать массива после сортировки---------");
            foreach (int a in arrSortTest)
            {
                Console.WriteLine(a);
            }
        }
    }
}
