using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using QuanLyBaiBaoKHCN.data;

namespace QuanLyBaiBaoKHCN.BienTapVien
{
    public partial class SoDuyet : Form
    {
        QLTapChi_KHCNDataContext qlTCKHCN = new QLTapChi_KHCNDataContext();
        string maNguoiDung;
        public SoDuyet(string maNguoiDung)
        {
            InitializeComponent();
            loadCbChuyenMuc();
            loadCbNgonNgu();
            loadBaiViet();
            this.maNguoiDung= maNguoiDung;
        }

        #region method
        void loadCbNgonNgu()
        {
            var ngonngu = from nn in qlTCKHCN.NgonNgus
                          select nn;
            cboNgonNgu.DataSource=ngonngu;
            cboNgonNgu.DisplayMember = "TenNgonNgu";
            cboNgonNgu.ValueMember = "MaNgonNgu";
            cboNgonNgu.SelectedIndex = -1;
        }    
        void loadCbChuyenMuc()
        {
            var chuyenMuc=from cn in qlTCKHCN.ChuyenMucs
                            select cn;
            cboChuyenMuc.DataSource=chuyenMuc;
            cboChuyenMuc.DisplayMember = "TenChuyenMuc";
            cboChuyenMuc.ValueMember = "MaChuyenMuc";
            cboChuyenMuc.SelectedIndex = -1;
        }
        void loadBaiViet()
        {
            var baiviet = from bv in qlTCKHCN.BaiViets
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
            grvBaiBao.AutoGenerateColumns = false;
            grvBaiBao.DataSource=baiviet.ToList();
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
            if(cboTrangThaiBaiBao.SelectedIndex != -1)
            {
                string trangthai= cboTrangThaiBaiBao.SelectedItem.ToString();
                query = query.Where(x => x.TrangThai==trangthai);
            }    
            grvBaiBao.DataSource = query.ToList();
        }
        private async Task UpdateProgress(int startValue, int endValue)
        {
            for (int i = startValue; i <= endValue; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(10); 
            }
        }


