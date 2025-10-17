using BlogStore_NTIER_AI_EntityLayer.Entities;

namespace BlogStore_NTIER_AI_BusinessLayer.Abstract
{
   public interface IArticleService:IGenericService<Article>
    {
        public List<Article> TGetArticlesWithCategories();
        //public List<Article> TGetArticleByIdWithAuthor(int id);
        public List<Article> TGetArticlesByAppUser(string id);
        public AppUser TGetAppUserByArticleId(int id);
        public List<Article> TGetById(int id);
    }
}
