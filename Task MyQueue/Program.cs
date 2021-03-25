using System;
using System.Collections.Generic;
namespace Task_MyQueue
{
    public class MyQueue
    {
        List<int> list;

        public MyQueue()
        {
            list = new List<int>();
        }

        public void AdQueue(int rect)
        {
           
            list.Add(rect);
        }

        public int GetQueue()
        {
            int tmp = list[0];
            list.RemoveAt(0);
            return tmp;
        }
        public int GetCopyQueue()
        {
            return list[0];
        }
        public void DrawQueue()
        {
            foreach (int r in list)
            {
                Console.WriteLine(r);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
