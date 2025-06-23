using Microsoft.Reporting.WinForms;
using QLDSV.Be;
using QLDSV.Be.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace QLDSV.Fe.Reports.BDLTC
{
    public partial class BDLTCReport : Form
    {
        private readonly string _tenKhoa;
        private readonly string _nienkhoa;
        private readonly string _hocky;
        private readonly string _maMH;
        private readonly string _tenMH;
        private readonly string _nhom;

        public BDLTCReport(string tenKhoa, string nienKhoa, string hocKy, string maMH, string tenMH, string nhom)
        {
            InitializeComponent();
            _tenKhoa = tenKhoa;
            _nienkhoa = nienKhoa;
            _hocky = hocKy;
            _maMH = maMH;
            _tenMH = tenMH;
            _nhom = nhom;

            Utils.HideExportFormats(reportViewer1.LocalReport, "PDF");
        }

        private void BDLTCReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
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

            var dataSource = GetReportData();

            if (dataSource == null || dataSource.Rows.Count == 0)
            {
                MessageBox.Show("Không thể lấy dữ liệu cho báo cáo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConfigureReportViewer(reportPath, dataSource, _tenKhoa);
        }

        private string GetReportPath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Fe\Reports\BDLTC\BDLTC.rdlc");
        }

        private DataTable GetReportData()
        {
            string baseTable = "DANGKY dk";

            string joins = @"
                        JOIN SINHVIEN sv ON dk.MASV = sv.MASV
                        JOIN LOPTINCHI ltc ON dk.MALTC = ltc.MALTC";

            string columns = @"
                        sv.HO,
                        sv.TEN,
                        dk.DIEM_CC,
                        dk.DIEM_GK,
                        dk.DIEM_CK,
                        (ISNULL(dk.DIEM_CC, 0) * 0.1 +
                         ISNULL(dk.DIEM_GK, 0) * 0.3 +
                         ISNULL(dk.DIEM_CK, 0) * 0.6) AS DIEM_HM";

            string where = @"
                        ltc.NIENKHOA = @NIENKHOA AND
                        ltc.HOCKY = @HOCKY AND
                        ltc.MAMH = @MAMH AND
                        ltc.NHOM = @NHOM AND
                        ltc.HUYLOP = 0";

            string groupBy = "";

            var parameters = new[]
            {
                new SqlParameter("@NIENKHOA", _nienkhoa),
                new SqlParameter("@HOCKY", _hocky),
                new SqlParameter("@MAMH", _maMH),
                new SqlParameter("@NHOM", _nhom)
            };

            return DbHandler.RunJoinedQuery(baseTable, joins, columns, where, groupBy, useDefault: false, parameters);
        }

        private void ConfigureReportViewer(string reportPath, DataTable data, string tenKhoa)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = reportPath;

            var reportDataSource = new ReportDataSource("SVDangKyReportTable", data);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            var reportParameters = new[]
            {
                new ReportParameter("TENKHOA", tenKhoa),
                new ReportParameter("NIENKHOA", _nienkhoa),
                new ReportParameter("HOCKY", _hocky),
                new ReportParameter("TENMH", _tenMH),
                new ReportParameter("NHOM", _nhom),
                new ReportParameter("COUNT", data.Rows.Count.ToString())
            };

            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }
    }
}
