using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork_6
{
    
        class Program
        {
        public Dictionary<int,int> GetNumbersFrequancy(List<int> numbers)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach (var item in numbers)
            {
                if (dictionary.ContainsKey(item))
                {
                    dictionary[item]++;
                    
                }
                else
                {
                    dictionary.Add(item, 1);
                }
            }
            return dictionary;
        }
            static void Main(string[] args)
            {
                
                
            }

        }
    
}
