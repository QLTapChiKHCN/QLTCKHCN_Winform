using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyBaiBaoKHCN.BienTapVien;
using QuanLyBaiBaoKHCN.TongBienTap;
using QuanLyBaiBaoKHCN.data;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Net.Http;
using System.IO;

namespace QuanLyBaiBaoKHCN
{
    public partial class CaiDat : Form
    {
        QLTapChi_KHCNDataContext qltc = new QLTapChi_KHCNDataContext();
        private Form_Main F_BTV = null;
        private FMain F_TBT = null;
        static string tenFile = "";
        public CaiDat(Form_Main mainForm, FMain fmain)
        {
            InitializeComponent();
            F_BTV = mainForm;
            F_TBT = fmain;
            string connectionString = Properties.Settings.Default.STRConn; // Lấy chuỗi kết nối từ file config
            string databaseName = GetDatabaseName(connectionString); // Lấy tên cơ sở dữ liệu từ chuỗi kết nối
            txtTenFile.Text = databaseName; // Gán tên cơ sở dữ liệu vào txtTenFile
            tenFile = databaseName;

            // Quản lí vai trò người 
            load_grvNguoiDung();
            load_comboVaiTro_BTV();

        }

        #region Sao Lưu

        private void btnDuongDan_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog_SaoLuu = new SaveFileDialog();
            saveFileDialog_SaoLuu.Filter = "Backup Files (*.bak)|*.bak"; // Chỉ cho phép chọn tệp .bak
            saveFileDialog_SaoLuu.Title = "Chọn vị trí và tên tệp sao lưu";
            saveFileDialog_SaoLuu.DefaultExt = "bak"; // Mặc định là tệp .bak

            // Lấy tên cơ sở dữ liệu từ txtTenFile
            string databaseName = txtTenFile.Text;

            // Gắn tên cơ sở dữ liệu vào tên tệp sao lưu mặc định
            saveFileDialog_SaoLuu.FileName = databaseName + ".bak"; // Tên file mặc định sẽ là tên cơ sở dữ liệu + ".bak"

