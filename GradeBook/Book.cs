using System;
using System.Collections.Generic;

namespace GradeBook
{
    internal class Book
    {
        private List<double> Grade { get; set; }=new List<double>();
        internal double GetAverageofGrades()
        {
            var sum = 0.0;
            foreach (var item in Grade)
            {
                sum += item;
            }
            return sum /= Grade.Count;
        }

        public void AddGrade(double gradeval)
        {
            if (gradeval <= 100 && gradeval > 0)
                Grade.Add(gradeval);
        }
    }
}