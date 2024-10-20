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
            List<Sanpham> entities = _repo.GetList();
            var vms = entities.Select(e => SanPhamMapping.MapEntityToVM(e)).ToList();
            return vms;
        }

        public bool Update(SanPhamUpdateVM updateVM)
        {
            Sanpham entitiy = SanPhamMapping.MapUpdateVMToEntitiy(updateVM);
            var result = _repo.Update(entitiy);
            return result;
        }
    }
}
