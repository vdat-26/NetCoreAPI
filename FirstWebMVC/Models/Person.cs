using System.ComponentModel.DataAnnotations; // Thư viện hỗ trợ validation

namespace FirstWebMVC.Models
{
    public class Person
    {
        [Key] // Đánh dấu PersonId là khóa chính
        public string? PersonId { get; set; }

        [Required(ErrorMessage = "Họ và tên không được để trống")]
        [StringLength(100, ErrorMessage = "Tên không được dài hơn 100 ký tự")]
        public string? FullName { get; set; }

        [Required]
        public string? Address { get; set; }

        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string? Email { get; set; }
    }
}
