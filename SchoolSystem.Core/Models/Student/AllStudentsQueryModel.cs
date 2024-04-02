namespace SchoolSystem.Core.Models.Student
{
    public class AllStudentsQueryModel
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public int ClassID { get; set; }

        public int ClassTeacherId { get; set; }

        public decimal AverageScore { get; set; }
    }
}
