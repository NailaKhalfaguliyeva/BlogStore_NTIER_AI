using BlogStore_NTIER_AI_EntityLayer.Entities;

namespace BlogStore_NTIER_AI_PresentationLayer.Models
{
    public class WriterWithArticleViewModel
    {
        public List<AppUser> Writers { get; set; }
        public List<Article> Articles { get; set; }
        public string SelectedAuthorId { get; set; }
    }
}
