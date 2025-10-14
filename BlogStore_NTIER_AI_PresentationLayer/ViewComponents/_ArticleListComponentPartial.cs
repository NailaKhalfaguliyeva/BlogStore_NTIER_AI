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


            var filteredArticles = articles
                .Where(x => !x.Title.Contains("test", StringComparison.OrdinalIgnoreCase)
                         && !x.Title.Contains("try", StringComparison.OrdinalIgnoreCase))
                .ToList();


            return View(filteredArticles);
        }
    }
}