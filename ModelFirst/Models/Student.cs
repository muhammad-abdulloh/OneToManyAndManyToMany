namespace ModelFirst.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CourseStudent> StudentCourses { get; set; }
    }
}
