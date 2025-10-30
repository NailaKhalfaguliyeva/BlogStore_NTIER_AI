using BlogStore_NTIER_AI_EntityLayer.Entities;

namespace BlogStore_NTIER_AI_PresentationLayer.Models
{
    public class AuthorProfileViewModel
    {
        public AppUser Author { get; set; }               
        public List<Article> Articles { get; set; }
    }
}
