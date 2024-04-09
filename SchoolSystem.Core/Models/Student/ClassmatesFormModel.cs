namespace SchoolSystem.Core.Models.Student
{
    public class ClassmatesFormModel
    {
        public string ClassName {  get; set; } = string.Empty;

        public string TeacherName { get; set; } = string.Empty;

        public List<string> ClassmatesName { get; set; } = new List<string>();
    }
}
