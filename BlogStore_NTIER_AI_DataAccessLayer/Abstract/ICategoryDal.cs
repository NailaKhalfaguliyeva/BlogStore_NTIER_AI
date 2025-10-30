using BlogStore_NTIER_AI_DataAccessLayer.Dtos;
using BlogStore_NTIER_AI_EntityLayer.Entities;

namespace BlogStore_NTIER_AI_DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        List<CategoryWithArticleCountDto> GetCategoryWithArticleCount();
    }
}
