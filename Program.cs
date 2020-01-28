using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a set of numbers: "); // Ask for input
            var input = Console.ReadLine(); // Store the input somewhere

            // Evaluate Input
            var array = input.Split(','); //Seperate on comma and turn into array

            var totalNumbers = array.Length; //Get total numbers
            var totalSum = 0; //Initialize the sum of all numbers

            foreach(var i in array)
            {
                totalSum += Convert.ToInt32(i); //Add all the numbers up to the sum
            }

            //Then we need to divide the sum of all the numbers by the amount of numbers given
            var average = totalSum / totalNumbers;
            Console.WriteLine(average); // Print result
        }
    }
}
