namespace GradeBook.GradeBooks
{
    using GradeBook.Enums;

    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            this.Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            int totalStudents = this.Students.Count;
            if (totalStudents < 5) { throw new System.InvalidOperationException(); }
            if (averageGrade >= 80.0) { return 'A'; }
            if (averageGrade >= 60.0) { return 'B'; }
            if (averageGrade >= 40.0) { return 'C'; }
            if (averageGrade >= 20.0) { return 'D'; }

            return 'F';

        }
    }
}
