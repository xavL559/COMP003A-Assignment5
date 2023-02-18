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
            PrintSeparator("Triangle");
            string inputCharacter;
            Console.Write("Enter a single character: ");
            inputCharacter= Console.ReadLine();
            char person = Convert.ToChar(inputCharacter);

            string size;
            Console.Write("Enter a positive whole number: ");
            size = Console.ReadLine();
            int number = Convert.ToInt32(size);   
            
            IsoscelesTriangleBuilder(person, number);
        }

        static void PrintSeparator()
        {
            Console.WriteLine("**************************************************");
        }

        /// <summary>
        /// This method is me calling another method into a whole different method
        /// </summary>
        /// <param name="print"></param>
        static void PrintSeparator(string Triangle)
        {
            PrintSeparator();
            Console.WriteLine(Triangle);
            PrintSeparator();
        }

        /// <summary>
        /// This part of the code is me looping a user input triangle and what the user inputs is the character of the triangle and how many rows it is
        /// </summary>
        /// <param name="inputCharacter"></param>
        /// <param name="size"></param>
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

        /// <summary>
        /// This method is subtracting the current year "2023" minus the year my character was born to calculate their age.
        /// </summary>
        /// <param name="year"></param>
        /// <returns>This returns the characters age, how old they are</returns>
        static int AgeCalculaotr(int year)
        {
            return 2023 - year;
        }

        /// <summary>
        /// This method is me getting the characters name and year they were born!
        /// </summary>
        /// <param name="name"></param>
        /// <param name="year"></param>
        static void CharacterInfo(string name , int year) 
        {
            Console.WriteLine($"{name}, turns {year} this year!");
        }

    }
}