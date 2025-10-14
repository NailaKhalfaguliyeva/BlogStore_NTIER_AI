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

        //private readonly BlogContext _blogContext;



        public List<Article> GetArticlesWithCategories()
        {
            return _blogContext.Articles.Include(x => x.Category).ToList();
        }
    }
}
