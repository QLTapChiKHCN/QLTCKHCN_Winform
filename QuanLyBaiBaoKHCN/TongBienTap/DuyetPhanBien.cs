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

namespace QuanLyBaiBaoKHCN.TongBienTap
{
    public partial class DuyetPhanBien : Form
    {
        QLTapChi_KHCNDataContext qltc = new QLTapChi_KHCNDataContext();

        public DuyetPhanBien()
        {
            InitializeComponent();
            load_combobox_BanDau();
            load_grvBaiViet();
            dateDenNgay.Value = DateTime.Today;
        }

        #region Load các thể loại combobox
        void load_combobox_BanDau()
        {
            cbo_NgonNgu();
            cbo_ChuyenMuc();
            load_combobox_rong();
        }

        void load_combobox_rong()
        {
            cboNgonNgu.Text = "";
            cboChuyenMuc.Text = "";
            txtTrangThai.Clear();
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
                         where bv.TrangThai == "Tiến hành phản biện"
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
            public string TrangThaiTBT { get; set; }
            public string TrangThai_DSPB { get; set; }
            public string HoTen { get; set; }
            public string MaNguoiDung { get; set; }
        }
        List<ThongTinPhanBien> ls_ChonPB = new List<ThongTinPhanBien>();
        void load_grvPhanBien(string mabv)
        {
            ls_ChonPB = new List<ThongTinPhanBien>();
            var pb = from PB in qltc.LichSuChonNguoiPhanBiens
                     join ND in qltc.NguoiDungs on PB.MaNguoiDung equals ND.MaNguoiDung
                     join BV in qltc.BaiViets on PB.MaBaiBao equals BV.MaBaiBao
                     where PB.MaBaiBao == mabv && PB.TrangThaiTBT == "Chờ duyệt"
                     select new
                     {
                         MaBaiViet = PB.MaBaiBao,
                         TenBaiBao = BV.TenBaiBao,
                         TrangThai = PB.TrangThai,
                         HoTen = ND.HoTen,
                         MaNguoiDung = PB.MaNguoiDung,
                         NgayGuiYeuCau = PB.NgayGuiYeuCau,
                         TrangThaiTBT = PB.TrangThaiTBT
                     };
            foreach (var item in pb)
            {
                ls_ChonPB.Add(new ThongTinPhanBien
                {
                    MaBaiViet = item.MaBaiViet,
                    TenBaiBao = item.TenBaiBao,
                    TrangThai_DSPB = item.TrangThai,
                    HoTen = item.HoTen,
                    MaNguoiDung = item.MaNguoiDung,
                    TrangThaiTBT = item.TrangThaiTBT
                });
            }

            grvDanhSachPB.AutoGenerateColumns = false;
            grvDanhSachPB.DataSource = ls_ChonPB;
        }

