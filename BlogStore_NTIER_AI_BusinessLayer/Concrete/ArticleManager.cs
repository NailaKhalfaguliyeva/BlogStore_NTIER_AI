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

        public AppUser TGetAppUserByArticleId(int id)
        {
            return _articleDal.GetAppUserByArticleId(id);
        }

        public List<Article> TGetArticlesByAppUser(string id)
        {
            return _articleDal.GetArticlesByAppUser(id);
        }

        public List<Article> TGetArticlesWithCategories()
        {
            return _articleDal.GetArticlesWithCategories();
        }

        public List<Article> TGetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
