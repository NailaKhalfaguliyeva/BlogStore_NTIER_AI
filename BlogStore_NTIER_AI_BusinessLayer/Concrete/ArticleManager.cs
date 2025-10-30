using BlogStore_NTIER_AI_BusinessLayer.Abstract;
using BlogStore_NTIER_AI_DataAccessLayer.Abstract;
using BlogStore_NTIER_AI_EntityLayer.Entities;

namespace BlogStore_NTIER_AI_BusinessLayer.Concrete
{
   public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;
        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public void TDelete(int id)
        {
            _articleDal.Delete(id);
        }

        public List<Article> TGetAll()
        {
            return _articleDal.GetAll();
        }

        public AppUser TGetAppUserByArticleId(int id)
        {
            return _articleDal.GetAppUserByArticleId(id);
        }

        public Article TGetArticleBySlug(string slug)
        {
            return _articleDal.GetArticleBySlug(slug);
        }

        public List<(string CategoryName, int ArticleCount)> TGetArticleCountByCategory()
        {
            return _articleDal.GetArticleCountByCategory();
        }

        public List<Article> TGetArticlesByAppUser(string id)
        {
            return _articleDal.GetArticlesByAppUser(id);
        }

        public List<Article> TGetArticlesByCategoryId(int id)
        {
            return _articleDal.GetArticlesByCategoryId(id);
        }

        public List<Article> TGetArticlesByUserId(string id)
        {
            return _articleDal.GetArticlesByUserId(id);
        }

        public List<Article> TGetArticlesWithCategories()
        {
            return _articleDal.GetArticlesWithCategories();
        }

        public Article TGetArticleWithUser(int id)
        {
            return _articleDal.GetArticleWithUser(id);
        }

        public Article TGetById(int id)
        {
            return _articleDal.GetById(id);
        }

        public List<Article> TGetLast5ArticlesByUser(string id)
        {
            return _articleDal.GetLast5ArticlesByUser(id);
        }

        public List<Article> TGetTop3PopularArticles()
        {
            return _articleDal.GetTop3PopularArticles();
        }

        public void TInsert(Article entity)
        {
            {
                if (entity.Title.Length >= 10 && entity.Title.Length <= 100 && entity.Description != "" && entity.ImageUrl.Contains("a"))
                {
                    _articleDal.Insert(entity);
                }
                else
                {
                    
                }
            }
        }
        public void TUpdate(Article entity)
        {
            _articleDal.Update(entity);
        }
    }
}
