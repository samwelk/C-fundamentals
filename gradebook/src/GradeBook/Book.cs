
using System;
using System.Collections.Generic;

namespace GradeBook
{

    
    public class Book
    {
        public Book(string name){
          grades = new List<double>(); 
           this.name = name;
        }
        public void addGrade(double grade){
            grades.Add(grade);
        }
         public statistics getStatistics()
        {
            var result = new statistics(double.MinValue, double.MaxValue);
            // {
            //     average  = 0.0,
            //     high = double.MinValue,
            //     low = double.MaxValue
            // };

            // result.average  = 0.0;
            // result.high = double.MinValue;
            // result.low = double.MaxValue;

            // foreach(var grade in grades){

            //     result.high = Math.Max(grade,  result.high);
            //     result.low = Math.Min(grade, result.low );
                    
            //     result.average += grade;
            // }
            //     result.average /= grades.Count;
            result.calculateAverage(grades);
            return result;      
        }
        private List<double> grades = null;

       

        private string name;
        
    }
}