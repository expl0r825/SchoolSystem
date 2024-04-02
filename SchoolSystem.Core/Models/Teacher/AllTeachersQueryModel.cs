namespace SchoolSystem.Core.Models.Teacher
{
    public class AllTeachersQueryModel
    {
        public string FullName { get; set; } = string.Empty;

        public string Email {  get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty; 

        public bool IsClassTeacher { get; set; }
    }
}
