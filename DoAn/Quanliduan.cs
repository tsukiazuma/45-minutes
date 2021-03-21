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
    public partial class Quanliduan : Form
    {
        QuanlinhansuDBContext db = new QuanlinhansuDBContext();
        public Quanliduan()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int sonv = 0;
            if (txtMaDA.Text.Trim() == "")
                MessageBox.Show("Mã dự án không được để trống !");
            else if (txtTenDA.Text.Trim() == "")
                MessageBox.Show("Tên dự án không được để trống !");
            else
            {
                DUAN da = new DUAN();
                da.id_Da = txtMaDA.Text;
                da.name_Da = txtTenDA.Text;
                da.sonv_Da = Convert.ToInt32(txtSoNVDA.Text);
                da.mota_Da = txtMotaDA.Text;

                db.DUANs.Add(da);
                db.SaveChanges();
            }
            Quanliduan_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DUAN da = db.DUANs.FirstOrDefault(da1 => da1.id_Da == txtMaDA.Text);
            da.id_Da = txtMaDA.Text;
            da.name_Da = txtTenDA.Text;
            da.sonv_Da = Convert.ToInt32(txtSoNVDA.Text);
            da.mota_Da = txtMotaDA.Text;

            db.SaveChanges();
            Quanliduan_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DUAN da = db.DUANs.FirstOrDefault(da1 => da1.id_Da == txtMaDA.Text);
            db.DUANs.Remove(da);
            db.SaveChanges();
            Quanliduan_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaDA.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
                txtTenDA.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
                txtSoNVDA.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
                txtMotaDA.Text = dataGridView1.Rows[row].Cells[3].Value.ToString();
            }
        }

        private void Quanliduan_Load(object sender, EventArgs e)
        {
            List<DUAN> listNV = db.DUANs.ToList();
            BindGrid(listNV);
        }

        private void BindGrid(List<DUAN> listDA)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listDA)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.id_Da;
                dataGridView1.Rows[index].Cells[1].Value = item.name_Da;
                dataGridView1.Rows[index].Cells[2].Value = item.sonv_Da;
                dataGridView1.Rows[index].Cells[3].Value = item.mota_Da;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<DUAN> listnv = new List<DUAN>();
                string ma = txtSearch.Text;
                listnv = db.DUANs.Where(nv => nv.id_Da == ma || nv.name_Da == ma).ToList();
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
