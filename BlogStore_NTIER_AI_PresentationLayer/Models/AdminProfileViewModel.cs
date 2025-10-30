using BlogStore_NTIER_AI_EntityLayer.Entities;

namespace BlogStore_NTIER_AI_PresentationLayer.Models
{
    public class AdminProfileViewModel
    {
        public AppUser User { get; set; }            
        public string NewPassword { get; set; }        
        public string ConfirmPassword { get; set; }
    }
}
