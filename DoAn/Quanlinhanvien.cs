using DoAn.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class Quanlinhanvien : Form
    {
        QuanlinhansuDBContext db = new QuanlinhansuDBContext();
        public Quanlinhanvien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int luongnv = 0;
            try
            {
                luongnv = int.Parse(txtLuong.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Kiểu dữ liệu của lương phải là kiểu số !");
            }
            if (txtMaNv.Text.Trim() == "")
                MessageBox.Show("Mã nhân viên không được để trống !");
            else if (txtTenNv.Text.Trim() == "")
                MessageBox.Show("Tên nhân viên không được để trống !");
            else if (luongnv == 0)
                MessageBox.Show("Thêm thất bại !");
            else
            {
                NHANVIEN nv = new NHANVIEN();
                nv.id_Nv = txtMaNv.Text;
                nv.name_Nv = txtTenNv.Text;
                nv.ngaysinh_Nv = dtpNgaysinh.Value.Date;
                nv.diachi_Nv = txtDiachi.Text;
                nv.luong_Nv = Convert.ToInt32(txtLuong.Text);
                nv.id_Pb = txtMapb.Text;
                nv.id_Da = txtMada.Text;

                db.NHANVIENs.Add(nv);
                db.SaveChanges();
            }
            //List<NHANVIEN> listnv = db.NHANVIENs.ToList();
            Quanlinhanvien_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = db.NHANVIENs.FirstOrDefault(nv1 => nv1.id_Nv == txtMaNv.Text);
            //nv.id_Nv = txtMaNv.Text;
            nv.name_Nv = txtTenNv.Text;
            nv.ngaysinh_Nv = dtpNgaysinh.Value.Date;
            nv.diachi_Nv = txtDiachi.Text;
            nv.luong_Nv = Convert.ToInt32(txtLuong.Text);
            nv.id_Pb = txtMapb.Text;
            nv.id_Da = txtMada.Text;

            db.SaveChanges();
            Quanlinhanvien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = db.NHANVIENs.FirstOrDefault(nv1 => nv1.id_Nv == txtMaNv.Text);
            db.NHANVIENs.Remove(nv);
            db.SaveChanges();
            Quanlinhanvien_Load(sender, e);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                List<NHANVIEN> listnv = new List<NHANVIEN>();
                string ma = txtSearch.Text;
                listnv = db.NHANVIENs.Where(nv => nv.id_Nv == ma).ToList();
                BindGrid(listnv);
            }
            catch
            {
                MessageBox.Show("Không tìm thấy!!!");
                return;
            }
        }

        public void BindGrid(List<NHANVIEN> listNV)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listNV)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.id_Nv;
                dataGridView1.Rows[index].Cells[1].Value = item.name_Nv;
                dataGridView1.Rows[index].Cells[2].Value = Convert.ToDateTime(item.ngaysinh_Nv).ToString("dd/MM/yyyy");
                dataGridView1.Rows[index].Cells[3].Value = item.diachi_Nv;
                dataGridView1.Rows[index].Cells[4].Value = item.luong_Nv;
                dataGridView1.Rows[index].Cells[5].Value = item.id_Pb;
                dataGridView1.Rows[index].Cells[6].Value = item.id_Da;

            }
        }

        private void Quanlinhanvien_Load(object sender, EventArgs e)
        {
            List<NHANVIEN> listNV = db.NHANVIENs.ToList();
            BindGrid(listNV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaNv.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                txtTenNv.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                dtpNgaysinh.Value = Convert.ToDateTime(dataGridView1.Rows[row].Cells[2].Value);
                txtDiachi.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
                txtLuong.Text = dataGridView1.Rows[row].Cells[4].Value.ToString();
                txtMapb.Text = dataGridView1.Rows[row].Cells[5].Value.ToString();
                txtMada.Text = dataGridView1.Rows[row].Cells[6].Value.ToString();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtDiachi.Text = "";
            txtLuong.Text = "";
            txtMaNv.Text = "";
            txtSearch.Text = "";
            txtTenNv.Text = "";
        }
    }
}
