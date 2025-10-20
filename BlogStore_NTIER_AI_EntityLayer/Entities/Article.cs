using System.ComponentModel.DataAnnotations;

namespace BlogStore_NTIER_AI_EntityLayer.Entities
{
   public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
     
        public DateTime CreatedDate { get; set; }
        public string Slug { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string? AppUserId { get; set; }
        public AppUser AppUser { get; set; }
       
        public List<Comment> Comments { get; set; }
    
    }
}
