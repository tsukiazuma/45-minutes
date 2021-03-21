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
    public partial class Dangnhap : Form
    {
        public delegate void chungthuctk(Models.DANGNHAP taiKhoan);
        public event chungthuctk chungthucTK;
        public Dangnhap()
        {
            InitializeComponent();
            txtTaiKhoan.ForeColor = Color.LightGray;
            txtTaiKhoan.Text = "Nhập tài khoản";
            this.txtTaiKhoan.Leave += new System.EventHandler(this.textBox1_Leave);
            this.txtTaiKhoan.Enter += new System.EventHandler(this.textBox1_Enter);

            txtMatKhau.ForeColor = Color.LightGray;
            txtMatKhau.Text = "Nhập mật khẩu";
            this.txtMatKhau.Leave += new System.EventHandler(this.textBox2_Leave);
            this.txtMatKhau.Enter += new System.EventHandler(this.textBox2_Enter);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                txtTaiKhoan.Text = "Nhập tài khoản";
                txtTaiKhoan.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "Nhập tài khoản")
            {
                txtTaiKhoan.Text = "";
                txtTaiKhoan.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Nhập mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "Nhập mật khẩu";
                txtMatKhau.ForeColor = Color.Gray;
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "")
            {
                using (var _dbcontext = new Models.QuanlinhansuDBContext())
                {
                    string TaiKhoan = txtTaiKhoan.Text;
                    string MatKhau = txtMatKhau.Text;
                    Models.DANGNHAP tk = _dbcontext.DANGNHAPs.Where(ac => ac.username == TaiKhoan && ac.password == MatKhau).FirstOrDefault();
                    if (tk != null)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        this.Close();
                        chungthucTK(tk);
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại");
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
