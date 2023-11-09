using Microsoft.EntityFrameworkCore;
using ModelFirst.Configuratin;
using ModelFirst.Models;
using ModelFirst.Models.MyModels;
using System.Reflection;

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
        public virtual DbSet<Printer> Printers { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // shunda shu assemblydagi hama type configurationlarni o'zi topvolib qo'shib qo'yadi
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetCallingAssembly());

            // bu holatda bittadan o'tkazamiz
            //modelBuilder.ApplyConfiguration(new BookTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new PrinterTypeConfiguration());
        }


    }
}
