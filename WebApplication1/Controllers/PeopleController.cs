using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    public class PeopleController : Controller
    {
        private readonly AppDbContext _context;
        public PeopleController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var people = await _context.People.ToListAsync();
            return View(people);
        }
    }
}
