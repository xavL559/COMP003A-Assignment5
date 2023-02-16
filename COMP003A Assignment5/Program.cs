/*
  * Author: Xavier Leftridge
  * Course: COMP-003A
  * Purpose: Code for Lecture Activity 5
  * 
 */

using System.Collections.Generic;
using System.Globalization;

namespace COMP003A_Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsoscelesTriangleBuilder('G', 6);
        }

        static void PrintSeparator()
        {
            Console.WriteLine("**************************************************");
        }

        /// <summary>
        /// This method is me calling another method into a whole different method
        /// </summary>
        /// <param name="print"></param>
        static void PrintSeparator(string print)
        {
            PrintSeparator();
            Console.WriteLine(print);
            PrintSeparator();
        }

        static void IsoscelesTriangleBuilder(char inputCharacter, int size)
        {

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(inputCharacter);
                }
                Console.Write("\n");
            }

            for (int i = size-1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(inputCharacter);
                }
                Console.Write("\n");
            }
        }
    }
}