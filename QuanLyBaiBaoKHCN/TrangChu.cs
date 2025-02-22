using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBaiBaoKHCN.data;
using System.Net.Http;
using System.IO;

namespace QuanLyBaiBaoKHCN
{
    public partial class TrangChu : Form
    {
        QLTapChi_KHCNDataContext qltc = new QLTapChi_KHCNDataContext();
        public TrangChu()
        {
            InitializeComponent();
            load_combobox_BanDau();
            load_grvBaiViet();
            dateDenNgay.Value = DateTime.Today;
        }

        void load_combobox_BanDau()
        {
            cbo_NgonNgu();
            cbo_ChuyenMuc();
        }
        void cbo_NgonNgu()
        {
            var NgonNgu = from ngonngu in qltc.NgonNgus select ngonngu;
            cboNgonNgu.DataSource = NgonNgu;
            cboNgonNgu.DisplayMember = "TenNgonNgu";
            cboNgonNgu.ValueMember = "MaNgonNgu";
        }

        void cbo_ChuyenMuc()
        {
            var ChuyenMuc = from cm in qltc.ChuyenMucs select cm;
            cboChuyenMuc.DataSource = ChuyenMuc;
            cboChuyenMuc.DisplayMember = "TenChuyenMuc";
            cboChuyenMuc.ValueMember = "MaChuyenMuc";
        }
        void load_grvBaiViet()
        {
            var baibao = from bv in qltc.BaiViets
                         join nn in qltc.NgonNgus on bv.MaNgonNgu equals nn.MaNgonNgu
                         join cm in qltc.ChuyenMucs on bv.MaChuyenMuc equals cm.MaChuyenMuc
                         select new
                         {
                             MaBaiBao_BV = bv.MaBaiBao,
                             TieuDe = bv.TieuDe,
                             TenBaiBao = bv.TenBaiBao,
                             TenBaiBaoTiengAnh = bv.TenBaiBaoTiengAnh,
                             TomTat = bv.TomTat,
                             TomTatTiengAnh = bv.TomTatTiengAnh,
                             NgayXetDuyet = bv.NgayXetDuyet,
                             NgayGui = bv.NgayGui,
                             TuKhoa = bv.TuKhoa,
                             TuKhoaTiengAnh = bv.TuKhoaTiengAnh,
                             FileBaiViet = bv.FileBaiViet,
                             TrangThai = bv.TrangThai,
                             MaNgonNgu = nn.MaNgonNgu,
                             TenNgonNgu = nn.TenNgonNgu,
                             MaChuyenMuc = cm.MaChuyenMuc,
                             TenChuyenMuc = cm.TenChuyenMuc
                         };
            grvBaiBao.AutoGenerateColumns = false;
            grvBaiBao.DataSource = baibao.ToList();
        }
        public class ThongTinPhanBien
        {
            public string MaBaiViet { get; set; }
            public string TenBaiBao { get; set; }
            public string TrangThai_DSPB { get; set; }
            public string HoTen { get; set; }
            public string MaNguoiDung { get; set; }
        }
        List<ThongTinPhanBien> ls_ChonPB = new List<ThongTinPhanBien>();
        void load_grvPhanBien(string mabv)
        {
            var pb = from PB in qltc.LichSuChonNguoiPhanBiens
                     join ND in qltc.NguoiDungs on PB.MaNguoiDung equals ND.MaNguoiDung
                     join BV in qltc.BaiViets on PB.MaBaiBao equals BV.MaBaiBao
                     where PB.MaBaiBao == mabv
                     orderby PB.MaNguoiDung, PB.MaBaiBao, PB.NgayGuiYeuCau descending
                     select new
                     {
                         PB.MaBaiBao,
                         BV.TenBaiBao,
                         PB.TrangThai,
                         ND.HoTen,
                         PB.MaNguoiDung,
                         PB.NgayGuiYeuCau
                     };

            var latestPB = pb.ToList()
                            .GroupBy(x => new { x.MaNguoiDung, x.MaBaiBao })
                            .Select(g => g.First())
                            .Select(x => new ThongTinPhanBien
                            {
                                MaBaiViet = x.MaBaiBao,
                                TenBaiBao = x.TenBaiBao,
                                TrangThai_DSPB = x.TrangThai,
                                HoTen = x.HoTen,
                                MaNguoiDung = x.MaNguoiDung
                            }).ToList();

            grvDanhSachPB.DataSource = latestPB;
        }

