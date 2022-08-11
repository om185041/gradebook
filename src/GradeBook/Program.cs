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
            bool done = false;
            while(!done)
            {
                string input="";
                double grade =0;

                System.Console.WriteLine("Enter a number grade or q to quit");
                 input = Console.ReadLine();
                if (input.ToLower() =="q")
                {
                    done = true;
                    break;
                }

                try
                {
                    grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            } 
            
           var stats = book.ShowStats();
           

           System.Console.WriteLine("For the book named {0}", book.Name);
           System.Console.WriteLine("The lowest grade is {0}" , stats.Low);
           System.Console.WriteLine("The highest grade is {0}" , stats.High);
           System.Console.WriteLine("The average grade is {0}" , stats.Average);
           System.Console.WriteLine("The letter grade is {0}" , stats.Letter);
            
        }
    }

}

