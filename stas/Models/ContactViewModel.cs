using System.ComponentModel.DataAnnotations;

namespace stas.Models
{
    public class ContactViewModel
    {
        [Required (ErrorMessage ="please provide your name")]
        public string Name { get; set; }

        [Required (ErrorMessage ="please provide your email adress")]
        [EmailAddress (ErrorMessage ="please enter a valid email adress")]
        public string Email { get; set; }

        [Required (ErrorMessage ="please fill in the subject")]
        public string Subject { get; set; }

        [Required (ErrorMessage ="please fill in your email adress")]
        [MaxLength(500, ErrorMessage ="Your message must be 500 characters or less")]
        public string Message { get; set; }
    }
}