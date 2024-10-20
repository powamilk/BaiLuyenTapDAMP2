using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM.BUS.ViewModel
{
    public class SanPhamUpdateVM
    {
        public int Id { get; set; }
        public string Ten { get; set; } = null!;

        public string Mota { get; set; } = null!;

        public int? Soluongtonkho { get; set; }

        public int? Giatien { get; set; }

        public int? IdNcc { get; set; }
    }
}
