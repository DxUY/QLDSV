using Microsoft.Reporting.WinForms;
using QLDSV.Be;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLDSV.Be.Utils;

namespace QLDSV.Fe.Reports.DSLTC
{
    public partial class DSLTCReport : Form
    {
        private readonly string _maKhoa;
        private readonly string _tenKhoa;
        private readonly string _nienKhoa;
        private readonly int _hocKy;

        public DSLTCReport(string maKhoa, string tenKhoa, string nienKhoa, int hocKy)
        {
            InitializeComponent();
            _maKhoa = maKhoa;
            _tenKhoa = tenKhoa;
            _nienKhoa = nienKhoa;
            _hocKy = hocKy;

            Utils.HideExportFormats(reportViewer1.LocalReport, "PDF");
        }

        private void DSLTCReport_Load(object sender, EventArgs e)
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

            var dataSource = GetReportData();

            if (dataSource == null)
            {
                MessageBox.Show("DataTable is null. Possibly a SQL error.", "Debug");
                return;
            }

            if (dataSource.Rows.Count == 0)
            {
                MessageBox.Show("Không thể lấy dữ liệu cho báo cáo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConfigureReportViewer(reportPath, dataSource);
        }

        private string GetReportPath()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Fe\Reports\DSLTC\DSLTC.rdlc");
            return path;
        }

        private DataTable GetReportData()
        {
            string baseTable = "LOPTINCHI ltc";

            string joins = @"
                JOIN MONHOC mh ON ltc.MAMH = mh.MAMH
                JOIN GIANGVIEN gv ON ltc.MAGV = gv.MAGV
                LEFT JOIN DANGKY dk ON ltc.MALTC = dk.MALTC";

            string columns = @"
                mh.TENMH,
                ltc.NHOM,
                gv.HO + ' ' + gv.TEN AS HOTEN,
                ltc.SOSVTOITHIEU,
                COUNT(dk.MASV) AS SLDANGKY";

            string where = @"
                ltc.MAKHOA = @MAKHOA
                AND ltc.NIENKHOA = @NIENKHOA
                AND ltc.HOCKY = @HOCKY
                AND ltc.HUYLOP = 0";

            string groupBy = "mh.TENMH, gv.HO, gv.TEN, ltc.NHOM, ltc.SOSVTOITHIEU";

            var parameters = new[]
            {
                new SqlParameter("@MAKHOA", _maKhoa),
                new SqlParameter("@NIENKHOA", _nienKhoa),
                new SqlParameter("@HOCKY", _hocKy)
            };

            try
            {
                var result = DbHandler.RunJoinedQuery(baseTable, joins, columns, where, groupBy, false, parameters);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Exception: " + ex.Message, "Error");
                return null;
            }
        }

        private void ConfigureReportViewer(string reportPath, DataTable data)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = reportPath;

            var reportDataSource = new ReportDataSource("LopTinChiReportTable", data);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            var reportParameters = new[]
            {
                new ReportParameter("TENKHOA", _tenKhoa),
                new ReportParameter("NIENKHOA", _nienKhoa),
                new ReportParameter("HOCKY", _hocKy.ToString()),
                new ReportParameter("COUNT", data.Rows.Count.ToString())
            };

            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }
    }
}
