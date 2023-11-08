using Microsoft.EntityFrameworkCore;
using ModelFirst.Models;

namespace ModelFirst.DataAcsess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

        public virtual DbSet<User> Users { get; set; }
        
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseStudent> CourseStudents { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<PersonCars> PersonCars { get; set; }


    }
}
