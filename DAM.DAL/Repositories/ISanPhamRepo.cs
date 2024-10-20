using DAM.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM.DAL.Repositories
{
    public interface ISanPhamRepo
    {
        string Create(Sanpham sanpham);
        bool Delete(int id);    
        List<Sanpham> GetList();    
        bool Update(Sanpham sanpham);
    }
}
