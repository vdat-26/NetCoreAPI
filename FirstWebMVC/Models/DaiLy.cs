using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // Import thư viện hỗ trợ quan hệ khóa ngoại

namespace FirstWebMVC.Models
{
    public class DaiLy
    {
        [Key]
        public string? MaDaiLy { get; set; }

        [Required]
        public string? TenDaiLy { get; set; }

        public string? DiaChi { get; set; }
        public string? NguoiDaiDien { get; set; }
        public string? DienThoai { get; set; }

        // Khóa ngoại liên kết với HeThongPhanPhoi
        [ForeignKey("HeThongPhanPhoi")]
        public string? MaHTPP { get; set; }

        public HeThongPhanPhoi? HeThongPhanPhoi { get; set; }
    }
}
