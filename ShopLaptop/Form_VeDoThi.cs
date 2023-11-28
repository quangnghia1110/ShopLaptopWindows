using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf.Charts.Base;
using LiveCharts.Wpf;
using ShopLaptop.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq.Mapping;
using System.Globalization;
using System.Windows.Media;
using System.Data.SqlClient;

namespace ShopLaptop
{
    public partial class Form_VeDoThi : Form
    {
        BUS_HoaDon bUS_HoaDon = new BUS_HoaDon();
        BUS_Laptop bUS_Laptop = new BUS_Laptop();
        BUS_PhieuNhapKho bUS_PhieuNhapKho = new BUS_PhieuNhapKho();
        MyConnect myconn = new MyConnect();
        public Form_VeDoThi()
        {
            InitializeComponent();
            LoadSoLuongPhieuNhap();
            LoadSPBanChay();
            LoadDoanhSoLaptop();
            LoadSoLuongHoaDon();
            LoadPTThanhToan();
            LoadSPConHang();
        }

        private void btn_DoThiTheoNam_Load_Click(object sender, EventArgs e)
        {
            LoadDoanhSoLaptop();
        }
        private void LoadDoanhSoLaptop()
        {
            linechart_HoaDonTheoThang.AxisX.Clear();
            linechart_HoaDonTheoThang.AxisY.Clear();
            linechart_HoaDonTheoThang.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Months",
                Labels = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" }
            });
            linechart_HoaDonTheoThang.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Total",
                MinValue = 0,
            });
            linechart_HoaDonTheoThang.Series.Clear();
            linechart_HoaDonTheoThang.Series = new SeriesCollection();
            linechart_HoaDonTheoThang.LegendLocation = LiveCharts.LegendLocation.Right;
            var years = bUS_HoaDon.SelectDistinctYear();
            foreach (var year in years)
            {
                List<int> totalList = new List<int>();
                for (int month = 1; month <= 12; month++)
                {
                    int total = bUS_HoaDon.SumSoTienOnMonthAndYear(month, year);
                    totalList.Add(total);
                }
                linechart_HoaDonTheoThang.Series.Add(new LineSeries()
                {
                    Title = year.ToString(),
                    Values = new ChartValues<int>(totalList)
                });
            }
        }
        private void LoadSPBanChay()
        {
            if (txt_SPBanChay_Year.Text == string.Empty)
            {
                txt_SPBanChay_Year.Text = DateTime.Now.Year.ToString();
            }
            
            List<string> labels = new List<string>();

            chart_SPBanChay.AxisX.Clear();
            chart_SPBanChay.AxisY.Clear();
            chart_SPBanChay.Series.Clear();
            chart_SPBanChay.Series = new SeriesCollection();

            DataTable result = this.bUS_Laptop.SelectNameTop5BuyedLaptop(this.txt_SPBanChay_Year.Text);
            List<int> values = new List<int>();
            for (int i = 0; i < result.Rows.Count; i++)
            {
                DataRow row = result.Rows[i];
                labels.Add(row["TenLT"].ToString());
                values.Add(Convert.ToInt32(row["Total"]));
            }
            chart_SPBanChay.Series.Add(new ColumnSeries
            {
                Values = new ChartValues<int>(values)
            });

            
            chart_SPBanChay.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Laptops",
                Labels = labels,
            });
            chart_SPBanChay.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Total",
                MinValue = 0,
            });
        }

        private void btn_SPBanChay_Load_Click(object sender, EventArgs e)
        {
            LoadSPBanChay();
        }

        private void btn_SoLuongHoaDon_Load_Click(object sender, EventArgs e)
        {
            LoadSoLuongHoaDon();
        }
        public void LoadSoLuongHoaDon()
        {
            chart_HoaDon.AxisX.Clear();
            chart_HoaDon.AxisY.Clear();
            chart_HoaDon.Series.Clear();
            if (txt_SPBanChay_Year.Text == string.Empty)
            {
                txt_SPBanChay_Year.Text = DateTime.Now.Year.ToString();
            }
            List<string> labels = new List<string>();
            List<int> months = new List<int>();
            var years = bUS_HoaDon.SelectDistinctYear();
            for (int i = 1; i <= 12; i++) 
            {
                months.Add(i);
            }
            chart_HoaDon.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Months",
                Labels = months.ConvertAll(x=>x.ToString())
            });
            chart_HoaDon.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                MinValue = 0,
            });

            foreach (int year in years) {
                List<int> resultList = new List<int>();
                foreach(int month in months)
                {
                    int result = this.bUS_HoaDon.CountSoLuongHoaDonOnMonthAndYear(month,year);
                    resultList.Add(result);
                }
                chart_HoaDon.Series.Add(new LineSeries()
                {
                    Title = year.ToString(),
                    Values = new ChartValues<int>(resultList)
                });
            }
        }
        public void LoadSoLuongPhieuNhap()
        {
            List<int> months = new List<int>();
            var years = bUS_PhieuNhapKho.SelectDistinctYear();
            for (int i = 1; i <= 12; i++)
            {
                months.Add(i);
            }
            chart_PhieuNhap.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Months",
                Labels = months.ConvertAll(x => x.ToString())
            });
            chart_PhieuNhap.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                MinValue = 0,
            });
            foreach (var year in years)
            {
                List<int> resultList = new List<int>();
                foreach (var month in months)
                {
                    int result = this.bUS_PhieuNhapKho.CountPhieuNhapKhoOnMonthAndYear(month, year);
                    resultList.Add(result);
                }
                chart_PhieuNhap.Series.Add(new LineSeries()
                {
                    Title = year.ToString(),
                    Values = new ChartValues<int>(resultList)
                });
            }
        }

        public void LoadPTThanhToan()
        {
            chart_PTThanhToan.AxisX.Clear();
            chart_PTThanhToan.AxisY.Clear();
            chart_PTThanhToan.Series.Clear();

            if (txt_PTThanhToan.Text == string.Empty)
            {
                txt_PTThanhToan.Text = "2023";
            }

            int year = Convert.ToInt32(txt_PTThanhToan.Text);
            DataTable dt = bUS_HoaDon.CountPhuongThucThanhToanOnMonthAndYear(year);

            if (dt == null)
            {
                return;
            }
            List<int> months = new List<int>();
            for (int i = 1; i <= 12; i++)
            {
                months.Add(i);
            }

            chart_PTThanhToan.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Months",
                Labels = months.ConvertAll(x => x.ToString())
            });
            chart_PTThanhToan.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                MinValue = 0,
            });

            List<string> PTTTs = dt.AsEnumerable().Select(x => x[0].ToString()).ToList();
            foreach (string PTTT in PTTTs.Distinct())
            {
                List<int> value = new List<int>();
                for (int i = 0; i < 12; i++)
                {
                    value.Add(0);
                }
                for (int i = 0;i < dt.Rows.Count; i++) 
                {
                    DataRow row = dt.Rows[i];
                    if (PTTT == row["PhuongThucThanhToan"].ToString())
                    {
                        int month = Convert.ToInt32(row["Month"]);
                        value[month-1] = Convert.ToInt32(row["Total"]);
                    }
                }
                chart_PTThanhToan.Series.Add(new LineSeries
                {
                    Title = PTTT,
                    Values = new ChartValues<int>(value)
                }) ;
            }

        }

        private void btn_PTThanhToan_Load_Click(object sender, EventArgs e)
        {
            LoadPTThanhToan();
        }
        private void LoadSPConHang()
        {
            chart_SPConHang.AxisX.Clear();
            chart_SPConHang.AxisY.Clear();
            chart_SPConHang.Series.Clear();

            chart_SPConHang.AxisY.Add(new Axis
            {
                MinValue = 0
            });
            List<string> labelList = new List<string>();
            List<int> valueList = new List<int>();
            DataTable dt = this.bUS_Laptop.CountLaptop();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                labelList.Add(row["TenLT"].ToString());
                valueList.Add(Convert.ToInt32(row["SoLuong"]));
            }
            chart_SPConHang.AxisX.Add(new Axis
            {
                Title = "Laptop",
                Labels = labelList.ToArray()
            });
            chart_SPConHang.Series.Add(new ColumnSeries()
            {
                Values = new ChartValues<int>(valueList)
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadSPConHang();
        }

        private void txt_SPBanChay_Year_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_LoiNhuan_Xuat_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT dbo.fn_TinhLoiNhuanNgay(@Ngay)", myconn.getConnection);
            cmd.Parameters.AddWithValue("@Ngay", dt_LoiNhuan.Value);
            myconn.openConnection();
            object result = cmd.ExecuteScalar();
            txt_LoiNhuan.Text = result.ToString();
            myconn.closeConnection();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tab_Tra_Gop)
            {
                txt_NgayHienTai.Text = DateTime.Now.ToString("dd/MM/yyyy");
                myconn.openConnection();
                SqlCommand cmd = new SqlCommand("Select * From func_ThongKeTraGopDaoHan()", myconn.getConnection);
                DataTable dt = new DataTable();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgv_TraGop_DaoHan.DataSource = dt;
                myconn.closeConnection();
            }
        }
    }
}
