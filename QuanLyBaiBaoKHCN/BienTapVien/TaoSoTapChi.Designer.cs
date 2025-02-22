
namespace QuanLyBaiBaoKHCN.BienTapVien
{
    partial class TaoSoTapChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaoSoTapChi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnChonAnh = new Sunny.UI.UIButton();
            this.txtMaSoTapChi = new Sunny.UI.UITextBox();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.txtTenSoTapChi = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.dateNXB = new Sunny.UI.UIDatePicker();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.btnLuu = new Sunny.UI.UISymbolButton();
            this.btnHuy = new Sunny.UI.UISymbolButton();
            this.btnTao = new Sunny.UI.UIButton();
            this.pic_AnhBia = new System.Windows.Forms.PictureBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.progressBar1 = new Sunny.UI.UIProcessBar();
            this.grvTapChi = new Sunny.UI.UIDataGridView();
            this.MaSoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnhBia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnhBiaLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new Sunny.UI.UIButton();
            this.btnXoa = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhBia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTapChi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonAnh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.Location = new System.Drawing.Point(157, 314);
            this.btnChonAnh.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.ShowFocusLine = true;
            this.btnChonAnh.Size = new System.Drawing.Size(209, 35);
            this.btnChonAnh.TabIndex = 60;
            this.btnChonAnh.Text = "Chọn ảnh bìa";
            this.btnChonAnh.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChonAnh.TipsText = "1";
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // txtMaSoTapChi
            // 
            this.txtMaSoTapChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSoTapChi.Enabled = false;
            this.txtMaSoTapChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaSoTapChi.Location = new System.Drawing.Point(638, 34);
            this.txtMaSoTapChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSoTapChi.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMaSoTapChi.Name = "txtMaSoTapChi";
            this.txtMaSoTapChi.Padding = new System.Windows.Forms.Padding(5);
            this.txtMaSoTapChi.ShowText = false;
            this.txtMaSoTapChi.Size = new System.Drawing.Size(352, 29);
            this.txtMaSoTapChi.TabIndex = 107;
            this.txtMaSoTapChi.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaSoTapChi.Watermark = "";
            // 
            // uiLabel12
            // 
            this.uiLabel12.AutoSize = true;
            this.uiLabel12.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel12.Location = new System.Drawing.Point(496, 38);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(128, 25);
            this.uiLabel12.TabIndex = 106;
            this.uiLabel12.Text = "Mã số tạp chí";
            // 
            // txtTenSoTapChi
            // 
            this.txtTenSoTapChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSoTapChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTenSoTapChi.Location = new System.Drawing.Point(638, 86);
            this.txtTenSoTapChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenSoTapChi.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTenSoTapChi.Name = "txtTenSoTapChi";
            this.txtTenSoTapChi.Padding = new System.Windows.Forms.Padding(5);
            this.txtTenSoTapChi.ShowText = false;
            this.txtTenSoTapChi.Size = new System.Drawing.Size(352, 29);
            this.txtTenSoTapChi.TabIndex = 109;
            this.txtTenSoTapChi.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTenSoTapChi.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(496, 90);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(135, 25);
            this.uiLabel1.TabIndex = 108;
            this.uiLabel1.Text = "Tên số tạp chí";
            // 
            // dateNXB
            // 
            this.dateNXB.FillColor = System.Drawing.Color.White;
            this.dateNXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateNXB.Location = new System.Drawing.Point(638, 133);
            this.dateNXB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateNXB.MaxLength = 10;
            this.dateNXB.MinimumSize = new System.Drawing.Size(63, 0);
            this.dateNXB.Name = "dateNXB";
            this.dateNXB.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dateNXB.Size = new System.Drawing.Size(352, 34);
            this.dateNXB.SymbolDropDown = 61555;
            this.dateNXB.SymbolNormal = 61555;
            this.dateNXB.SymbolSize = 24;
            this.dateNXB.TabIndex = 111;
            this.dateNXB.Text = "2024-10-18";
            this.dateNXB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateNXB.Value = new System.DateTime(2024, 10, 18, 21, 13, 6, 512);
            this.dateNXB.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(496, 142);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(138, 25);
            this.uiLabel3.TabIndex = 110;
            this.uiLabel3.Text = "Ngày xuất bản";
            // 
            // btnLuu
            // 
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(922, 314);
            this.btnLuu.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLuu.Size = new System.Drawing.Size(209, 35);
            this.btnLuu.Style = Sunny.UI.UIStyle.Custom;
            this.btnLuu.StyleCustomMode = true;
            this.btnLuu.Symbol = 61530;
            this.btnLuu.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnLuu.TabIndex = 116;
            this.btnLuu.Text = "Lưu tạp chí";
            this.btnLuu.TipsFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnHuy.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnHuy.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnHuy.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHuy.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnHuy.Location = new System.Drawing.Point(747, 314);
            this.btnHuy.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnHuy.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnHuy.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHuy.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHuy.Size = new System.Drawing.Size(152, 35);
            this.btnHuy.Style = Sunny.UI.UIStyle.Custom;
            this.btnHuy.StyleCustomMode = true;
            this.btnHuy.Symbol = 61453;
            this.btnHuy.TabIndex = 115;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TipsFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnTao
            // 
            this.btnTao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTao.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.Location = new System.Drawing.Point(781, 175);
            this.btnTao.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnTao.Name = "btnTao";
            this.btnTao.ShowFocusLine = true;
            this.btnTao.Size = new System.Drawing.Size(209, 35);
            this.btnTao.TabIndex = 117;
            this.btnTao.Text = "Tạo mới tạp chí";
            this.btnTao.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTao.TipsText = "1";
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // pic_AnhBia
            // 
            this.pic_AnhBia.BackColor = System.Drawing.Color.Silver;
            this.pic_AnhBia.Location = new System.Drawing.Point(89, 38);
            this.pic_AnhBia.Name = "pic_AnhBia";
            this.pic_AnhBia.Size = new System.Drawing.Size(341, 270);
            this.pic_AnhBia.TabIndex = 118;
            this.pic_AnhBia.TabStop = false;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(214, 10);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(86, 25);
            this.uiLabel2.TabIndex = 119;
            this.uiLabel2.Text = "Ảnh bìa";
            // 
            // progressBar1
            // 
            this.progressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.progressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.progressBar1.Location = new System.Drawing.Point(477, 214);
            this.progressBar1.MinimumSize = new System.Drawing.Size(3, 3);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 29);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Text = "uiProcessBar1";
            this.progressBar1.Visible = false;
            // 
            // grvTapChi
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvTapChi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grvTapChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvTapChi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.grvTapChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvTapChi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvTapChi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grvTapChi.ColumnHeadersHeight = 32;
            this.grvTapChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grvTapChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSoTC,
            this.TenSo,
            this.AnhBia,
            this.AnhBiaLocal,
            this.NgayXuatBan,
            this.TrangThai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(216)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvTapChi.DefaultCellStyle = dataGridViewCellStyle3;
            this.grvTapChi.EnableHeadersVisualStyles = false;
            this.grvTapChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvTapChi.GridColor = System.Drawing.Color.Black;
            this.grvTapChi.Location = new System.Drawing.Point(49, 366);
            this.grvTapChi.Name = "grvTapChi";
            this.grvTapChi.ReadOnly = true;
            this.grvTapChi.RectColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(193)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvTapChi.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grvTapChi.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.grvTapChi.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grvTapChi.RowTemplate.Height = 23;
            this.grvTapChi.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grvTapChi.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grvTapChi.ScrollBarStyleInherited = false;
            this.grvTapChi.SelectedIndex = -1;
            this.grvTapChi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvTapChi.Size = new System.Drawing.Size(1082, 399);
            this.grvTapChi.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.grvTapChi.Style = Sunny.UI.UIStyle.Custom;
            this.grvTapChi.TabIndex = 120;
            this.grvTapChi.TagString = "";
            this.grvTapChi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvTapChi_CellClick);
            // 
            // MaSoTC
            // 
            this.MaSoTC.DataPropertyName = "MaSoTC";
            this.MaSoTC.HeaderText = "Mã tạp chí";
            this.MaSoTC.MinimumWidth = 6;
            this.MaSoTC.Name = "MaSoTC";
            this.MaSoTC.ReadOnly = true;
            // 
            // TenSo
            // 
            this.TenSo.DataPropertyName = "TenSo";
            this.TenSo.HeaderText = "Tên số tạp chí";
            this.TenSo.MinimumWidth = 6;
            this.TenSo.Name = "TenSo";
            this.TenSo.ReadOnly = true;
            // 
            // AnhBia
            // 
            this.AnhBia.DataPropertyName = "AnhBia";
            this.AnhBia.HeaderText = "Ảnh bìa";
            this.AnhBia.MinimumWidth = 6;
            this.AnhBia.Name = "AnhBia";
            this.AnhBia.ReadOnly = true;
            this.AnhBia.Visible = false;
            // 
            // AnhBiaLocal
            // 
            this.AnhBiaLocal.DataPropertyName = "AnhBiaLocal";
            this.AnhBiaLocal.HeaderText = "Ảnh bìa";
            this.AnhBiaLocal.MinimumWidth = 6;
            this.AnhBiaLocal.Name = "AnhBiaLocal";
            this.AnhBiaLocal.ReadOnly = true;
            // 
            // NgayXuatBan
            // 
            this.NgayXuatBan.DataPropertyName = "NgayXuatBan";
            this.NgayXuatBan.HeaderText = "Ngày xuất bản";
            this.NgayXuatBan.MinimumWidth = 6;
            this.NgayXuatBan.Name = "NgayXuatBan";
            this.NgayXuatBan.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Enabled = false;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(507, 314);
            this.btnSua.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShowFocusLine = true;
            this.btnSua.Size = new System.Drawing.Size(97, 35);
            this.btnSua.TabIndex = 121;
            this.btnSua.Text = "Sửa";
            this.btnSua.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSua.TipsText = "1";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(627, 314);
            this.btnXoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShowFocusLine = true;
            this.btnXoa.Size = new System.Drawing.Size(97, 35);
            this.btnXoa.TabIndex = 122;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnXoa.TipsText = "1";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // TaoSoTapChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1291, 791);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.grvTapChi);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.pic_AnhBia);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dateNXB);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.txtTenSoTapChi);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.txtMaSoTapChi);
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.btnChonAnh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaoSoTapChi";
            this.Text = "TaoSoTapChi";
            ((System.ComponentModel.ISupportInitialize)(this.pic_AnhBia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTapChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Sunny.UI.UIButton btnChonAnh;
        private Sunny.UI.UITextBox txtMaSoTapChi;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UITextBox txtTenSoTapChi;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDatePicker dateNXB;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UISymbolButton btnLuu;
        private Sunny.UI.UISymbolButton btnHuy;
        private Sunny.UI.UIButton btnTao;
        private System.Windows.Forms.PictureBox pic_AnhBia;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIProcessBar progressBar1;
        private Sunny.UI.UIDataGridView grvTapChi;
        private Sunny.UI.UIButton btnSua;
        private Sunny.UI.UIButton btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSoTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnhBia;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnhBiaLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}