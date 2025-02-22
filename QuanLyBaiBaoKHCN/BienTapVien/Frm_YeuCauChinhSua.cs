using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBaiBaoKHCN.data;

namespace QuanLyBaiBaoKHCN.BienTapVien
{
    public partial class Frm_YeuCauChinhSua : Form
    {
        private QLTapChi_KHCNDataContext qlTCKHCN;
        private string maBaiBao;
        private string maNguoiDung;
        private string selectedFilePath;

        public string NoiDung { get; private set; }
        public string FilePath { get; private set; }
        public Frm_YeuCauChinhSua(string maBaiBao, string maNguoiDung)
        {
            InitializeComponent();
            this.maBaiBao = maBaiBao;
            this.maNguoiDung = maNguoiDung;
            qlTCKHCN = new QLTapChi_KHCNDataContext();
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNoiDung.Text))
                {
                    MessageBox.Show("Vui lòng nhập nội dung chỉnh sửa!");
                    return;
                }
                LichSuSoDuyetBaiViet lichSu = new LichSuSoDuyetBaiViet
                {
                    MaBaiBao = this.maBaiBao,
                    MaNguoiDung = this.maNguoiDung,
                    NgayGuiYeuCau = DateTime.Now,
                    NoiDungChinhSua = txtNoiDung.Text
                };

                qlTCKHCN.LichSuSoDuyetBaiViets.InsertOnSubmit(lichSu);
                qlTCKHCN.SubmitChanges();

                // Lưu thông tin để form chính có thể truy cập
                this.NoiDung = txtNoiDung.Text;
                this.FilePath = selectedFilePath;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        private void btnGuifile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = openFileDialog.FileName;
                    lbfile.Text = Path.GetFileName(selectedFilePath);
                }
            }
        }

        
    }
}
