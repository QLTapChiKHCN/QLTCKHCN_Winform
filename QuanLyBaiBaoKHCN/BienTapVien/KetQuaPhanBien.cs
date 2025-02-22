using QuanLyBaiBaoKHCN.data;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyBaiBaoKHCN.BienTapVien
{
    public partial class KetQuaPhanBien : Form
    {
        QLTapChi_KHCNDataContext qltc = new QLTapChi_KHCNDataContext();

        public KetQuaPhanBien()
        {
            InitializeComponent();
            loadCTPB();
            DisableAllButtons();
        }
        private async Task UpdateProgress(int startValue, int endValue)
        {
            for (int i = startValue; i <= endValue; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(10);
            }
        }
        void loadCTPB()
        {
            var ctpb = from ct in qltc.ChiTietPhanBiens
                       join bv in qltc.BaiViets on ct.MaBaiBao equals bv.MaBaiBao
                       where bv.TrangThai == "Tiến hành phản biện"
                       select new
                       {
                           MaBaiBao = ct.MaBaiBao,
                           MaNguoiDung = ct.MaNguoiDung,
                           TenBaiBao = bv.TenBaiBao,
                           NgayTraKetQua = ct.NgayTraKetQua,
                           NgayNhan = ct.NgayNhan,
                           KetQuaPhanBien = ct.KetQuaPhanBien,
                           FilePhanBien = ct.FilePhanBien,
                       };
            grvBaiBao.DataSource = ctpb.ToList();
        }

        private void DisableAllButtons()
        {
            btnDuyet.Enabled = false;
            btnKhongDuyet.Enabled = false;
            btnChinhSua.Enabled = false;
            btnChonPhanBien.Enabled = false;
        }

        private ThongKePhanBien GetThongKePhanBien(string maBaiBao)
        {
            var ketQua = new ThongKePhanBien();
            ketQua.MaBaiBao = maBaiBao;
            ketQua.FilePhanBien = new List<string>();


            var dsPhanBien = qltc.ChiTietPhanBiens
                                 .Where(ct => ct.MaBaiBao == maBaiBao)
                                 .GroupBy(ct => ct.MaNguoiDung)
                                 .Select(g => g.OrderByDescending(ct => ct.MaChiTietPhanBien).First())
                                 .ToList();

            var baiBao = qltc.BaiViets.FirstOrDefault(bv => bv.MaBaiBao == maBaiBao);
            if (baiBao != null)
                ketQua.TenBaiBao = baiBao.TenBaiBao;

            var ketQuaPhanBienTheoNguoi = new Dictionary<string, string>();
            var filePhanBienTheoNguoi = new Dictionary<string, string>();

            foreach (var pb in dsPhanBien)
            {
                if (pb.FilePhanBien != null && pb.FilePhanBien != "")
                {
                    filePhanBienTheoNguoi[pb.MaNguoiDung] = pb.FilePhanBien;
                }


                ketQuaPhanBienTheoNguoi[pb.MaNguoiDung] = pb.KetQuaPhanBien;
            }

            foreach (var ketQuaCuaNguoi in ketQuaPhanBienTheoNguoi.Values)
            {
                switch (ketQuaCuaNguoi)
                {
                    case "Đồng ý":
                        ketQua.SoPhieuDongY++;
                        break;
                    case "Từ chối":
                        ketQua.SoPhieuTuChoi++;
                        break;
                    case "Yêu cầu chỉnh sửa":
                        ketQua.SoPhieuChinhSua++;
                        break;
                }
            }

            ketQua.FilePhanBien = filePhanBienTheoNguoi.Values.ToList();

            return ketQua;
        }



    private void EnableButtons(ThongKePhanBien thongKe)
        {

            btnDuyet.Enabled = (thongKe.SoPhieuDongY >= 2);
            btnKhongDuyet.Enabled = (thongKe.SoPhieuTuChoi >= 2);
            btnChinhSua.Enabled = (thongKe.SoPhieuChinhSua > 0);

            btnChonPhanBien.Enabled = (thongKe.SoPhieuDongY == 1 && thongKe.SoPhieuTuChoi == 1);
        }


        private async Task sendEmailWithMultipleFiles(string maBaiBao, string trangThai, string messageBody)
        {
            
            var emails = (from ct in qltc.ChiTietBaiViets
                          join nd in qltc.NguoiDungs on ct.MaNguoiDung equals nd.MaNguoiDung
                          where ct.MaBaiBao == maBaiBao
                          select nd.Email).Distinct().ToList();

           
            var baiBao = qltc.BaiViets.FirstOrDefault(b => b.MaBaiBao == maBaiBao);
            if (baiBao == null) return;

            // Lấy tất cả các file phản biện
            var phanBienFiles = qltc.ChiTietPhanBiens
                .Where(ct => ct.MaBaiBao == maBaiBao && ct.FilePhanBien != null && ct.FilePhanBien != "")
                .Select(ct => new {
                    FileName = ct.FilePhanBien,
                    MaNguoiDung = ct.MaNguoiDung,
                    NgayNhan = ct.NgayNhan
                })
                .ToList();

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
                Subject = $"Kết quả phản biện - {baiBao.TenBaiBao} - {trangThai}",
                Body = messageBody,
                IsBodyHtml = true,
            })
            {
                foreach (var email in emails)
                {
                    mailMessage.To.Add(email);
                }

                if (phanBienFiles.Any())
                {
                    foreach (var file in phanBienFiles)
                    {
                        try
                        {
                            using (HttpClient client = new HttpClient())
                            {
                                string url = $"http://127.0.0.1:8000/api/download-result/{maBaiBao}/{file.MaNguoiDung}/{file.NgayNhan:yyyy-MM-dd}";

                                var response = await client.GetAsync(url);
                                if (response.IsSuccessStatusCode)
                                {
                                    byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();
                                    var memoryStream = new MemoryStream(fileBytes);
                                    mailMessage.Attachments.Add(new Attachment(memoryStream, file.FileName));
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi tải file {file.FileName}: {ex.Message}");
                            continue;
                        }
                    }
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

        private async void btnDuyet_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                if (grvBaiBao.SelectedRows.Count > 0)
                {
                    await UpdateProgress(0, 20);
                    string maBaiBao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();
                    var baiBao = qltc.BaiViets.FirstOrDefault(bv => bv.MaBaiBao == maBaiBao);
                    await UpdateProgress(20, 40);
                    if (baiBao != null)
                    {
                        baiBao.TrangThai = "Chờ duyệt";
                        qltc.SubmitChanges();
                        await UpdateProgress(40, 80);
                        string messageBody = $@"
                        <h3>Thông báo kết quả phản biện</h3>
                        <p>Kính gửi quý tác giả,</p>
                        <p>Chúng tôi vui mừng thông báo bài báo '{baiBao.TenBaiBao}' đã được phản biện và chấp nhận.</p>
                        <p>Bài báo của quý vị hiện đang ở trạng thái chờ duyệt cuối cùng.</p>
                        <p>Đính kèm là các file phản biện chi tiết.</p>
                        <p>Trân trọng,</p>
                        <p>Ban biên tập</p>";
                        await UpdateProgress(80, 100);
                        await sendEmailWithMultipleFiles(maBaiBao, "Chấp nhận", messageBody);
       
                        loadCTPB();
                        DisableAllButtons();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                progressBar1.Visible = false;
                Cursor = Cursors.Default;
            }

        }

        private async void btnChinhSua_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                if (grvBaiBao.SelectedRows.Count > 0)
                {
                    await UpdateProgress(0, 20);
                    string maBaiBao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();
                    var baiBao = qltc.BaiViets.FirstOrDefault(bv => bv.MaBaiBao == maBaiBao);

                    await UpdateProgress(20, 40);
                    if (baiBao != null)
                    {
                        // Lấy kết quả phản biện mới nhất có yêu cầu chỉnh sửa
                        var nguoiDungYeuCauChinhSua = qltc.ChiTietPhanBiens
                            .Where(ct => ct.MaBaiBao == maBaiBao &&
                                         ct.KetQuaPhanBien == "Yêu cầu chỉnh sửa")
                            .GroupBy(ct => ct.MaNguoiDung)
                            .Select(g => g.OrderByDescending(ct => ct.NgayNhan).First())
                            .ToList();

                        baiBao.TrangThai = "Yêu cầu chỉnh sửa";
                        qltc.SubmitChanges();

                        await UpdateProgress(40, 60);
                        foreach (var phanBien in nguoiDungYeuCauChinhSua)
                        {
                            var lichSuChonPhanBien = new LichSuChonNguoiPhanBien
                            {
                                MaNguoiDung = phanBien.MaNguoiDung,
                                MaBaiBao = maBaiBao,
                                NgayGuiYeuCau = DateTime.Today,
                                TrangThai = "Chấp nhận phản biện",
                                TrangThaiTBT = "Đồng ý"
                            };
                            qltc.LichSuChonNguoiPhanBiens.InsertOnSubmit(lichSuChonPhanBien);

                            var newChiTietPhanBien = new ChiTietPhanBien
                            {
                                MaBaiBao = maBaiBao,
                                MaNguoiDung = phanBien.MaNguoiDung,
                                NgayNhan = DateTime.Today,
                                KetQuaPhanBien = "Chờ phản hồi",
                                YKienPhanBien = null,
                                NgayHetHan = null,
                                NgayTraKetQua = null,
                                FilePhanBien = null
                            };
                            qltc.ChiTietPhanBiens.InsertOnSubmit(newChiTietPhanBien);
                        }

                        qltc.SubmitChanges();

                        await UpdateProgress(60, 80);

                        string messageBody = $@"
                <h3>Thông báo kết quả phản biện</h3>
                <p>Kính gửi quý tác giả,</p>
                <p>Bài báo '{baiBao.TenBaiBao}' cần được chỉnh sửa theo góp ý của người phản biện.</p>
                <p>Vui lòng xem chi tiết trong các file phản biện đính kèm.</p>
                <p>Quý vị vui lòng chỉnh sửa và gửi lại bài báo trong thời gian sớm nhất.</p>
                <p>Trân trọng,</p>
                <p>Ban biên tập</p>";

                        await UpdateProgress(80, 100);
                        await sendEmailWithMultipleFiles(maBaiBao, "Yêu cầu chỉnh sửa", messageBody);

                        loadCTPB();
                        DisableAllButtons();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                progressBar1.Visible = false;
                Cursor = Cursors.Default;
            }
        }

        private async void btnKhongDuyet_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                if (grvBaiBao.SelectedRows.Count > 0)
                {
                    await UpdateProgress(0, 20);
                    string maBaiBao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();
                    var baiBao = qltc.BaiViets.FirstOrDefault(bv => bv.MaBaiBao == maBaiBao);
                    if (baiBao != null)
                    {
                        await UpdateProgress(20, 40);
                        baiBao.TrangThai = "Từ chối";
                        baiBao.NgayXetDuyet = DateTime.Today;
                        qltc.SubmitChanges();
                        await UpdateProgress(40, 80);
                        string messageBody = $@"
                        <h3>Thông báo kết quả phản biện</h3>
                        <p>Kính gửi quý tác giả,</p>
                        <p>Chúng tôi rất tiếc phải thông báo bài báo '{baiBao.TenBaiBao}' chưa đáp ứng được yêu cầu để xuất bản.</p>
                        <p>Chi tiết lý do được nêu trong các file phản biện đính kèm.</p>
                        <p>Cảm ơn quý vị đã quan tâm đến tạp chí của chúng tôi.</p>
                        <p>Trân trọng,</p>
                        <p>Ban biên tập</p>";
                        await UpdateProgress(80, 100);
                        await sendEmailWithMultipleFiles(maBaiBao, "Từ chối", messageBody);
                       
                        loadCTPB();
                        DisableAllButtons();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                progressBar1.Visible = false;
                Cursor = Cursors.Default;
            }
        }

        private async void btnChonPhanBien_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                if (grvBaiBao.SelectedRows.Count > 0)
                {
                    string maBaiBao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();
                    var baiBao = qltc.BaiViets.FirstOrDefault(bv => bv.MaBaiBao == maBaiBao);
                    await UpdateProgress(20, 40);
                    if (baiBao != null)
                    {
                        await UpdateProgress(40, 80);
                        string messageBody = $@"
                        <h3>Thông báo kết quả phản biện</h3>
                        <p>Kính gửi quý tác giả,</p>
                        <p>Bài báo của quý vị hiện đang ở trạng thái chọn phản biện mới để quyết định bài viết.</p>
                        <p>Đính kèm là các file phản biện chi tiết.</p>
                        <p>Trân trọng,</p>
                        <p>Ban biên tập</p>";
                        await UpdateProgress(80, 100);
                        await sendEmailWithMultipleFiles(maBaiBao, "Chọn lại phản biện", messageBody);
                    }
                }
                Form_Main main = this.Owner as Form_Main;
                if (main != null)
                {
                    main.MoForm_ChonPB();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Form chọn pb");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                progressBar1.Visible = false;
                Cursor = Cursors.Default;
            }
        }

        private void grvBaiBao_SelectionChanged(object sender, EventArgs e)
        {
            if (grvBaiBao.SelectedRows.Count > 0)
            {
                string maBaiBao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();
                var thongKe = GetThongKePhanBien(maBaiBao);
                EnableButtons(thongKe);
            }
        }

        private async void btnFile_Click(object sender, EventArgs e)
        {
            if (grvBaiBao.SelectedRows.Count > 0)
            {
                string maBaiBao = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value?.ToString();
                string maNguoiDung = grvBaiBao.SelectedRows[0].Cells["MaNguoiDung"].Value?.ToString();
                string fileName = grvBaiBao.SelectedRows[0].Cells["FilePhanBien"].Value?.ToString();
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Không có file được đính kèm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DateTime ngayNhan = Convert.ToDateTime(grvBaiBao.SelectedRows[0].Cells["NgayNhan"].Value);

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.FileName = fileName;
                    saveFileDialog.Filter = "All Files (*.*)|*.*";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            string url = $"http://127.0.0.1:8000/api/download-result/{maBaiBao}/{maNguoiDung}/{ngayNhan:yyyy-MM-dd}";

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

        private void btntest_Click(object sender, EventArgs e)
        {
            Form_Main main = this.Owner as Form_Main;
            ChonPhanBien chonpb = new ChonPhanBien();
            chonpb.Show();
        }

        private void grvBaiBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value != null)
                {
                    txtMaBaiBao.Text = grvBaiBao.SelectedRows[0].Cells["MaBaiBao"].Value.ToString();
                    txtTenBaiBao.Text = grvBaiBao.SelectedRows[0].Cells["TenBaiBao"].Value.ToString();
                    txtFileBienSoan.Text = grvBaiBao.SelectedRows[0].Cells["FilePhanBien"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
           
        }
    }
}