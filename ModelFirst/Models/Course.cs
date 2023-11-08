namespace ModelFirst.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CourseStudent> CourseStudents { get; set; }
    }
}
