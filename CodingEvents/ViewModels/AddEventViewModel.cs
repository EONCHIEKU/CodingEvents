using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
	public class AddEventViewModel
	{
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a description for your event.")]
        [StringLength(500, ErrorMessage = "Description is too long!")]
        public string? Description { get; set; }

		[EmailAddress]
		public string? ContactEmail { get; set; }
        [Required(ErrorMessage = "Location is required. FIX IT!")]
        [StringLength (50, MinimumLength = 3, ErrorMessage = "Thats Absract. Be specific. The location should have between 3 to 50 characters" )]
        public string Location { get; set; }
        [Required(ErrorMessage = "You cant miss some friends. put some name here")]
        [Range(0, 100000)]
        public int NumOfAttendees { get; set; }
        public bool  MustRegister { get; set; }
        
        [Compare("MustRegister", ErrorMessage = "No")]
        public bool IsTrue { get { return true; } }

    }
}
