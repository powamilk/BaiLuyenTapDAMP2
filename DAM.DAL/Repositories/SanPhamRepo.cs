using DAM.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM.DAL.Repositories
{
    public class SanPhamRepo : ISanPhamRepo
    {
        AppDbContext _context;

        public SanPhamRepo()
        {
            _context = new AppDbContext();
        }
        public string Create(Sanpham sanpham)
        {
            try
            {
                _context.Add(sanpham);
                _context.SaveChanges();
                return "Thêm Thành Công Sản Phẩm";
            }
            catch (Exception ex)
            {
                return "Thêm Thất Bại\n" + $"Lỗi: {ex.Message}";
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var queryable = _context.Sanphams.AsQueryable();
                Sanpham sanPham = queryable.FirstOrDefault(e => e.Id == id);

                if (sanPham != null)
                {
                    _context.Remove(sanPham);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public List<Sanpham> GetList()
        {
            var sanphams = _context.Sanphams
                            .Include(sp => sp.IdNccNavigation)
                            .ToList();
            return sanphams;
        }

        public bool Update(Sanpham sanpham)
        {
            try
            {
                var queryable = _context.Sanphams.AsQueryable();
                Sanpham existingSanPham = queryable.FirstOrDefault(e => e.Id == sanpham.Id);

                if (existingSanPham != null)
                {
                   existingSanPham.Ten = sanpham.Ten;   
                   existingSanPham.Mota = sanpham.Mota;
                   existingSanPham.Soluongtonkho = sanpham.Soluongtonkho;
                    existingSanPham.Giatien = sanpham.Giatien;
                    existingSanPham.IdNcc = sanpham.IdNcc;  

                    _context.Update(existingSanPham);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
