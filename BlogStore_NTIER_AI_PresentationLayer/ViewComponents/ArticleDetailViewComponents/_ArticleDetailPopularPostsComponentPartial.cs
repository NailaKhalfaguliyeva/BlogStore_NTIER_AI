using BlogStore_NTIER_AI_BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogStore_NTIER_AI_PresentationLayer.ViewComponents.ArticleDetailViewComponents
{
    public class _ArticleDetailPopularPostsComponentPartial:ViewComponent
    {
        private readonly IArticleService _articleService;

        public _ArticleDetailPopularPostsComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _articleService.TGetTop3PopularArticles();
            return View(values);
        }
    }
}
