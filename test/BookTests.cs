using System;
using Xunit;
using FluentAssertions;
using GradeBook;

namespace test
{
    public class BookTests
    {
        [Fact]
        public void Gradebook_lower_grade()
        {
            //Arrange
            var book = new Book("Yeswanth");
            book.AddGrade(20.1);
            book.AddGrade(82.1);
            book.AddGrade(90.6);
            //Act

            //Assert
            book.GetStatistics().LowGrade.Should().Be(20.1);

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
            book.GetStatistics().AverageGrade.Should().BeApproximately(64.2,1);

        }
    }
}
