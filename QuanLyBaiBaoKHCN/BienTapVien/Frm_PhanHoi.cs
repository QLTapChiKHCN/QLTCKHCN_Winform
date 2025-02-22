using QuanLyBaiBaoKHCN.data;
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
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.Net;

namespace QuanLyBaiBaoKHCN.BienTapVien
{
    public partial class Frm_PhanHoi : Form
    {
        QLTapChi_KHCNDataContext qltckh = new QLTapChi_KHCNDataContext();
        string maNguoiDung;
        public Frm_PhanHoi(string maNguoiDung)
        {
            InitializeComponent();
            loadPhanhoi();
            this.maNguoiDung = maNguoiDung;
        }

        #region method

        void loadPhanhoi()
        {
            var phanhoi = from ph in qltckh.PhanHois
                          join bv in qltckh.BaiViets on ph.MaBaiBao equals bv.MaBaiBao
                          join nd in qltckh.NguoiDungs on ph.MaNguoiDung equals nd.MaNguoiDung
                          join vt in qltckh.NguoiDung_VaiTros on ph.MaNguoiDung equals vt.MaNguoiDung
                          where vt.MaVaiTro == "VT03"
                          select new
                          {
                              MaBaiBao = bv.MaBaiBao,
                              TenBaiBao = bv.TenBaiBao,
                              MaNguoiDung = ph.MaNguoiDung,
                              TenNguoiDung = nd.HoTen,
                              NgayGui = ph.NgayGui,
                              FileBienSoan = ph.FileBienSoan,
                              NoiDung = ph.NoiDung,
                          };
            grvBaiBao.DataSource= phanhoi;
        }
        #endregion

        private void grvBaiBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grvBaiBao.Rows.Count)
            {
                DataGridViewRow row = grvBaiBao.Rows[e.RowIndex];
                txtMaBaiBao.Text = row.Cells["MaBaiBao"].Value?.ToString() ?? "";
                txtTenBaiBao.Text = row.Cells["TenBaiBao"].Value?.ToString() ?? "";
                txtMaNguoiDung.Text= row.Cells["MaNguoiDung"].Value?.ToString() ?? "";
                txtHoTen.Text = row.Cells["TenNguoiDung"].Value?.ToString() ?? "";
                if (row.Cells["NgayGui"].Value != DBNull.Value)
                {
                    DateTime ngayGui = Convert.ToDateTime(row.Cells["NgayGui"].Value);
                    dateNgayGui.Value = ngayGui; 
                }
                txtnoidung.Text = row.Cells["NoiDung"].Value?.ToString() ?? "";
                txtFileBienSoan.Text= row.Cells["FileBienSoan"].Value?.ToString() ?? "";
            }
        }

        private async void btnFile_Click(object sender, EventArgs e)
        {
            if (grvBaiBao.SelectedRows.Count > 0)
            {
                
                string maBaiBao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value?.ToString();
                string maNguoiDung = grvBaiBao.SelectedRows[0].Cells["MaNguoiDung"].Value?.ToString(); 
                string fileName = grvBaiBao.SelectedRows[0].Cells["FileBienSoan"].Value?.ToString();
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Không có file được đính kèm cho bài báo này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                DateTime ngayGui = Convert.ToDateTime(grvBaiBao.SelectedRows[0].Cells["NgayGui"].Value); 

               
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.FileName = fileName;  
                    saveFileDialog.Filter = "All Files (*.*)|*.*";  

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            
                            string url = $"http://127.0.0.1:8000/api/download-feedback/{maBaiBao}/{maNguoiDung}/{ngayGui:yyyy-MM-dd}";

                            try
                            {
                                
                                HttpResponseMessage response = await client.GetAsync(url);

                                if (response.IsSuccessStatusCode)
                                {
                                    
                                    byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();

                                   
                                    File.WriteAllBytes(saveFileDialog.FileName, fileBytes);

                                    
                                    MessageBox.Show("File tải thành công!");

                                  
                                    DialogResult result = MessageBox.Show("Bạn có muốn mở file không?", "Mở file", MessageBoxButtons.YesNo);
                                    if (result == DialogResult.Yes)
                                    {
                                        
                                        System.Diagnostics.Process.Start(saveFileDialog.FileName);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Tải file thất bại. Đã xảy ra lỗi khi kết nối đến server.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
                            }
                        }
                    }
                }
            }
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
        private async void btnPhanhoi_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                await UpdateProgress(0, 20);
                string mabaibao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();
                FormPhanHoi frmph = new FormPhanHoi(mabaibao, maNguoiDung);
                if(frmph.ShowDialog() == DialogResult.OK)
                {
                    await UpdateProgress(20, 60);
                    var emails = (from ct in qltckh.PhanHois
                                  join nd in qltckh.NguoiDungs on ct.MaNguoiDung equals nd.MaNguoiDung
                                  where ct.MaBaiBao == mabaibao
                                  select nd.Email).ToList();

                    string emailBody = $@"<html>
                        <body>
                            <p>{frmph.NoiDung}</p>
                        </body>
                        </html>";


                    await UpdateProgress(60, 80);

                    var emailTasks = emails.Select(email =>
                        Task.Run(() => sendEmailFormArticle(email, "Đã Nhận Phản Hồi", emailBody))
                    ).ToList();

                    await Task.WhenAll(emailTasks);

                    await UpdateProgress(80, 100);

                    MessageBox.Show("Thành công");
                }    

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi"+ex.Message);
            }
            finally
            {
                progressBar1.Visible = false;
               
            }
        }
    }
}
