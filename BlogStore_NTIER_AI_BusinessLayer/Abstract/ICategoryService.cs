using BlogStore_NTIER_AI_DataAccessLayer.Dtos;
using BlogStore_NTIER_AI_EntityLayer.Entities;

namespace BlogStore_NTIER_AI_BusinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        public List<CategoryWithArticleCountDto> TGetCategoryWithArticleCount();
    }
}
