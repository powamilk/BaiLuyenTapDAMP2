namespace DAM.PL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_sanpham = new DataGridView();
            btn_them = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_show = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_giatien = new TextBox();
            txt_ten = new TextBox();
            cb_nhacungcap = new ComboBox();
            label6 = new Label();
            txt_mota = new TextBox();
            txt_soluongton = new TextBox();
            label1 = new Label();
            txt_timkiem = new TextBox();
            btn_tim = new Button();
            cb_timkiem = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_sanpham).BeginInit();
            SuspendLayout();
            // 
            // dgv_sanpham
            // 
            dgv_sanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sanpham.Location = new Point(3, 248);
            dgv_sanpham.Name = "dgv_sanpham";
            dgv_sanpham.Size = new Size(832, 228);
            dgv_sanpham.TabIndex = 0;
            dgv_sanpham.CellClick += dgv_sanpham_CellClick;
            dgv_sanpham.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(599, 37);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(156, 54);
            btn_them.TabIndex = 1;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(599, 157);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(156, 54);
            btn_xoa.TabIndex = 2;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(599, 97);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(156, 54);
            btn_sua.TabIndex = 3;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_show
            // 
            btn_show.Location = new Point(2, 212);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(48, 30);
            btn_show.TabIndex = 5;
            btn_show.Text = "Show";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 46);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 7;
            label3.Text = "Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 117);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 8;
            label4.Text = "Giá Tiền";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 147);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 9;
            label5.Text = "Nhà Cung Cấp";
            // 
            // txt_giatien
            // 
            txt_giatien.Location = new Point(103, 114);
            txt_giatien.Name = "txt_giatien";
            txt_giatien.Size = new Size(264, 23);
            txt_giatien.TabIndex = 12;
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(103, 37);
            txt_ten.Name = "txt_ten";
            txt_ten.RightToLeft = RightToLeft.No;
            txt_ten.Size = new Size(264, 23);
            txt_ten.TabIndex = 14;
            // 
            // cb_nhacungcap
            // 
            cb_nhacungcap.FormattingEnabled = true;
            cb_nhacungcap.Location = new Point(104, 147);
            cb_nhacungcap.Name = "cb_nhacungcap";
            cb_nhacungcap.Size = new Size(263, 23);
            cb_nhacungcap.TabIndex = 15;
            cb_nhacungcap.SelectedIndexChanged += cb_nhacungcap_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 82);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 16;
            label6.Text = "Mô tả";
            // 
            // txt_mota
            // 
            txt_mota.Location = new Point(103, 74);
            txt_mota.Name = "txt_mota";
            txt_mota.Size = new Size(264, 23);
            txt_mota.TabIndex = 17;
            // 
            // txt_soluongton
            // 
            txt_soluongton.Location = new Point(104, 176);
            txt_soluongton.Name = "txt_soluongton";
            txt_soluongton.Size = new Size(264, 23);
            txt_soluongton.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 179);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 19;
            label1.Text = "Số Lượng tồn";
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(104, 217);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(264, 23);
            txt_timkiem.TabIndex = 20;
            // 
            // btn_tim
            // 
            btn_tim.Location = new Point(506, 219);
            btn_tim.Name = "btn_tim";
            btn_tim.Size = new Size(84, 25);
            btn_tim.TabIndex = 21;
            btn_tim.Text = "Tìm Kiếm";
            btn_tim.UseVisualStyleBackColor = true;
            btn_tim.Click += btn_tim_Click;
            // 
            // cb_timkiem
            // 
            cb_timkiem.FormattingEnabled = true;
            cb_timkiem.Location = new Point(374, 219);
            cb_timkiem.Name = "cb_timkiem";
            cb_timkiem.Size = new Size(126, 23);
            cb_timkiem.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 488);
            Controls.Add(cb_timkiem);
            Controls.Add(btn_tim);
            Controls.Add(txt_timkiem);
            Controls.Add(label1);
            Controls.Add(txt_soluongton);
            Controls.Add(txt_mota);
            Controls.Add(label6);
            Controls.Add(cb_nhacungcap);
            Controls.Add(txt_ten);
            Controls.Add(txt_giatien);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_show);
            Controls.Add(btn_sua);
            Controls.Add(btn_xoa);
            Controls.Add(btn_them);
            Controls.Add(dgv_sanpham);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_sanpham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_sanpham;
        private Button btn_them;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_show;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_giatien;
        private TextBox txt_ten;
        private ComboBox cb_nhacungcap;
        private Label label6;
        private TextBox txt_mota;
        private TextBox txt_soluongton;
        private Label label1;
        private TextBox txt_timkiem;
        private Button btn_tim;
        private ComboBox cb_timkiem;
    }
}
