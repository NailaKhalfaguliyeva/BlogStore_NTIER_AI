namespace BlogStore_NTIER_AI_EntityLayer.Entities
{
   public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string ImageUrl { get; set; }
        public List<Article> Articles { get; set; }
    }
}
