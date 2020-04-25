
using System.ComponentModel.DataAnnotations;


namespace Umbraco.NoiThat.Core.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = " Họ và tên không được để trống.")]
        public string Name { get; set; }

        [Required(ErrorMessage = " Số điện thoại không được để trống.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Địa chỉ Email không được để trống.")]
        [EmailAddress(ErrorMessage = " Địa chỉ Email không đúng.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được để trống.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Nội dung không được để trống.")]
        public string Message { get; set; }

        public int ContactFormId { get; set; }
    }   
}
