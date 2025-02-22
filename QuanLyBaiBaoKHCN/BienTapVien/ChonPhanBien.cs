using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using QuanLyBaiBaoKHCN.data;

namespace QuanLyBaiBaoKHCN.BienTapVien
{
    public partial class ChonPhanBien : Form
    {
        QLTapChi_KHCNDataContext PB = new QLTapChi_KHCNDataContext();
        public ChonPhanBien()
        {
            InitializeComponent();
            load_LofA();
            load_Cbbox();
            load_PB(null);
            dateDenNgay.Value = DateTime.Today;
        }

        int flag;
        string flag_BB;

        public class DanhSachPB
        {
            public string MaNguoiDung { get; set; }
            public string TrangThai_TBT { get; set; }
            public string KetQua { get; set; }
            public bool IsNew { get; set; }
        }

        private void load_LofA()
        {
            try
            {
                var ds1 = (from bv in PB.BaiViets
                           join ctpb in PB.ChiTietPhanBiens on bv.MaBaiBao equals ctpb.MaBaiBao
                           group ctpb by bv.MaBaiBao into g
                           let dongYCount = g.Count(ctpb => ctpb.KetQuaPhanBien == "Đồng ý")
                           let tuChoiCount = g.Count(ctpb => ctpb.KetQuaPhanBien == "Từ chối")
                           where dongYCount == 1 && tuChoiCount == 1
                           select new
                           {
                               MaBaiBao = g.Key,
                               TenBaiBao = PB.BaiViets.FirstOrDefault(x => x.MaBaiBao == g.Key).TenBaiBao,
                               NgayGui = PB.BaiViets.FirstOrDefault(x => x.MaBaiBao == g.Key).NgayGui,
                               TieuDe = PB.BaiViets.FirstOrDefault(x => x.MaBaiBao == g.Key).TieuDe
                           });

                var ds2 = (from x in PB.BaiViets
                           where x.TrangThai == "Tiến hành phản biện"
                                 && !PB.ChiTietPhanBiens.Any(ctpb => ctpb.MaBaiBao == x.MaBaiBao)
                           select new
                           {
                               MaBaiBao = x.MaBaiBao,
                               TenBaiBao = x.TenBaiBao,
                               NgayGui = x.NgayGui,
                               TieuDe = x.TieuDe
                           });

                // Hợp nhất hai danh sách
                var ds = ds1.Union(ds2).ToList();

                // Gán danh sách vào DataGridView
                grvBaiBao.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void load_PB(List<string> mand)
        {
            // Kiểm tra danh sách mand trước khi thực hiện truy vấn
            if (mand == null)
            {
                mand = new List<string>(); // Gán danh sách rỗng nếu mand là null
            }

            var x = from pb in PB.NguoiDungs
                    join vt in PB.NguoiDung_VaiTros on pb.MaNguoiDung equals vt.MaNguoiDung
                    where vt.MaVaiTro == "VT04"
                          && !mand.Contains(pb.MaNguoiDung) // Bây giờ mand không bao giờ null
                    select new
                    {
                        MaPB = pb.MaNguoiDung,
                        HoTen = pb.HoTen,
                        CCCD = pb.CCCD,
                        SDT = pb.SoDienThoai,
                        GioiTinh = pb.GioiTinh
                    };

            // Gán kết quả cho DataSource
            grvGVPB.DataSource = x.ToList();
        }



        private void load_Cbbox()
        {
            // For ChuyenMuc ComboBox
            var ChuyenMuc = (from x in PB.ChuyenMucs
                             select x).ToList();
            ChuyenMuc.Insert(0, new ChuyenMuc { MaChuyenMuc = "", TenChuyenMuc = "---" });
            cboChuyenMuc.DataSource = ChuyenMuc;
            cboChuyenMuc.ValueMember = "MaChuyenMuc";
            cboChuyenMuc.DisplayMember = "TenChuyenMuc";

            var NgonNgu = (from nn in PB.NgonNgus
                           select nn).ToList();
            NgonNgu.Insert(0, new NgonNgu { MaNgonNgu = "", TenNgonNgu = "---" });
            cboNgonNgu.DataSource = NgonNgu;
            cboNgonNgu.ValueMember = "MaNgonNgu";
            cboNgonNgu.DisplayMember = "TenNgonNgu";

            var HocHam = (from hh in PB.HocHams select hh).ToList();
            HocHam.Insert(0, new HocHam { MaHocHam = "", TenHocHam = "---" });
            cboHocHam.DataSource = HocHam;
            cboHocHam.ValueMember = "MaHocHam";
            cboHocHam.DisplayMember = "TenHocHam";

            var HocVi = (from hv in PB.HocVis select hv).ToList();
            HocVi.Insert(0, new HocVi { MaHocVi = "", TenHocVi = "---" });
            cboHocVi.DataSource = HocVi;
            cboHocVi.ValueMember = "MaHocVi";
            cboHocVi.DisplayMember = "TenHocVi";

            var Chuyennganh = (from cn in PB.ChuyenNganhs select cn).ToList();
            Chuyennganh.Insert(0, new ChuyenNganh { MaChuyenNganh = "", TenChuyenNganh = "---" });
            cboChuyenNganh.DataSource = Chuyennganh;
            cboChuyenNganh.ValueMember = "MaChuyenNganh";
            cboChuyenNganh.DisplayMember = "TenChuyenNganh";


            var quocgia = (from qg in PB.QuocGias select qg).ToList();
            quocgia.Insert(0, new QuocGia { MaQG = "", TenQG = "---" });
            cboQuocGia.DataSource = quocgia;
            cboQuocGia.ValueMember = "MaQG";
            cboQuocGia.DisplayMember = "TenQG";

            var donvi = (from dv in PB.DonVis select dv).ToList();
            donvi.Insert(0, new DonVi { MaDonVi = "", TenDonVi = "---" });
            cbo_Donvi.DataSource = donvi;
            cbo_Donvi.ValueMember = "MaDonVi";
            cbo_Donvi.DisplayMember = "TenDonVi";
        }


        private BindingList<DanhSachPB> dspbList = new BindingList<DanhSachPB>();


        private void grvBaiBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    string mbb = grvBaiBao.Rows[e.RowIndex].Cells["MaBaiBao"].Value.ToString();
                    flag_BB = mbb;

                    // Lọc danh sách các phản biện và nhóm theo MaNguoiDung
                    var dsPB = (from ds in PB.LichSuChonNguoiPhanBiens
                                where ds.MaBaiBao == mbb
                                group ds by ds.MaNguoiDung into g // Group by MaNguoiDung
                                select new DanhSachPB
                                {
                                    MaNguoiDung = g.Key,  // Lấy MaNguoiDung duy nhất trong nhóm
                                    TrangThai_TBT = g.First().TrangThaiTBT,  // Chọn trạng thái của phản biện đầu tiên trong nhóm
                                    KetQua = g.First().TrangThai,  // Chọn kết quả của phản biện đầu tiên trong nhóm
                                    IsNew = false
                                }).ToList();

                    // Cập nhật BindingList với danh sách đã nhóm
                    dspbList = new BindingList<DanhSachPB>(dsPB);

                    List<string> dsGV = (from x in PB.ChiTietBaiViets
                                         where x.MaBaiBao == mbb
                                         select x.MaNguoiDung).ToList();
                    load_PB(dsGV);
                    grvDanhSachPB.DataSource = dspbList;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn bài báo: " + ex.Message);
            }
        }

