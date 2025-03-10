using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Tự động tăng ID
        public int Id { get; set; }  // Thêm dòng này để dùng đúng chuẩn ASP.NET MVC

        public string? FullName { get; set; }
        public string? Address { get; set; }
    }
}
