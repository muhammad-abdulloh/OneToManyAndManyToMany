using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelFirst.DataAcsess;
using ModelFirst.Models;
using System.Diagnostics;

namespace ModelFirst.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private ApplicationDbContext _context;

        public UserController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }


        [HttpPost]
        public async ValueTask<IActionResult> CreatePersonAsync()
        {
            //var result = await _context.Cars
            //    .Include(x => x.Person)
            //    .ThenInclude(x => x.Cars)
            //    .ToListAsync();
                //.FirstOrDefaultAsync(x => x.Name == "Rustam");

            Person person = new Person();
            //person.Name = name;

            var bahridin = await _context.Persons.FirstOrDefaultAsync(x => x.Name == "Bahriddin");
            var myCar = await _context.Cars.FirstOrDefaultAsync(x => x.Id == 2);

            await _context.PersonCars.AddAsync(new PersonCars()
            {
                PersonRustamId = bahridin.Id,
                CarRustamId = myCar.Id
            });

            await _context.SaveChangesAsync();
            

            return Ok("Let Check");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetPersonAsync()
        {
            var result = await _context.Persons
                .Include(x => x.PersonCars)
                .ThenInclude(x => x.Cars)
                .ToListAsync();

            return Ok(result);
           
        }



        /** test
        [HttpGet]
        public async ValueTask<IActionResult> Get()
        {
            var values = await _context.Users.ToListAsync();
            return Ok(values);
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateUser(User user)
        {
            var users = await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return Ok(users);
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateCompany(string name)
        {
            Company company = new Company();
            company.Name = name;
            var companies = await  _context.Companies.AddAsync(company);
            await _context.SaveChangesAsync();
            return Ok(companies);
        }


        [HttpPost]
        public async ValueTask<IActionResult> GetAllBinarsa()
        {
            //var all = await 
            User user = new User();
            user.Name = "www";
            user.Username = "wwww";
            user.Age = 13;
            user.Email = "dwdwdwd";
            user.CompanyId = 1;
            user.Password = "Tdwdwest";

            var res = await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();


            return Ok("yes");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllBinarsaInclude()
        {
            

            var res = await _context.Users.
                Include(x => x.Company)
                .ToListAsync();

            return Ok(res);
        }

        [HttpPost]
        public async ValueTask<IActionResult> TestCrud()
        {
            //Student student = new Student() { Name = "StudentB" };
            //Course course = new Course() { Name = "CourseB" };

            var xstudent = _context.Students
                .Include(x => x.StudentCourses)
                .ThenInclude(x => x.Course)
                .FirstOrDefault(x => x.Name == "StudentB");
            //var xcourse = _context.Courses.FirstOrDefault(x => x.Name == "CourseB");

            //_context.CourseStudents.Add(new CourseStudent()
            //{
            //    StudentId = xstudent.Id, 
            //    CourseId = xcourse.Id,
            //});

            //_context.Students.Add(student);
            //_context.Courses.Add(course);
            await _context.SaveChangesAsync();

            return Ok(xstudent);
        }

        */
    }
}
