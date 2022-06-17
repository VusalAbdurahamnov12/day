using day.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace day.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public AppDbContext _context { get; }

        // GET: HomeController
        public ActionResult Index()
        {
            return View(_context.Products.Include(x=>x.Category).ToList());
        }

    }
}
