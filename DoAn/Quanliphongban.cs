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
    public partial class Quanliphongban : Form
    {
        QuanlinhansuDBContext db = new QuanlinhansuDBContext();
        public Quanliphongban()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int sonv = 0;
            if (txtMaPB.Text.Trim() == "")
                MessageBox.Show("Mã dự án không được để trống !");
            else if (txtMaPB.Text.Trim() == "")
                MessageBox.Show("Tên dự án không được để trống !");
            else
            {
                PHONGBAN pb = new PHONGBAN();
                pb.id_Pb = txtMaPB.Text;
                pb.name_Pb = txtTenPB.Text;
                pb.sonv_Pb = Convert.ToInt32(txtSoNV.Text);
                pb.mota_Pb = txtMota.Text;

                db.PHONGBANs.Add(pb);
                db.SaveChanges();
            }
            Quanliphongban_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            PHONGBAN pb = db.PHONGBANs.FirstOrDefault(da1 => da1.id_Pb == txtMaPB.Text);
            pb.id_Pb = txtMaPB.Text;
            pb.name_Pb = txtTenPB.Text;
            pb.sonv_Pb = Convert.ToInt32(txtSoNV.Text);
            pb.mota_Pb = txtMota.Text;

            db.SaveChanges();
            Quanliphongban_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PHONGBAN pb = db.PHONGBANs.FirstOrDefault(da1 => da1.id_Pb == txtMaPB.Text);
            db.PHONGBANs.Remove(pb);
            db.SaveChanges();
            Quanliphongban_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaPB.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                txtTenPB.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                txtSoNV.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
                txtMota.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            }
        }

        private void Quanliphongban_Load(object sender, EventArgs e)
        {
            List<PHONGBAN> listPB = db.PHONGBANs.ToList();
            BindGrid(listPB);
        }

        private void BindGrid(List<PHONGBAN> listPB)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listPB)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.id_Pb;
                dataGridView1.Rows[index].Cells[1].Value = item.name_Pb;
                dataGridView1.Rows[index].Cells[2].Value = item.sonv_Pb;
                dataGridView1.Rows[index].Cells[3].Value = item.mota_Pb;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<PHONGBAN> listnv = new List<PHONGBAN>();
                string ma = txtSearch.Text;
                listnv = db.PHONGBANs.Where(nv => nv.id_Pb == ma).ToList();
                BindGrid(listnv);
            }
            catch
            {
                MessageBox.Show("Không tìm thấy!!!");
                return;
            }
        }
    }
}
