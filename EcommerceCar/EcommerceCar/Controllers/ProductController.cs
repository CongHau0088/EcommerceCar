using CarBook.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CarBook.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        private const int PageSize = 9; // Items per page

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("index")]
        [Route("")]
        public IActionResult Index(int page = 1)
        {
            var products = _context.Products.ToList();
            int totalItems = products.Count();

            var paginatedProducts = products
                .Skip((page - 1) * PageSize)
                .Take(PageSize)
                .ToList();

            ViewBag.TotalPages = (int)Math.Ceiling(totalItems / (double)PageSize);
            ViewBag.CurrentPage = page;
            ViewBag.Data = paginatedProducts;

            return View();
        }

        [Route("detail/{id}")]
        public ActionResult Details(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View("Detail", product);
        }
    }
}
