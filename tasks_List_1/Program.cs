using System;
using System.Collections.Generic;
using System.Linq;
namespace tasks_List_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test = new List<int>() { 14, 1234, 232, 414 };
            List<int> test1 = new List<int>();
            foreach (int i in test)
            {
                test1.Add(i % 10);
            }
            foreach (int i in test1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
