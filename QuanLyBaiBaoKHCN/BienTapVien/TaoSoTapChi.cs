using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using QuanLyBaiBaoKHCN.data;

namespace QuanLyBaiBaoKHCN.BienTapVien
{
    public partial class TaoSoTapChi : Form
    {
        QLTapChi_KHCNDataContext qltckhcn = new QLTapChi_KHCNDataContext();
        public TaoSoTapChi()
        {
            InitializeComponent();
            load_grv();
            dateNXB.Value = DateTime.Today;
            grvTapChi.CellFormatting += grvTapChi_CellFormatting;
        }
        #region method
        private void grvTapChi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grvTapChi.Columns[e.ColumnIndex].Name == "TrangThai")
            {
                var row = grvTapChi.Rows[e.RowIndex];
                var soTapChi = row.DataBoundItem as SoTapChi;

                if (soTapChi != null && soTapChi.MaSoTC != null)
                {
                    bool? trangThai = soTapChi.TrangThai;
                    if (trangThai.HasValue)
                    {
                        e.Value = trangThai.Value ? "Hoạt động" : "Đã xóa";
                        e.FormattingApplied = true;
                    }
                    else
                    {
                        e.Value = "Không xác định";
                        e.FormattingApplied = true;
                    }
                }
            }
        }
        BindingList<SoTapChi> tapChiList = new BindingList<SoTapChi>();
        void load_grv()
        {
            grvTapChi.Rows.Clear();
            var tc = from tapchi in qltckhcn.SoTapChis select tapchi;
            tapChiList = new BindingList<SoTapChi>(tc.ToList());
            grvTapChi.DataSource = tapChiList;
            grvTapChi.Refresh();
        }

        public string GenerateMaSoTapChi()
        {

            var lastCode = qltckhcn.SoTapChis
                .Where(dm => dm.MaSoTC.StartsWith("STC"))
                .OrderByDescending(dm => dm.MaSoTC)
                .Select(dm => dm.MaSoTC)
                .FirstOrDefault();

            int newNumber = 1;

            if (lastCode != null)
            {

                var lastNumber = int.Parse(lastCode.Substring(3));
                newNumber = lastNumber + 1;
            }
            return $"STC{newNumber:D2}";
        }
        private async Task<string> UploadImageToAPI(string imagePath)
        {
            try
            {
                using (var httpClient = new HttpClient())
                using (var formData = new MultipartFormDataContent())
                using (var fileStream = File.OpenRead(imagePath))
                {
                    var fileContent = new StreamContent(fileStream);
                    formData.Add(fileContent, "image", Path.GetFileName(imagePath));
                    var response = await httpClient.PostAsync("http://127.0.0.1:8000/api/upload-image", formData);
                    var result = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {

                        dynamic jsonResponse = JsonConvert.DeserializeObject(result);
                        return jsonResponse.data.path.ToString();
                    }
                    else
                    {
                        throw new Exception($"Upload failed: {result}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi upload hình: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void ClearPictureBox(PictureBox pb)
        {
            if (pb.Image != null)
            {
                pb.Image.Dispose();
                pb.Image = null;
            }

            if (pb.BackgroundImage != null)
            {
                pb.BackgroundImage.Dispose();
                pb.BackgroundImage = null;
            }
        }
        private async Task UpdateProgress(int startValue, int endValue)
        {
            for (int i = startValue; i <= endValue; i++)
            {
                progressBar1.Value = i;
                await Task.Delay(20);
            }
        }
        #endregion
        private string imageLocation = "";
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Title = "Chọn hình ảnh";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageLocation = openFileDialog.FileName;
                    // Load hình ảnh vào PictureBox
                    pic_AnhBia.Image = Image.FromFile(openFileDialog.FileName);
                    pic_AnhBia.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi load hình: " + ex.Message, "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSoTapChi.Clear();
            txtTenSoTapChi.Clear();
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            qltckhcn.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, qltckhcn.SoTapChis);
            load_grv();
            ClearPictureBox(pic_AnhBia);
            if (btnTao.Enabled == false)
            {
                btnTao.Enabled = true;
                btnLuu.Enabled = false;
            }
            flag = "";
        }

        string flag = "";
        private void btnTao_Click(object sender, EventArgs e)
        {
            txtMaSoTapChi.Text = GenerateMaSoTapChi();
            flag = "tao";
            btnTao.Enabled = false;
            btnLuu.Enabled = true;
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                btnLuu.Enabled = false;
                progressBar1.Visible = true;
                progressBar1.Value = 0;

                if (txtTenSoTapChi.Text.Length > 0)
                {
                    string fileName = null;
                    string localImagePath = null;

                    if (!string.IsNullOrEmpty(imageLocation))
                    {
                        await UpdateProgress(0, 20);

                        // Tạo thư mục lưu ảnh nếu chưa tồn tại
                        string imageFolder = Path.Combine(Application.StartupPath, "Images");
                        if (!Directory.Exists(imageFolder))
                        {
                            Directory.CreateDirectory(imageFolder);
                        }

                        // Tạo tên file mới và copy ảnh vào thư mục
                        string extension = Path.GetExtension(imageLocation);
                        string newFileName = $"SoTapChi_{DateTime.Now:yyyyMMdd_HHmmss}{extension}";
                        localImagePath = Path.Combine(imageFolder, newFileName);

                        // Copy file vào thư mục local
                        File.Copy(imageLocation, localImagePath, true);

                        // Upload hình lên Laravel API và nhận về đường dẫn
                        string imagePath = await UploadImageToAPI(imageLocation);
                        if (!string.IsNullOrEmpty(imagePath))
                        {
                            fileName = imagePath;
                        }
                    }

                    await UpdateProgress(20, 40);

                    // Kiểm tra flag để xác định hành động
                    if (flag == "tao")
                    {
                        // Thực hiện tạo mới
                        var exist = qltckhcn.SoTapChis.FirstOrDefault(x => x.MaSoTC == txtMaSoTapChi.Text);
                        if (exist != null)
                        {
                            MessageBox.Show("Mã đã tồn tại");
                            return;
                        }

                        await UpdateProgress(40, 60);

                        SoTapChi st = new SoTapChi
                        {
                            MaSoTC = txtMaSoTapChi.Text,
                            TenSo = txtTenSoTapChi.Text.Trim(),
                            NgayXuatBan = dateNXB.Value,
                            AnhBia = fileName,
                            AnhBiaLocal = localImagePath,
                            TrangThai = true
                        };

                        await UpdateProgress(60, 80);
                        qltckhcn.SoTapChis.InsertOnSubmit(st);
                        qltckhcn.SubmitChanges();

                        await UpdateProgress(80, 100);
                        MessageBox.Show("Thêm số tạp chí thành công");

                        flag = "";
                    }
                    else if (flag == "sua")
                    {
                        // Thực hiện sửa thông tin
                        if (grvTapChi.SelectedRows.Count > 0)
                        {
                            DataGridViewRow row = grvTapChi.SelectedRows[0];
                            int index = row.Index;

                            tapChiList[index].MaSoTC = txtMaSoTapChi.Text;
                            tapChiList[index].TenSo = txtTenSoTapChi.Text;
                            tapChiList[index].NgayXuatBan = dateNXB.Value;
                            tapChiList[index].AnhBiaLocal = imageLocation;

                            await UpdateProgress(40, 60);

                            var updated = qltckhcn.SoTapChis.FirstOrDefault(x => x.MaSoTC == txtMaSoTapChi.Text);
                            if (updated != null)
                            {
                                updated.TenSo = txtTenSoTapChi.Text.Trim();
                                updated.NgayXuatBan = dateNXB.Value;
                                updated.AnhBia = fileName;
                                updated.AnhBiaLocal = localImagePath;
                            }

                            qltckhcn.SubmitChanges();

                            await UpdateProgress(80, 100);
                            MessageBox.Show("Cập nhật số tạp chí thành công");

                            flag = "";
                        }
                    }
                    else if (flag == "xoa")
                    {
                        // Thực hiện xóa (ẩn)
                        if (grvTapChi.SelectedRows.Count > 0)
                        {
                            DataGridViewRow row = grvTapChi.SelectedRows[0];
                            string maSoTC = row.Cells["MaSoTC"].Value.ToString();

                            var record = qltckhcn.SoTapChis.FirstOrDefault(x => x.MaSoTC == maSoTC);
                            if (record != null)
                            {
                                record.TrangThai = false;
                                qltckhcn.SubmitChanges();
                            }

                            MessageBox.Show("Đã ẩn số tạp chí");

                            flag = "";
                        }
                    }

                    // Reset form
                    btnTao.Enabled = true;
                    btnLuu.Enabled = false;
                    btnChonAnh.Enabled = true;
                    txtMaSoTapChi.Clear();
                    txtTenSoTapChi.Clear();
                    ClearPictureBox(pic_AnhBia);
                    load_grv();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
            finally
            {
                progressBar1.Value = 0;
                progressBar1.Visible = false;
                btnLuu.Enabled = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (grvTapChi.SelectedRows.Count > 0)
            {
                flag = "sua";
                DataGridViewRow row = grvTapChi.SelectedRows[0];
                int index = row.Index;

                if (!string.IsNullOrEmpty(imageLocation) && !string.IsNullOrEmpty(txtTenSoTapChi.Text))
                {
                    tapChiList[index].MaSoTC = txtMaSoTapChi.Text;
                    tapChiList[index].TenSo = txtTenSoTapChi.Text;
                    tapChiList[index].NgayXuatBan = dateNXB.Value;
                    tapChiList[index].AnhBiaLocal = imageLocation;
                }

                grvTapChi.Refresh();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnTao.Enabled = false;
                btnLuu.Enabled = true;
            }
            else
                MessageBox.Show("Vui lòng chọn dòng cần sửa");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (grvTapChi.SelectedRows[0].Cells["MaSoTC"].Value != null)
            {
                flag = "xoa";
                grvTapChi.SelectedRows[0].Cells["TrangThai"].Value = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnTao.Enabled = false;
                btnLuu.Enabled = true;
            }
        }

        private void grvTapChi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grvTapChi.SelectedRows[0].Cells["MaSoTC"].Value != null)
                {
                    txtMaSoTapChi.Text = grvTapChi.SelectedRows[0].Cells["MaSoTC"].Value.ToString();
                    txtTenSoTapChi.Text = grvTapChi.SelectedRows[0].Cells["TenSo"].Value.ToString();
                    imageLocation = grvTapChi.SelectedRows[0].Cells["AnhBiaLocal"].Value.ToString();
                    pic_AnhBia.ImageLocation = imageLocation;
                    pic_AnhBia.SizeMode = PictureBoxSizeMode.Zoom;
                    dateNXB.Value = Convert.ToDateTime(grvTapChi.SelectedRows[0].Cells["NgayXuatBan"].Value.ToString());
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}