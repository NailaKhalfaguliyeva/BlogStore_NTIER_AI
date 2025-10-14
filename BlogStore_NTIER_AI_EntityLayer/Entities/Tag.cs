namespace BlogStore_NTIER_AI_EntityLayer.Entities
{
   public class Tag
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public List<ArticleTag> ArticleTags { get; set; }
    }
}
