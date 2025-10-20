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

        public List<Article> TGetArticlesByAppUser(string id)
        {
            return _articleDal.GetArticlesByAppUser(id);
        }

        public List<Article> TGetArticlesWithCategories()
        {
            return _articleDal.GetArticlesWithCategories();
        }

        public Article TGetById(int id)
        {
            return _articleDal.GetById(id);
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
