using BlogStore_NTIER_AI_EntityLayer.Entities;

namespace BlogStore_NTIER_AI_DataAccessLayer.Abstract
{
   public interface IArticleDal:IGenericDal<Article>
    {
        public List<Article> GetArticlesWithCategories();
        //public List<Article> GetArticleByIdWithAuthor(int id);
        public List<Article> GetArticlesByAppUser(string id);
        public AppUser GetAppUserByArticleId(int id);
    }
}
