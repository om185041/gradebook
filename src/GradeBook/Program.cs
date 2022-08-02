// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;


namespace GradeBook // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {12.7, 10.3, 6.11, 4.1};
            List<double> grades;
            var result = 0.0;
            foreach(var number in numbers)
            {
                result += number;
                
            }
            Console.WriteLine(result);


if (args.Length>0)
{
Console.WriteLine($"Hello, {args[0]} !");
}
else
{
    Console.WriteLine("Hello");
}

        }
    }
}

