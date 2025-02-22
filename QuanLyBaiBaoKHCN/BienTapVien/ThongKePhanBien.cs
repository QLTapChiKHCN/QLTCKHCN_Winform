using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBaiBaoKHCN.BienTapVien
{
    public  class ThongKePhanBien
    {
        public string MaBaiBao { get; set; }
        public string TenBaiBao { get; set; }
        public int SoPhieuDongY { get; set; }
        public int SoPhieuTuChoi { get; set; }
        public int SoPhieuChinhSua { get; set; }
        public List<string> FilePhanBien { get; set; }
    }
}
