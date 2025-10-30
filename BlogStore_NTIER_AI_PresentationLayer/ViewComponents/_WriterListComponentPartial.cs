using BlogStore_NTIER_AI_BusinessLayer.Abstract;
using BlogStore_NTIER_AI_EntityLayer.Entities;
using BlogStore_NTIER_AI_PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogStore_NTIER_AI_PresentationLayer.ViewComponents
{
    public class _WriterListComponentPartial:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IArticleService _articleService;

        public _WriterListComponentPartial(UserManager<AppUser> userManager, IArticleService articleService)
        {
            _userManager = userManager;
            _articleService = articleService;
        }
        public IViewComponentResult Invoke(string id)
        {
            var model = new WriterWithArticleViewModel();
            model.Writers = _userManager.Users.ToList();
            model.SelectedAuthorId = id;

            if (!string.IsNullOrEmpty(id))
            {
                model.Articles = _articleService.TGetArticlesByUserId(id);
            }

            return View(model);
        }
    }
}
