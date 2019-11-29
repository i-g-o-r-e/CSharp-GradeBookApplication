namespace GradeBook.GradeBooks
{
    using GradeBook.Enums;
    using System;

    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            this.Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (this.Students.Count < 5) { throw new InvalidOperationException(); }
            if (averageGrade >= 80.0) { return 'A'; }
            if (averageGrade >= 60.0) { return 'B'; }
            if (averageGrade >= 40.0) { return 'C'; }
            if (averageGrade >= 20.0) { return 'D'; }

            return 'F';
        }

        public override void  CalculateStatistics()
        {
            if (this.Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
            }
            else
            {
                base.CalculateStatistics();
            }
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (this.Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}