        string mabaibao = "";
        private void grvBaiBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grvBaiBao.SelectedRows[0].Cells["MaBaiBao_BV"].Value != null)
                {
                    mabaibao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao_BV"].Value.ToString();
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

        string manguoidung = "";
        string tennguoidung = "";
        private void grvDanhSachPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grvDanhSachPB.SelectedRows[0].Cells["MaNguoiDung"].Value != null)
                {
                    if (grvDanhSachPB.SelectedRows[0].Cells["TrangThaiTBT"].Value.ToString() == "Chờ duyệt")
                    {
                        btnDuyet.Enabled = true;
                        btnYeuCauChonPBKhac.Enabled = true;
                    }
                    else
                    {
                        btnDuyet.Enabled = false;
                        btnYeuCauChonPBKhac.Enabled = false;
                    }
                    manguoidung = grvDanhSachPB.SelectedRows[0].Cells["MaNguoiDung"].Value.ToString();
                    tennguoidung = grvDanhSachPB.SelectedRows[0].Cells["HoTen"].Value.ToString();
                    var nguoidung = (from nd in qltc.NguoiDungs
                                     join hv in qltc.HocVis on nd.MaHocVi equals hv.MaHocVi
                                     join hh in qltc.HocHams on nd.MaHocHam equals hh.MaHocHam into hhGroup
                                     from hh in hhGroup.DefaultIfEmpty()
                                     join dv in qltc.DonVis on nd.MaDonVi equals dv.MaDonVi
                                     join cn in qltc.ChuyenNganhs on nd.MaChuyenNganh equals cn.MaChuyenNganh
                                     join qg in qltc.QuocGias on nd.MaQG equals qg.MaQG
                                     where nd.MaNguoiDung == manguoidung
                                     select new
                                     {
                                         NguoiDung = nd,
                                         HocHam = hh == null ? "" : hh.TenHocHam,
                                         DonVi = dv,
                                         QuocGia = qg,
                                         HocVi = hv,
                                         ChuyenNganh = cn,
                                     }).SingleOrDefault();

                    txtHocHam.Text = nguoidung.HocHam;
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
        #endregion

        #region xử lí button
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
        void enable_btn(bool x)
        {
            btnDuyet.Enabled = !x;
            btnYeuCauChonPBKhac.Enabled = !x;
            btnHuy.Enabled = x;
            btnLuu.Enabled = x;
        }

        List<LichSuChonNguoiPhanBien> ListPB = new List<LichSuChonNguoiPhanBien>();
        List<LichSuChonNguoiPhanBien> ListPB_ChoNutHuy = new List<LichSuChonNguoiPhanBien>();
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            var ChonPB = (from chonpb in qltc.LichSuChonNguoiPhanBiens
                          where chonpb.MaBaiBao == mabaibao && chonpb.MaNguoiDung == manguoidung
                          select chonpb).SingleOrDefault();

            if (ChonPB != null)
            {
                    DialogResult result = MessageBox.Show($"Duyệt phản biện \"{tennguoidung}\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var capnhat = ChonPB;
                    var newChonPB = new LichSuChonNguoiPhanBien();

                    // Kiểm tra xem đối tượng đã có trong danh sách ListPB_ChoNutHuy chưa
                    var existingPB = ListPB_ChoNutHuy.FirstOrDefault(t => t.MaBaiBao == mabaibao && t.MaNguoiDung == manguoidung);
                    if (existingPB == null)
                    {
                        // Thêm vào ListPB khi chưa có
                        ListPB.Add(new LichSuChonNguoiPhanBien
                        {
                            MaBaiBao = capnhat.MaBaiBao,
                            MaNguoiDung = capnhat.MaNguoiDung,
                            TrangThaiTBT = capnhat.TrangThaiTBT,
                            TrangThai = capnhat.TrangThai,
                            NgayGuiYeuCau = capnhat.NgayGuiYeuCau
                        });

                        // Tạo đối tượng mới với trạng thái "Đồng ý"
                        newChonPB = new LichSuChonNguoiPhanBien
                        {
                            MaBaiBao = capnhat.MaBaiBao,
                            MaNguoiDung = capnhat.MaNguoiDung,
                            NgayGuiYeuCau = DateTime.Now.Date,
                            TrangThaiTBT = "Đồng ý",
                            TrangThai = "Chờ phản hồi"
                        };
                        ListPB_ChoNutHuy.Add(newChonPB);
                    }
                    else
                    {
                        // Cập nhật trạng thái TBT của đối tượng đã có
                        existingPB.TrangThaiTBT = "Đồng ý";
                        existingPB.TrangThai = null;
                    }

                    enable_btn(true);
                    grvBaiBao.Enabled = false;
                    foreach (DataGridViewRow row in grvDanhSachPB.Rows)
                    {
                        if (row.Cells["MaBaiViet"].Value.ToString() == mabaibao && row.Cells["MaNguoiDung"].Value.ToString() == manguoidung)
                        {
                            row.Cells["TrangThaiTBT"].Value = "Đồng ý";
                            break;
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Không tìm thấy phản biện.");
            }
        }
        private void btnYeuCauChonPBKhac_Click(object sender, EventArgs e)
        {
            var ChonPB = (from chonpb in qltc.LichSuChonNguoiPhanBiens
                          where chonpb.MaBaiBao == mabaibao && chonpb.MaNguoiDung == manguoidung
                          select chonpb).SingleOrDefault();

            if (ChonPB != null)
            {
                DialogResult result = MessageBox.Show($"Từ chối phản biện \"{tennguoidung}\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var capnhat = ChonPB;
                    var newChonPB = new LichSuChonNguoiPhanBien();

                    // Kiểm tra xem đối tượng đã có trong danh sách ListPB_ChoNutHuy chưa
                    var existingPB = ListPB_ChoNutHuy.FirstOrDefault(t => t.MaBaiBao == mabaibao && t.MaNguoiDung == manguoidung);
                    if (existingPB == null)
                    {
                        // Thêm vào ListPB khi chưa có
                        ListPB.Add(new LichSuChonNguoiPhanBien
                        {
                            MaBaiBao = capnhat.MaBaiBao,
                            MaNguoiDung = capnhat.MaNguoiDung,
                            TrangThaiTBT = capnhat.TrangThaiTBT,
                            TrangThai = capnhat.TrangThai,
                            NgayGuiYeuCau = capnhat.NgayGuiYeuCau
                        });

                        // Tạo đối tượng mới với trạng thái "Từ chối"
                        newChonPB = new LichSuChonNguoiPhanBien
                        {
                            MaBaiBao = capnhat.MaBaiBao,
                            MaNguoiDung = capnhat.MaNguoiDung,
                            NgayGuiYeuCau = DateTime.Now.Date,
                            TrangThaiTBT = "Từ chối",
                            TrangThai = null
                        };
                        ListPB_ChoNutHuy.Add(newChonPB);
                    }
                    else
                    {
                        // Cập nhật trạng thái TBT của đối tượng đã có
                        existingPB.TrangThaiTBT = "Từ chối";
                        existingPB.TrangThai = null;
                    }

                    enable_btn(true);
                    grvBaiBao.Enabled = false;
                    foreach (DataGridViewRow row in grvDanhSachPB.Rows)
                    {
                        if (row.Cells["MaBaiViet"].Value.ToString() == mabaibao && row.Cells["MaNguoiDung"].Value.ToString() == manguoidung)
                        {
                            row.Cells["TrangThaiTBT"].Value = "Từ chối";
                            break;
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy phản biện.");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (ListPB_ChoNutHuy != null && ListPB_ChoNutHuy.Count > 0)
            {
                foreach (var pb in ListPB_ChoNutHuy)
                {
                    var entity = qltc.LichSuChonNguoiPhanBiens.FirstOrDefault(chonpb => chonpb.MaBaiBao == pb.MaBaiBao && chonpb.MaNguoiDung == pb.MaNguoiDung);

                    if (entity != null)
                    {
                        qltc.LichSuChonNguoiPhanBiens.DeleteOnSubmit(entity);
                    }
                }

                // Tạo danh sách các khóa chính từ ListPB
                var keys = ListPB.Select(pb => new { pb.MaBaiBao, pb.MaNguoiDung, pb.NgayGuiYeuCau }).ToList();

                foreach (var pb in ListPB)
                {
                    var originalPB = (from chonpb in qltc.LichSuChonNguoiPhanBiens
                                      where chonpb.MaBaiBao == pb.MaBaiBao && chonpb.MaNguoiDung == pb.MaNguoiDung && chonpb.NgayGuiYeuCau == pb.NgayGuiYeuCau
                                      select chonpb).SingleOrDefault();

                    if (originalPB != null)
                    {
                        // Phục hồi đối tượng gốc
                        originalPB.TrangThaiTBT = pb.TrangThaiTBT;
                        originalPB.TrangThai = pb.TrangThai;
                        originalPB.NgayGuiYeuCau = pb.NgayGuiYeuCau;
                    }
                    else
                    {
                        // Thêm lại đối tượng gốc nếu đã bị xóa
                        qltc.LichSuChonNguoiPhanBiens.InsertOnSubmit(pb);
                    }
                }

                TrangThaiBanDau();
                ListPB.Clear();
                enable_btn(false);
                grvBaiBao.Enabled = true;
                MessageBox.Show("Đã hoàn tác thay đổi.");
            }
            else
            {
                MessageBox.Show("Không có thay đổi trạng thái ban đầu nào để khôi phục.");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var pb in ListPB_ChoNutHuy)
                {
                    var entity = qltc.LichSuChonNguoiPhanBiens.FirstOrDefault(chonpb => chonpb.MaBaiBao == pb.MaBaiBao && chonpb.MaNguoiDung == pb.MaNguoiDung);
                    if (entity != null)
                    {
                        qltc.LichSuChonNguoiPhanBiens.DeleteOnSubmit(entity);
                    }
                    qltc.LichSuChonNguoiPhanBiens.InsertOnSubmit(pb);
                }

                qltc.SubmitChanges();

                ListPB.Clear();
                ListPB_ChoNutHuy.Clear();
                TrangThaiBanDau();
                enable_btn(false);
                btnDuyet.Enabled = false;
                btnYeuCauChonPBKhac.Enabled = false;
                MessageBox.Show("Lưu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        void TrangThaiBanDau()
        {
            load_grvPhanBien(mabaibao);
            manguoidung = "";
            tennguoidung = "";
            txtChuyenNganh.Clear();
            txtDiaChi.Clear();
            txtQuocGia.Clear();
            txtHocHam.Clear();
            txtHocVi.Clear();
            txtEmail.Clear();
            txtDonVi.Clear();
            enable_btn(false);
            ListPB.Clear();
            grvBaiBao.Enabled = true;
        }

        #endregion

        private void DuyetPhanBien_Load(object sender, EventArgs e)
        {

        }

        private void cboNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBaiViet(dateTuNgay.Value, dateDenNgay.Value);
        }

        private void cboChuyenMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBaiViet(dateTuNgay.Value, dateDenNgay.Value);
        }

        void FilterBaiViet(DateTime tungay, DateTime denngay)
        {
            var query = from bv in qltc.BaiViets
                        join cm in qltc.ChuyenMucs on bv.MaChuyenMuc equals cm.MaChuyenMuc
                        join nn in qltc.NgonNgus on bv.MaNgonNgu equals nn.MaNgonNgu
                        where bv.TrangThai == "Tiến hành phản biện"
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
