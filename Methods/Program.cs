﻿using System;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            //1.Write a code that by given name prints on the console "Hello, <name>!"
            //(for example: "Hello, Peter!").
            Console.Write("EX1: Enter your name: ");
            string name = Console.ReadLine();
            PrintHelloAnyBody(name);
            EndOfScript();

            //2.Create a method GetMax() with two integer(int) parameters, that
            //returns maximal of the two numbers. Write a program that reads three
            //numbers from the console and prints the biggest of them. Use the
            //GetMax() method you just created. Write a test program that validates
            //that the methods works correctly.
            Console.WriteLine("EX2: Enter 3 numbers, I will return bigest one.");
            Console.Write("Enter numer 1: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Enter numer 2: ");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.Write("Enter numer 3: ");
            int numberThree = int.Parse(Console.ReadLine());
            int biggestOne = numberOne;
            biggestOne = GetMax(numberOne, numberTwo);
            biggestOne = GetMax(biggestOne, numberThree);

            if (biggestOne >= numberOne && biggestOne >= numberTwo && biggestOne >= numberThree)
            {
                Console.WriteLine("The biggest number is " + biggestOne);
            }
            else
            {
                Console.WriteLine("Something is wrong, returned number {0} is not biggest!!!", biggestOne);
            }            

            EndOfScript();
            //3.Write a method that returns the English name of the last digit of a
            //given number. Example: for 512 prints "two"; for 1024 -> "four".

            //4.Write a method that finds how many times certain number can be
            //found in a given array. Write a program to test that the method works
            //correctly.

            //5.Write a method that checks whether an element, from a certain position
            //in an array is greater than its two neighbors. Test whether the
            //method works correctly.

            //6.Write a method that returns the position of the first occurrence of an
            //element from an array, such that it is greater than its two neighbors
            //simultaneously.Otherwise the result must be -1.

            //7.Write a method that prints the digits of a given decimal number in a
            //reversed order. For example 256, must be printed as 652.

            //8.Write a method that calculates the sum of two very long positive
            //integer numbers. The numbers are represented as array digits and
            //the last digit(the ones) is stored in the array at index 0. Make the
            //method work for all numbers with length up to 10 000 digits.

            //9.Write a method that finds the biggest element of an array. Use that
            //method to implement sorting in descending order.

            //10.Write a program that calculates and prints the n! for any n in the range [1 … 100].

            //11.Write a program that solves the following tasks: 
            //-Put the digits from an integer number into a reversed order.
            //- Calculate the average of given sequence of numbers.
            //- Solve the linear equation a * x + b = 0.
            //Create appropriate methods for each of the above tasks.
            //Make the program show a text menu to the user.By choosing an option
            //of that menu, the user will be able to choose which task to be invoked.
            //Perform validation of the input data: 
            //-The integer number must be a positive in the range [1 … 50 000 000]. 
            //-The sequence of numbers cannot be empty. 
            //-The coefficient a must be non - zero.

            //12.Write a method that calculates the sum of two polynomials with integer
            //coefficients, for example 
            //(3x^2 + x - 3) + (x - 1) = (3x^2 + 2x - 4).

            //13. * Write a method that calculates the product of two polynomials with
            //integer coefficients, for example
            //(3x^2 + x - 3) * (x - 1) = (3x^3 - 2x^2 - 4x + 3).
        }

        //1.Write a code that by given name prints on the console "Hello, <name>!"
        //(for example: "Hello, Peter!").
        static void PrintHelloAnyBody (string name)
        {
            Console.WriteLine($"Hello {name}");
        }

        //2.Create a method GetMax() with two integer(int) parameters, that
        //returns maximal of the two numbers. Write a program that reads three
        //numbers from the console and prints the biggest of them. Use the
        //GetMax() method you just created. Write a test program that validates
        //that the methods works correctly.
        static int GetMax(int x, int y)
        {
            if (x >= y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }


        //support methods
        static void EndOfScript ()
        {
            Console.WriteLine(new String('#', 80));
            Console.WriteLine();
        }
    }
}
