namespace SchoolSystem.Core.Models.Student
{
    public class SubjectsWithTeachersFormModel
    {
        public List<string> SubjectName { get; set; } = new List<string>();

        public List<string> TeacherName { get; set; } = new List<string>();
    }
}
