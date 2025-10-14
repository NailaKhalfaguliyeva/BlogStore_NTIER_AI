
using BlogStore_NTIER_AI_BusinessLayer.Abstract;
using BlogStore_NTIER_AI_DataAccessLayer.Abstract;

namespace BlogStore_NTIER_AI_BusinessLayer.Concrete
{
   public class CategoryManager : ICategoryService
    {
        public readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
    }
}
