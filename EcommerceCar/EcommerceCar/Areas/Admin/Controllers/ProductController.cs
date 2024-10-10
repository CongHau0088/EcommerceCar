using Microsoft.AspNetCore.Mvc;

namespace CarBook.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/product")]
    public class ProductController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("add")]
        public IActionResult Add()
        {
            return View("add");
        }

        [Route("update/{id}")]
        public IActionResult Update(int id)
        {
            return View("update");
        }

        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            return RedirectToAction("index","product");
        }
    }
}
