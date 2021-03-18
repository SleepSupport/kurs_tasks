using System;

namespace kurs_arr_tasks_5_1
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[8];
            int searchLast=0;
            bool check=false;
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-50, 50);
                if(arr[i]<0)
                {
                    check = true;
                    searchLast = i;
                }
            }
            if (check)
            {
                Console.WriteLine($"последний отрицательный элемент массива имеет индекс {searchLast} и значение {arr[searchLast]}");
            }
            else
            {
                Console.WriteLine("нету отрицательных элементов");
            }
        }
    }
}
