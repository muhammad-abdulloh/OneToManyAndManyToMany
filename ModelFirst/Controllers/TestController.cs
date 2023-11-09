using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelFirst.DataAcsess;
using ModelFirst.Models.External;
using ModelFirst.Models.MyModels;

namespace ModelFirst.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private ApplicationDbContext _context;


        public TestController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateAny()
        {
            var mainMenu = await _context.Menus.FirstOrDefaultAsync(x => x.Name == "Main");

            mainMenu.Children.Add(new Menu() { Name = "Products" });
            mainMenu.Children.Add(new Menu() { Name = "Orders" });

            //await _context.Menus.AddAsync(menu);
            await _context.SaveChangesAsync();

            return Ok("yes");
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateEmployee()
        {
            Employee employee = new Employee()
            {
                Name = "Shokir",
                Age = 22,
                CompanyId = 2,
                Phone = "999000202"
            };

            await _context.AddAsync(employee);

            await _context.SaveChangesAsync();

            return Ok(employee);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetLikeChildren(string name)
        {
            //var menu = await _context.Menus
            //    .Include(x => x.Children)
            //    .Where(x => EF.Functions.Like(x.Name, $"%{name}%")).ToListAsync();
            ////.FirstOrDefaultAsync(x => x.Name == name);

            // with contains
            var menu2 = await _context.Menus
              .Include(x => x.Children)
              .Where(x => x.Name.Contains(name)).ToListAsync();


            return Ok(menu2);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetChildren(string name)
        {
            var menu = await _context.Menus
                .Include(x => x.Children)
                .FirstOrDefaultAsync(x => x.Name == name);

            return Ok(menu);
        }

        /// <summary>
        /// GetAny
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        public async ValueTask<IActionResult> GetAny(string name)
        {
            var result = await _context.Menus.FirstOrDefaultAsync(x => x.Name == name);    

            return Ok(result);
        }


        [HttpGet]
        public async ValueTask<IActionResult> GetFluent()
        {

            var result = await _context.FluentClasses.FromSqlRaw("Select * from FluentClasses").ToListAsync();

            return Ok(result);
        }
    }
}
