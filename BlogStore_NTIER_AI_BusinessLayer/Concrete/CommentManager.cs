

using BlogStore_NTIER_AI_BusinessLayer.Abstract;
using BlogStore_NTIER_AI_DataAccessLayer.Abstract;

namespace BlogStore_NTIER_AI_BusinessLayer.Concrete
{
   public class CommentManager:ICommentService
    {
       public readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
    }
}
