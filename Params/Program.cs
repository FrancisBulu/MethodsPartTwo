using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(2, 4);
            Sum(5, 8, 2);
            Sum(9, 1, 25, 6);
            Sum(11, 55, 60, 54, 987, 321);
        }

        #region multiple methodes
        //static void Sum(int number, int numberTwo)
        //{
        //    Console.WriteLine(number+numberTwo);
        //}
        //static void Sum(int number, int numberTwo, int thirdNumber)
        //{
        //    Console.WriteLine(number + numberTwo + thirdNumber);
        //}
        //static void Sum(int number, int numberTwo, int thirdNumber, int numberFour)
        //{
        //    Console.WriteLine(number + numberTwo + thirdNumber + numberFour);
        //}
        #endregion // niet de goeie manier

        static  void Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int item in numbers)
            {
                sum += item;
                Console.WriteLine(item);
            }
        }
    }
}

