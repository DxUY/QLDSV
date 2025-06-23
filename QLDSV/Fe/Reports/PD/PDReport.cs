using Microsoft.Reporting.WinForms;
using QLDSV.Be;
using QLDSV.Be.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace QLDSV.Fe.Reports.PD
{
    public partial class PDReport : Form
    {
        private readonly string _masv;
        private readonly string _hoten;
        private readonly string _tenLop;
        private readonly string _tenKhoa;

        public PDReport(string masv, string hoten, string tenLop, string tenKhoa)
        {
            InitializeComponent();
            _masv = masv;
            _hoten = hoten;
            _tenLop = tenLop;
            _tenKhoa = tenKhoa;

            Utils.HideExportFormats(reportViewer1.LocalReport, "PDF");
        }

        private void PDReport_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            string reportPath = GetReportPath();

            if (!File.Exists(reportPath))
            {
                MessageBox.Show($"RDLC file not found:\n{reportPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dataSource = GetReportData();

            if (dataSource == null || dataSource.Rows.Count == 0)
            {
                MessageBox.Show("Không thể lấy dữ liệu cho báo cáo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hoten = dataSource.Rows[0]["HOTENSV"].ToString();
            string lop = dataSource.Rows[0]["TENLOP"].ToString();
            string khoa = dataSource.Rows[0]["TENKHOA"].ToString();

            ConfigureReportViewer(reportPath, dataSource);
        }

        private string GetReportPath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Fe\Reports\PD\PD.rdlc");
        }

        private DataTable GetReportData()
        {
            string baseTable = "DANGKY dk";

            string joins = @"
                        JOIN LOPTINCHI ltc ON dk.MALTC = ltc.MALTC
                        JOIN MONHOC mh ON ltc.MAMH = mh.MAMH";

            string columns = @"
                        mh.TENMH,
                        dk.DIEM_CK";

            string where = "dk.MASV = @MASV";

            string groupBy = "";

            var parameters = new[]
            {
                new SqlParameter("@MASV", _masv)
            };

            return DbHandler.RunJoinedQuery(baseTable, joins, columns, where, groupBy, useDefault: false, parameters);
        }

        private void ConfigureReportViewer(string reportPath, DataTable data)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = reportPath;

            var reportDataSource = new ReportDataSource("PDReportTable", data);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            var reportParameters = new[]
            {

                new ReportParameter("HOTEN", _hoten),
                new ReportParameter("MASV", _masv),
                new ReportParameter("TENLOP", _tenLop),
                new ReportParameter("TENKHOA", _tenKhoa)
            };

            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }
    }
}
