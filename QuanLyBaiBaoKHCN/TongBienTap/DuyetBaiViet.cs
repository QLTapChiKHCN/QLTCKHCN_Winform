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
    public partial class DuyetBaiViet : Form
    {
        QLTapChi_KHCNDataContext qltc = new QLTapChi_KHCNDataContext();
        public DuyetBaiViet()
        {
            InitializeComponent();
            load_gridview();
            load_combobox_BanDau();
            dateDenNgay.Value = DateTime.Today;
            cboNgonNgu.Text = "";
            cboChuyenMuc.Text = "";
        }

        #region xử lí load
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
        void load_gridview()
        {
            var baibao = from bv in qltc.BaiViets
                         join nn in qltc.NgonNgus on bv.MaNgonNgu equals nn.MaNgonNgu
                         join cm in qltc.ChuyenMucs on bv.MaChuyenMuc equals cm.MaChuyenMuc
                         where bv.TrangThai == "Chờ duyệt"
                         select new
                         {
                             MaBaiBao = bv.MaBaiBao,
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
            //grvBaiBao.AutoGenerateColumns = false;
            grvBaiBao.DataSource = baibao.ToList();
        }

        void enable_btn(bool x)
        {
            btnXemFile.Enabled = x;
            btnDuyet.Enabled = x;
            btnKhongDuyet.Enabled = x;
            btnHuy.Enabled = !x;
            btnLuu.Enabled = !x;
        }

        private void grvBaiBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value != null)
                {
                    string mabaibao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();
                    var baiviet = qltc.BaiViets.SingleOrDefault(bv => bv.MaBaiBao == mabaibao);
                    cboChuyenMuc.SelectedValue = baiviet.MaChuyenMuc;
                    cboNgonNgu.SelectedValue = baiviet.MaNgonNgu;
                    txtTrangThai.Text = baiviet.TrangThai;
                    enable_btn(txtTrangThai.Text != "Đồng ý" && txtTrangThai.Text != "Từ chối");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region xử lí button

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (grvBaiBao.SelectedRows.Count > 0)
            {
                string tenBaiBao = grvBaiBao.SelectedRows[0].Cells["TenBaiBao"].Value.ToString();
                DialogResult result = MessageBox.Show($"Duyệt bài viết '{tenBaiBao}'?", "Xác nhận duyệt", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string mabaibao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();
                    var baiviet = qltc.BaiViets.SingleOrDefault(bv => bv.MaBaiBao == mabaibao);
                    if (baiviet != null)
                    {
                        baiviet.NgayXetDuyet = DateTime.Today;
                        baiviet.TrangThai = "Đồng ý";
                        txtTrangThai.Text = "Đồng ý";
                    }
                    enable_btn(txtTrangThai.Text != "Đồng ý" && txtTrangThai.Text != "Từ chối");
                }
            }
        }
        private void btnKhongDuyet_Click(object sender, EventArgs e)
        {
            if (grvBaiBao.SelectedRows.Count > 0)
            {
                string tenBaiBao = grvBaiBao.SelectedRows[0].Cells["TenBaiBao"].Value.ToString();
                DialogResult result = MessageBox.Show($"Từ chối bài viết '{tenBaiBao}'?", "Xác nhận từ chối", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string mabaibao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();
                    var baiviet = qltc.BaiViets.SingleOrDefault(bv => bv.MaBaiBao == mabaibao);
                    if (baiviet != null)
                    {
                        baiviet.NgayXetDuyet = DateTime.Today;
                        baiviet.TrangThai = "Từ chối";
                        txtTrangThai.Text = "Từ chối";
                    }
                    enable_btn(txtTrangThai.Text != "Đồng ý" && txtTrangThai.Text != "Từ chối");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            qltc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, qltc.BaiViets);
            load_gridview();
            enable_btn(true);
            txtTrangThai.Clear();
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                qltc.SubmitChanges();
                MessageBox.Show("Đã lưu thay đổi!");
                load_gridview();
                enable_btn(false);
                txtTrangThai.Clear();
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }

        private async void btnXemFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (grvBaiBao.SelectedRows[0].Cells["FileBaiViet"].Value != null)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #endregion


        #region lọc bài viết
        void FilterBaiViet(DateTime tungay, DateTime denngay)
        {
            var query = from bv in qltc.BaiViets
                        join cm in qltc.ChuyenMucs on bv.MaChuyenMuc equals cm.MaChuyenMuc
                        join nn in qltc.NgonNgus on bv.MaNgonNgu equals nn.MaNgonNgu
                        where bv.TrangThai == "Chờ duyệt"
                        select new
                        {
                            MaBaiBao = bv.MaBaiBao,
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
        #endregion
    }
}
