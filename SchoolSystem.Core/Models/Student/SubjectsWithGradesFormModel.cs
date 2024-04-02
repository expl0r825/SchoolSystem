namespace SchoolSystem.Core.Models.Student
{
    public class SubjectsWithGradesFormModel
    {
        public string StudentName { get; set; } = string.Empty;

        public string SubjectName { get; set; } = string.Empty;

        public decimal Grade { get; set; }
    }
}
