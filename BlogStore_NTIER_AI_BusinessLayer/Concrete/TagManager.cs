using BlogStore_NTIER_AI_BusinessLayer.Abstract;
using BlogStore_NTIER_AI_DataAccessLayer.Abstract;
using BlogStore_NTIER_AI_EntityLayer.Entities;

namespace BlogStore_NTIER_AI_BusinessLayer.Concrete
{
   public class TagManager:ITagService
    {
        public readonly ITagDal _tagDal;

        public TagManager(ITagDal tagDal)
        {
            _tagDal = tagDal;
        }

        public void TDelete(int id)
        {
            _tagDal.Delete(id);
        }

        public List<Tag> TGetAll()
        {
            return _tagDal.GetAll();
        }

        public Tag TGetById(int id)
        {
            return _tagDal.GetById(id);
        }

        public void TInsert(Tag entity)
        {
            _tagDal.Insert(entity);
        }

        public void TUpdate(Tag entity)
        {
            _tagDal.Update(entity);
        }
    }
}
