using System;

namespace kurs_string_tasks_5_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку в которой хотите посчитать количество гласных");
            string check = Console.ReadLine();
            char[] arr = { 'о', 'а', 'й', 'у', 'е', 'э', 'я', 'и', 'ю', 'ы' };
            int count=0;
            for (int i = 0; i < check.Length; i++)
            {
                    for (int j = 0; j <arr.Length; j++)
                    {
                        if(arr[j]==check[i])
                        {
                            count++;
                        }
                    }
                
            }
            Console.WriteLine("количество гласных букв равно = "+count);

        }
    }
}
