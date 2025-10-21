using BlogStore_NTIER_AI_BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogStore_NTIER_AI_PresentationLayer.ViewComponents.ArticleDetailViewComponents
{
    public class _ArticleDetailCommentListComponentPartial : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _ArticleDetailCommentListComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.TGetCommentsByArticle(id);
            ViewBag.Id = id;
            return View(values);
        }
    }
}

