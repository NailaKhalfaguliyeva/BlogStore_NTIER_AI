using BlogStore_NTIER_AI_DataAccessLayer.Abstract;
using BlogStore_NTIER_AI_DataAccessLayer.Context;
using BlogStore_NTIER_AI_DataAccessLayer.Dtos;
using BlogStore_NTIER_AI_DataAccessLayer.Repositories;
using BlogStore_NTIER_AI_EntityLayer.Entities;

namespace BlogStore_NTIER_AI_DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        private readonly BlogContext _blogContext;
        public EfCategoryDal(BlogContext blogContext) : base(blogContext)
        {
            _blogContext = blogContext;
        }

        public List<CategoryWithArticleCountDto> GetCategoryWithArticleCount()
        {
            var result = _blogContext.Categories.Select(c => new CategoryWithArticleCountDto
            {
                CategoryName = c.CategoryName,
                ArticleCount = _blogContext.Articles.Count(a => a.CategoryId == c.CategoryId)
            }).ToList();
            return result;
        }
    }
}
