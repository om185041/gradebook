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
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public int NumberOfBooks()
        {
            
            int result=0;
            result = grades.Count();
            return result;
        }

        public void AddGrade(char letter)
        {
            switch (letter)
            {
                case 'a': AddGrade(90);
                break;
                case 'A': AddGrade(90);
                break;

                case 'b':AddGrade(80);
                break;
                case 'B':AddGrade(80);
                break;

                case 'c':AddGrade(70);
                break;
                case 'C':AddGrade(70);
                break;

                case 'd':AddGrade(60);
                break;
                case 'D':AddGrade(60);
                break;

                case 'F':AddGrade(50);
                break;
                case 'f':AddGrade(50);
                break;

                default: AddGrade(0);
                break;
            }
        }
          
        public Statistics ShowStats()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.Low = double.MaxValue;
            result.High = double.MinValue;
            
            for(int index = 0; index < grades.Count; index++)
            {
                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
                
            }
            
            result.Average /= grades.Count;
            switch (result.Average)
            {
                case var letterGrade when letterGrade>= 90.0: 
                result.Letter ='A';
                break;

                case var letterGrade when letterGrade>= 80.0: 
                result.Letter ='B';
                break;

                case var letterGrade when letterGrade>= 70.0: 
                result.Letter ='C';
                break;
                
                case var letterGrade when letterGrade>= 60.0: 
                result.Letter ='D';
                break;

                default: result.Letter = 'f';
                break;
            }

            return result;
        }
        private List <double> grades;
        public string Name
        {
            get;
            set;
        }

        public const string CATEGORY = "Science";
        

    }
}