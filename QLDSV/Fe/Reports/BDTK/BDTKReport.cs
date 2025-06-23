using Microsoft.Reporting.WinForms;
using QLDSV.Be;
using QLDSV.Be.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.Fe.Reports.BDTK
{
    public partial class BDTKReport : Form
    {
        private readonly string _maLop;
        private readonly string _tenLop;
        private readonly string _tenKhoa;
        private readonly string _khoaHoc;


        public BDTKReport(string maLop, string tenLop, string tenKhoa, string khoaHoc)
        {
            InitializeComponent();
            _maLop = maLop;
            _tenLop = tenLop;
            _tenKhoa = tenKhoa;
            _khoaHoc = khoaHoc;

            Utils.HideExportFormats(reportViewer1.LocalReport, "PDF");
        }

        private void BDTKReport_Load(object sender, EventArgs e)
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

            if (dataSource == null || dataSource.Rows.Count == 0)
            {
                MessageBox.Show("Không thể lấy dữ liệu cho báo cáo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConfigureReportViewer(reportPath, dataSource);
        }

        private string GetReportPath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Fe\Reports\BDTK\BDTK.rdlc");
        }

        private DataTable GetReportData()
        {
            string baseTable = "SINHVIEN sv";

            string joins = @"
                    INNER JOIN DANGKY dk ON sv.MASV = dk.MASV AND dk.HUYDANGKY = 0
                    INNER JOIN LOPTINCHI ltc ON dk.MALTC = ltc.MALTC
                    INNER JOIN MONHOC mh ON ltc.MAMH = mh.MAMH";

            string columns = @"
                    sv.MASV,
                    sv.HO + ' ' + sv.TEN AS HOTEN,
                    mh.TENMH,
                    MAX(ISNULL(dk.DIEM_CC, 0) * 0.1 + ISNULL(dk.DIEM_GK, 0) * 0.3 + ISNULL(dk.DIEM_CK, 0) * 0.6) AS DIEM_HM";

            string where = "sv.MALOP = @maLop";

            string groupBy = "sv.MASV, sv.HO + ' ' + sv.TEN, mh.TENMH";

            var parameters = new[]
            {
                new SqlParameter("@maLop", _maLop)
            };

            return DbHandler.RunJoinedQuery(baseTable, joins, columns, where, groupBy, true, parameters);
        }

        private void ConfigureReportViewer(string reportPath, DataTable data)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportPath = reportPath;

            var reportDataSource = new ReportDataSource("BDTKReportTable", data);
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            var reportParameters = new[]
            {
                new ReportParameter("TENLOP", _tenLop),
                new ReportParameter("KHOAHOC", _khoaHoc),
                new ReportParameter("TENKHOA", _tenKhoa)
            };

            reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.RefreshReport();
        }
    }
}
