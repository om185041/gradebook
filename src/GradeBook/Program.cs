// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;


namespace GradeBook // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>(){12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);
            var result = 0.0;
            var divResult = 0.0;
            foreach(var number in grades)
            {
                result += number;
                
            }
            divResult=result/grades.Count;
            System.Console.WriteLine($"The sum is {result}");
            Console.WriteLine($"The average is grade {divResult:N2}");


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

