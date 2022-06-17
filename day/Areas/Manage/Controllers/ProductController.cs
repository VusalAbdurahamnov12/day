using day.DAL;
using day.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace day.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductController(AppDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }
        // GET: Product
        public async Task <ActionResult >Index()
        {
            return View(await _context.Products.Include(x=>x.Category).ToListAsync());
        }
        // GET: Product/Create
        public ActionResult Create()
        {
            ViewBag.Products = new SelectList(_context.Categories, nameof(Category.Id), nameof(Category.Name));
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <ActionResult >Create(Product products)
        {
                if (products != null)
                {
                    ViewBag.Products = new SelectList(_context.Categories,nameof(Category.Id),nameof(Category.Name));
                    var UniqFileName = Guid.NewGuid().ToString() + products.Photo.FileName;
                    string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "assets", "images");
                    string filePath = Path.Combine(uploadsFolder, UniqFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        products.Photo.CopyTo(fileStream);
                    }
                    Product newproducts = new Product
                    {
                        Title = products.Title,
                        Description = products.Description,
                        Image = UniqFileName,
                        CategoryId = products.CategoryId,
                        Link = products.Link,
                    };
                    await _context.Products.AddAsync(newproducts);
                    await _context.SaveChangesAsync();

                }
                return RedirectToAction(nameof(Index));
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Products = new SelectList(_context.Categories, nameof(Category.Id), nameof(Category.Name));

            return View(_context.Products.Find(id));
        }
        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <ActionResult> Edit(Product products)
        {
            ViewBag.Products = new SelectList(_context.Categories, nameof(Category.Id), nameof(Category.Name));

            if (products != null)
            {
                var existdb = _context.Products.FirstOrDefault(c => c.Id == products.Id);
                ViewBag.Products = new SelectList(_context.Categories, nameof(Category.Id), nameof(Category.Name));
                var UniqFileName = Guid.NewGuid().ToString() + products.Photo.FileName;
                string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "assets", "images");
                string filePath = Path.Combine(uploadsFolder, UniqFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    products.Photo.CopyTo(fileStream);
                }
                System.IO.File.Delete(Path.Combine(uploadsFolder, existdb.Image));
                existdb.Description=products.Description;
                existdb.Title=products.Title;
                existdb.Image = UniqFileName;
                existdb.Link = products.Link;
                existdb.CategoryId = products.CategoryId;

                await _context.SaveChangesAsync();

            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            if (id != null)
            {
                _context.Products.Remove(_context.Products.Find(id));
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