        private void grvGVPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    flag = e.RowIndex;
                    string cc = grvGVPB.Rows[e.RowIndex].Cells[0].Value.ToString();
                    //var x = (from pb in PB.NguoiDungs
                    //         where pb.MaNguoiDung == cc
                    //         select pb).FirstOrDefault();
                    var x = (from nd in PB.NguoiDungs
                             join hv in PB.HocVis on nd.MaHocVi equals hv.MaHocVi
                             join hh in PB.HocHams on nd.MaHocHam equals hh.MaHocHam into hhGroup
                             from hh in hhGroup.DefaultIfEmpty()
                             join dv in PB.DonVis on nd.MaDonVi equals dv.MaDonVi
                             join cn in PB.ChuyenNganhs on nd.MaChuyenNganh equals cn.MaChuyenNganh
                             join qg in PB.QuocGias on nd.MaQG equals qg.MaQG
                             where nd.MaNguoiDung == cc
                             select new
                             {
                                 NguoiDung = nd,
                                 HocHam = hh == null ? "" : hh.MaHocHam,
                                 DonVi = dv,
                                 QuocGia = qg,
                                 HocVi = hv,
                                 ChuyenNganh = cn,
                             }).SingleOrDefault();
                    if (x != null)
                    {
                        cboHocHam.SelectedValue = x.HocHam;
                        cboHocVi.SelectedValue = x.HocVi.MaHocVi;
                        txtEmail.Text = x.NguoiDung.Email;
                        cboChuyenNganh.SelectedValue = x.ChuyenNganh.MaChuyenNganh;
                        cboQuocGia.SelectedValue = x.QuocGia.MaQG;
                        cbo_Donvi.SelectedValue = x.NguoiDung.MaDonVi;
                    }
                }
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ktraPB_ChonLai())
            {
                int countChoDuyet = 0;

                foreach (DataGridViewRow r in grvDanhSachPB.Rows)
                {
                    if (r.Cells[1].Value != null && r.Cells[1].Value.ToString() == "Chờ duyệt")
                    {
                        countChoDuyet++;
                    }
                }

                if (countChoDuyet >= 2)
                {
                    MessageBox.Show("Đã có 2 giảng viên trong trạng thái 'Chờ duyệt'. Không thể thêm nữa.");
                    return;
                }
                string ma = grvGVPB.Rows[flag].Cells[0].Value.ToString();
                var isDuplicate = PB.ChiTietPhanBiens
                                   .Where(x => x.MaBaiBao == flag_BB)
                                   .Any(x => x.MaNguoiDung == ma);
                if (isDuplicate)
                {
                    MessageBox.Show("Giảng viên này đã có trong danh sách phản biện.");
                    return;
                }

                if (grvDanhSachPB.Rows.Count <= 3)
                {
                    themCTPB(ma);
                }
                else
                {
                    MessageBox.Show("Đã đủ số lượng phản biện");
                }
            }

            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
        }


        private bool ktraPB_ChonLai()
        {
            try
            {
                var chiTietPB = PB.ChiTietPhanBiens
                                  .Where(x => x.MaBaiBao == flag_BB)
                                  .ToList();
                int uniqueReviewersCount = chiTietPB.Select(x => x.MaNguoiDung).Distinct().Count();

                if (uniqueReviewersCount == 0 || uniqueReviewersCount == 1)
                {
                    return true;
                }
                else if (uniqueReviewersCount == 2)
                {
                    bool hasAccepted = chiTietPB.Any(x => x.KetQuaPhanBien == "Đồng ý");
                    bool hasRejected = chiTietPB.Any(x => x.KetQuaPhanBien == "Từ chối");

                    if (hasAccepted && hasRejected)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Phản biện không thỏa mãn điều kiện 'Đồng ý' và 'Từ chối'.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Danh sách phản biện đã đủ số lượng.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra điều kiện: " + ex.Message);
                return false;
            }
        }
        void themCTPB(string mand)
        {
            try
            {
                if (!string.IsNullOrEmpty(flag_BB))
                {
                    if (dspbList.Any(x => x.MaNguoiDung == mand))
                    {
                        MessageBox.Show("Giảng viên này đã có trong danh sách phản biện.");
                        return;
                    }
                    dspbList.Add(new DanhSachPB
                    {
                        MaNguoiDung = mand,
                        TrangThai_TBT = "Chờ duyệt",
                        IsNew = true
                    });
                    var bindingSource = new BindingSource();
                    bindingSource.DataSource = dspbList;
                    grvDanhSachPB.DataSource = bindingSource;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn bài viết.");
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm phản biện.");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in dspbList)
                {
                    var existingItem = PB.LichSuChonNguoiPhanBiens
                        .FirstOrDefault(x => x.MaNguoiDung == item.MaNguoiDung && x.MaBaiBao == flag_BB);

                    if (existingItem == null)
                    {
                        var newItem = new LichSuChonNguoiPhanBien
                        {

                            MaNguoiDung = item.MaNguoiDung,
                            MaBaiBao = flag_BB,
                            NgayGuiYeuCau = DateTime.Now,
                            TrangThaiTBT = item.TrangThai_TBT
                        };
                        PB.LichSuChonNguoiPhanBiens.InsertOnSubmit(newItem);
                    }
                }
                PB.SubmitChanges();
                MessageBox.Show("Dữ liệu đã được lưu thành công.");
                btnLuu.Enabled = false;
                btnXoa.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btn_TimBV_Click(object sender, EventArgs e)
        {
            find_BV(ChkLocNgay.Checked, cboNgonNgu.SelectedValue.ToString(), cboChuyenMuc.SelectedValue.ToString());
        }

        private void find_BV(bool cd, string ngonNgu, string chuyenMuc)
        {
            try
            {
                var query = PB.BaiViets.AsQueryable();
                query = query.Where(bv => bv.TrangThai == "Tiến hành phản biện");
                if (cd)
                {
                    bool tempt = ktraNgay(dateTuNgay.Value, dateDenNgay.Value);
                    if (!tempt)
                        return;
                    else
                        query = query.Where(bv => bv.NgayGui >= dateTuNgay.Value && bv.NgayGui <= dateDenNgay.Value);
                }
                if (!string.IsNullOrEmpty(ngonNgu) && ngonNgu != "---")
                {
                    query = query.Where(bv => bv.MaNgonNgu == ngonNgu);
                }
                if (!string.IsNullOrEmpty(chuyenMuc) && chuyenMuc != "---")
                {
                    query = query.Where(bv => bv.MaChuyenMuc == chuyenMuc);
                }
                var result = query.Select(bv => new
                {
                    MaBaiBao = bv.MaBaiBao,
                    TenBaiBao = bv.TenBaiBao,
                    TieuDe = bv.TieuDe,
                    NgayGui = bv.NgayGui,

                }).ToList(); 
                grvBaiBao.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool ktraNgay(DateTime st, DateTime end)
        {
            if (st > end)
            {
                MessageBox.Show("Ngày không hợp lệ, vui lòng chọn lại");
                return false;
            }
            return true;
        }
        private void btn_timPB_Click(object sender, EventArgs e)
        {
            string hocham = cboHocHam.SelectedValue.ToString();
            string hocvi = cboHocVi.SelectedValue.ToString();
            string chuyennganh = cboChuyenNganh.SelectedValue.ToString();
            string quocgia = cboQuocGia.SelectedValue.ToString();
            string email = txtEmail.Text;
            string donvi = cbo_Donvi.SelectedValue.ToString();
            find_PB(hocham, hocvi, chuyennganh, quocgia, email, donvi);
        }

        private void find_PB(string hocham, string hocvi, string chuyennganh, string quocgia, string email, string donvi)
        {
            try
            {
                var pb = PB.NguoiDungs.AsQueryable();

                if (!string.IsNullOrEmpty(hocham) && hocham != "---")
                {
                    pb = pb.Where(t => t.MaHocHam == hocham);
                }
                if (!string.IsNullOrEmpty(hocvi) && hocvi != "---")
                {
                    pb = pb.Where(t => t.MaHocVi == hocvi);
                }
                if (!string.IsNullOrEmpty(chuyennganh) && chuyennganh != "---")
                {
                    pb = pb.Where(t => t.MaChuyenNganh == chuyennganh);
                }
                if (!string.IsNullOrEmpty(quocgia) && quocgia != "---")
                {
                    pb = pb.Where(t => t.MaQG == quocgia);
                }
                if (!string.IsNullOrEmpty(email))
                {
                    pb = pb.Where(t => t.Email.Equals(email));
                }
                if (!string.IsNullOrEmpty(donvi) && donvi != "---")
                {
                    pb = pb.Where(t => t.MaDonVi == donvi);
                }


                var result = pb.Select(fpb => new
                {
                    MaPB = fpb.MaNguoiDung,
                    CCCD = fpb.CCCD,
                    HoTen = fpb.HoTen,
                    SDT = fpb.SoDienThoai,
                    GioiTinh = fpb.GioiTinh
                }).ToList();
                if (result.Count > 0)
                    grvGVPB.DataSource = result;
                else
                {
                    MessageBox.Show("Không có phản biện viên phù hợp");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            grvDanhSachPB.Rows.Clear();
            load_LofA();
            load_Cbbox();
            load_PB(null);
            txtEmail.Clear();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (grvDanhSachPB.CurrentRow != null)
                {
                    var selectedRow = grvDanhSachPB.CurrentRow;
                    string maNguoiDung = selectedRow.Cells["MaNguoiDung"].Value.ToString();
                    var itemToRemove = dspbList.FirstOrDefault(x => x.MaNguoiDung == maNguoiDung && x.IsNew);

                    if (itemToRemove != null)
                    {
                        dspbList.Remove(itemToRemove);
                        var bindingSource = new BindingSource();
                        bindingSource.DataSource = dspbList;
                        grvDanhSachPB.DataSource = bindingSource;
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa phản biện đã có sẵn trong cơ sở dữ liệu.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void grvDanhSachPB_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.Name == "IsNew")
            {
                e.Column.Visible = false;
            }
        }

        private void ChkLocNgay_CheckedChanged(object sender, EventArgs e)
        {
            dateTuNgay.Enabled = ChkLocNgay.Checked;
            dateDenNgay.Enabled = ChkLocNgay.Checked;
        }
    }
}
