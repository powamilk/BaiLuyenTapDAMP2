using DAM.BUS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAM.BUS.Service
{
    public interface ISanPhamService
    {
        List<SanPhamVM> GetList();
        string Create(SanPhamCreateVM createVM);
        bool Update(SanPhamUpdateVM updateVM);
        bool Delete(int id);
        List<NhaCungCapVM> GetAllNhaCungCap();

    }
}
