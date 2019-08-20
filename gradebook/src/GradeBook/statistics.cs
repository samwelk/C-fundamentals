using System;
using System.Collections.Generic;
namespace GradeBook{

    public class statistics{
        public double average {get; set;}
        public double low {get; set;}
        public double high {get; set;}
        
        public statistics(){}
        public statistics(double hi, double lo){
            high = hi;
            low = lo;
        }
        public void calculateAverage(List<double> grades)
        {
            foreach(var grade in grades){

                high = Math.Max(grade,  high);
                low = Math.Min(grade, low );
                    
                average += grade;
            }

            average /= grades.Count;

            //return average;
                
        }

    }
}   