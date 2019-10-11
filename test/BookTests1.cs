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
        [Fact]
        public void Two_variables_can_acces_same_variable()
        {
            //Arrange
            int i=32;
            var book =  GetBook("Yeswanth");
            var book1 =  book;
            book.Name.Should().Be("Yeswanth");
            book.Should().BeSameAs(book1);
            Assert.True(object.ReferenceEquals(book,book1));
        }

        private Book GetBook(string name)
        {
           return new Book(name);
        }
    }
}
