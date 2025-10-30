using BlogStore_NTIER_AI_EntityLayer.Entities;

namespace BlogStore_NTIER_AI_PresentationLayer.Models
{
    public class ArticleAdminViewModel
    {
        public List<Article> Articles { get; set; }
        public Article NewArticle { get; set; }
    }
}
