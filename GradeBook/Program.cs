using System;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new []{ 10.2, 23.4, 24.3 };
            var grade=new List<double>();
            grade.Add(56.1);
            var sum=0.0;
           foreach (var item in grade)
           {
               sum+=item;
           }
            sum /= grade.Count;
            Console.WriteLine(sum);
        }
    }
}
