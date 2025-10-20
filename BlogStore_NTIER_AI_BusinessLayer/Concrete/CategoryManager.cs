
using BlogStore_NTIER_AI_BusinessLayer.Abstract;
using BlogStore_NTIER_AI_DataAccessLayer.Abstract;
using BlogStore_NTIER_AI_EntityLayer.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlogStore_NTIER_AI_BusinessLayer.Concrete
{
   public class CategoryManager : ICategoryService
    {
        public readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(int id)
        {
            _categoryDal.Delete(id);
        }

        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id); ;
        }

        public void TInsert(Category entity)
        {
            if (entity.CategoryName != "" && entity.CategoryName.Length >= 3 && entity.CategoryName.Length <= 30 && entity.CategoryName.Contains('a'))
            {
                _categoryDal.Insert(entity);
            }
            else
            {
               // error message
            }
        }

        public void TUpdate(Category entity)
        {
            if (entity.CategoryName != null)
            {
                _categoryDal.Update(entity);
            }
            else
            {
                // error message
            }
        }
    }
}
