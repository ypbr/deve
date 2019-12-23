using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace deve.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
    }
}