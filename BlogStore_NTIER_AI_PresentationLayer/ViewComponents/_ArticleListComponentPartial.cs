using BlogStore_NTIER_AI_BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogStore_NTIER_AI_PresentationLayer.ViewComponents
{

    public class _ArticleListComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;
        public IViewComponentResult Invoke()
        {
            var articles = _articleService.TGetArticlesWithCategories();
            return View(articles);
        }
    }
}