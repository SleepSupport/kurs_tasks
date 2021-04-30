using System;
using System.Linq;
using System.Collections.Generic;
namespace exDelegate
{
    class Program
    {
        delegate double Average(double[] numbers);
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            double[] arr = new double[] { 1, 4, 34, 34, 34, 432, 34, 54, 26, 5 };
            double[] arr2 = new double[] { 5, 235, 4354, 44, 14, 1, 34, 1, 26, 5 };
            
         
        }
        private static double AverageArr(double[] numbers)
        {
            double average = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                average += numbers[i];
            }
            return (average / numbers.Length);
        }
        private static double AverageLinq(double[] numbers)
        {
            
            return numbers.Average();
        }
    }
}
