using System;
using System.Collections.Generic;

namespace TvcDay07EF.Models;

public partial class SanPham1
{
    public string MaSp { get; set; } = null!;

    public string TenSp { get; set; } = null!;

    public DateOnly NgaySx { get; set; }

    public DateOnly NgayHh { get; set; }

    public string DonVi { get; set; } = null!;

    public decimal DonGia { get; set; }

    public string? GhiChu { get; set; }
}
