
namespace DoAn
{
    partial class Quanlinhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quanlinhanvien));
            this.btnreset = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMada = new System.Windows.Forms.TextBox();
            this.txtMapb = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtTenNv = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtMaNv = new System.Windows.Forms.TextBox();
            this.lblMaDa = new System.Windows.Forms.Label();
            this.lblMaPb = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.lblTenNv = new System.Windows.Forms.Label();
            this.lblMaNv = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblTieude = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong_Nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Pb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Da = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnreset.Image = ((System.Drawing.Image)(resources.GetObject("btnreset.Image")));
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.Location = new System.Drawing.Point(174, 231);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(82, 31);
            this.btnreset.TabIndex = 66;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(524, 229);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 65;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(408, 229);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 64;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.Location = new System.Drawing.Point(292, 229);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 31);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMada
            // 
            this.txtMada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMada.Location = new System.Drawing.Point(466, 166);
            this.txtMada.Multiline = true;
            this.txtMada.Name = "txtMada";
            this.txtMada.Size = new System.Drawing.Size(149, 24);
            this.txtMada.TabIndex = 62;
            // 
            // txtMapb
            // 
            this.txtMapb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMapb.Location = new System.Drawing.Point(466, 129);
            this.txtMapb.Multiline = true;
            this.txtMapb.Name = "txtMapb";
            this.txtMapb.Size = new System.Drawing.Size(149, 24);
            this.txtMapb.TabIndex = 61;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.Location = new System.Drawing.Point(636, 48);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(113, 28);
            this.btnTim.TabIndex = 53;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.CustomFormat = "MM-dd-yyyy";
            this.dtpNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysinh.Location = new System.Drawing.Point(169, 167);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(151, 24);
            this.dtpNgaysinh.TabIndex = 52;
            // 
            // txtTenNv
            // 
            this.txtTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNv.Location = new System.Drawing.Point(169, 135);
            this.txtTenNv.Name = "txtTenNv";
            this.txtTenNv.Size = new System.Drawing.Size(149, 24);
            this.txtTenNv.TabIndex = 50;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearch.Location = new System.Drawing.Point(468, 50);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(147, 24);
            this.txtSearch.TabIndex = 54;
            // 
            // txtLuong
            // 
            this.txtLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtLuong.Location = new System.Drawing.Point(466, 96);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(149, 24);
            this.txtLuong.TabIndex = 58;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiachi.Location = new System.Drawing.Point(169, 201);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(149, 24);
            this.txtDiachi.TabIndex = 56;
            // 
            // txtMaNv
            // 
            this.txtMaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNv.Location = new System.Drawing.Point(169, 96);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.Size = new System.Drawing.Size(149, 24);
            this.txtMaNv.TabIndex = 48;
            // 
            // lblMaDa
            // 
            this.lblMaDa.AutoSize = true;
            this.lblMaDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaDa.Location = new System.Drawing.Point(358, 169);
            this.lblMaDa.Name = "lblMaDa";
            this.lblMaDa.Size = new System.Drawing.Size(69, 18);
            this.lblMaDa.TabIndex = 60;
            this.lblMaDa.Text = "Mã dự án";
            // 
            // lblMaPb
            // 
            this.lblMaPb.AutoSize = true;
            this.lblMaPb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaPb.Location = new System.Drawing.Point(358, 135);
            this.lblMaPb.Name = "lblMaPb";
            this.lblMaPb.Size = new System.Drawing.Size(102, 18);
            this.lblMaPb.TabIndex = 59;
            this.lblMaPb.Text = "Mã phòng ban";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLuong.Location = new System.Drawing.Point(358, 96);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(49, 18);
            this.lblLuong.TabIndex = 57;
            this.lblLuong.Text = "Lương";
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgaysinh.Location = new System.Drawing.Point(89, 169);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(73, 18);
            this.lblNgaysinh.TabIndex = 51;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // lblTenNv
            // 
            this.lblTenNv.AutoSize = true;
            this.lblTenNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenNv.Location = new System.Drawing.Point(91, 135);
            this.lblTenNv.Name = "lblTenNv";
            this.lblTenNv.Size = new System.Drawing.Size(52, 18);
            this.lblTenNv.TabIndex = 49;
            this.lblTenNv.Text = "Họ tên";
            // 
            // lblMaNv
            // 
            this.lblMaNv.AutoSize = true;
            this.lblMaNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaNv.Location = new System.Drawing.Point(91, 96);
            this.lblMaNv.Name = "lblMaNv";
            this.lblMaNv.Size = new System.Drawing.Size(53, 18);
            this.lblMaNv.TabIndex = 47;
            this.lblMaNv.Text = "Mã NV";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiachi.Location = new System.Drawing.Point(91, 204);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(53, 18);
            this.lblDiachi.TabIndex = 55;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblTieude
            // 
            this.lblTieude.AutoSize = true;
            this.lblTieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieude.Location = new System.Drawing.Point(280, 9);
            this.lblTieude.Name = "lblTieude";
            this.lblTieude.Size = new System.Drawing.Size(203, 25);
            this.lblTieude.TabIndex = 46;
            this.lblTieude.Text = "Quản lý nhân viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Nv,
            this.name_Nv,
            this.ngaysinh_Nv,
            this.diachi_Nv,
            this.luong_Nv,
            this.id_Pb,
            this.id_Da});
            this.dataGridView1.Location = new System.Drawing.Point(34, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 270);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id_Nv
            // 
            this.id_Nv.HeaderText = "Mã nhân viên";
            this.id_Nv.Name = "id_Nv";
            // 
            // name_Nv
            // 
            this.name_Nv.HeaderText = "Tên nhân viên";
            this.name_Nv.Name = "name_Nv";
            // 
            // ngaysinh_Nv
            // 
            this.ngaysinh_Nv.HeaderText = "Ngày sinh";
            this.ngaysinh_Nv.Name = "ngaysinh_Nv";
            // 
            // diachi_Nv
            // 
            this.diachi_Nv.HeaderText = "Địa chỉ";
            this.diachi_Nv.Name = "diachi_Nv";
            // 
            // luong_Nv
            // 
            this.luong_Nv.HeaderText = "Lương";
            this.luong_Nv.Name = "luong_Nv";
            // 
            // id_Pb
            // 
            this.id_Pb.HeaderText = "Mã PB";
            this.id_Pb.Name = "id_Pb";
            // 
            // id_Da
            // 
            this.id_Da.HeaderText = "Mã DA";
            this.id_Da.Name = "id_Da";
            // 
            // Quanlinhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMada);
            this.Controls.Add(this.txtMapb);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.txtTenNv);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtMaNv);
            this.Controls.Add(this.lblMaDa);
            this.Controls.Add(this.lblMaPb);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.lblNgaysinh);
            this.Controls.Add(this.lblTenNv);
            this.Controls.Add(this.lblMaNv);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblTieude);
            this.Name = "Quanlinhanvien";
            this.Text = "Quản lí Nhân viên";
            this.Load += new System.EventHandler(this.Quanlinhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMada;
        private System.Windows.Forms.TextBox txtMapb;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox txtTenNv;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtMaNv;
        private System.Windows.Forms.Label lblMaDa;
        private System.Windows.Forms.Label lblMaPb;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.Label lblTenNv;
        private System.Windows.Forms.Label lblMaNv;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblTieude;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong_Nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Pb;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Da;
    }
}

