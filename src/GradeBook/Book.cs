using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public void ShowStats()
        {
            System.Console.WriteLine($"The sum of all of the grades is {grades.Sum()}");
            Console.WriteLine($"The maximum grade is {grades.Max()}");
            System.Console.WriteLine($"The minimum grade is {grades.Min()}");
            System.Console.WriteLine($"The average of all grades is {grades.Average()}");
            
        }
        private List <double> grades;
        private string name;
    }
}