using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NntDay09LabCF.Models
{
    [Table("Nnt_SanPham")]
    public class Nnt_SanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int nntId { get; set; }
        [Display(Name = "Mã Sản Phẩm")]
        [StringLength(10)]
        public string nntMaSanPham { get; set; }
        [Display(Name = "Tên Sản Phẩm")]
        [StringLength(100)]
        public string nntTenSanPham { get; set; } = null!;
        [Display(Name = "Giá Sản Phẩm")]
        public string nntHinhAnh { get; set; } = null!;
        public int nntSoLuong { get; set; }
        public decimal nntDonGia { get; set; }
        [Display(Name = "Mô Tả Sản Phẩm")]
        [StringLength(500)]
        public string nntMaLoai { get; set; }
        public bool nntTrangThai { get; set; } = false;

        public Nnt_LoaiSanPham? Nnt_LoaiSanPham { get; set; }
    }
}