        private async Task sendEmailFormArticle(string toEmail, string subject, string body, string attachmentPath = null)
        {
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
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
            })
            {
                mailMessage.To.Add(toEmail);

                if (!string.IsNullOrEmpty(attachmentPath) && File.Exists(attachmentPath))
                {
                    mailMessage.Attachments.Add(new Attachment(attachmentPath));
                }

                try
                {
                    await smtpClient.SendMailAsync(mailMessage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi gửi email: " + ex.Message);
                }
            }
        }
        void enable()
        {
            btnDuyet.Enabled = false;
            btnKhongDuyet.Enabled = false;
            btnChinhSua.Enabled = false;
        }
        #endregion
        #region Event
        private async void btnNhanBai_Click(object sender, EventArgs e)
        {
            if (grvBaiBao.SelectedRows.Count > 0)
            {
                try
                {
                   
                    Cursor = Cursors.WaitCursor;
                    progressBar1.Visible = true;
                    progressBar1.Value = 0;

                    btnXemFile.Enabled = true;
                    string TrangThai = "Đang xét duyệt";

                    
                    await UpdateProgress(0, 20);

                    string mabaibao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();
                    var baiviet = qlTCKHCN.BaiViets.SingleOrDefault(bv => bv.MaBaiBao == mabaibao);

                    if (baiviet != null && baiviet.TrangThai.Equals("Chờ xét duyệt"))
                    {
                        
                        await UpdateProgress(20, 40);

                        btnDuyet.Enabled = true;
                        btnKhongDuyet.Enabled = true;
                        btnChinhSua.Enabled = true;
                        baiviet.TrangThai = TrangThai;
                        qlTCKHCN.SubmitChanges();

                       
                        await UpdateProgress(40, 60);

                        var emails = (from ct in qlTCKHCN.ChiTietBaiViets
                                      join nd in qlTCKHCN.NguoiDungs on ct.MaNguoiDung equals nd.MaNguoiDung
                                      where ct.MaBaiBao == mabaibao
                                      select nd.Email).ToList();

                
                        await UpdateProgress(60, 80);

                        var emailTasks = emails.Select(email =>
                            Task.Run(() => sendEmailFormArticle(email, "Đã nhận bài báo",
                                $@"
                        <h3>Thông báo kết quả phản biện</h3>
                        <p>Kính gửi quý tác giả,</p>
                        <p>Bài báo của quý vị hiện đang ở trạng thái chờ xét duyệt, vui lòng đợi từ 3 đến 5 ngày.</p>
                        <p>Trân trọng,</p>
                        <p>Ban biên tập</p>"))
                        ).ToList();

                        await Task.WhenAll(emailTasks);

                        
                        await UpdateProgress(80, 100);

                        MessageBox.Show("Thành công");
                        loadBaiViet();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn bài viết có trạng thái Chờ Xét Duyệt");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
                finally
                {
                    progressBar1.Visible = false;
                    Cursor = Cursors.Default;
                }
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
                                DialogResult result = MessageBox.Show("Bạn có muốn mở file không?", "Mở file", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    // Mở file sau khi tải xong 
                                    System.Diagnostics.Process.Start(filePath);
                                }
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

        private void cboTrangThaiBaiBao_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBaiViet();
        }

        private void cboChuyenMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBaiViet();
        }

        private void cboNgonNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterBaiViet();
        }

        private async void btnDuyet_Click(object sender, EventArgs e)
        {
            if (grvBaiBao.SelectedRows.Count > 0)
            {
                try
                {
                    
                    Cursor = Cursors.WaitCursor;
                    progressBar1.Visible = true;
                    progressBar1.Value = 0;

                    btnXemFile.Enabled = true;
                    string TrangThai = "Tiến hành phản biện";

                    
                    await UpdateProgress(0, 20);

                    string mabaibao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();
                    var baiviet = qlTCKHCN.BaiViets.SingleOrDefault(bv => bv.MaBaiBao == mabaibao);

                    if (baiviet != null && baiviet.TrangThai.Equals("Đang xét duyệt"))
                    {
                      
                        await UpdateProgress(20, 40);

                        baiviet.TrangThai = TrangThai;
                        qlTCKHCN.SubmitChanges();

                        
                        await UpdateProgress(40, 60);

                        var emails = (from ct in qlTCKHCN.ChiTietBaiViets
                                      join nd in qlTCKHCN.NguoiDungs on ct.MaNguoiDung equals nd.MaNguoiDung
                                      where ct.MaBaiBao == mabaibao
                                      select nd.Email).ToList();

                        
                        await UpdateProgress(60, 80);

                        var emailTasks = emails.Select(email =>
                            Task.Run(() => sendEmailFormArticle(email, "Đã Duyệt Bài Viết",
                                $@"
                        <h3>Thông báo kết quả phản biện</h3>
                        <p>Kính gửi quý tác giả,</p>
                        <p>Bài báo của quý vị hiện đang ở trạng thái phản biện</p>
                        <p>Trân trọng,</p>
                        <p>Ban biên tập</p>"))
                        ).ToList();

                        await Task.WhenAll(emailTasks);

                       
                        await UpdateProgress(80, 100);

                        MessageBox.Show("Thành công");
                        loadBaiViet();
                        enable();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn bài viết có trạng thái là Đang Xét Duyệt");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
                finally
                {
                    progressBar1.Visible = false;
                    Cursor = Cursors.Default;
                }
            }
        }

        private void grvBaiBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mabaibao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();

            var baiviet = qlTCKHCN.BaiViets.SingleOrDefault(bv => bv.MaBaiBao == mabaibao);
            if(baiviet.TrangThai.Equals("Đang xét duyệt"))
            {
                btnDuyet.Enabled = true;
                btnKhongDuyet.Enabled = true;
                btnChinhSua.Enabled = true;
            }    
            else
            {
                enable();
            }    
        }

        private async void btnKhongDuyet_Click(object sender, EventArgs e)
        {
            if (grvBaiBao.SelectedRows.Count > 0)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    progressBar1.Visible = true;
                    progressBar1.Value = 0;

                    btnXemFile.Enabled = true;
                    string TrangThai = "Từ chối";

                   
                    await UpdateProgress(0, 20);

                    string mabaibao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();
                    var baiviet = qlTCKHCN.BaiViets.SingleOrDefault(bv => bv.MaBaiBao == mabaibao);

                    if (baiviet != null && baiviet.TrangThai.Equals("Đang xét duyệt"))
                    {
                        
                        await UpdateProgress(20, 40);

                        baiviet.TrangThai = TrangThai;
                        qlTCKHCN.SubmitChanges();
                       
                        await UpdateProgress(40, 60);

                        var emails = (from ct in qlTCKHCN.ChiTietBaiViets
                                      join nd in qlTCKHCN.NguoiDungs on ct.MaNguoiDung equals nd.MaNguoiDung
                                      where ct.MaBaiBao == mabaibao
                                      select nd.Email).ToList();

                        await UpdateProgress(60, 80);

                        var emailTasks = emails.Select(email =>
                            Task.Run(() => sendEmailFormArticle(email, "Từ Chối Bài Viết",
                                $@"
                        <h3>Thông báo kết quả phản biện</h3>
                        <p>Kính gửi quý tác giả,</p>
                        <p>Bài báo của quý vị không đủ điều kiện để sơ duyệt</p>
                        <p>Trân trọng,</p>
                        <p>Ban biên tập</p>"))
                        ).ToList();

                        await Task.WhenAll(emailTasks);
                        
                        await UpdateProgress(80, 100);

                        MessageBox.Show("Thành công");
                        loadBaiViet();
                        enable();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn bài viết có trạng thái là Đang Xét Duyệt");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
                finally
                {
                    progressBar1.Visible = false;
                    Cursor = Cursors.Default;
                }
            }
        }

        private async void uiButton1_Click(object sender, EventArgs e)
        {
            if (grvBaiBao.SelectedRows.Count > 0)
            {
                try
                {
                    
                    Cursor = Cursors.WaitCursor;
                    progressBar1.Visible = true;
                    progressBar1.Value = 0;

                    btnXemFile.Enabled = true;
                    string TrangThai = "Chỉnh sửa";

                    
                    await UpdateProgress(0, 20);

                    string mabaibao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();
                    var baiviet = qlTCKHCN.BaiViets.SingleOrDefault(bv => bv.MaBaiBao == mabaibao);

                    if (baiviet != null && baiviet.TrangThai.Equals("Đang xét duyệt"))
                    {
                        await UpdateProgress(20, 40);

                        Frm_YeuCauChinhSua frmYeuCau = new Frm_YeuCauChinhSua(mabaibao, maNguoiDung);
                        if (frmYeuCau.ShowDialog() == DialogResult.OK)
                        {
                           
                            await UpdateProgress(40, 60);

                            baiviet.TrangThai = TrangThai;
                            qlTCKHCN.SubmitChanges();

                            var emails = (from ct in qlTCKHCN.ChiTietBaiViets
                                          join nd in qlTCKHCN.NguoiDungs on ct.MaNguoiDung equals nd.MaNguoiDung
                                          where ct.MaBaiBao == mabaibao
                                          select nd.Email).ToList();

                            string emailBody = $@"<html>
                        <body>
                            <p>Bài báo của bạn cần chỉnh sửa lại</p>
                            <p><strong>Nội dung yêu cầu chỉnh sửa:</strong></p>
                            <p>{frmYeuCau.NoiDung}</p>
                        </body>
                        </html>";

                          
                            await UpdateProgress(60, 80);

                            var emailTasks = emails.Select(email =>
                                Task.Run(() => sendEmailFormArticle(email, "Chỉnh Sửa Bài Viết", emailBody, frmYeuCau.FilePath))
                            ).ToList();

                            await Task.WhenAll(emailTasks);

                            await UpdateProgress(80, 100);

                            MessageBox.Show("Thành công");
                            loadBaiViet();
                            enable();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng chọn bài viết có trạng thái là Đang Xét Duyệt");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
                finally
                {
                    progressBar1.Visible = false;
                    Cursor = Cursors.Default;
                }
            }
        }

        private void dateTuNgay_ValueChanged(object sender, DateTime value)
        {
            if (ChkLocNgay.Checked)
            {
                if (dateTuNgay.Value > dateDenNgay.Value)
                {
                    MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Cảnh báo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateTuNgay.Value = dateDenNgay.Value;
                    return;
                }
                FilterBaiViet();
            }
        }

        private void dateDenNgay_ValueChanged(object sender, DateTime value)
        {
            if (ChkLocNgay.Checked)
            {
                if (dateDenNgay.Value < dateTuNgay.Value)
                {
                    MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu!", "Cảnh báo",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateDenNgay.Value = dateTuNgay.Value;
                    return;
                }
                FilterBaiViet();
            }
        }

        private void ChkLocNgay_CheckedChanged(object sender, EventArgs e)
        {
            dateTuNgay.Enabled = ChkLocNgay.Checked;
            dateDenNgay.Enabled = ChkLocNgay.Checked;
            FilterBaiViet();
        }
        #endregion
    }
}
