
namespace BlogStore_NTIER_AI_BusinessLayer.Abstract
{
   public interface IGenericService<T> where T : class
    {
        void TInsert(T entity);
        void TDelete(int id);
        void TUpdate(T entity);
        List<T> TGetAll();
        T TGetById(int id);
    }
}
