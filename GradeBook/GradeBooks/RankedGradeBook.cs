using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {

        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            int count = 0;

            if (Students.Count < 5) { 
                throw new InvalidOperationException("Less than 5 students");
            }

            foreach(var student in Students)
            {

                if (student.AverageGrade > averageGrade) 
                {
                    count++; // liczba studentow ktorzy maja lepsza ocene
                }

            }


            if (count < (0.2 * Students.Count))
            {
                return 'A';
            }
            if ((count >= (0.2 * Students.Count)) && (count < (0.4 * Students.Count)))
            {
                return 'B';
            }
            if ((count >= (0.4 * Students.Count)) && (count < (0.6 * Students.Count)))
            {
                return 'C';
            }
            if ((count >= (0.6 * Students.Count)) && (count < (0.8 * Students.Count)))
            {
                return 'D';
            }
            if (count >= (0.8 * Students.Count))
            {
                return 'F';
            }
            return 'N';

          



        }

    }
}
