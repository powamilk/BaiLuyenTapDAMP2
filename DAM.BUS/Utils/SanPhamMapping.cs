using DAM.BUS.ViewModel;
using DAM.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM.BUS.Utils
{
    public class SanPhamMapping
    {
        public static SanPhamVM MapEntityToVM(Sanpham entity)
        {
            return new()
            {
                Id = entity.Id,
                Ten = entity.Ten,
                Mota = entity.Mota,
                Soluongtonkho = entity.Soluongtonkho,
                Giatien = entity.Giatien,
                IdNcc = entity.IdNcc,
            };
        }


        public static Sanpham MapCreateVMToEntity(SanPhamCreateVM createVM)
        {
            return new()
            {
                Id = createVM.Id,
                Ten = createVM.Ten,
                Mota = createVM.Mota,
                Soluongtonkho = createVM.Soluongtonkho,
                Giatien = createVM.Soluongtonkho,
                IdNcc = createVM.IdNcc,
            };
        }

        public static Sanpham MapUpdateVMToEntitiy(SanPhamUpdateVM updateVM)
        {
            return new()
            {
                Id = updateVM.Id,
                Ten = updateVM.Ten,
                Mota = updateVM.Mota,
                Soluongtonkho = updateVM.Soluongtonkho,
                Giatien = updateVM.Soluongtonkho,
                IdNcc = updateVM.IdNcc,
            };
        }
    }
}
