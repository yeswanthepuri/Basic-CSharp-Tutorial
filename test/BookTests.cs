using System;
using Xunit;
using FluentAssertions;
using GradeBook;

namespace test
{

    public class copyConstructor
    {
        int x;
        public copyConstructor(copyConstructor obj)
        {
            x=obj.x;
        }
        public copyConstructor(int i)
        {
            x=i;
        }
        public void Display()
        {
            Console.WriteLine(x);
        }
    }

    public class ReferenceTest
    {
        [Fact]
        public void test_rererence()
        {
        copyConstructor cb1=new copyConstructor(10);
        cb1.Display();
        copyConstructor cb2=new copyConstructor(cb1);

        Assert.False(object.ReferenceEquals( cb1,cb2));
        }
    }
    public class BookTests
    {
        // testing my delegate invokes my methos as many times as i hook it. 
        int count;
        public delegate string writeconsol(string printvalue);
        [Fact]
        public void Chech_delegate_canInvoke_otherMethod()
        {
            //
            writeconsol write= Logsomething;
            write += LogsomethingLower;
            write += Logsomething;
            var opvalue = write("Hello");
            //opvalue.Should().Be("HellohelloHello");
            count.Should().Be(3);
        }
        //testing delagate
        private string LogsomethingLower(string inputString)
        {
            count++;
            return inputString.ToLower();
        }
        private string Logsomething(string inputString)
        {
            count++;
            return inputString;
        }
        [Fact]
        public void Gradebook_lower_grade()
        {
            //Arrange
            var book = new Book("Yeswanth");
            book.AddGrade(95.1);
            book.AddGrade(82.1);
            book.AddGrade(90.6);
            book.AddGrade('D');

            //Act

            //Assert
            book.GetStatistics().LowGrade.Should().Be(60);

        }
        [Fact]
        public void Gradebook_Average_grade()
        {
            //Arrange
            var book = new Book("Yeswanth");
            book.AddGrade(20.1);
            book.AddGrade(82.1);
            book.AddGrade(90.6);
            //Act

            //Assert
            book.GetStatistics().AverageGrade.Should().BeApproximately(64.2, 1);

        }
    }
}
