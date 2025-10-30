using BlogStore_NTIER_AI_EntityLayer.Entities;

namespace BlogStore_NTIER_AI_BusinessLayer.Abstract
{
   public interface IArticleService:IGenericService<Article>
    {
        public List<Article> TGetArticlesWithCategories();
        public AppUser TGetAppUserByArticleId(int id);
        public Article TGetArticleBySlug(string slug);
        public List<Article> TGetArticlesByAppUser(string id);
        List<Article> TGetLast5ArticlesByUser(string id);
        List<Article> TGetArticlesByUserId(string id);
        public List<Article> TGetTop3PopularArticles();
        public Article TGetArticleWithUser(int id);
        public List<Article> TGetArticlesByCategoryId(int id);
        List<(string CategoryName, int ArticleCount)> TGetArticleCountByCategory();

    }
}
