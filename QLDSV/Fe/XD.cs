using QLDSV.Be;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSV.Fe
{
    public partial class XD : UserControl
    {
        private readonly string _masv;
        private readonly string _name;
        private readonly string _tenLop;
        private readonly string _tenKhoa;

        public XD(string masv, string name, string tenLop, string tenKhoa)
        {
            InitializeComponent();
            _masv = masv;
            _name = name;
            _tenLop = tenLop;
            _tenKhoa = tenKhoa;

            LoadSVInfo();
            LoadRegisteredCourses();
        }

        private void LoadSVInfo()
        {
            masv.Text = _masv;
            ten.Text = _name;
            lop.Text = _tenLop;
            khoa.Text = _tenKhoa;
        }

        private void LoadRegisteredCourses()
        {
            var courseData = DbHandler.RunJoinedQuery("DANGKY DK", "JOIN LOPTINCHI LTC ON DK.MALTC = LTC.MALTC JOIN MONHOC MH ON LTC.MAMH = MH.MAMH",
                                                    "LTC.NIENKHOA, LTC.HOCKY, DK.MALTC, MH.TENMH, DK.DIEM_CC, DK.DIEM_GK, DK.DIEM_CK",
                                                    "DK.MASV = @masv", "", true, new[] { new SqlParameter("@masv", _masv) });

            main.DataSource = courseData;

            main.GroupColumnDescriptions.Add(new GroupColumnDescription { ColumnName = "NIENKHOA" });
            main.GroupColumnDescriptions.Add(new GroupColumnDescription { ColumnName = "HOCKY" });
        }
    }
}
