/// Chapter No. 2		Lab No. 2
/// File Name: Program.cs
/// @author: Marcus Moore
/// Date:  September 12, 2021
///
/// Problem Statement: Given a number of tickets won from an arcade machine and that the price of a candy bar
/// is 10 tickets and a gumball is 3 tickets, find the maximum number of candy bars and gumballs you can buy
/// with the entered number of ticket, focusing mainly on candy bars with the leftovers going to gumballs.
/// 
/// Overall Plan:
/// 1) Create an int called tickets.
/// 2) Prompt user to enter the number of tickets they have won. Save this value into tickets.
/// 3) Create two ints, candy_bars and gumballs.
/// 4) Store the number of tickets divided by 10 into candy_bars.
/// 5) Create a temp variable to store the mod of tickets and 10.
/// 6) Divide the temp variable by 3 and store this in gumballs.
/// 7) Print a message stating how many candy bars and gumballs the user can buy.
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program tells you how many candy bars and gumballs you can buy!");
            int tickets, candy_bars, gumballs, temp;
            Console.WriteLine("Enter the number of tickets you won:");
            tickets = Int32.Parse(Console.ReadLine());

            candy_bars = tickets / 10;
            temp = tickets % 10;
            gumballs = temp / 3;

            Console.WriteLine("You can buy " + candy_bars + " candy bar(s) and " + gumballs + " gumball(s).");

            Console.ReadLine();
        }
    }
}
