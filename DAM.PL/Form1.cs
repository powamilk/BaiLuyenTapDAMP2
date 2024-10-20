using DAM.BUS.Service;
using DAM.BUS.ViewModel;

namespace DAM.PL
{
    public partial class Form1 : Form
    {
        List<SanPhamVM> _sanPhams;
        ISanPhamService _sanPhamService;

        public Form1()
        {
            _sanPhamService = new SanPhamService();
            InitializeComponent();
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
                    sp.IdNcc
                );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var sanPhamVM = new SanPhamUpdateVM
            {
                Id = int.Parse(dgv_sanpham.SelectedRows[0].Cells["Id"].Value.ToString()), 
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
            var id = int.Parse(dgv_sanpham.SelectedRows[0].Cells["Id"].Value.ToString());
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                var result = _sanPhamService.Delete(id);
                MessageBox.Show(result ? "Xóa thành công" : "Xóa thất bại", "Thông báo");
                LoadGridSanPham();
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
            if (e.RowIndex >= 0)
            {
                txt_ten.Text = dgv_sanpham.Rows[e.RowIndex].Cells["clm_ten"].Value.ToString();
                txt_mota.Text = dgv_sanpham.Rows[e.RowIndex].Cells["clm_mota"].Value.ToString();
                txt_soluongton.Text = dgv_sanpham.Rows[e.RowIndex].Cells["clm_soluongton"].Value.ToString();
                txt_giatien.Text = dgv_sanpham.Rows[e.RowIndex].Cells["clm_giatien"].Value.ToString();
                int idNcc = int.Parse(dgv_sanpham.Rows[e.RowIndex].Cells["clm_nhacungcap"].Value.ToString());
                cb_nhacungcap.SelectedValue = idNcc;

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
                else
                    return sp.Mota.ToLower().Contains(keyword);
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
                    sp.IdNcc 
                );
            }
        }
    }
}
