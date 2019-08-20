using System;
using System.Collections.Generic;
namespace GradeBook
{


   
    class Program
    {
        static void Main(string[] args)//method

        {

            var book = new Book("Sams Name");

            book.addGrade(34.5);
            book.addGrade(10.5);
            book.addGrade(94.5);
            var stats = book.getStatistics();

            Console.WriteLine($"this is the stats: {stats.low}");
        }
    }
}
