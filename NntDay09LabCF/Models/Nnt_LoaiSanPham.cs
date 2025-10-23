using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NntDay09LabCF.Models
{
    [Table("Nnt_LoaiSanPham")]
    public class Nnt_LoaiSanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int nntId { get; set; }
        [Display(Name = "Mã Loại")]
        [StringLength(10)]
        public string nntMaLoai { get; set; }
        [Display(Name = "Tên Loại")]
        [StringLength(100)]
        public string nntTenLoai { get; set; } = null!;

        public ICollection<Nnt_SanPham>? Nnt_SanPhams { get; set; }
    }
}
