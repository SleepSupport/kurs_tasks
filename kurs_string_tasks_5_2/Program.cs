using System;

namespace kurs_string_tasks_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для замены букв");
            string tets = Console.ReadLine();
           tets= tets.Replace('а', 'А');
          
            Console.WriteLine("новая строка: "+ tets);
        }
    }
}
