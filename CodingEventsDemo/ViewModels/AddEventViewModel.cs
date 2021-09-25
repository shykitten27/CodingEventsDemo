using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500, ErrorMessage = "Description too long!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Type is required.")]
        public EventType Type { get; set; }

        public List<SelectListItem> EventTypes { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(EventType.Conference.ToString(), ((int)EventType.Conference).ToString()),
            new SelectListItem(EventType.Meetup.ToString(), ((int)EventType.Meetup).ToString()),
            new SelectListItem(EventType.Workshop.ToString(), ((int)EventType.Workshop).ToString()),
            new SelectListItem(EventType.Social.ToString(), ((int)EventType.Social).ToString())
        };
        // <option value="0">Conference</option> first argument is text, second argument is value

        [Required(ErrorMessage = "Location is required.")]
        [StringLength(500, MinimumLength = 3, ErrorMessage = "Location must be between 3 and 500 characters.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Number of attendees is required.")]
        [Range(0, 100000, ErrorMessage = "Number of attendees must be between 0 and 100,000.")]
        public int NumOfAttendees { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        public bool IsTrue { get { return true; } }

        [Compare("IsTrue", ErrorMessage = "Registration required.")]
        public bool RegistrationRequired { get; set; }
    }
}
