using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            //var numbers = new []{ 10.2, 23.4, 24.3 };
            //var grade=new List<double>(){ 10.2, 23.4, 24.3 };
            book.AddGrade(56.1);
            book.AddGrade(10.2);
            double result = book.GetAverageofGrades();
            Console.WriteLine(result);
        }
    }
}
