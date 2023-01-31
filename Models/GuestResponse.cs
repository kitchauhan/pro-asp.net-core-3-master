using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please Enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter your Email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify wheather you'll attend")]
        public bool? WillAttend { get; set; }
    }
}
