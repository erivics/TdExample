using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdExample.Example
{
    public class SwitchGradeExample
    {
        
        //Constructor to create new instance of students grade
        public SwitchGradeExample()
        {
            StudentsGrades = new List<float>();
        }

        
        /// <summary>
        /// To add grades of students
        /// </summary>
        /// <param name="grade"></param>
        public void AddGrades( float grade)
        {
            StudentsGrades.Add(grade);
        }

        
        //If you did not use access modifier "public" this method name will not be visible in the program.cs class. Try remove it and see.
        //Here I make it private I want it to be access only by this class and let the Constructor create it instance.
        private List<float> StudentsGrades;

        public GradeStatistic ComputeStatistics()
        {
            GradeStatistic stats = new GradeStatistic();

            float sum = 0;
            foreach(float grade in StudentsGrades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            if(StudentsGrades.Count != 0)  //Error needs to be managed here should student grade count is equals zero
            {
                stats.AverageGrade = sum / StudentsGrades.Count;
            }
            else
            {
                throw new ArithmeticException("Student grade count Must not be Zero. Ensure student grades are inputed");
            }
            return stats;  // This is returning all the stats object( lowest highest and Average)
        }
    }
}