        private void grvBaiBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grvBaiBao.SelectedRows[0].Cells["MaBaiBao_BV"].Value != null)
                {
                    string mabaibao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao_BV"].Value.ToString();
                    var baiviet = qltc.BaiViets.SingleOrDefault(bv => bv.MaBaiBao == mabaibao);
                    load_grvPhanBien(baiviet.MaBaiBao);
                    txtTrangThai.Text = baiviet.TrangThai.ToString();

                    btnXemFile.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grvDanhSachPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grvDanhSachPB.SelectedRows[0].Cells["MaNguoiDung"].Value != null)
                {
                    string manguoidung = grvDanhSachPB.SelectedRows[0].Cells["MaNguoiDung"].Value.ToString();
                    var nguoidung = (from nd in qltc.NguoiDungs
                                     join hv in qltc.HocVis on nd.MaHocVi equals hv.MaHocVi
                                     join hh in qltc.HocHams on nd.MaHocHam equals hh.MaHocHam
                                     join dv in qltc.DonVis on nd.MaDonVi equals dv.MaDonVi
                                     join cn in qltc.ChuyenNganhs on nd.MaChuyenNganh equals cn.MaChuyenNganh
                                     join qg in qltc.QuocGias on nd.MaQG equals qg.MaQG
                                     where nd.MaNguoiDung == manguoidung
                                     select new
                                     {
                                         NguoiDung = nd,
                                         HocHam = hh,
                                         DonVi = dv,
                                         QuocGia = qg,
                                         HocVi = hv,
                                         ChuyenNganh = cn,
                                     }).SingleOrDefault();

                    txtHocHam.Text = nguoidung.HocHam.TenHocHam;
                    txtDonVi.Text = nguoidung.DonVi.TenDonVi;
                    txtQuocGia.Text = nguoidung.QuocGia.TenQG;
                    txtHocVi.Text = nguoidung.HocVi.TenHocVi;
                    txtChuyenNganh.Text = nguoidung.ChuyenNganh.TenChuyenNganh;
                    txtEmail.Text = nguoidung.NguoiDung.Email;
                    txtDiaChi.Text = nguoidung.NguoiDung.DiaChi;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnXemFile_Click(object sender, EventArgs e)
        {
            if (grvBaiBao.SelectedRows.Count > 0)
            {
                string maBaiBao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();
                string fileName = grvBaiBao.SelectedRows[0].Cells["FileBaiViet"].Value.ToString();

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.FileName = fileName;
                    saveFileDialog.Filter = "All Files (*.*)|*.*";


                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            string url = $"http://127.0.0.1:8000/api/download-file/{maBaiBao}";
                            HttpResponseMessage response = await client.GetAsync(url);

                            if (response.IsSuccessStatusCode)
                            {
                                // Lưu file vào đường dẫn người dùng đã chọn
                                string filePath = saveFileDialog.FileName;  // Đường dẫn và tên file từ SaveFileDialog
                                byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();
                                File.WriteAllBytes(filePath, fileBytes);

                                MessageBox.Show("File tải thành công!");

                                // Mở file sau khi tải xong (tuỳ chọn)
                                System.Diagnostics.Process.Start(filePath);
                            }
                            else
                            {
                                MessageBox.Show("Tải file thất bại.");
                            }
                        }
                    }
                }
            }
        }

        void FilterBaiViet(DateTime tungay, DateTime denngay)
        {
            var query = from bv in qltc.BaiViets
                        join cm in qltc.ChuyenMucs on bv.MaChuyenMuc equals cm.MaChuyenMuc
                        join nn in qltc.NgonNgus on bv.MaNgonNgu equals nn.MaNgonNgu
                        select new
                        {
                            MaBaiBao_BV = bv.MaBaiBao,
                            TieuDe = bv.TieuDe,
                            TenBaiBao = bv.TenBaiBao,
                            TenBaiBaoTiengAnh = bv.TenBaiBaoTiengAnh,
                            TomTat = bv.TomTat,
                            TomTatTiengAnh = bv.TomTatTiengAnh,
                            NgayXetDuyet = bv.NgayXetDuyet,
                            NgayGui = bv.NgayGui,
                            TuKhoa = bv.TuKhoa,
                            TuKhoaTiengAnh = bv.TuKhoaTiengAnh,
                            FileBaiViet = bv.FileBaiViet,
                            TrangThai = bv.TrangThai,
                            MaNgonNgu = nn.MaNgonNgu,
                            TenNgonNgu = nn.TenNgonNgu,
                            MaChuyenMuc = cm.MaChuyenMuc,
                            TenChuyenMuc = cm.TenChuyenMuc
                        };
            if (LocNgay > 1)
            {
                DateTime tuNgay = dateTuNgay.Value.Date;
                DateTime denNgay = dateDenNgay.Value.Date.AddDays(1).AddSeconds(-1);

                query = query.Where(x => x.NgayGui >= tuNgay && x.NgayGui <= denNgay);
            }

            if (cboChuyenMuc.SelectedValue != null)
            {
                string maChuyenMuc = cboChuyenMuc.SelectedValue.ToString();
                query = query.Where(x => x.MaChuyenMuc == maChuyenMuc);
            }

            if (cboNgonNgu.SelectedValue != null)
            {
                string maNgonNgu = cboNgonNgu.SelectedValue.ToString();
                query = query.Where(x => x.MaNgonNgu == maNgonNgu);
            }

            grvBaiBao.DataSource = query.ToList();
        }
        int LocNgay = 0;

        private void cboChuyenMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBaiViet(dateTuNgay.Value, dateDenNgay.Value);
        }

        private void cboNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBaiViet(dateTuNgay.Value, dateDenNgay.Value);
        }

        private void dateDenNgay_ValueChanged(object sender, DateTime value)
        {
            LocNgay++;
            FilterBaiViet(dateTuNgay.Value, dateDenNgay.Value);
        }

        private void dateTuNgay_ValueChanged(object sender, DateTime value)
        {
            FilterBaiViet(dateTuNgay.Value, dateDenNgay.Value);
        }
    }
}
