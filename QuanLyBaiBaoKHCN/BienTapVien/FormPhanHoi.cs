using QuanLyBaiBaoKHCN.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaiBaoKHCN.BienTapVien
{
    public partial class FormPhanHoi : Form
    {
        QLTapChi_KHCNDataContext qltckh;
        private string maBaiBao;
        private string maNguoiDung;
        public FormPhanHoi(string mabaibao,string maNguoiDung)
        {
            InitializeComponent();
            qltckh = new QLTapChi_KHCNDataContext();
            this.maBaiBao= mabaibao;
            this.maNguoiDung= maNguoiDung;
        }
        public string NoiDung { get; private set; }
        private void btnGui_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNoiDung.Text))
                {
                    MessageBox.Show("Vui lòng nhập nội dung chỉnh sửa!");
                    return;
                }

                PhanHoi ph = new PhanHoi
                {
                    MaBaiBao = this.maBaiBao,
                    MaNguoiDung= this.maNguoiDung,
                    NoiDung=txtNoiDung.Text,
                    NgayGui=DateTime.Now
                };
                qltckh.PhanHois.InsertOnSubmit(ph);
                qltckh.SubmitChanges();

                NoiDung = txtNoiDung.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
    }
}
