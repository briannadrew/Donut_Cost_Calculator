/* Author: Brianna Drew
Student ID: 0622446
Description: This is a program that computes the cost of donuts at the local Rich Horton's store based on the number of donuts being purchased.

Data Dictionary (Variables):
 * sevenAndUnder: constant variable that holds the price per donut when the customer purchases 7 or less donuts (of course, not including 0 or a negative number of donuts)
 * underFifteen: constant variable that holds the price per donut when the customer purchases between 7 and 15 donuts (not including 7 or 15).
 * fifteenAndUp: constant variable that holds the price per donut when the customer purchases 15 or more donuts.
 * constantCharge: constant variable that holds the amount to contribute to the final cost of any REAL amount of donuts purchased.
 * tax: constant variable that holds the HST amount to contribute to the final cost of less than 12 donuts purchased.
 * totalCost: double variable that will hold the final cost of donuts purchases by the customer when calculated.
 * donutsPurchased: int variable that will hold the number of donuts a customer purchases, inputted by the user.
 * lastName: string variable that will hold customer's last name inputted by the user. */

using System;
public static class Assign1
{
    public static void Main()
    {
        // defining the variables and their types.
        const double sevenAndUnder = 1.00, underFifteen = 0.90, fifteenAndUp = 0.75, constantCharge = 0.25, tax = 1.13;
        double totalCost = 0;
        int donutsPurchased = 0;
        string lastName;

        // introduction to the program.
        Console.Write("Welcome to the Rich Horton's Donut Order Cost Calculator.");
        Console.WriteLine(" ");
        Console.WriteLine(" ");

        // prompt the user to enter customer's last name.
        Console.Write("Enter customer's last name: ");
        lastName = Console.ReadLine();

        // prompt the user to enter number of donuts purchased.
        Console.Write("Enter number of donuts purchased: ");
        donutsPurchased = Convert.ToInt32(Console.ReadLine());

            // determine what price to charge per donut depending on the number of donuts purchased.
        if (donutsPurchased >= 0 && donutsPurchased <= 7)
            totalCost = sevenAndUnder * donutsPurchased;
        else if (donutsPurchased < 15 && donutsPurchased > 0)
            totalCost = underFifteen * donutsPurchased;
        else if (donutsPurchased >= 15)
            totalCost = fifteenAndUp * donutsPurchased;
        else
        {
            totalCost = 0;
            Console.Write("That is an invalid entry. Please close the program and try again.");
            Console.ReadLine();
        }

        // add the constant charge on top of the actual price of the donuts.
        if (donutsPurchased > 0)
            totalCost = constantCharge + totalCost;

        // calculate the tax on top of the price if number of donuts purchased is less than 12.
        if (donutsPurchased < 12)
            totalCost = totalCost * tax;

        // final output.
        Console.WriteLine(" ");
        Console.WriteLine("Customer Last Name: {0}, Number of Donuts Purchased: {1}, Total Cost: {2:C}",
            lastName, donutsPurchased, totalCost);

        Console.ReadLine();
    }
}
