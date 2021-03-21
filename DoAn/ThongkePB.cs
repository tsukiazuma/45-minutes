using Microsoft.Reporting.WinForms;
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
    public partial class ThongkePB : Form
    {
        public ThongkePB()
        {
            InitializeComponent();
        }

        private void ThongkePB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlynhasu_3FDataSet.PHONGBAN' table. You can move, or remove it, as needed.
            this.pHONGBANTableAdapter.Fill(this.quanlynhasu_3FDataSet.PHONGBAN);
            // TODO: This line of code loads data into the 'quanlynhasu_3FDataSet.DUAN' table. You can move, or remove it, as needed.
            this.dUANTableAdapter.Fill(this.quanlynhasu_3FDataSet.DUAN);

            this.reportViewer1.RefreshReport();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            using (var _dbContext = new Models.QuanlinhansuDBContext())
            {
                string query = "select * from NHANVIEN";
                List<ReportPB> listReport = _dbContext.Database.SqlQuery<ReportPB>(query).ToList();
                if (comboBox1.Text != "")
                {
                    listReport = listReport.Where(m => m.id_Pb == comboBox1.Text).ToList();
                    this.reportViewer1.LocalReport.ReportPath = @"G:\Winform\DoAn\DoAn\ReportPB.rdlc";
                    var reportDataSource = new ReportDataSource("DataSet1", listReport);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                    this.reportViewer1.RefreshReport();
                }
            }
        }
    }
}
