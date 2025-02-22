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
using QuanLyBaiBaoKHCN.data;

namespace QuanLyBaiBaoKHCN.BienTapVien
{
    public partial class Form_Main : UIForm
    {
        string MaND, TenND;
        public Form_Main() { }
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
        ThongKe Frm_ThongKe = null;
        Frm_PhanHoi Frm_PhanHoi = null;
        KetQuaPhanBien Frm_ketqua = null;
        CaiDat Frm_CaiDat = null;
        public void DongForm()
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
            if (Frm_ThongKe != null)
            {
                panelForm.Controls.Remove(Frm_ThongKe);
                Frm_ThongKe = null;
            }
            if (Frm_PhanHoi != null)
            {
                panelForm.Controls.Remove(Frm_PhanHoi);
                Frm_PhanHoi = null;
            }
            if(Frm_ketqua !=null)
            {
                panelForm.Controls.Remove(Frm_ketqua);
                Frm_ketqua= null;
            }
            if (Frm_CaiDat != null)
            {
                panelForm.Controls.Remove(Frm_CaiDat);
                Frm_CaiDat = null;
            }
        }
        public void MoForm_ChonPB()
        {
            panelForm.Controls.Remove(Frm_ketqua);
            ChonPhanBien chonpb = new ChonPhanBien();
            chonpb.TopLevel = false;
            chonpb.Dock = DockStyle.Fill;
            panelForm.Controls.Add(chonpb);
            panelForm.Tag = chonpb;
            chonpb.Show();

            Frm_ChonPhanBien = chonpb;
        }
        private void btnSoDuyet_Form_Click(object sender, EventArgs e)
        {
            DongForm();
            if (Frm_SoDuyet == null)
            {
                Frm_SoDuyet = new SoDuyet(MaND);
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

        private void btnThongKe_Form_Click(object sender, EventArgs e)
        {
            DongForm();
            if (Frm_ThongKe == null)
            {
                Frm_ThongKe = new ThongKe();
                Frm_ThongKe.TopLevel = false;
                panelForm.Controls.Add(Frm_ThongKe);
                Frm_ThongKe.Dock = DockStyle.Fill;
                Frm_ThongKe.Show();
            }
            else
            {
                Frm_ThongKe.Activate();
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
        private void btnXemPhanHoi_Form_Click(object sender, EventArgs e)
        {
            DongForm();
            if (Frm_PhanHoi == null)
            {
                Frm_PhanHoi = new Frm_PhanHoi(MaND);
                Frm_PhanHoi.TopLevel = false;
                panelForm.Controls.Add(Frm_PhanHoi);
                Frm_PhanHoi.Dock = DockStyle.Fill;
                Frm_PhanHoi.Show();
            }
            else
            {
                Frm_PhanHoi.Activate();
            }
        }
        private void btnCaiDat_Form_Click(object sender, EventArgs e)
        {
            DongForm();
            if (Frm_CaiDat == null)
            {
                Frm_CaiDat = new CaiDat(this, null);
                Frm_CaiDat.TopLevel = false;
                panelForm.Controls.Add(Frm_CaiDat);
                Frm_CaiDat.Dock = DockStyle.Fill;
                Frm_CaiDat.Show();
            }
            else
            {
                Frm_CaiDat.Activate();
            }
        }

        public void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Visible = true;
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            DongForm();

            Form main;
            main = panelForm.Controls.OfType<MiForm>().FirstOrDefault();
            if (main == null)
            {
                main = new MiForm { Owner = this };
                main.TopLevel = false;
                main.Dock = DockStyle.Fill;
                panelForm.Controls.Add(main);
                panelForm.Tag = main;
                main.Show();
                switch (main)
                {
                    case KetQuaPhanBien F_KQPB:
                        Frm_ketqua = F_KQPB;
                        break;
                }
            }
            else
            {
                main.Activate();
            }
        }

        private void btnKetqua_Click(object sender, EventArgs e)
        {
            AbrirFormulario<KetQuaPhanBien>();
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
