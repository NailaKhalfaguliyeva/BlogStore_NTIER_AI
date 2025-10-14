
using BlogStore_NTIER_AI_BusinessLayer.Abstract;
using BlogStore_NTIER_AI_DataAccessLayer.Abstract;

namespace BlogStore_NTIER_AI_BusinessLayer.Concrete
{
   public class ArticleTagManager:IArticleTagService
    {
        public readonly IArticleTagDal _articleTagDal;
        public ArticleTagManager(IArticleTagDal articleTagDal)
        {
            _articleTagDal = articleTagDal;
        }
    }
}
