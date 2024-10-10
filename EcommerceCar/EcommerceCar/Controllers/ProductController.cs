using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("detail/{id}")]
        public ActionResult Details(int id)
        {
            return View("Detail");
        }

       
        
    }
}
