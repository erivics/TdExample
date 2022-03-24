using System;
using TdExample.Example;

namespace TdExample
{
    class Program
    {
        static void Main(string[] args)
        {
           
            SwitchGradeExample myGrade = new SwitchGradeExample();
            myGrade.AddGrades(91);
            myGrade.AddGrades(86.7f);
            myGrade.AddGrades(69);

            
            //Am using this method to pass myGrade into GradeStatistic object and ofcourse selecting the highest, Lowest and avaerage grade
            GradeStatistic stats = myGrade.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowers", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        
        
        //I want to kind of modify the WriteLine a bit with this method. Not a big deal guys
        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description} : {result}" , description, result);
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description} : {result}", description, result);
        }
    }
}
