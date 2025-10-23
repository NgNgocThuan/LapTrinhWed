using Microsoft.EntityFrameworkCore;

namespace NntDay09LabCF.Models
{
    public class NntDay09LabCFContext:DbContext
    {
        public NntDay09LabCFContext(DbContextOptions<NntDay09LabCFContext> options) : base(options)
        {
        }
        public DbSet<Nnt_SanPham> Nnt_SanPhams { get; set; }
        public DbSet<Nnt_LoaiSanPham> Nnt_LoaiSanPhams { get; set; }    
    }
}
