using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage ="Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")] //min 3 and max 50
        public string Name { get; set; }
        [Required(ErrorMessage ="Please enter a description for your event.")]
        [StringLength(500, ErrorMessage = "Description is too long!")] //max 500
        public string Description { get; set; }
        [EmailAddress] //helps validate
        public string ContactEmail { get; set; }
    }
}