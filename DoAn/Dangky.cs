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
    public partial class Dangky : Form
    {
        QuanlinhansuDBContext db = new QuanlinhansuDBContext();
        public Dangky()
        {
            InitializeComponent();
            txtTaikhoan.ForeColor = Color.LightGray;
            txtTaikhoan.Text = "Nhập tài khoản";
            this.txtTaikhoan.Leave += new System.EventHandler(this.textBox1_Leave);
            this.txtTaikhoan.Enter += new System.EventHandler(this.textBox1_Enter);

            txtMaNv.ForeColor = Color.LightGray;
            txtMaNv.Text = "Nhập ID nhân viên của bạn";
            this.txtMaNv.Leave += new System.EventHandler(this.textBox2_Leave);
            this.txtMaNv.Enter += new System.EventHandler(this.textBox2_Enter);

            txtMatkhau.ForeColor = Color.LightGray;
            txtMatkhau.Text = "Nhập mật khẩu";
            this.txtMatkhau.Leave += new System.EventHandler(this.textBox3_Leave);
            this.txtMatkhau.Enter += new System.EventHandler(this.textBox3_Enter);

            txtNhaplai.ForeColor = Color.LightGray;
            txtNhaplai.Text = "Nhập lại mật khẩu";
            this.txtNhaplai.Leave += new System.EventHandler(this.textBox4_Leave);
            this.txtNhaplai.Enter += new System.EventHandler(this.textBox4_Enter);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtTaikhoan.Text == "")
            {
                txtTaikhoan.Text = "Nhập tài khoản";
                txtTaikhoan.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtTaikhoan.Text == "Nhập tài khoản")
            {
                txtTaikhoan.Text = "";
                txtTaikhoan.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtMaNv.Text == "Nhập ID nhân viên của bạn")
            {
                txtMaNv.Text = "";
                txtMaNv.ForeColor = Color.Black;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtMaNv.Text == "")
            {
                txtMaNv.Text = "Nhập ID nhân viên của bạn";
                txtMaNv.ForeColor = Color.Gray;
            }
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (txtMatkhau.Text == "Nhập mật khẩu")
            {
                txtMatkhau.Text = "";
                txtMatkhau.ForeColor = Color.Black;
            }
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (txtMatkhau.Text == "")
            {
                txtMatkhau.Text = "Nhập mật khẩu";
                txtMatkhau.ForeColor = Color.Gray;
            }
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (txtNhaplai.Text == "Nhập lại mật khẩu")
            {
                txtNhaplai.Text = "";
                txtNhaplai.ForeColor = Color.Black;
            }
        }
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (txtNhaplai.Text == "")
            {
                txtNhaplai.Text = "Nhập lại mật khẩu";
                txtNhaplai.ForeColor = Color.Gray;
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNhaplai.Text == txtMatkhau.Text)
                {
                    if(db.NHANVIENs.Find(txtMaNv.Text) == null)
                    {
                        MessageBox.Show("Không có mã nhân viên!!!");
                        return;
                    }
                    if(db.DANGNHAPs.Find(txtMaNv.Text) != null)
                    {
                        MessageBox.Show("Nhân viên đã có tài khoản!!!");
                        return;
                    }
                    DANGNHAP dangnhap = new DANGNHAP();
                    dangnhap.username = txtTaikhoan.Text;
                    dangnhap.password = txtMatkhau.Text;
                    dangnhap.id_Nv = txtMaNv.Text;
                    
                    db.DANGNHAPs.Add(dangnhap);
                    db.SaveChanges();
                    MessageBox.Show("Đăng ký tài khoản thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không đúng !");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Bạn nhập sai cú pháp !");
            }
        }
    }
}
