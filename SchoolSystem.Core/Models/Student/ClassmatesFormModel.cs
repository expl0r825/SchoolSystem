namespace SchoolSystem.Core.Models.Student
{
    public class ClassmatesFormModel
    {
        public string Class {  get; set; } = string.Empty;

        public List<string> ClassMatesName { get; set; } = new List<string>();
    }
}
