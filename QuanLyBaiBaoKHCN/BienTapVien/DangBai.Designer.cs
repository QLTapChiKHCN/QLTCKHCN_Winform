
namespace QuanLyBaiBaoKHCN.BienTapVien
{
    partial class DangBai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnXemFile = new Sunny.UI.UIButton();
            this.grvBaiBao = new Sunny.UI.UIDataGridView();
            this.MaBaiBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBaiBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboChuyenMuc = new Sunny.UI.UIComboBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.cboNgonNgu = new Sunny.UI.UIComboBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.dateDenNgay = new Sunny.UI.UIDatePicker();
            this.dateTuNgay = new Sunny.UI.UIDatePicker();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.cboMaSoTapChi = new Sunny.UI.UIComboBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.txtTenSoTapChi = new Sunny.UI.UITextBox();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiDatePicker1 = new Sunny.UI.UIDatePicker();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.AnhBia = new System.Windows.Forms.PictureBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.dateNgayDang = new Sunny.UI.UIDatePicker();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.btnDangBai = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaiBao)).BeginInit();
            this.uiTitlePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnhBia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXemFile
            // 
            this.btnXemFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnXemFile.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnXemFile.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.btnXemFile.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnXemFile.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnXemFile.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnXemFile.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.btnXemFile.Location = new System.Drawing.Point(921, 331);
            this.btnXemFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXemFile.Name = "btnXemFile";
            this.btnXemFile.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnXemFile.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.btnXemFile.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnXemFile.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnXemFile.ShowFocusLine = true;
            this.btnXemFile.Size = new System.Drawing.Size(194, 35);
            this.btnXemFile.Style = Sunny.UI.UIStyle.Custom;
            this.btnXemFile.StyleCustomMode = true;
            this.btnXemFile.TabIndex = 103;
            this.btnXemFile.Text = "Xem file bài báo";
            this.btnXemFile.TipsFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // grvBaiBao
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.grvBaiBao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grvBaiBao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvBaiBao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.grvBaiBao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvBaiBao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grvBaiBao.ColumnHeadersHeight = 32;
            this.grvBaiBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grvBaiBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBaiBao,
            this.TenBaiBao,
            this.TieuDe,
            this.NgayGui,
            this.TrangThai});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvBaiBao.DefaultCellStyle = dataGridViewCellStyle8;
            this.grvBaiBao.EnableHeadersVisualStyles = false;
            this.grvBaiBao.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grvBaiBao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.grvBaiBao.Location = new System.Drawing.Point(20, 136);
            this.grvBaiBao.Name = "grvBaiBao";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvBaiBao.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grvBaiBao.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.grvBaiBao.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grvBaiBao.RowTemplate.Height = 23;
            this.grvBaiBao.SelectedIndex = -1;
            this.grvBaiBao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvBaiBao.Size = new System.Drawing.Size(1095, 189);
            this.grvBaiBao.TabIndex = 102;
            // 
            // MaBaiBao
            // 
            this.MaBaiBao.DataPropertyName = "MaBaiBao";
            this.MaBaiBao.HeaderText = "Mã bài báo";
            this.MaBaiBao.MinimumWidth = 6;
            this.MaBaiBao.Name = "MaBaiBao";
            // 
            // TenBaiBao
            // 
            this.TenBaiBao.DataPropertyName = "TenBaiBao";
            this.TenBaiBao.HeaderText = "Tên bài báo";
            this.TenBaiBao.MinimumWidth = 6;
            this.TenBaiBao.Name = "TenBaiBao";
            // 
            // TieuDe
            // 
            this.TieuDe.DataPropertyName = "TieuDe";
            this.TieuDe.HeaderText = "Tiêu đề";
            this.TieuDe.MinimumWidth = 6;
            this.TieuDe.Name = "TieuDe";
            // 
            // NgayGui
            // 
            this.NgayGui.DataPropertyName = "NgayGui";
            this.NgayGui.HeaderText = "Ngày gửi";
            this.NgayGui.MinimumWidth = 6;
            this.NgayGui.Name = "NgayGui";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            // 
            // cboChuyenMuc
            // 
            this.cboChuyenMuc.DataSource = null;
            this.cboChuyenMuc.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboChuyenMuc.FillColor = System.Drawing.Color.White;
            this.cboChuyenMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboChuyenMuc.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboChuyenMuc.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboChuyenMuc.Location = new System.Drawing.Point(900, 84);
            this.cboChuyenMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboChuyenMuc.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboChuyenMuc.Name = "cboChuyenMuc";
            this.cboChuyenMuc.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboChuyenMuc.Size = new System.Drawing.Size(215, 33);
            this.cboChuyenMuc.SymbolSize = 24;
            this.cboChuyenMuc.TabIndex = 101;
            this.cboChuyenMuc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboChuyenMuc.Watermark = "";
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(895, 54);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(123, 25);
            this.uiLabel5.TabIndex = 100;
            this.uiLabel5.Text = "Chuyên mục";
            // 
            // cboNgonNgu
            // 
            this.cboNgonNgu.DataSource = null;
            this.cboNgonNgu.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboNgonNgu.FillColor = System.Drawing.Color.White;
            this.cboNgonNgu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboNgonNgu.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboNgonNgu.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboNgonNgu.Location = new System.Drawing.Point(550, 84);
            this.cboNgonNgu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNgonNgu.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboNgonNgu.Name = "cboNgonNgu";
            this.cboNgonNgu.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboNgonNgu.Size = new System.Drawing.Size(215, 33);
            this.cboNgonNgu.SymbolSize = 24;
            this.cboNgonNgu.TabIndex = 99;
            this.cboNgonNgu.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboNgonNgu.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(545, 54);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(97, 25);
            this.uiLabel4.TabIndex = 98;
            this.uiLabel4.Text = "Ngôn ngữ";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.FillColor = System.Drawing.Color.White;
            this.dateDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateDenNgay.Location = new System.Drawing.Point(282, 84);
            this.dateDenNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateDenNgay.MaxLength = 10;
            this.dateDenNgay.MinimumSize = new System.Drawing.Size(63, 0);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dateDenNgay.Size = new System.Drawing.Size(133, 34);
            this.dateDenNgay.SymbolDropDown = 61555;
            this.dateDenNgay.SymbolNormal = 61555;
            this.dateDenNgay.SymbolSize = 24;
            this.dateDenNgay.TabIndex = 97;
            this.dateDenNgay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateDenNgay.Value = new System.DateTime(2024, 10, 18, 21, 13, 6, 512);
            this.dateDenNgay.Watermark = "";
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.FillColor = System.Drawing.Color.White;
            this.dateTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTuNgay.Location = new System.Drawing.Point(20, 84);
            this.dateTuNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTuNgay.MaxLength = 10;
            this.dateTuNgay.MinimumSize = new System.Drawing.Size(63, 0);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dateTuNgay.Size = new System.Drawing.Size(127, 34);
            this.dateTuNgay.SymbolDropDown = 61555;
            this.dateTuNgay.SymbolNormal = 61555;
            this.dateTuNgay.SymbolSize = 24;
            this.dateTuNgay.TabIndex = 96;
            this.dateTuNgay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateTuNgay.Value = new System.DateTime(2024, 10, 18, 21, 13, 6, 512);
            this.dateTuNgay.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(277, 54);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(96, 25);
            this.uiLabel3.TabIndex = 95;
            this.uiLabel3.Text = "Đến ngày";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(15, 54);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(84, 25);
            this.uiLabel2.TabIndex = 94;
            this.uiLabel2.Text = "Từ ngày";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(481, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(232, 25);
            this.uiLabel1.TabIndex = 93;
            this.uiLabel1.Text = "DANH SÁCH BÀI BÁO";
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Controls.Add(this.btnDangBai);
            this.uiTitlePanel1.Controls.Add(this.dateNgayDang);
            this.uiTitlePanel1.Controls.Add(this.uiLabel10);
            this.uiTitlePanel1.Controls.Add(this.uiLabel9);
            this.uiTitlePanel1.Controls.Add(this.AnhBia);
            this.uiTitlePanel1.Controls.Add(this.uiDatePicker1);
            this.uiTitlePanel1.Controls.Add(this.uiLabel8);
            this.uiTitlePanel1.Controls.Add(this.uiComboBox1);
            this.uiTitlePanel1.Controls.Add(this.uiLabel7);
            this.uiTitlePanel1.Controls.Add(this.txtTenSoTapChi);
            this.uiTitlePanel1.Controls.Add(this.uiLabel12);
            this.uiTitlePanel1.Controls.Add(this.cboMaSoTapChi);
            this.uiTitlePanel1.Controls.Add(this.uiLabel6);
            this.uiTitlePanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiTitlePanel1.Location = new System.Drawing.Point(20, 374);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.uiTitlePanel1.ShowText = false;
            this.uiTitlePanel1.Size = new System.Drawing.Size(1095, 323);
            this.uiTitlePanel1.TabIndex = 104;
            this.uiTitlePanel1.Text = "Lên lịch đăng bài";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboMaSoTapChi
            // 
            this.cboMaSoTapChi.DataSource = null;
            this.cboMaSoTapChi.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboMaSoTapChi.FillColor = System.Drawing.Color.White;
            this.cboMaSoTapChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboMaSoTapChi.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboMaSoTapChi.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboMaSoTapChi.Location = new System.Drawing.Point(190, 44);
            this.cboMaSoTapChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaSoTapChi.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboMaSoTapChi.Name = "cboMaSoTapChi";
            this.cboMaSoTapChi.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboMaSoTapChi.Size = new System.Drawing.Size(215, 33);
            this.cboMaSoTapChi.SymbolSize = 24;
            this.cboMaSoTapChi.TabIndex = 106;
            this.cboMaSoTapChi.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboMaSoTapChi.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(3, 52);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(180, 25);
            this.uiLabel6.TabIndex = 105;
            this.uiLabel6.Text = "Chọn mã số tạp chí";
            // 
            // txtTenSoTapChi
            // 
            this.txtTenSoTapChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSoTapChi.Enabled = false;
            this.txtTenSoTapChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenSoTapChi.Location = new System.Drawing.Point(190, 87);
            this.txtTenSoTapChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenSoTapChi.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTenSoTapChi.Name = "txtTenSoTapChi";
            this.txtTenSoTapChi.Padding = new System.Windows.Forms.Padding(5);
            this.txtTenSoTapChi.ShowText = false;
            this.txtTenSoTapChi.Size = new System.Drawing.Size(215, 33);
            this.txtTenSoTapChi.TabIndex = 108;
            this.txtTenSoTapChi.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTenSoTapChi.Watermark = "";
            // 
            // uiLabel12
            // 
            this.uiLabel12.AutoSize = true;
            this.uiLabel12.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel12.Location = new System.Drawing.Point(3, 95);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(135, 25);
            this.uiLabel12.TabIndex = 107;
            this.uiLabel12.Text = "Tên số tạp chí";
            // 
            // uiLabel7
            // 
            this.uiLabel7.AutoSize = true;
            this.uiLabel7.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(564, 52);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(109, 25);
            this.uiLabel7.TabIndex = 109;
            this.uiLabel7.Text = "Mã bài báo";
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiComboBox1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiComboBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBox1.Location = new System.Drawing.Point(728, 44);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(215, 33);
            this.uiComboBox1.SymbolSize = 24;
            this.uiComboBox1.TabIndex = 107;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "";
            // 
            // uiDatePicker1
            // 
            this.uiDatePicker1.FillColor = System.Drawing.Color.White;
            this.uiDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiDatePicker1.Location = new System.Drawing.Point(190, 130);
            this.uiDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker1.MaxLength = 10;
            this.uiDatePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker1.Name = "uiDatePicker1";
            this.uiDatePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker1.Size = new System.Drawing.Size(215, 33);
            this.uiDatePicker1.SymbolDropDown = 61555;
            this.uiDatePicker1.SymbolNormal = 61555;
            this.uiDatePicker1.SymbolSize = 24;
            this.uiDatePicker1.TabIndex = 111;
            this.uiDatePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePicker1.Value = new System.DateTime(2024, 10, 18, 21, 13, 6, 512);
            this.uiDatePicker1.Watermark = "";
            // 
            // uiLabel8
            // 
            this.uiLabel8.AutoSize = true;
            this.uiLabel8.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(3, 138);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(138, 25);
            this.uiLabel8.TabIndex = 110;
            this.uiLabel8.Text = "Ngày xuất bản";
            // 
            // AnhBia
            // 
            this.AnhBia.BackColor = System.Drawing.Color.Silver;
            this.AnhBia.Location = new System.Drawing.Point(194, 171);
            this.AnhBia.Name = "AnhBia";
            this.AnhBia.Size = new System.Drawing.Size(211, 143);
            this.AnhBia.TabIndex = 120;
            this.AnhBia.TabStop = false;
            // 
            // uiLabel9
            // 
            this.uiLabel9.AutoSize = true;
            this.uiLabel9.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.Location = new System.Drawing.Point(3, 184);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(79, 25);
            this.uiLabel9.TabIndex = 121;
            this.uiLabel9.Text = "Ảnh bìa";
            // 
            // dateNgayDang
            // 
            this.dateNgayDang.FillColor = System.Drawing.Color.White;
            this.dateNgayDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateNgayDang.Location = new System.Drawing.Point(728, 86);
            this.dateNgayDang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateNgayDang.MaxLength = 10;
            this.dateNgayDang.MinimumSize = new System.Drawing.Size(63, 0);
            this.dateNgayDang.Name = "dateNgayDang";
            this.dateNgayDang.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dateNgayDang.Size = new System.Drawing.Size(215, 34);
            this.dateNgayDang.SymbolDropDown = 61555;
            this.dateNgayDang.SymbolNormal = 61555;
            this.dateNgayDang.SymbolSize = 24;
            this.dateNgayDang.TabIndex = 123;
            this.dateNgayDang.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateNgayDang.Value = new System.DateTime(2024, 10, 18, 21, 13, 6, 512);
            this.dateNgayDang.Watermark = "";
            // 
            // uiLabel10
            // 
            this.uiLabel10.AutoSize = true;
            this.uiLabel10.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel10.Location = new System.Drawing.Point(564, 95);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(157, 25);
            this.uiLabel10.TabIndex = 122;
            this.uiLabel10.Text = "Chọn ngày đăng";
            // 
            // btnDangBai
            // 
            this.btnDangBai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangBai.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnDangBai.Location = new System.Drawing.Point(728, 128);
            this.btnDangBai.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDangBai.Name = "btnDangBai";
            this.btnDangBai.Size = new System.Drawing.Size(215, 35);
            this.btnDangBai.Style = Sunny.UI.UIStyle.Custom;
            this.btnDangBai.StyleCustomMode = true;
            this.btnDangBai.TabIndex = 124;
            this.btnDangBai.Text = "Đăng bài";
            this.btnDangBai.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // DangBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1218, 769);
            this.Controls.Add(this.uiTitlePanel1);
            this.Controls.Add(this.btnXemFile);
            this.Controls.Add(this.grvBaiBao);
            this.Controls.Add(this.cboChuyenMuc);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.cboNgonNgu);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.dateDenNgay);
            this.Controls.Add(this.dateTuNgay);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangBai";
            this.Text = "DangBai";
            ((System.ComponentModel.ISupportInitialize)(this.grvBaiBao)).EndInit();
            this.uiTitlePanel1.ResumeLayout(false);
            this.uiTitlePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnhBia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton btnXemFile;
        private Sunny.UI.UIDataGridView grvBaiBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBaiBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBaiBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGui;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private Sunny.UI.UIComboBox cboChuyenMuc;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboBox cboNgonNgu;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIDatePicker dateDenNgay;
        private Sunny.UI.UIDatePicker dateTuNgay;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UIComboBox cboMaSoTapChi;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox txtTenSoTapChi;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIDatePicker uiDatePicker1;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel9;
        private System.Windows.Forms.PictureBox AnhBia;
        private Sunny.UI.UIDatePicker dateNgayDang;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UISymbolButton btnDangBai;
    }
}