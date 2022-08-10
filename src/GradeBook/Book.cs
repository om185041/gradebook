using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        
        public void AddGrade(double grade)
        {
            
            if(grade <= 100 && grade >=0)
            {
                grades.Add(grade);
            }
            else
            {
                System.Console.WriteLine("invalid value");
            }
        }
          
        public Statistics ShowStats()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;
            int index = 0;
            do{
                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
                index++;
            }while (index < grades.Count);
            
            result.Average /= grades.Count;
            return result;
        }
        private List <double> grades;
        public string Name;
    }
}