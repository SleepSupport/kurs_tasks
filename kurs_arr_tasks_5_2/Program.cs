using System;

namespace kurs_arr_tasks_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[10,10];
            int max,index;
            Random r = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(1, 100);
                    Console.Write(arr[i,j]+"\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                index = 0;
                max = arr[i, 0];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max<arr[i,j])
                    {
                        max = arr[i, j];
                        index = j;
                    }
                  
                }
                            if(index != arr.GetLength(1)-1)
                    {
                        arr[i, index + 1] = 0;
                    }
              
            }
            Console.WriteLine("Печать нового массива");
            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                   
                    Console.Write(arr[i, j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
