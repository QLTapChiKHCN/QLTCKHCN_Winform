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

namespace QuanLyBaiBaoKHCN
{
    public partial class Login : Form
    {
        QLTapChi_KHCNDataContext qltc = new QLTapChi_KHCNDataContext();
        public Login()
        {
            InitializeComponent();
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

        bool flag = false;
        private void btnDangNhap_Click(object sender, EventArgs e)
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
                flag = true;
            }
            else if (txtUser.IsEmpty)
            {
                lblEx1.Visible = true;
                panelPass.Top += (lblEx1.Height - 8);
                flag = true;
            }
            else if (txtPass.IsEmpty)
            {
                lblEx2.Visible = true;
                btnDangNhap.Top += (lblEx1.Height - 11);
                flag = true;
            }
            else
            {
                try
                {
                    string tenDangNhap = txtUser.Text;
                    string matKhau = txtPass.Text;
                    var user = qltc.NguoiDungs.FirstOrDefault(t => t.TenDangNhap == tenDangNhap && t.MatKhau == matKhau);
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

    }
}
