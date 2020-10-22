using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4 };
            show(array);
        }
       
        static void show(int[] x)
        {
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
            CopyArray(x);
        }
        static void CopyArray(int[] c)
        {
            Console.WriteLine("*****copiedArray*****");
            int[] copiedArray = { 0, 0, 0, 0, };
            for (int i = 0; i < c.Length; i++)
            {
                copiedArray[i] = c[i];
                Console.WriteLine(copiedArray[i]);
            }
            showCopiedArray(copiedArray);
        }
        static void showCopiedArray(int[] copiedArray)
        {
            Console.WriteLine("copied array");
            foreach (var item in copiedArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
