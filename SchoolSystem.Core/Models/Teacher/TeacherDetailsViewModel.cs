namespace SchoolSystem.Core.Models.Teacher
{
    public class TeacherDetailsViewModel
    {
        public int Id { get; set; }
        public bool IsClassTeacher { get; set; }

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;
    }
}
