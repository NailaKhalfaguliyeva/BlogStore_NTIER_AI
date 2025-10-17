using BlogStore_NTIER_AI_DataAccessLayer.Abstract;
using BlogStore_NTIER_AI_DataAccessLayer.Context;
using BlogStore_NTIER_AI_DataAccessLayer.Repositories;
using BlogStore_NTIER_AI_EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogStore_NTIER_AI_DataAccessLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        private readonly BlogContext _blogContext;
        public EfArticleDal(BlogContext blogContext) : base(blogContext)
        {
            _blogContext = blogContext;
        }

        public AppUser GetAppUserByArticleId(int id)
        {
            string userId = _blogContext.Articles.Where(x => x.Id == id).Select(y => y.AppUserId).FirstOrDefault();
            var userValue = _blogContext.Users.Where(x => x.Id == userId).FirstOrDefault();
            return userValue;
        }

        public List<Article> GetArticleByIdWithAuthor(int id)
        {
            return _blogContext.Articles.Include(x => x.Author).Where(x => x.Id == id).ToList();
        }

        public List<Article> GetArticlesByAppUser(string id)
        {
            return _blogContext.Articles.Where(x => x.AppUserId == id).ToList();
        }

        public List<Article> GetArticlesWithCategories()
        {
            return _blogContext.Articles.Include(x => x.Category).ToList();
        }
    }
}
