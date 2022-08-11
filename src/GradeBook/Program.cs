// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;


namespace GradeBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string keepgoing;
            string secondInput = " ";
            
            Book book = new Book("Scott's Grade Book");
            do
            {
                int input=0;

                System.Console.WriteLine("Enter a number grade");
                input = Convert.ToInt32(Console.ReadLine());
                book.AddGrade(input);

                Console.WriteLine("Would you like to quit? Press Q otherwise press any key then press enter");
                secondInput = Console.ReadLine();
                secondInput = secondInput.ToLower();
                
            } while (secondInput != "q");

            
            
           var stats = book.ShowStats();

           System.Console.WriteLine("The lowest grade is {0}" , stats.Low);
           System.Console.WriteLine("The highest grade is {0}" , stats.High);
           System.Console.WriteLine("The average grade is {0}" , stats.Average);
           System.Console.WriteLine("The letter grade is {0}" , stats.Letter);
            
        }
    }

}

