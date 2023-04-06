using System.ComponentModel.DataAnnotations;
namespace CodingEvents.ViewModels
{
    public class AddEventCategoryViewModel
    {
        [Required(ErrorMessage = "Please enter a category.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Name must contain a minimum of 3 characters and a maximum of 20.")]
        public string? Name { get; set; }
    }
}
