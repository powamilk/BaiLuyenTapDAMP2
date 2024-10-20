using DAM.BUS.Utils;
using DAM.BUS.ViewModel;
using DAM.DAL;
using DAM.DAL.Entities;
using DAM.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM.BUS.Service
{
    public class SanPhamService : ISanPhamService 
    {
        private readonly ISanPhamRepo _repo;
        private readonly AppDbContext _context;

        public SanPhamService()
        {
            _repo = new SanPhamRepo();
            _context = new AppDbContext();
        }
        public string Create(SanPhamCreateVM createVM)
        {
            Sanpham entity = SanPhamMapping.MapCreateVMToEntity(createVM);
            var result = _repo.Create(entity);
            return result;
        }

        public List<NhaCungCapVM> GetAllNhaCungCap()
        {
            var nhaCungCaps = _context.Nhacungcaps.ToList(); 
            var nhaCungCapVMs = nhaCungCaps.Select(ncc => new NhaCungCapVM
            {
                Id = ncc.Id,
                Ten = ncc.Ten
            }).ToList();

            return nhaCungCapVMs;
        }


        public bool Delete(int id)
        {
            var result = _repo.Delete(id);
            return result;
        }

        public List<SanPhamVM> GetList()
        {
            var sanphams = _repo.GetList();
            var sanPhamVMs = sanphams.Select(sp => new SanPhamVM
            {
                Id = sp.Id,
                Ten = sp.Ten,
                Mota = sp.Mota,
                Soluongtonkho = sp.Soluongtonkho ?? 0,
                Giatien = sp.Giatien ?? 0,
                IdNcc = sp.IdNcc ?? 0,
                NhaCungCap = sp.IdNccNavigation != null
                             ? new NhaCungCapVM
                             {
                                 Id = sp.IdNccNavigation.Id,
                                 Ten = sp.IdNccNavigation.Ten,
                                 Diachi = sp.IdNccNavigation.Diachi
                             }
                             : null  
            }).ToList();

            return sanPhamVMs;
        }

        public bool Update(SanPhamUpdateVM updateVM)
        {
            Sanpham entitiy = SanPhamMapping.MapUpdateVMToEntitiy(updateVM);
            var result = _repo.Update(entitiy);
            return result;
        }
    }
}
