using day.DAL;
using day.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace day.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class HomeController : Controller
    {
        public AppDbContext _context { get; }

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        // GET: HomeController
        public async Task <ActionResult> Index()
        {

            return View(await _context.Categories.ToListAsync());
        }

        // GET: HomeController/Create
        public async Task <ActionResult> Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <ActionResult >Create(Category Categories)
        {
            try
            {
                if (Categories!=null)
                {
                    
                    await _context.Categories.AddAsync(Categories);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View(_context.Categories.Find(id));

        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <ActionResult > Edit(Category category)
        {
            try
            {
                var existdb = _context.Categories.FirstOrDefault(c => c.Id == category.Id);
                if (existdb != null)
                {
                    existdb.Name = category.Name;
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));

                }
                return BadRequest();
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public async Task <ActionResult>  Delete(int id)
        {
            if (id!=null)
            {
                _context.Categories.Remove(await _context.Categories.FindAsync(id));
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return BadRequest();
        }

    }
}
