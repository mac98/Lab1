/// Chapter No. 2		Lab No. 1
/// File Name: Program.cs
/// @author: Marcus Moore
/// Date:  September 12, 2021
/// 
/// Modifications:
/// A) Now adds 3 numbers rather than 2.
/// B) Now also finds the product of the 3 numbers.
/// C) Finds the quotient of the sum and product.
///
/// Problem Statement: Ask the user to enter two numbers, calculate the sum of
/// these two numbers, and display the sum to the screen
/// 
/// Overall Plan:
/// 1) Print an initial welcoming message to the screen
/// 2) Prompt the user for two integers
/// 3) Calculate the sum of the integers
/// 4) Print the sum of the integers to the screen
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            // print a message to the screen
            Console.WriteLine("Hello out there.");
            Console.WriteLine("I will add and multiply three numbers for you.");
            Console.WriteLine("Enter one number and press enter, then do the same for the second and third numbers:");

            // declare 3 integer variables
            int n1, n2, n3, sum, prod, quot;

            string userInput;
            userInput = Console.ReadLine();
            n1 = Int32.Parse(userInput);
            n2 = Int32.Parse(Console.ReadLine());
            n3 = Int32.Parse(Console.ReadLine());

            // calculate the sum and product of these two numbers
            sum = n1 + n2 + n3;
            prod = n1 * n2 * n3;

            // calculate the quotient of the sum divided by the product
            quot = sum / prod;

            // print a message along with the sum of the 3 numbers.
            Console.WriteLine("The sum of the three numbers is");
            Console.WriteLine(sum);

            //print a message containing the product of the 3 numbers.
            Console.WriteLine("The product of the three numbers is");
            Console.WriteLine(prod);

            //print a message containing quotient of the sum and product.
            Console.WriteLine("The quotient of the sum and product is");
            Console.WriteLine(quot);

            //Just to pause the screen.
            Console.ReadLine();

        }
    }
}