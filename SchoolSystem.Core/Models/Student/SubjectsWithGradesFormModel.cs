namespace SchoolSystem.Core.Models.Student
{
    public class SubjectsWithGradesFormModel
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; } = string.Empty;

        public List<string> SubjectName { get; set; } = new List<string>();

        public List<decimal> Grade { get; set; } = new List<decimal>();
    }
}
