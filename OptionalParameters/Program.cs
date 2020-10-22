using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Multiplication(554,395));// de derde parameter is nietverplicht
            Multiplication(2,3,2);
            string fullName3 = GetFullName(lastName: "Bulu", firstName: "Franck");
            Console.WriteLine(fullName3);
        }

        #region eerst
        //static int Multiplication(int numberOne, int numberTwo, int numberTrhee=3)// omdat

        //{
        //    //int result;
        //    // return numberOne * numberTwo;
        //    int result = numberOne * numberTwo *numberTrhee;
        //    return result;
        //}
        #endregion
        static void Multiplication(int numberOne, int numberTwo, int numberTrhee, ConsoleColor color = ConsoleColor.Green)// omdat
        {
            //int result;
            // return numberOne * numberTwo;
            // int result = numberOne * numberTwo * numberTrhee;
            //return result;
            Console.ForegroundColor = color;
            Console.WriteLine(numberOne*numberTwo*numberTrhee);
        }
        static string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
