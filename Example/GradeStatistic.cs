using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdExample.Example
{
    public class GradeStatistic
    {

        public GradeStatistic()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
        
        // Access Modifier by default is private if you do not specify it. Hence i make it public to make is visible to SwitchGradeExample
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;


        public string LetterGrade
        {
            get
            {
                string result;
                if(AverageGrade >= 90)
                {
                    result = "A";
                }
                else if(AverageGrade >= 80)
                {
                    result = "B";
                }
                else if(AverageGrade >= 70)
                {
                    result = "C";
                }
                else if(AverageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }
                return result;
            }
        }

        public string Description
        {
            get 
            {
                //char, interger, string or Enum are usable only for switch
                string result;
                switch(LetterGrade)  // LetterGrade is returning choices of result either "A"---"F". 
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "Below Average";
                        break;
                    default:               // if non of the lettergrade found in the case
                        result = "Failed";
                        break;

                }
                return result;
            } 
        }
    }
}
