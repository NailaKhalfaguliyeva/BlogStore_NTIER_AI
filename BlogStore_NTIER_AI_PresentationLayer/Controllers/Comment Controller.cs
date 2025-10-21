using BlogStore_NTIER_AI_BusinessLayer.Abstract;
using BlogStore_NTIER_AI_EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogStore_NTIER_AI_PresentationLayer.Controllers
{
    public class Comment_Controller : Controller
    {
       private readonly ICommentService _commentService;
        private readonly UserManager<AppUser> _userManager;

        public Comment_Controller(ICommentService commentService, UserManager<AppUser> userManager)
        {
            _commentService = commentService;
            _userManager = userManager;
        }

        public IActionResult CommentList()
        {
            var values = _commentService.TGetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateComment()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult CreateComment(Comment comment)
        {
            if (ModelState.IsValid)
            {
                comment.CommentDate = DateTime.Now;
                comment.IsValid = true;
                _commentService.TInsert(comment);
                return Json(new
                {
                    success = true,
                    detail = comment.CommentDetail,
                    date = comment.CommentDate.ToString("dd MMM yyyy"),
                    message = "Comment added successfully!",
                });               
            }
            return Json(new { success = false, message = "Could not add comment." });
        }

        public IActionResult DeleteComment(int id)
        {
            _commentService.TDelete(id);
            return RedirectToAction("CommentList");
        }

        [HttpGet]
        public IActionResult UpdateComment(int id)
        {
            var value = _commentService.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateComment(Comment comment)
        {
            comment.CommentDate = DateTime.Now;
            comment.IsValid = false;
            _commentService.TUpdate(comment);
            return RedirectToAction("CommentList");
        }

    }
}

