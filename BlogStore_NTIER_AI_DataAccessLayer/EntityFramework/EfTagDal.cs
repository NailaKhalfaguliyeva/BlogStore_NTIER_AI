using BlogStore_NTIER_AI_DataAccessLayer.Abstract;
using BlogStore_NTIER_AI_DataAccessLayer.Context;
using BlogStore_NTIER_AI_DataAccessLayer.Repositories;
using BlogStore_NTIER_AI_EntityLayer.Entities;

namespace BlogStore_NTIER_AI_DataAccessLayer.EntityFramework
{
    public class EfTagDal : GenericRepository<Tag>, ITagDal
    {
        public EfTagDal(BlogContext blogContext) : base(blogContext)
        {
        }
    }
}
