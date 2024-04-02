namespace SchoolSystem.Core.Models.Student
{
    public class StudentDetailsViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Class { get; set; } = string.Empty;

        public string ClassTeacher { get; set; } = string.Empty;

        public decimal AverageGrade { get; set; }
    }
}
