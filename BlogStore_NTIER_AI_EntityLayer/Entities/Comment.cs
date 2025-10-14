namespace BlogStore_NTIER_AI_EntityLayer.Entities
{
   public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