            // Nếu người dùng chọn tệp sao lưu, gán đường dẫn và tên tệp vào TextBox
            if (saveFileDialog_SaoLuu.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan.Text = saveFileDialog_SaoLuu.FileName; // Đường dẫn đầy đủ của tệp sao lưu
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDuongDan.Text) || string.IsNullOrEmpty(txtTenFile.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin đường dẫn và tên file sao lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = Properties.Settings.Default.STRConn;
            string backupFile = txtDuongDan.Text;

            try
            {
                BackupDatabase(connectionString, backupFile, "FULL");
                MessageBox.Show("Sao lưu cơ sở dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sao lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void BackupDatabase(string connectionString, string backupFilePath, string backupType)
        {
            string databaseName = tenFile;

            string backupQuery = backupType == "FULL"
                ? $"BACKUP DATABASE [{databaseName}] TO DISK = '{backupFilePath}' WITH INIT"
                : backupType == "DIFFERENTIAL"
                    ? $"BACKUP DATABASE [{databaseName}] TO DISK = '{backupFilePath}' WITH DIFFERENTIAL, INIT"
                    : $"BACKUP LOG [{databaseName}] TO DISK = '{backupFilePath}' WITH INIT";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(backupQuery, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Không thể sao lưu cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

        public string GetDatabaseName(string connectionString)
        {
            string databaseName = string.Empty;
            var connStringBuilder = new SqlConnectionStringBuilder(connectionString);
            databaseName = connStringBuilder.InitialCatalog;
            return databaseName;
        }

        // Tự động sao lưu


        
        #endregion

        #region phục hồi
        private void btnDuongDan_PhucHoi_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog_PhucHoi = new OpenFileDialog();
            openFileDialog_PhucHoi.Filter = "Backup Files (*.bak)|*.bak"; // Chỉ cho phép chọn tệp .bak
            openFileDialog_PhucHoi.Title = "Chọn tệp sao lưu để phục hồi";

            // Nếu người dùng chọn tệp sao lưu, gán đường dẫn và tên tệp vào TextBox
            if (openFileDialog_PhucHoi.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan_PhucHoi.Text = openFileDialog_PhucHoi.FileName; // Đường dẫn đầy đủ của tệp sao lưu
            }
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDuongDan_PhucHoi.Text) || string.IsNullOrEmpty(txtTenFile.Text))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin đường dẫn và tên file phục hồi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = Properties.Settings.Default.STRConn;
            string backupFile = txtDuongDan_PhucHoi.Text;

            try
            {
                RestoreDatabase (connectionString, backupFile);
                MessageBox.Show("Phục hồi cơ sở dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (F_BTV != null)
                {
                    F_BTV.DongForm();
                    F_BTV.btnDangXuat_Click(sender, e);
                    F_BTV = null;
                }
                if (F_TBT != null)
                {
                    F_TBT.DongForm();
                    F_TBT.btnDangXuat_Click(sender, e);
                    F_TBT = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi phục hồi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RestoreDatabase(string connectionString, string backupFilePath)
        {
            string databaseName = txtTenFile.Text;

            // Kết nối tới cơ sở dữ liệu master để thực hiện lệnh RESTORE DATABASE
            string restoreQuery = $@"
                USE master;
                ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                RESTORE DATABASE [{databaseName}] FROM DISK = '{backupFilePath}' WITH REPLACE;
                ALTER DATABASE [{databaseName}] SET MULTI_USER;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(restoreQuery, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Không thể phục hồi cơ sở dữ liệu: " + ex.Message);
                }
            }
        }
        #endregion

        #region Quản lí vai trò tác giả, phản biện
        void load_comboVaiTro_BTV()
        {
            if (F_BTV != null)
            {
                var vt = from VT in qltc.VaiTros where VT.MaVaiTro != "VT01" && VT.MaVaiTro != "VT02" select VT;
                cboVaiTro_BTV.DataSource = vt;
                cboVaiTro_BTV.ValueMember = "MaVaiTro";
                cboVaiTro_BTV.DisplayMember = "TenVaiTro";
            }
            else
            {
                var vt = from VT in qltc.VaiTros where VT.MaVaiTro == "VT01" || VT.MaVaiTro == "VT02" select VT;
                cboVaiTro_BTV.DataSource = vt;
                cboVaiTro_BTV.ValueMember = "MaVaiTro";
                cboVaiTro_BTV.DisplayMember = "TenVaiTro";
            }
        }

        void load_grvNguoiDung()
        {
            if (F_BTV != null)
            {
                var nd = from ND in qltc.NguoiDungs
                         join NDVT in qltc.NguoiDung_VaiTros on ND.MaNguoiDung equals NDVT.MaNguoiDung
                         where NDVT.MaVaiTro != "VT01" && NDVT.MaVaiTro != "VT02"
                         group ND by new
                         {
                             ND.MaNguoiDung,
                             ND.HoTen,
                             ND.Email,
                             ND.CCCD,
                             ND.SoDienThoai,
                             ND.DiaChi,
                             ND.GioiTinh
                         } into grouped
                         select new
                         {
                             MaNguoiDung = grouped.Key.MaNguoiDung,
                             HoTen = grouped.Key.HoTen,
                             Email = grouped.Key.Email,
                             CCCD = grouped.Key.CCCD,
                             SoDienThoai = grouped.Key.SoDienThoai,
                             DiaChi = grouped.Key.DiaChi,
                             GioiTinh = grouped.Key.GioiTinh
                         };

                grvDanhSachPB.AutoGenerateColumns = false;
                grvDanhSachPB.DataSource = nd.ToList();
            }
            else
            {
                var nd = from ND in qltc.NguoiDungs
                         join NDVT in qltc.NguoiDung_VaiTros on ND.MaNguoiDung equals NDVT.MaNguoiDung
                         group ND by new
                         {
                             ND.MaNguoiDung,
                             ND.HoTen,
                             ND.Email,
                             ND.CCCD,
                             ND.SoDienThoai,
                             ND.DiaChi,
                             ND.GioiTinh
                         } into grouped
                         select new
                         {
                             MaNguoiDung = grouped.Key.MaNguoiDung,
                             HoTen = grouped.Key.HoTen,
                             Email = grouped.Key.Email,
                             CCCD = grouped.Key.CCCD,
                             SoDienThoai = grouped.Key.SoDienThoai,
                             DiaChi = grouped.Key.DiaChi,
                             GioiTinh = grouped.Key.GioiTinh
                         };

                grvDanhSachPB.AutoGenerateColumns = false;
                grvDanhSachPB.DataSource = nd.ToList();
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
                    btnThem_BTV.Enabled = true;

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
                    txtHoTen_BTV.Text = tennguoidung;

                    load_grvVaiTro();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void load_grvVaiTro()
        {
            var vaitros = from nd_vt in qltc.NguoiDung_VaiTros
                          join vt in qltc.VaiTros on nd_vt.MaVaiTro equals vt.MaVaiTro
                          where nd_vt.MaNguoiDung == manguoidung
                          select new
                          {
                              TenVaiTro = vt.TenVaiTro,
                              MaVaiTro = vt.MaVaiTro
                          };

            grvVaiTro.DataSource = vaitros.ToList();
        }

        string flag = "";
        List<NguoiDung_VaiTro> vaiTrosTam = new List<NguoiDung_VaiTro>();
        private void btnThem_BTV_Click(object sender, EventArgs e)
        {
            var exist = qltc.NguoiDung_VaiTros.FirstOrDefault(x => x.MaNguoiDung == manguoidung && x.MaVaiTro == cboVaiTro_BTV.SelectedValue.ToString());
            if (exist != null)
            {
                MessageBox.Show("Người dùng này đã có vai trò " + cboVaiTro_BTV.Text + " rồi!");
                return;
            }
            btnLuu_BTV.Enabled = true;
            btnThem_BTV.Enabled = false;
            btnXoa_BTV.Enabled = false;
            btnHuy_BTV.Enabled = true;
            flag = "them";
        }

        private void grvVaiTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grvVaiTro.SelectedRows[0].Cells["MaVaiTro"].Value != null)
                {
                    btnXoa_BTV.Enabled = true;
                    cboVaiTro_BTV.SelectedValue = grvVaiTro.SelectedRows[0].Cells["MaVaiTro"].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_BTV_Click(object sender, EventArgs e)
        {
            try
            {
                if (grvVaiTro.SelectedRows.Count > 0)
                {
                    string maVaiTro = grvVaiTro.SelectedRows[0].Cells["MaVaiTro"].Value.ToString();

                    if (maVaiTro == "VT03")
                    {
                        MessageBox.Show("Không thể xóa vai trò tác giả");
                    }
                    else
                    {
                        var roleToRemove = vaiTrosTam.FirstOrDefault(vt => vt.MaVaiTro == maVaiTro && vt.MaNguoiDung == manguoidung);
                        if (roleToRemove == null)
                        {
                            roleToRemove = new NguoiDung_VaiTro { MaVaiTro = maVaiTro, MaNguoiDung = manguoidung };
                            vaiTrosTam.Add(roleToRemove);
                        }
                        else
                        {
                            vaiTrosTam.Remove(roleToRemove);
                        }

                        flag = "xoa";
                        btnLuu_BTV.Enabled = true;
                        btnThem_BTV.Enabled = false;
                        btnXoa_BTV.Enabled = false;
                        btnHuy_BTV.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_BTV_Click(object sender, EventArgs e)
        {
            try
            {
                load_grvVaiTro();
                btnLuu_BTV.Enabled = false;
                btnThem_BTV.Enabled = true;
                btnXoa_BTV.Enabled = false;
                btnHuy_BTV.Enabled = false;
                flag = "";
                vaiTrosTam.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnLuu_BTV_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == "them")
                {
                    NguoiDung_VaiTro ndvt = new NguoiDung_VaiTro
                    {
                        MaNguoiDung = manguoidung,
                        MaVaiTro = cboVaiTro_BTV.SelectedValue.ToString()
                    };

                    btnLuu_BTV.Enabled = false;
                    btnThem_BTV.Enabled = true;
                    btnXoa_BTV.Enabled = false;
                    btnHuy_BTV.Enabled = false;

                    await sendEmail("Bạn đã được cập nhật thêm vai trò " + cboVaiTro_BTV.Text + ".");
                    qltc.NguoiDung_VaiTros.InsertOnSubmit(ndvt);
                }
                else if (flag == "xoa")
                {
                    foreach (var role in vaiTrosTam)
                    {
                        var exist = qltc.NguoiDung_VaiTros.FirstOrDefault(x => x.MaNguoiDung == role.MaNguoiDung && x.MaVaiTro == role.MaVaiTro);
                        if (exist != null)
                        {
                            qltc.NguoiDung_VaiTros.DeleteOnSubmit(exist);
                        }
                    }

                    btnLuu_BTV.Enabled = false;
                    btnThem_BTV.Enabled = true;
                    btnXoa_BTV.Enabled = false;
                    btnHuy_BTV.Enabled = false;

                    await sendEmail("Vai trò " + cboVaiTro_BTV.Text + " của bạn đã bị xóa.");
                }
                qltc.SubmitChanges();
                MessageBox.Show("Lưu thành công!");
                flag = "";
                load_grvVaiTro();
                vaiTrosTam.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task sendEmail(string messageBody)
        {
            var emails = (from nd in qltc.NguoiDungs
                          where nd.MaNguoiDung == manguoidung
                          select nd.Email).Distinct().ToList();

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
                Subject = $"Thông báo cập nhật vai trò",
                Body = $@"
            <html>
            <body>
                <h2>Thông báo cập nhật vai trò</h2>
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
                    await smtpClient.SendMailAsync(mailMessage);
                    MessageBox.Show("Đã gửi email thông báo thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi gửi email: " + ex.Message);
                }
            }
        }


        #endregion

    }
}
