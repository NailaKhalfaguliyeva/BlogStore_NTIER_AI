
using BlogStore_NTIER_AI_BusinessLayer.Abstract;
using BlogStore_NTIER_AI_DataAccessLayer.Context;
using BlogStore_NTIER_AI_PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogStore_NTIER_AI_PresentationLayer.Controllers
{
    [Route("article")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [Route("{slug}")]
        public IActionResult Detail(string slug)
        {
            var article = _articleService.TGetArticleBySlug(slug);
            if (article == null) return NotFound();

            var appUser = _articleService.TGetAppUserByArticleId(article.ArticleId);

            var viewModel = new ArticleDetailViewModel
            {
                Article = article,
                Author = appUser
            };


            return View(viewModel);


            ViewBag.i = article.ArticleId;
            return View();
        }
    }
}
