using System;
using System.Collections.Generic;

namespace DAM.DAL.Entities;

public partial class Nhacungcap
{
    public int Id { get; set; }

    public string Ten { get; set; } = null!;

    public string? Diachi { get; set; }

    public virtual ICollection<Sanpham> Sanphams { get; set; } = new List<Sanpham>();
}
