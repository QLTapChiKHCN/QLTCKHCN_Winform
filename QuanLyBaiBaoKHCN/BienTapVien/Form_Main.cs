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

namespace QuanLyBaiBaoKHCN.BienTapVien
{
    public partial class Form_Main : UIForm
    {
        string MaND, TenND;
        public Form_Main(string MaND, string TenND)
        {
            InitializeComponent();
            UIStyles.CultureInfo = CultureInfos.en_US;

            this.MaND = MaND;
            this.TenND = TenND;
            panelHoTen.Text = TenND;
        }

        SoDuyet Frm_SoDuyet = null;
        ChonPhanBien Frm_ChonPhanBien = null;
        TaoSoTapChi Frm_TaoSoTapChi = null;
        DangBai Frm_DangBai = null;
        TrangChu Frm_TrangChu = null;

        void DongForm()
        {
            if (Frm_SoDuyet != null)
            {
                panelForm.Controls.Remove(Frm_SoDuyet);
                Frm_SoDuyet = null;
            }
            if (Frm_TaoSoTapChi != null)
            {
                panelForm.Controls.Remove(Frm_TaoSoTapChi);
                Frm_TaoSoTapChi = null;
            }
            if (Frm_ChonPhanBien != null)
            {
                panelForm.Controls.Remove(Frm_ChonPhanBien);
                Frm_ChonPhanBien = null;
            }
            if (Frm_DangBai != null)
            {
                panelForm.Controls.Remove(Frm_DangBai);
                Frm_DangBai = null;
            }
            if (Frm_TrangChu != null)
            {
                panelForm.Controls.Remove(Frm_TrangChu);
                Frm_TrangChu = null;
            }
        }

        private void btnSoDuyet_Form_Click(object sender, EventArgs e)
        {
            DongForm();
            if (Frm_SoDuyet == null)
            {
                Frm_SoDuyet = new SoDuyet();
                Frm_SoDuyet.TopLevel = false;
                panelForm.Controls.Add(Frm_SoDuyet);
                Frm_SoDuyet.Dock = DockStyle.Fill;
                Frm_SoDuyet.Show();
            }
            else
            {
                Frm_SoDuyet.Activate();
            }
        }

        private void btnChonPhanBien_Form_Click(object sender, EventArgs e)
        {
            DongForm();
            if (Frm_ChonPhanBien == null)
            {
                Frm_ChonPhanBien = new ChonPhanBien();
                Frm_ChonPhanBien.TopLevel = false;
                panelForm.Controls.Add(Frm_ChonPhanBien);
                Frm_ChonPhanBien.Dock = DockStyle.Fill;
                Frm_ChonPhanBien.Show();
            }
            else
            {
                Frm_ChonPhanBien.Activate();
            }
        }

        private void btnTaoSoTapChi_Form_Click(object sender, EventArgs e)
        {
            DongForm();
            if (Frm_TaoSoTapChi == null)
            {
                Frm_TaoSoTapChi = new TaoSoTapChi();
                Frm_TaoSoTapChi.TopLevel = false;
                panelForm.Controls.Add(Frm_TaoSoTapChi);
                Frm_TaoSoTapChi.Dock = DockStyle.Fill;
                Frm_TaoSoTapChi.Show();
            }
            else
            {
                Frm_TaoSoTapChi.Activate();
            }
        }

        private void btnDangBai_Form_Click(object sender, EventArgs e)
        {
            DongForm();
            if (Frm_DangBai == null)
            {
                Frm_DangBai = new DangBai();
                Frm_DangBai.TopLevel = false;
                panelForm.Controls.Add(Frm_DangBai);
                Frm_DangBai.Dock = DockStyle.Fill;
                Frm_DangBai.Show();
            }
            else
            {
                Frm_DangBai.Activate();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Visible = true;
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
    }
}
