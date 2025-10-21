using BlogStore_NTIER_AI_DataAccessLayer.Abstract;
using BlogStore_NTIER_AI_DataAccessLayer.Context;
using BlogStore_NTIER_AI_DataAccessLayer.Repositories;
using BlogStore_NTIER_AI_EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogStore_NTIER_AI_DataAccessLayer.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        private readonly BlogContext _blogContext;

        public EfCommentDal(BlogContext blogContext) : base(blogContext)
        {
            _blogContext = blogContext;
        }

        public List<Comment> GetAllComments()
        {
            return _blogContext.Comments.ToList();
        }

        public List<Comment> GetCommentsByArticle(int id)
        {
            var values = _blogContext.Comments.Include(x => x.AppUser).Include(y => y.Article).Where(z => z.ArticleId == id).ToList();
            return values;
        }
    }
}
