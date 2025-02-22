namespace QuanLyBaiBaoKHCN.BienTapVien
{
    partial class KetQuaPhanBien
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
            this.grvBaiBao = new Sunny.UI.UIDataGridView();
            this.MaBaiBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBaiBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTraKetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePhanBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFileBienSoan = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.btnFile = new Sunny.UI.UIButton();
            this.dateNgayGui = new Sunny.UI.UIDatePicker();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txtTenBaiBao = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txtMaBaiBao = new Sunny.UI.UITextBox();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.btnChinhSua = new Sunny.UI.UIButton();
            this.btnKhongDuyet = new Sunny.UI.UISymbolButton();
            this.btnDuyet = new Sunny.UI.UISymbolButton();
            this.btnChonPhanBien = new Sunny.UI.UISymbolButton();
            this.progressBar1 = new Sunny.UI.UIProcessBar();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaiBao)).BeginInit();
            this.SuspendLayout();
            // 
            // grvBaiBao
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvBaiBao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grvBaiBao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grvBaiBao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.grvBaiBao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvBaiBao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvBaiBao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grvBaiBao.ColumnHeadersHeight = 32;
            this.grvBaiBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grvBaiBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBaiBao,
            this.TenBaiBao,
            this.MaNguoiDung,
            this.KetQua,
            this.NgayNhan,
            this.NgayTraKetQua,
            this.FilePhanBien});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(216)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvBaiBao.DefaultCellStyle = dataGridViewCellStyle8;
            this.grvBaiBao.EnableHeadersVisualStyles = false;
            this.grvBaiBao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvBaiBao.GridColor = System.Drawing.Color.Black;
            this.grvBaiBao.Location = new System.Drawing.Point(28, 170);
            this.grvBaiBao.Name = "grvBaiBao";
            this.grvBaiBao.RectColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(193)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvBaiBao.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grvBaiBao.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.grvBaiBao.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.grvBaiBao.RowTemplate.Height = 23;
            this.grvBaiBao.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grvBaiBao.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grvBaiBao.ScrollBarStyleInherited = false;
            this.grvBaiBao.SelectedIndex = -1;
            this.grvBaiBao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvBaiBao.Size = new System.Drawing.Size(1233, 480);
            this.grvBaiBao.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.grvBaiBao.Style = Sunny.UI.UIStyle.Custom;
            this.grvBaiBao.TabIndex = 119;
            this.grvBaiBao.TagString = "";
            this.grvBaiBao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvBaiBao_CellClick);
            this.grvBaiBao.SelectionChanged += new System.EventHandler(this.grvBaiBao_SelectionChanged);
            // 
            // MaBaiBao
            // 
            this.MaBaiBao.DataPropertyName = "MaBaiBao";
            this.MaBaiBao.HeaderText = "Mã bài viết";
            this.MaBaiBao.MinimumWidth = 6;
            this.MaBaiBao.Name = "MaBaiBao";
            this.MaBaiBao.Width = 133;
            // 
            // TenBaiBao
            // 
            this.TenBaiBao.DataPropertyName = "TenBaiBao";
            this.TenBaiBao.HeaderText = "Tên bài viết";
            this.TenBaiBao.MinimumWidth = 6;
            this.TenBaiBao.Name = "TenBaiBao";
            this.TenBaiBao.Width = 137;
            // 
            // MaNguoiDung
            // 
            this.MaNguoiDung.DataPropertyName = "MaNguoiDung";
            this.MaNguoiDung.HeaderText = "Mã người dùng";
            this.MaNguoiDung.MinimumWidth = 6;
            this.MaNguoiDung.Name = "MaNguoiDung";
            this.MaNguoiDung.Width = 165;
            // 
            // KetQua
            // 
            this.KetQua.DataPropertyName = "KetQuaPhanBien";
            this.KetQua.HeaderText = "Kết Quả Phản Biện";
            this.KetQua.MinimumWidth = 6;
            this.KetQua.Name = "KetQua";
            this.KetQua.Width = 200;
            // 
            // NgayNhan
            // 
            this.NgayNhan.DataPropertyName = "NgayNhan";
            this.NgayNhan.HeaderText = "Ngày Nhận";
            this.NgayNhan.MinimumWidth = 6;
            this.NgayNhan.Name = "NgayNhan";
            this.NgayNhan.Width = 131;
            // 
            // NgayTraKetQua
            // 
            this.NgayTraKetQua.DataPropertyName = "NgayTraKetQua";
            this.NgayTraKetQua.HeaderText = "Ngày Trả Kết Quả";
            this.NgayTraKetQua.MinimumWidth = 6;
            this.NgayTraKetQua.Name = "NgayTraKetQua";
            this.NgayTraKetQua.Width = 194;
            // 
            // FilePhanBien
            // 
            this.FilePhanBien.DataPropertyName = "FilePhanBien";
            this.FilePhanBien.HeaderText = "File Phản Biện";
            this.FilePhanBien.MinimumWidth = 6;
            this.FilePhanBien.Name = "FilePhanBien";
            this.FilePhanBien.Width = 159;
            // 
            // txtFileBienSoan
            // 
            this.txtFileBienSoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFileBienSoan.Enabled = false;
            this.txtFileBienSoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFileBienSoan.Location = new System.Drawing.Point(553, 77);
            this.txtFileBienSoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFileBienSoan.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtFileBienSoan.Name = "txtFileBienSoan";
            this.txtFileBienSoan.Padding = new System.Windows.Forms.Padding(5);
            this.txtFileBienSoan.ShowText = false;
            this.txtFileBienSoan.Size = new System.Drawing.Size(231, 29);
            this.txtFileBienSoan.TabIndex = 130;
            this.txtFileBienSoan.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtFileBienSoan.Watermark = "";
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(512, 81);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(43, 25);
            this.uiLabel5.TabIndex = 128;
            this.uiLabel5.Text = "File";
            // 
            // btnFile
            // 
            this.btnFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFile.Location = new System.Drawing.Point(684, 114);
            this.btnFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(100, 35);
            this.btnFile.TabIndex = 132;
            this.btnFile.Text = "Xem file";
            this.btnFile.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // dateNgayGui
            // 
            this.dateNgayGui.Enabled = false;
            this.dateNgayGui.FillColor = System.Drawing.Color.White;
            this.dateNgayGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateNgayGui.Location = new System.Drawing.Point(608, 28);
            this.dateNgayGui.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateNgayGui.MaxLength = 10;
            this.dateNgayGui.MinimumSize = new System.Drawing.Size(63, 0);
            this.dateNgayGui.Name = "dateNgayGui";
            this.dateNgayGui.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dateNgayGui.Size = new System.Drawing.Size(144, 29);
            this.dateNgayGui.SymbolDropDown = 61555;
            this.dateNgayGui.SymbolNormal = 61555;
            this.dateNgayGui.SymbolSize = 24;
            this.dateNgayGui.TabIndex = 131;
            this.dateNgayGui.Text = "2024-10-18";
            this.dateNgayGui.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateNgayGui.Value = new System.DateTime(2024, 10, 18, 21, 13, 6, 512);
            this.dateNgayGui.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(512, 32);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(89, 25);
            this.uiLabel4.TabIndex = 129;
            this.uiLabel4.Text = "Ngày gửi";
            // 
            // txtTenBaiBao
            // 
            this.txtTenBaiBao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenBaiBao.Enabled = false;
            this.txtTenBaiBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenBaiBao.Location = new System.Drawing.Point(165, 78);
            this.txtTenBaiBao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenBaiBao.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTenBaiBao.Name = "txtTenBaiBao";
            this.txtTenBaiBao.Padding = new System.Windows.Forms.Padding(5);
            this.txtTenBaiBao.ShowText = false;
            this.txtTenBaiBao.Size = new System.Drawing.Size(176, 29);
            this.txtTenBaiBao.TabIndex = 125;
            this.txtTenBaiBao.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTenBaiBao.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(23, 82);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(113, 25);
            this.uiLabel3.TabIndex = 124;
            this.uiLabel3.Text = "Tên bài viết";
            // 
            // txtMaBaiBao
            // 
            this.txtMaBaiBao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaBaiBao.Enabled = false;
            this.txtMaBaiBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaBaiBao.Location = new System.Drawing.Point(164, 28);
            this.txtMaBaiBao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaBaiBao.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMaBaiBao.Name = "txtMaBaiBao";
            this.txtMaBaiBao.Padding = new System.Windows.Forms.Padding(5);
            this.txtMaBaiBao.ShowText = false;
            this.txtMaBaiBao.Size = new System.Drawing.Size(176, 29);
            this.txtMaBaiBao.TabIndex = 121;
            this.txtMaBaiBao.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaBaiBao.Watermark = "";
            // 
            // uiLabel12
            // 
            this.uiLabel12.AutoSize = true;
            this.uiLabel12.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel12.Location = new System.Drawing.Point(32, 32);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(106, 25);
            this.uiLabel12.TabIndex = 120;
            this.uiLabel12.Text = "Mã bài viết";
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChinhSua.Enabled = false;
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnChinhSua.Location = new System.Drawing.Point(891, 60);
            this.btnChinhSua.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(159, 35);
            this.btnChinhSua.TabIndex = 175;
            this.btnChinhSua.Text = "Cần Chỉnh Sửa";
            this.btnChinhSua.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnKhongDuyet
            // 
            this.btnKhongDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhongDuyet.Enabled = false;
            this.btnKhongDuyet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnKhongDuyet.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnKhongDuyet.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnKhongDuyet.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKhongDuyet.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKhongDuyet.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnKhongDuyet.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnKhongDuyet.Location = new System.Drawing.Point(891, 101);
            this.btnKhongDuyet.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnKhongDuyet.Name = "btnKhongDuyet";
            this.btnKhongDuyet.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnKhongDuyet.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnKhongDuyet.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKhongDuyet.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnKhongDuyet.Size = new System.Drawing.Size(159, 35);
            this.btnKhongDuyet.Style = Sunny.UI.UIStyle.Custom;
            this.btnKhongDuyet.StyleCustomMode = true;
            this.btnKhongDuyet.Symbol = 61453;
            this.btnKhongDuyet.TabIndex = 174;
            this.btnKhongDuyet.Text = "Từ Chối";
            this.btnKhongDuyet.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnKhongDuyet.Click += new System.EventHandler(this.btnKhongDuyet_Click);
            // 
            // btnDuyet
            // 
            this.btnDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuyet.Enabled = false;
            this.btnDuyet.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnDuyet.Location = new System.Drawing.Point(891, 12);
            this.btnDuyet.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(159, 35);
            this.btnDuyet.Style = Sunny.UI.UIStyle.Custom;
            this.btnDuyet.StyleCustomMode = true;
            this.btnDuyet.TabIndex = 173;
            this.btnDuyet.Text = "Chấp nhận";
            this.btnDuyet.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
            // 
            // btnChonPhanBien
            // 
            this.btnChonPhanBien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonPhanBien.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnChonPhanBien.Location = new System.Drawing.Point(61, 666);
            this.btnChonPhanBien.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChonPhanBien.Name = "btnChonPhanBien";
            this.btnChonPhanBien.Size = new System.Drawing.Size(220, 35);
            this.btnChonPhanBien.Style = Sunny.UI.UIStyle.Custom;
            this.btnChonPhanBien.StyleCustomMode = true;
            this.btnChonPhanBien.TabIndex = 173;
            this.btnChonPhanBien.Text = "Chọn phản biện";
            this.btnChonPhanBien.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChonPhanBien.Click += new System.EventHandler(this.btnChonPhanBien_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.progressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressBar1.Location = new System.Drawing.Point(452, 328);
            this.progressBar1.MinimumSize = new System.Drawing.Size(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 29);
            this.progressBar1.TabIndex = 176;
            this.progressBar1.Text = "uiProcessBar1";
            this.progressBar1.Visible = false;
            // 
            // KetQuaPhanBien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1273, 744);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnKhongDuyet);
            this.Controls.Add(this.btnChonPhanBien);
            this.Controls.Add(this.btnDuyet);
            this.Controls.Add(this.txtFileBienSoan);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.dateNgayGui);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.txtTenBaiBao);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.txtMaBaiBao);
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.grvBaiBao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KetQuaPhanBien";
            this.Text = "KetQuaPhanBien";
            ((System.ComponentModel.ISupportInitialize)(this.grvBaiBao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIDataGridView grvBaiBao;
        private Sunny.UI.UITextBox txtFileBienSoan;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIButton btnFile;
        private Sunny.UI.UIDatePicker dateNgayGui;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtTenBaiBao;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtMaBaiBao;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UIButton btnChinhSua;
        private Sunny.UI.UISymbolButton btnKhongDuyet;
        private Sunny.UI.UISymbolButton btnDuyet;
        private Sunny.UI.UISymbolButton btnChonPhanBien;
        private Sunny.UI.UIProcessBar progressBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBaiBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBaiBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn KetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTraKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePhanBien;
    }
}