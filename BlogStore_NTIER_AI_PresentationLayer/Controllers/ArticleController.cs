
using BlogStore_NTIER_AI_BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogStore_NTIER_AI_PresentationLayer.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IActionResult Detail(int id)
        {
            ViewBag.i = id;
            return View();
        }
    }
}
