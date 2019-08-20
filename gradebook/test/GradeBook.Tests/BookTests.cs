using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
         //arrange
         var book = new Book("");
         book.addGrade(34.4);
         book.addGrade(34.4);
         book.addGrade(34.4);

         //act
         var results = book.GetshowStatistic();


         //assert
         Assert.Equal(30.4, results.average);
         Assert.Equal(30.4, results.low);
         Assert.Equal(30.4, results.high);


        }
    }
}
