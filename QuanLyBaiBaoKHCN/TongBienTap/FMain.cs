using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using QuanLyBaiBaoKHCN.BienTapVien;

namespace QuanLyBaiBaoKHCN.TongBienTap
{
    public partial class FMain : UIForm
    {
        string MaND, TenND;
        public FMain(string MaND, string TenND)
        {
            InitializeComponent();
            UIStyles.CultureInfo = CultureInfos.en_US;

            this.MaND = MaND;
            this.TenND = TenND;
            panelHoTen.Text = TenND;
        }

        DuyetBaiViet Frm_DuyetBaiViet = null;
        DuyetPhanBien Frm_DuyetPhanBien = null;
        TrangChu Frm_TrangChu = null;
        void DongForm()
        {
            if (Frm_DuyetBaiViet != null)
            {
                panelForm.Controls.Remove(Frm_DuyetBaiViet);
                Frm_DuyetBaiViet = null;
            }
            if (Frm_DuyetPhanBien != null)
            {
                panelForm.Controls.Remove(Frm_DuyetPhanBien);
                Frm_DuyetPhanBien = null;
            }
            if (Frm_TrangChu != null)
            {
                panelForm.Controls.Remove(Frm_TrangChu);
                Frm_TrangChu = null;
            }
        }
        private void btnDuyetBai_Form_Click(object sender, EventArgs e)
        {
            DongForm();
            if (Frm_DuyetBaiViet == null)
            {
                Frm_DuyetBaiViet = new DuyetBaiViet();
                Frm_DuyetBaiViet.TopLevel = false;
                panelForm.Controls.Add(Frm_DuyetBaiViet);
                Frm_DuyetBaiViet.Dock = DockStyle.Fill;
                Frm_DuyetBaiViet.Show();
            }
            else
            {
                Frm_DuyetBaiViet.Activate();
            }
        }

        private void btnDuyetPhanBien_Form_Click(object sender, EventArgs e)
        {
            DongForm();
            if (Frm_DuyetPhanBien == null)
            {
                Frm_DuyetPhanBien = new DuyetPhanBien();
                Frm_DuyetPhanBien.TopLevel = false;
                panelForm.Controls.Add(Frm_DuyetPhanBien);
                Frm_DuyetPhanBien.Dock = DockStyle.Fill;
                Frm_DuyetPhanBien.Show();
            }
            else
            {
                Frm_DuyetPhanBien.Activate();
            }
        }

        private void btnTrangChu_Form_Click(object sender, EventArgs e)
        {
            DongForm();
            if (Frm_TrangChu == null)
            {
                Frm_TrangChu = new TrangChu();
                Frm_TrangChu.TopLevel = false;
                panelForm.Controls.Add(Frm_TrangChu);
                Frm_TrangChu.Dock = DockStyle.Fill;
                Frm_TrangChu.Show();
            }
            else
            {
                Frm_TrangChu.Activate();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Visible = true;
        }
    }
}
