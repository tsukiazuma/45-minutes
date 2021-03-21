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
    public partial class Quanlinhansu : Form
    {
        Models.DANGNHAP acc = new Models.DANGNHAP();
        public Quanlinhansu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form child = this.MdiChildren.OfType<Hotro>().FirstOrDefault();
            if (child == null)
            {
                Hotro fm = new Hotro();
                fm.MdiParent = this;
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.Show();
                return;
            }
            child.Activate();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form child = this.MdiChildren.OfType<Dangky>().FirstOrDefault();
            if (child == null)
            {
                Dangky fm = new Dangky();
                fm.MdiParent = this;
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.Show();
                return;
            }
            child.Activate();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form child = this.MdiChildren.OfType<Dangnhap>().FirstOrDefault();
            if (child == null)
            {
                Dangnhap fm = new Dangnhap();
                fm.MdiParent = this;
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.chungthucTK += DangNhapThanhCong;
                fm.Show();
                return;
            }
            child.Activate();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form child = this.MdiChildren.OfType<Quanlinhanvien>().FirstOrDefault();
            if (child == null)
            {
                Quanlinhanvien fm = new Quanlinhanvien();
                fm.MdiParent = this;
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.Show();
                return;
            }
            child.Activate();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form child = this.MdiChildren.OfType<Quanliphongban>().FirstOrDefault();
            if (child == null)
            {
                Quanliphongban fm = new Quanliphongban();
                fm.MdiParent = this;
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.Show();
                return;
            }
            child.Activate();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Form child = this.MdiChildren.OfType<Quanliduan>().FirstOrDefault();
            if (child == null)
            {
                Quanliduan fm = new Quanliduan();
                fm.MdiParent = this;
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.Show();
                return;
            }
            child.Activate();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
            acc = null;
            textBox1.Text = "";
            chucnang(false);
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form child = this.MdiChildren.OfType<Dangky>().FirstOrDefault();
            if (child == null)
            {
                Dangky fm = new Dangky();
                fm.MdiParent = this;
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.Show();
                return;
            }
            child.Activate();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form child = this.MdiChildren.OfType<Dangnhap>().FirstOrDefault();
            if (child == null)
            {
                Dangnhap fm = new Dangnhap();
                fm.MdiParent = this;
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.chungthucTK += DangNhapThanhCong;
                fm.Show();
                return;
            }
            child.Activate();
        }
        private void DangNhapThanhCong(Models.DANGNHAP taiKhoan)
        {
            this.acc = taiKhoan;
            textBox1.Text = acc.NHANVIEN.name_Nv.ToString();
            chucnang(true);
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form child = this.MdiChildren.OfType<Quanlinhanvien>().FirstOrDefault();
            if (child == null)
            {
                Quanlinhanvien fm = new Quanlinhanvien();
                fm.MdiParent = this;
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.Show();
                return;
            }
            child.Activate();
        }

        private void quảnLýPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form child = this.MdiChildren.OfType<Quanliphongban>().FirstOrDefault();
            if (child == null)
            {
                Quanliphongban fm = new Quanliphongban();
                fm.MdiParent = this;
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.Show();
                return;
            }
            child.Activate();
        }

        private void quảnLýDựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form child = this.MdiChildren.OfType<Quanliduan>().FirstOrDefault();
            if (child == null)
            {
                Quanliduan fm = new Quanliduan();
                fm.MdiParent = this;
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.Show();
                return;
            }
            child.Activate();
        }
        public void chucnang(bool value)
        {
            toolStripButton3.Visible = value;
            toolStripButton4.Visible = value;
            toolStripButton5.Visible = value;
            toolStripButton6.Visible = value;
            toolStripMenuItem1.Visible = value;
            chứcNăngToolStripMenuItem.Visible = !value;
            toolStripButton1.Visible = !value;
            toolStripButton2.Visible = !value;
            toolStripButton6.Visible = value;
            label1.Visible = value;
            textBox1.Visible = value;
        }

        private void Quanlinhansu_Load(object sender, EventArgs e)
        {
            chucnang(false);
        }

        private void thốngKêPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form child = this.MdiChildren.OfType<ThongkePB>().FirstOrDefault();
            if (child == null)
            {
                ThongkePB fm = new ThongkePB();
                fm.MdiParent = this;
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.Show();
                return;
            }
            child.Activate();
        }

        private void thốngKêDựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form child = this.MdiChildren.OfType<ThongkeDA>().FirstOrDefault();
            if (child == null)
            {
                ThongkeDA fm = new ThongkeDA();
                fm.MdiParent = this;
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.Show();
                return;
            }
            child.Activate();
        }
    }
}
