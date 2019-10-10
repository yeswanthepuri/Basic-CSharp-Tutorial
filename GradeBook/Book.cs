using System;
using System.Collections.Generic;

namespace GradeBook
{
    internal class Book
    {
        #region Private member
        private string name { get; set; }
        private static double HighGrade { get; set; } = double.MinValue;
        private static double LowGrade { get; set; } = double.MaxValue;
        private List<double> Grade { get; set; } = new List<double>();
        
        private double GetAverageofGrades()
        {
            var sum = 0.0;
            foreach (var item in Grade)
            {
                HighGrade = Math.Max(item, HighGrade);
                LowGrade = Math.Max(item, LowGrade);
                sum += item;
            }
            return sum /= Grade.Count;
        }
        #endregion
        
        public Book(string name)
        {
            this.name = name;
        }

        internal void ShowStatics()
        {
            double result = GetAverageofGrades();
            Console.WriteLine($"Average Grade is: {result}");
            Console.WriteLine($"Highest Grade {Book.HighGrade}");
            Console.WriteLine($"LowGrade is : {Book.LowGrade}");
            Console.Read();
        }

        public void AddGrade(double gradeval)
        {
            if (gradeval <= 100 && gradeval > 0)
                Grade.Add(gradeval);
        }
    }
}