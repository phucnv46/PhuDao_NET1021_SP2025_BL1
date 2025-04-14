using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace B3_Ontap.Models;

public partial class Sach
{
    public string MaSach { get; set; } = null!;

    [DisplayName("Tên Sách")]
    public string? TenSach { get; set; }

    [DisplayName("Đơn Giá")]

    public decimal? DonGia { get; set; }

    [DisplayName("Số trang")]

    public int? SoTrang { get; set; }
}
