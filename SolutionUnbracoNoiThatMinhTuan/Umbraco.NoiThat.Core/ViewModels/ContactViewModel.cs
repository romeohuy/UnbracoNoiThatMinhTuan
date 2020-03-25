
using System.ComponentModel.DataAnnotations;


namespace Umbraco.NoiThat.Core.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = " Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = " Phone is required.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Email invalid.")]
        public string Email { get; set; }

        [Required(ErrorMessage = " Subject is required.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Message is required.")]
        public string Message { get; set; }

        public int ContactFormId { get; set; }
    }   
}
