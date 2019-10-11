using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Statistics
    {
        public double HighGrade { get; set; }
        public double LowGrade { get; set; }
        public double AverageGrade { get; set; }


    }
    public class Book
    {
        #region Private member
        public string Name { get; set; }
        private List<double> Grade { get; set; } = new List<double>();

        private Statistics GetAverageofGrades(Statistics statistics)
        {
            statistics.AverageGrade = 0.0;
            statistics.HighGrade = double.MinValue;
            statistics.LowGrade = double.MaxValue;
            // foreach (var grade in Grade)
            // {
            //     statistics.HighGrade = Math.Max(grade, statistics.HighGrade);
            //     statistics.LowGrade = Math.Min(grade, statistics.LowGrade);
            //     statistics.AverageGrade += grade;
            // }
            var index = 0;
            do
            {
                statistics.HighGrade = Math.Max(Grade[index], statistics.HighGrade);
                statistics.LowGrade = Math.Min(Grade[index], statistics.LowGrade);
                statistics.AverageGrade += Grade[index];
                index++;
            } while (index < Grade.Count);
            statistics.AverageGrade /= Grade.Count;
            return statistics;
        }

        internal void WriteStatistics(Statistics statistics)
        {
            Console.WriteLine($"Average Grade is: {statistics.AverageGrade}");
            Console.WriteLine($"Highest Grade {statistics.HighGrade}");
            Console.WriteLine($"LowGrade is : {statistics.LowGrade}");
            Console.Read();
        }
        #endregion

        public Book(string name)
        {
            this.Name = name;
        }

        public Statistics GetStatistics()
        {
            Statistics statistics = new Statistics();
            GetAverageofGrades(statistics);
            return statistics;
        }



        public void AddGrade(double gradeval)
        {
            if (gradeval <= 100 && gradeval > 0)
                Grade.Add(gradeval);
        }
    }
}