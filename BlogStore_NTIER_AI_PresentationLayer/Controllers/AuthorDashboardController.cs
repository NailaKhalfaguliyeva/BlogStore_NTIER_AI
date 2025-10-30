using BlogStore_NTIER_AI_BusinessLayer.Abstract;
using BlogStore_NTIER_AI_EntityLayer.Entities;
using BlogStore_NTIER_AI_PresentationLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogStore_NTIER_AI_PresentationLayer.Controllers
{
    public class AuthorDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }      
    }
}
