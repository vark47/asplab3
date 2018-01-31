using System.ComponentModel.DataAnnotations;
namespace FanSite.Models
{
    public class StoryResponse
    {
        [Required(ErrorMessage = "Please enter a story name")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a date")]
        public string Date { get; set; }
        [Required(ErrorMessage = "Please enter your story")]
        public string Story { get; set; }
        
    }
    
}