using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sunny.UI;
using QuanLyBaiBaoKHCN.data;

namespace QuanLyBaiBaoKHCN.BienTapVien
{
    public partial class ThongKe : Form
    {
        QLTapChi_KHCNDataContext qltc = new QLTapChi_KHCNDataContext();

        public ThongKe()
        {
            InitializeComponent();
            DatePick_DenNgay.Value = DateTime.Today;
            load_cboQuy();
            load_PieChart_TheoNgay(DateTime.Now, DateTime.Now);
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }

        #region pie_Chart
        void load_PieChart_Quy(int quy, int nam)
        {
            try
            {
                int[] monthsInQuarter = new int[3];
                switch (quy)
                {
                    case 1:
                        monthsInQuarter = new int[] { 1, 2, 3 };
                        break;
                    case 2:
                        monthsInQuarter = new int[] { 4, 5, 6 };
                        break;
                    case 3:
                        monthsInQuarter = new int[] { 7, 8, 9 };
                        break;
                    case 4:
                        monthsInQuarter = new int[] { 10, 11, 12 };
                        break;
                }

                var baiVietThang = from bv in qltc.BaiViets
                                   where bv.NgayGui.Value.Year == nam
                                   group bv by new { bv.NgayGui.Value.Month, bv.TrangThai } into g
                                   select new
                                   {
                                       Thang = g.Key.Month,
                                       TrangThai = g.Key.TrangThai,
                                       SoLuong = g.Count()
                                   };

                var option = new UIPieOption();
                option.Title = new UITitle();
                option.Title.Text = "Số lượng bài viết quý " + quy + "/" + nam;
                option.Title.SubText = "";
                option.Title.Left = UILeftAlignment.Center;

                option.ToolTip.Visible = true;

                option.Legend = new UILegend();
                option.Legend.Orient = UIOrient.Vertical;
                option.Legend.Top = UITopAlignment.Top;
                option.Legend.Left = UILeftAlignment.Left;

                var series = new UIPieSeries();
                series.Name = "Số Lượng";
                series.Center = new UICenter(50, 55);
                series.Radius = 80;
                series.Label.Show = true;

                var colors = new List<string> { "#64C3A1", "#5EA7DC", "#EFB844" };
                int colorIndex = 0;

                int soLuongDaDang = 0;
                int soLuongDaGui = 0;
                int soLuongDaTuChoi = 0;

                foreach (var item in baiVietThang)
                {
                    if (monthsInQuarter.Contains(item.Thang))
                    {
                        soLuongDaGui += item.SoLuong;
                        if (item.TrangThai == "Đăng Bài")
                        {
                            soLuongDaDang += item.SoLuong;
                        }
                        else if (item.TrangThai == "Từ Chối")
                        {
                            soLuongDaTuChoi += item.SoLuong;
                        }
                        //else
                        //{
                        //    soLuongDaGui += item.SoLuong;
                        //}
                    }
                }

                // Thêm dữ liệu vào biểu đồ tròn
                var color = ColorTranslator.FromHtml(colors[colorIndex % colors.Count]);
                option.Legend.AddData("Đăng Bài", color);
                series.AddData("Đã đăng Bài", soLuongDaDang, color);
                colorIndex++;

                color = ColorTranslator.FromHtml(colors[colorIndex % colors.Count]);
                option.Legend.AddData("Đã Gửi", color);
                series.AddData("Đã Gửi", soLuongDaGui, color);
                colorIndex++;

                color = ColorTranslator.FromHtml(colors[colorIndex % colors.Count]);
                option.Legend.AddData("Từ Chối", color);
                series.AddData("Từ Chối", soLuongDaTuChoi, color);
                colorIndex++;

                option.Series.Clear();
                option.Series.Add(series);

                PieChart_ThongKe.SetOption(option);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void load_PieChart_TheoNgay(DateTime TuNgay, DateTime DenNgay)
        {
            try
            {
                var baiVietNgay = from bv in qltc.BaiViets
                                  where bv.NgayGui.Value.Date >= TuNgay.Date && bv.NgayGui.Value.Date <= DenNgay.Date
                                  group bv by new { bv.NgayGui.Value.Date, bv.TrangThai } into g
                                  select new
                                  {
                                      Ngay = g.Key.Date,
                                      TrangThai = g.Key.TrangThai,
                                      SoLuong = g.Count()
                                  };

                var option = new UIPieOption();
                option.Title = new UITitle();
                option.Title.Text = "Số lượng bài viết từ " + TuNgay.ToString("dd/MM/yyyy") + " đến " + DenNgay.ToString("dd/MM/yyyy");
                option.Title.SubText = "";
                option.Title.Left = UILeftAlignment.Center;

                option.ToolTip.Visible = true;

                option.Legend = new UILegend();
                option.Legend.Orient = UIOrient.Vertical;
                option.Legend.Top = UITopAlignment.Top;
                option.Legend.Left = UILeftAlignment.Left;

                var series = new UIPieSeries();
                series.Name = "Số Lượng";
                series.Center = new UICenter(50, 55);
                series.Radius = 80;
                series.Label.Show = true;

                var colors = new List<string> { "#64C3A1", "#5EA7DC", "#EFB844" };
                int colorIndex = 0;

                int soLuongDaDang = 0;
                int soLuongDaGui = 0;
                int soLuongDaTuChoi = 0;

                foreach (var item in baiVietNgay)
                {
                    soLuongDaGui += item.SoLuong;
                    if (item.TrangThai == "Đăng bài")
                    {
                        soLuongDaDang += item.SoLuong;
                    }
                    else if (item.TrangThai == "Từ chối")
                    {
                        soLuongDaTuChoi += item.SoLuong;
                    }
                    //else
                    //{
                    //    soLuongDaGui += item.SoLuong;
                    //}
                }

                // Thêm dữ liệu vào biểu đồ tròn
                var color = ColorTranslator.FromHtml(colors[colorIndex % colors.Count]);
                option.Legend.AddData("Đăng Bài", color);
                series.AddData("Đã đăng Bài", soLuongDaDang, color);
                colorIndex++;

                color = ColorTranslator.FromHtml(colors[colorIndex % colors.Count]);
                option.Legend.AddData("Đã Gửi", color);
                series.AddData("Đã Gửi", soLuongDaGui, color);
                colorIndex++;

                color = ColorTranslator.FromHtml(colors[colorIndex % colors.Count]);
                option.Legend.AddData("Từ Chối", color);
                series.AddData("Từ Chối", soLuongDaTuChoi, color);
                colorIndex++;

                option.Series.Clear();
                option.Series.Add(series);

                PieChart_ThongKe.SetOption(option);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoc_Ngay_Click(object sender, EventArgs e)
        {
            load_PieChart_TheoNgay(DatePick_TuNgay.Value, DatePick_DenNgay.Value);
        }

        class Quy
        {
            public int TenQuy { get; set; }
        }
        void load_cboQuy()
        {
            var quy = new List<Quy>
                                {
                                    new Quy { TenQuy = 1 },
                                    new Quy { TenQuy = 2 },
                                    new Quy { TenQuy = 3 },
                                    new Quy { TenQuy = 4 }
                                };

            cboChonQuy.DataSource = quy;
            cboChonQuy.DisplayMember = "TenQuy";
            cboChonQuy.ValueMember = "TenQuy";
        }

        private void btnLoc_Quy_Click(object sender, EventArgs e)
        {
            load_PieChart_Quy(int.Parse(cboChonQuy.Text.ToString()), int.Parse(DatePick_Year_Quy.Year.ToString()));
        }
        #endregion
    }
}
