using DAM.BUS.Service;
using DAM.BUS.ViewModel;

namespace DAM.PL
{
    public partial class Form1 : Form
    {
        List<SanPhamVM> _sanPhams;
        ISanPhamService _sanPhamService;
        private int? selectedNhaCungCapId;
        private int selectedSanPhamId;

        public Form1()
        {
            _sanPhamService = new SanPhamService();
            InitializeComponent();
            LoadNhaCungCapToTimKiemComboBox();
            LoadNhaCungCapToComboBox();
            LoadFormDataSanPham();
        }

        private void LoadNhaCungCapToComboBox()
        {
            var nhaCungCaps = _sanPhamService.GetAllNhaCungCap(); 

            cb_nhacungcap.DataSource = nhaCungCaps;
            cb_nhacungcap.DisplayMember = "Ten";  
            cb_nhacungcap.ValueMember = "Id"; 
        }

        private void LoadNhaCungCapToTimKiemComboBox()
        {
            var nhaCungCaps = _sanPhamService.GetAllNhaCungCap(); 

            cb_timkiem.DataSource = nhaCungCaps;
            cb_timkiem.DisplayMember = "Ten"; 
            cb_timkiem.ValueMember = "Id"; 
        }

        private void LoadFormDataSanPham()
        {
            dgv_sanpham.Columns.Clear();
            dgv_sanpham.Columns.Add("clm_stt", "STT");
            dgv_sanpham.Columns.Add("clm_ten", "Tên Sản Phẩm");
            dgv_sanpham.Columns.Add("clm_mota", "Mô tả");
            dgv_sanpham.Columns.Add("clm_soluongton", "Số lượng tồn kho");
            dgv_sanpham.Columns.Add("clm_giatien", "Giá tiền");
            dgv_sanpham.Columns.Add("clm_nhacungcap", "Nhà cung cấp");
        }

        private void LoadGridSanPham()
        {
            _sanPhams = _sanPhamService.GetList();
            dgv_sanpham.Rows.Clear();

            int stt = 1;
            foreach (var sp in _sanPhams)
            {

                dgv_sanpham.Rows.Add(
                    stt++,
                    sp.Ten,
                    sp.Mota,
                    sp.Soluongtonkho,
                    sp.Giatien,
                    sp.NhaCungCap != null? sp.NhaCungCap.Ten : "null"
                );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var selectedNccId = cb_nhacungcap.SelectedValue;
            if (selectedNccId != null )
            {
                var sanPhamVM = new SanPhamCreateVM
                {
                    Ten = txt_ten.Text,
                    Mota = txt_mota.Text,
                    Soluongtonkho = int.Parse(txt_soluongton.Text),
                    Giatien = int.Parse(txt_giatien.Text),
                    IdNcc = int.Parse(cb_nhacungcap.SelectedValue.ToString())
                };
                var result = _sanPhamService.Create(sanPhamVM);
                MessageBox.Show(result, "Thông báo");
                LoadGridSanPham();
            }
            else
            {
                MessageBox.Show("Vui Lòng chọn nhà cung cấp");
            }

            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var sanPhamVM = new SanPhamUpdateVM
            {
                Id = selectedSanPhamId,
                Ten = txt_ten.Text,
                Mota = txt_mota.Text,
                Soluongtonkho = int.Parse(txt_soluongton.Text),
                Giatien = int.Parse(txt_giatien.Text),
                IdNcc = int.Parse(cb_nhacungcap.SelectedValue.ToString())
            };

            var result = _sanPhamService.Update(sanPhamVM);
            MessageBox.Show(result ? "Sửa thành công" : "Sửa thất bại", "Thông báo");
            LoadGridSanPham();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
           if(selectedSanPhamId != 0)
            {
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var result = _sanPhamService.Delete(selectedSanPhamId);
                    MessageBox.Show(result ? "Xóa thành công" : "Xóa thất bại", "Thông báo");
                    LoadGridSanPham();
                }
            }else
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm");
            }    
                   
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            LoadGridSanPham();
        }

        private void cb_nhacungcap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgv_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.RowIndex >= dgv_sanpham.Rows.Count)
                {
                    return;
                }
                int stt = int.Parse(dgv_sanpham.Rows[e.RowIndex].Cells["clm_stt"].Value.ToString());
                var selectedSanPham = _sanPhams[stt - 1];
                selectedSanPhamId = selectedSanPham.Id;
                txt_ten.Text = selectedSanPham.Ten;
                txt_mota.Text = selectedSanPham.Mota;
                txt_soluongton.Text = selectedSanPham.Soluongtonkho.ToString();
                txt_giatien.Text = selectedSanPham.Giatien.ToString();
                selectedNhaCungCapId = selectedSanPham.IdNcc;
                cb_nhacungcap.SelectedValue = selectedNhaCungCapId;
            } catch ( Exception ex )
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
                
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string keyword = txt_timkiem.Text.ToLower();
            var filterType = cb_timkiem.SelectedItem.ToString();

            var filteredList = _sanPhams.Where(sp =>
            {
                if (filterType == "Tên")
                    return sp.Ten.ToLower().Contains(keyword);
                else if (filterType == "Mô tả")
                    return sp.Mota.ToLower().Contains(keyword);
                else
                    return sp.NhaCungCap.Ten.ToLower().Contains(keyword);
            }).ToList();

            dgv_sanpham.Rows.Clear();
            int stt = 1;
            foreach (var sp in filteredList)
            {
                dgv_sanpham.Rows.Add(
                    stt++,
                    sp.Ten,
                    sp.Mota,
                    sp.Soluongtonkho,
                    sp.Giatien,
                    sp.NhaCungCap.Ten
                );
            }
        }
    }
}
