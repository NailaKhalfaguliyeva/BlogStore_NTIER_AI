namespace BlogStore_NTIER_AI_DataAccessLayer.Abstract
{
   public interface IGenericDal<T> where T : class
    {
        void Insert(T entity);
        void Delete(int id);
        void Update(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}
