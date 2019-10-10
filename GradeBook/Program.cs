using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Program
    {
        /*
        Static Key word - they are instance membors or methods of the class.
        */
        static void Main(string[] args)
        {
            //Create a new object of Books and pass 
            Book book = new Book("Yeswanth Grade Book");
            //var numbers = new []{ 10.2, 23.4, 24.3 };
            //var grade=new List<double>(){ 10.2, 23.4, 24.3 };
            //Add some Grades
            book.AddGrade(56.1);
            book.AddGrade(90.2);
            book.AddGrade(32.2);
            //
            book.ShowStatics();
        }
    }
}
