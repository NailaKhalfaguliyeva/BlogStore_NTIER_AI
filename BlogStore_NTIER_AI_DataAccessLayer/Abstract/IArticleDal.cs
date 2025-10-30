using BlogStore_NTIER_AI_EntityLayer.Entities;

namespace BlogStore_NTIER_AI_DataAccessLayer.Abstract
{
   public interface IArticleDal:IGenericDal<Article>
    {
        public List<Article> GetArticlesWithCategories();
        public AppUser GetAppUserByArticleId(int id);
        List<Article> GetArticlesByAppUser(string id);
        public Article GetArticleBySlug(string slug);
        public List<Article> GetArticlesByCategoryId(int id);
        List<Article> GetArticlesByUserId(string id);
        public Article GetArticleWithUser(int id);
        List<Article> GetLast5ArticlesByUser(string id);
        public List<Article> GetTop3PopularArticles();
        List<(string CategoryName, int ArticleCount)> GetArticleCountByCategory();
    }
}
