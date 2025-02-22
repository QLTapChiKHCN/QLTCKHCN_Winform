using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBaiBaoKHCN.BienTapVien;
using QuanLyBaiBaoKHCN.TongBienTap;
using QuanLyBaiBaoKHCN.data;
using System.Security.Cryptography;

namespace QuanLyBaiBaoKHCN
{
    public partial class Login : Form
    {
        QLTapChi_KHCNDataContext qltc = new QLTapChi_KHCNDataContext();
        public Login()
        {
            InitializeComponent();
        }

        public static string HashPassword(string password)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] bytes = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        int ViTriBanDau_lblEx2 = 0;
        int ViTriBanDau_btn = 0;
        int ViTriBanDau_pass = 0;
        private void Login_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            ViTriBanDau_lblEx2 = lblEx2.Top;
            ViTriBanDau_btn = btnDangNhap.Top;
            ViTriBanDau_pass = panelPass.Top;
        }
        void Dang_Nhap()
        {

            lblLoiPass.Visible = false;
            lblEx1.Visible = false;
            lblEx2.Visible = false;
            lblEx2.Top = ViTriBanDau_lblEx2;
            btnDangNhap.Top = ViTriBanDau_btn;
            panelPass.Top = ViTriBanDau_pass;

            if (txtUser.IsEmpty && txtPass.IsEmpty)
            {
                lblEx1.Visible = true;
                lblEx2.Visible = true;
                panelPass.Top += (lblEx1.Height - 8);
                lblEx2.Top += lblEx1.Height - 8;
                btnDangNhap.Top += (lblEx1.Height);
            }
            else if (txtUser.IsEmpty)
            {
                lblEx1.Visible = true;
                panelPass.Top += (lblEx1.Height - 8);
            }
            else if (txtPass.IsEmpty)
            {
                lblEx2.Visible = true;
                btnDangNhap.Top += (lblEx1.Height - 11);
            }
            else
            {
                try
                {
                    string tenDangNhap = txtUser.Text;
                    string matKhau = txtPass.Text;
                    string hashedPassword = HashPassword(matKhau);
                    var user = qltc.NguoiDungs.FirstOrDefault(t => t.TenDangNhap == tenDangNhap && t.MatKhau == hashedPassword);
                    var phanQuyen = qltc.NguoiDung_VaiTros.FirstOrDefault(t => t.MaNguoiDung == user.MaNguoiDung);

                    if (phanQuyen != null)
                    {
                        if (phanQuyen.MaVaiTro == "VT01")
                        {
                            Form_Main btv = new Form_Main(user.MaNguoiDung, user.HoTen);
                            btv.Show();

                            this.Hide();
                        }
                        else if (phanQuyen.MaVaiTro == "VT02")
                        {
                            FMain tbt = new FMain(user.MaNguoiDung, user.HoTen);
                            tbt.Show();
                            this.Hide();
                        }
                        else
                            MessageBox.Show("Bạn không có quyền truy cập hệ thống!");
                    }
                    else
                        MessageBox.Show("Bạn không có quyền truy cập hệ thống!");
                }
                catch (Exception ex)
                {
                    lblLoiPass.Visible = true;
                    txtPass.Clear();
                    txtUser.Clear();
                    txtUser.Focus();
                }
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Dang_Nhap();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Dang_Nhap();
        }

        private void btn_XemPass_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '\0';
            btn_XemPass.Visible = false;
            btn_DongPass.Visible = true;
        }

        private void btn_DongPass_Click(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            btn_XemPass.Visible = true;
            btn_DongPass.Visible = false;
        }
    }
}
