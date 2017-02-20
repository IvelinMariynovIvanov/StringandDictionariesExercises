using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringandDictionariesExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // string input = Console.ReadLine();
            string arr = Console.ReadLine();

            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
    }



}
