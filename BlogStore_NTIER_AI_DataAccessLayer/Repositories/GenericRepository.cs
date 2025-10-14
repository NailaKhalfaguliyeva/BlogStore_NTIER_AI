using BlogStore_NTIER_AI_DataAccessLayer.Abstract;
using BlogStore_NTIER_AI_DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogStore_NTIER_AI_DataAccessLayer.Repositories
{
   public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly BlogContext _blogContext;

        public GenericRepository(BlogContext blogContext)
        {
            _blogContext = blogContext;
        }
        public List<T> GetAll()
        {
            return _blogContext.Set<T>().ToList();

        }

        public T GetById(int id)
        {
            return _blogContext.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _blogContext.Set<T>().Add(entity);
            _blogContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _blogContext.Set<T>().Update(entity);
            _blogContext.SaveChanges();
        }
    }
}
