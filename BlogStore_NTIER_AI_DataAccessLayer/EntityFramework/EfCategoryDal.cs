using BlogStore_NTIER_AI_DataAccessLayer.Abstract;
using BlogStore_NTIER_AI_DataAccessLayer.Repositories;
using BlogStore_NTIER_AI_EntityLayer.Entities;

namespace BlogStore_NTIER_AI_DataAccessLayer.EntityFramework
{
   public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
    }
}
