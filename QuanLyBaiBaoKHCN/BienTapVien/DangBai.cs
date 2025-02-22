using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Sunny.UI;
using QuanLyBaiBaoKHCN.data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.Net;

namespace QuanLyBaiBaoKHCN.BienTapVien
{
    public partial class DangBai : Form
    {
        QLTapChi_KHCNDataContext qlTCKHCN = new QLTapChi_KHCNDataContext();
        public DangBai()
        {
            InitializeComponent();
            loadBaiViet();
            loadCbChuyenMuc();
            loadCbNgonNgu();
            loadCbSoTapChi();
        }

        private void DangBai_Load(object sender, EventArgs e)
        {

        }
        #region method
        private async Task UpdateProgress(int startValue, int endValue)
        {
            for (int i = startValue; i <= endValue; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(20);
            }
        }
        void loadCbSoTapChi()
        {
            var tapchi = from tc in qlTCKHCN.SoTapChis
                         select tc;
            cboMaSoTapChi.DataSource= tapchi;
            cboMaSoTapChi.DisplayMember = "TenSo";
            cboMaSoTapChi.ValueMember = "MaSoTC";
            cboMaSoTapChi.SelectedIndexChanged += cboMaSoTapChi_SelectedIndexChanged;
        }    
        void loadCbNgonNgu()
        {
            var ngonngu = from nn in qlTCKHCN.NgonNgus
                          select nn;
            cboNgonNgu.DataSource = ngonngu;
            cboNgonNgu.DisplayMember = "TenNgonNgu";
            cboNgonNgu.ValueMember = "MaNgonNgu";
            cboNgonNgu.SelectedIndex = -1;
        }
        void loadCbChuyenMuc()
        {
            var chuyenMuc = from cn in qlTCKHCN.ChuyenMucs
                            select cn;
            cboChuyenMuc.DataSource = chuyenMuc;
            cboChuyenMuc.DisplayMember = "TenChuyenMuc";
            cboChuyenMuc.ValueMember = "MaChuyenMuc";
            cboChuyenMuc.SelectedIndex = -1;
        }
        void loadBaiViet()
        {
            var baiviet = from bv in qlTCKHCN.BaiViets
                          join cm in qlTCKHCN.ChuyenMucs on bv.MaChuyenMuc equals cm.MaChuyenMuc
                          join nn in qlTCKHCN.NgonNgus on bv.MaNgonNgu equals nn.MaNgonNgu
                          where bv.TrangThai == "Đồng ý"
                          select new
                          {
                              MaBaiBao = bv.MaBaiBao,
                              TenBaiBao = bv.TenBaiBao,
                              TieuDe = bv.TieuDe,
                              NgayGui = bv.NgayGui,
                              FileBaiViet = bv.FileBaiViet,
                              TrangThai = bv.TrangThai,
                              TenChuyenMuc = cm.TenChuyenMuc,
                              TenNgonNgu = nn.TenNgonNgu,
                              MaChuyenMuc = bv.MaChuyenMuc,
                              MaNgonNgu = bv.MaNgonNgu
                          };
            
            grvBaiBao.DataSource = baiviet.ToList();

        }
        void FilterBaiViet()
        {
            var query = from bv in qlTCKHCN.BaiViets
                        join cm in qlTCKHCN.ChuyenMucs on bv.MaChuyenMuc equals cm.MaChuyenMuc
                        join nn in qlTCKHCN.NgonNgus on bv.MaNgonNgu equals nn.MaNgonNgu
                        select new
                        {
                            MaBaiBao = bv.MaBaiBao,
                            TenBaiBao = bv.TenBaiBao,
                            TieuDe = bv.TieuDe,
                            NgayGui = bv.NgayGui,
                            FileBaiViet = bv.FileBaiViet,
                            TrangThai = bv.TrangThai,
                            TenChuyenMuc = cm.TenChuyenMuc,
                            TenNgonNgu = nn.TenNgonNgu,
                            MaChuyenMuc = bv.MaChuyenMuc,
                            MaNgonNgu = bv.MaNgonNgu
                        };
            if (ChkLocNgay.Checked)
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
        #endregion

        private void ChkLocNgay_CheckedChanged(object sender, EventArgs e)
        {
            dateTuNgay.Enabled = ChkLocNgay.Checked;
            dateDenNgay.Enabled = ChkLocNgay.Checked;
            FilterBaiViet();
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

        private void AnhBia_Click(object sender, EventArgs e)
        {

        }

        private void cboMaSoTapChi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboMaSoTapChi.SelectedItem != null)
                {
                    var selectedTapChi = (SoTapChi)cboMaSoTapChi.SelectedItem;
             
                    if (selectedTapChi.NgayXuatBan != null)
                    {
                        dateNXB.Value = selectedTapChi.NgayXuatBan.Value;
                    }
                    if (AnhBia.Image != null)
                    {
                        AnhBia.Image.Dispose();
                        AnhBia.Image = null;
                    }

                 
                    if (!string.IsNullOrEmpty(selectedTapChi.AnhBiaLocal))
                    {
                      
                        string fileName = Path.GetFileName(selectedTapChi.AnhBiaLocal);

                      
                        string imagePath = Path.Combine(Application.StartupPath, "Images", fileName);

                       
                        if (File.Exists(imagePath))
                        {
                            using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                            {
                                AnhBia.Image = Image.FromStream(stream);
                            }
                            AnhBia.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        else
                        {
                            AnhBia.Image = null;
                            
                        }
                    }
                    else
                    {
                        AnhBia.Image = null;
                      
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load ảnh: {ex.Message}");
                AnhBia.Image = null;
            }
        }

        private void grvBaiBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grvBaiBao.Rows.Count)
            {
                DataGridViewRow row = grvBaiBao.Rows[e.RowIndex];
                string mabaibao = row.Cells["MaBaiBao"].Value?.ToString() ?? "";
                txtMaBaiBao.Text = mabaibao;  
            }
        }

