
using BlogStore_NTIER_AI_EntityLayer.Entities;

namespace BlogStore_NTIER_AI_BusinessLayer.Abstract
{
   public interface ICommentService : IGenericService<Comment>
    {
        public List<Comment> TGetCommentsByArticle(int id);
        List<Comment> TGetAllComments();
        List<Comment> TGetLast3CommentsByArticle(string id);
    }
}
