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
    public partial class ThongkeDA : Form
    {
        public ThongkeDA()
        {
            InitializeComponent();
        }

        private void ThongkeDA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlynhasu_3FDataSet.DUAN' table. You can move, or remove it, as needed.
            this.dUANTableAdapter.Fill(this.quanlynhasu_3FDataSet.DUAN);
            // TODO: This line of code loads data into the 'quanlynhasu_3FDataSet.PHONGBAN' table. You can move, or remove it, as needed.
            this.pHONGBANTableAdapter.Fill(this.quanlynhasu_3FDataSet.PHONGBAN);

            this.reportViewer1.RefreshReport();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            using (var _dbContext = new Models.QuanlinhansuDBContext())
            {
                string query = "select * from NHANVIEN";
                List<ReportDA> listReport = _dbContext.Database.SqlQuery<ReportDA>(query).ToList();
                if (comboBox1.Text != "")
                {
                    listReport = listReport.Where(m => m.id_Da == comboBox1.Text).ToList();
                    this.reportViewer1.LocalReport.ReportPath = @"G:\Winform\DoAn\DoAn\ReportDA.rdlc";
                    var reportDataSource = new ReportDataSource("DataSet1", listReport);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                    this.reportViewer1.RefreshReport();
                }
            }
        }
    }
}
