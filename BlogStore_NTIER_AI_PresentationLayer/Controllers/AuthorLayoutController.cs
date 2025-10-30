using Microsoft.AspNetCore.Mvc;

namespace BlogStore_NTIER_AI_PresentationLayer.Controllers
{
    public class AuthorLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
