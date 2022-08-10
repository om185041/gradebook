// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;


namespace GradeBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Scott's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            
           var stats = book.ShowStats();

           System.Console.WriteLine(stats.Low);
           System.Console.WriteLine(stats.High);
           System.Console.WriteLine(stats.Average);
            
        }
    }

}

