using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{

    class Program
    {
        static void OnGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("Grade Added");
        }
        static void OnGradeAddedWrong(object sender, EventArgs args)
        {
            Console.WriteLine("wrong Added");
        }
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
            char readvalue;
            do
            {
                Console.WriteLine("Please Enter a Grade, or enter Q to Quit");
                readvalue = Console.ReadLine()[0];
                if(readvalue == 'Q')
                break;
                else
                {
                book.AddGrade(readvalue);
                book.GradeAdded += OnGradeAdded;
                }
            } while (true);
            //Get Statist
            var statistics = book.GetStatistics();
            book.WriteStatistics(statistics);

        }
    }
}