        private async void btnDangBai_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                if (string.IsNullOrEmpty(txtMaBaiBao.Text))
                {
                    MessageBox.Show("Vui lòng chọn bài viết cần đăng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (cboMaSoTapChi.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn số tạp chí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string maBaiBao = txtMaBaiBao.Text;
                string maSoTC = cboMaSoTapChi.SelectedValue.ToString();
                await UpdateProgress(0, 20);
                var baiViet = qlTCKHCN.BaiViets.SingleOrDefault(bv => bv.MaBaiBao == maBaiBao);
                await UpdateProgress(20, 50);
                if (baiViet != null)
                {

                    baiViet.MaSoTC = maSoTC;
                    baiViet.TrangThai = "Đăng bài";

                    await UpdateProgress(50, 100);
                    qlTCKHCN.SubmitChanges();
                    await sendEmailWithMultipleFiles(maBaiBao, "Đăng bài", "Bài báo của bạn đã được đăng thành công.");
                    MessageBox.Show("Đăng bài thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    loadBaiViet();
                    cboMaSoTapChi.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy bài viết!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng bài: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar1.Value = 0;
                progressBar1.Visible = false;

            }
        }

        private async Task sendEmailWithMultipleFiles(string maBaiBao, string trangThai, string messageBody)
        {
            var emails = (from ct in qlTCKHCN.ChiTietBaiViets
                          join nd in qlTCKHCN.NguoiDungs on ct.MaNguoiDung equals nd.MaNguoiDung
                          where ct.MaBaiBao == maBaiBao
                          select nd.Email).Distinct().ToList();

            var baiBao = qlTCKHCN.BaiViets.FirstOrDefault(b => b.MaBaiBao == maBaiBao);
            if (baiBao == null) return;


            var soTapChi = qlTCKHCN.SoTapChis.FirstOrDefault(tc => tc.MaSoTC == baiBao.MaSoTC);
            if (soTapChi == null) return;

            if (!emails.Any()) return;

            var fromEmail = "lebuithienduc123@gmail.com";
            var fromPassword = "bfpqwikprpacliwt";

            using (var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromEmail, fromPassword),
                EnableSsl = true,
            })
            using (var mailMessage = new MailMessage
            {
                From = new MailAddress(fromEmail),
                Subject = $"Thông báo đăng bài - {baiBao.TenBaiBao}",
                Body = $@"
            <html>
            <body>
                <h2>Thông báo đăng bài</h2>
                <p>Bài báo của bạn đã được đăng với thông tin sau:</p>
                <ul>
                    <li><strong>Tên bài báo:</strong> {baiBao.TenBaiBao}</li>
                    <li><strong>Số tạp chí:</strong> {soTapChi.TenSo}</li>
                    <li><strong>Ngày xuất bản:</strong> {soTapChi.NgayXuatBan?.ToString("dd/MM/yyyy")}</li>
                </ul>
                {messageBody}
            </body>
            </html>
        ",
                IsBodyHtml = true,
            })
            {
                foreach (var email in emails)
                {
                    mailMessage.To.Add(email);
                }


                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        string url = $"http://127.0.0.1:8000/api/download-file/{maBaiBao}";
                        var response = await client.GetAsync(url);
                        if (response.IsSuccessStatusCode)
                        {
                            byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();
                            var memoryStream = new MemoryStream(fileBytes);
                            mailMessage.Attachments.Add(new Attachment(memoryStream, baiBao.FileBaiViet));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải file bài viết: {ex.Message}");
                }

                try
                {
                    await smtpClient.SendMailAsync(mailMessage);
                    MessageBox.Show("Đã gửi email thông báo thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi gửi email: " + ex.Message);
                }
            }
        }


    }
}
