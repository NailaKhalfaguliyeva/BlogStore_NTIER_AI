using BlogStore_NTIER_AI_EntityLayer.Entities;

namespace BlogStore_NTIER_AI_PresentationLayer.Models
{
    public class CategoryWithArticlesViewModel
    {
        public List<Category> Categories { get; set; }
        public List<Article> Articles { get; set; }
        public int? SelectedCategoryId { get; set; }
    }
}
