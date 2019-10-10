using System;
using Xunit;
using FluentAssertions;
using GradeBook;

namespace test
{
    public class BookTests1
    {
        [Fact]
        public void Gradebook_NameTest()
        {
            //Arrange
            var book =  GetBook("Yeswanth");
            var book1 =  GetBook("Gayatri");
            var book2 =  GetBook("Krithvika");
            book.Name.Should().Be("Yeswanth");
            book1.Name.Should().Be("Gayatri");
            book2.Name.Should().Be("Krithvika");

        }

        private Book GetBook(string name)
        {
           return new Book(name);
        }
    }
}
