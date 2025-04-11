using System;
using System.Collections.Generic;

namespace B2_KetNoiDatabase.Models;

public partial class NhanVien
{
    public string MaNhanVien { get; set; } = null!;

    public string? TenNhanVien { get; set; }

    public string? GioiTinh { get; set; }

    public string? ChucVu { get; set; }
}
