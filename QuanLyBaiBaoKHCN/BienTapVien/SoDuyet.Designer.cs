
namespace QuanLyBaiBaoKHCN.BienTapVien
{
    partial class SoDuyet
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
            this.uiDatePicker1 = new Sunny.UI.UIDatePicker();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.grvBaiBao = new Sunny.UI.UIDataGridView();
            this.MaBaiBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBaiBao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXemFile = new Sunny.UI.UIButton();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.cboTrangThaiBaiBao = new Sunny.UI.UIComboBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.cboChuyenMuc = new Sunny.UI.UIComboBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.cboNgonNgu = new Sunny.UI.UIComboBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.dateDenNgay = new Sunny.UI.UIDatePicker();
            this.dateTuNgay = new Sunny.UI.UIDatePicker();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaiBao)).BeginInit();
            this.SuspendLayout();
            // 
            // uiDatePicker1
            // 
            this.uiDatePicker1.AutoSize = true;
            this.uiDatePicker1.FillColor = System.Drawing.Color.White;
            this.uiDatePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiDatePicker1.Location = new System.Drawing.Point(17, 74);
            this.uiDatePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatePicker1.MaxLength = 10;
            this.uiDatePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatePicker1.Name = "uiDatePicker1";
            this.uiDatePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatePicker1.Size = new System.Drawing.Size(210, 34);
            this.uiDatePicker1.SymbolDropDown = 61555;
            this.uiDatePicker1.SymbolNormal = 61555;
            this.uiDatePicker1.SymbolSize = 24;
            this.uiDatePicker1.TabIndex = 6;
            this.uiDatePicker1.Text = "2024-10-18";
            this.uiDatePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatePicker1.Value = new System.DateTime(2024, 10, 18, 20, 55, 20, 435);
            this.uiDatePicker1.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(450, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(232, 25);
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "DANH SÁCH BÀI BÁO";
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
            this.grvBaiBao.Location = new System.Drawing.Point(21, 126);
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
            this.grvBaiBao.Size = new System.Drawing.Size(1181, 484);
            this.grvBaiBao.TabIndex = 15;
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
            this.btnXemFile.Location = new System.Drawing.Point(21, 616);
            this.btnXemFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXemFile.Name = "btnXemFile";
            this.btnXemFile.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.btnXemFile.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.btnXemFile.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnXemFile.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.btnXemFile.ShowFocusLine = true;
            this.btnXemFile.Size = new System.Drawing.Size(170, 35);
            this.btnXemFile.Style = Sunny.UI.UIStyle.Custom;
            this.btnXemFile.StyleCustomMode = true;
            this.btnXemFile.TabIndex = 65;
            this.btnXemFile.Text = "Xem file bài báo";
            this.btnXemFile.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(912, 616);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.StyleCustomMode = true;
            this.uiSymbolButton1.TabIndex = 80;
            this.uiSymbolButton1.Text = "Duyệt";
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiSymbolButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiSymbolButton2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.uiSymbolButton2.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton2.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.uiSymbolButton2.Location = new System.Drawing.Point(1043, 616);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiSymbolButton2.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.uiSymbolButton2.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton2.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton2.Size = new System.Drawing.Size(159, 35);
            this.uiSymbolButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton2.StyleCustomMode = true;
            this.uiSymbolButton2.Symbol = 61453;
            this.uiSymbolButton2.TabIndex = 81;
            this.uiSymbolButton2.Text = "Không duyệt";
            this.uiSymbolButton2.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // cboTrangThaiBaiBao
            // 
            this.cboTrangThaiBaiBao.DataSource = null;
            this.cboTrangThaiBaiBao.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboTrangThaiBaiBao.FillColor = System.Drawing.Color.White;
            this.cboTrangThaiBaiBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboTrangThaiBaiBao.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboTrangThaiBaiBao.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboTrangThaiBaiBao.Location = new System.Drawing.Point(987, 77);
            this.cboTrangThaiBaiBao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTrangThaiBaiBao.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboTrangThaiBaiBao.Name = "cboTrangThaiBaiBao";
            this.cboTrangThaiBaiBao.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboTrangThaiBaiBao.Size = new System.Drawing.Size(215, 33);
            this.cboTrangThaiBaiBao.SymbolSize = 24;
            this.cboTrangThaiBaiBao.TabIndex = 170;
            this.cboTrangThaiBaiBao.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboTrangThaiBaiBao.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(978, 46);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(100, 25);
            this.uiLabel6.TabIndex = 168;
            this.uiLabel6.Text = "Trạng thái";
            // 
            // cboChuyenMuc
            // 
            this.cboChuyenMuc.DataSource = null;
            this.cboChuyenMuc.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboChuyenMuc.FillColor = System.Drawing.Color.White;
            this.cboChuyenMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboChuyenMuc.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboChuyenMuc.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboChuyenMuc.Location = new System.Drawing.Point(700, 77);
            this.cboChuyenMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboChuyenMuc.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboChuyenMuc.Name = "cboChuyenMuc";
            this.cboChuyenMuc.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboChuyenMuc.Size = new System.Drawing.Size(215, 33);
            this.cboChuyenMuc.SymbolSize = 24;
            this.cboChuyenMuc.TabIndex = 171;
            this.cboChuyenMuc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboChuyenMuc.Watermark = "";
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(695, 47);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(123, 25);
            this.uiLabel5.TabIndex = 169;
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
            this.cboNgonNgu.Location = new System.Drawing.Point(417, 77);
            this.cboNgonNgu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboNgonNgu.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboNgonNgu.Name = "cboNgonNgu";
            this.cboNgonNgu.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboNgonNgu.Size = new System.Drawing.Size(215, 33);
            this.cboNgonNgu.SymbolSize = 24;
            this.cboNgonNgu.TabIndex = 167;
            this.cboNgonNgu.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboNgonNgu.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(412, 47);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(97, 25);
            this.uiLabel4.TabIndex = 166;
            this.uiLabel4.Text = "Ngôn ngữ";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.FillColor = System.Drawing.Color.White;
            this.dateDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateDenNgay.Location = new System.Drawing.Point(216, 77);
            this.dateDenNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateDenNgay.MaxLength = 10;
            this.dateDenNgay.MinimumSize = new System.Drawing.Size(63, 0);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dateDenNgay.Size = new System.Drawing.Size(133, 33);
            this.dateDenNgay.SymbolDropDown = 61555;
            this.dateDenNgay.SymbolNormal = 61555;
            this.dateDenNgay.SymbolSize = 24;
            this.dateDenNgay.TabIndex = 165;
            this.dateDenNgay.Text = "2024-10-18";
            this.dateDenNgay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateDenNgay.Value = new System.DateTime(2024, 10, 18, 21, 13, 6, 512);
            this.dateDenNgay.Watermark = "";
            // 
            // dateTuNgay
            // 
            this.dateTuNgay.FillColor = System.Drawing.Color.White;
            this.dateTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTuNgay.Location = new System.Drawing.Point(21, 77);
            this.dateTuNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTuNgay.MaxLength = 10;
            this.dateTuNgay.MinimumSize = new System.Drawing.Size(63, 0);
            this.dateTuNgay.Name = "dateTuNgay";
            this.dateTuNgay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dateTuNgay.Size = new System.Drawing.Size(127, 33);
            this.dateTuNgay.SymbolDropDown = 61555;
            this.dateTuNgay.SymbolNormal = 61555;
            this.dateTuNgay.SymbolSize = 24;
            this.dateTuNgay.TabIndex = 164;
            this.dateTuNgay.Text = "2024-10-18";
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
            this.uiLabel3.Location = new System.Drawing.Point(211, 46);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(96, 25);
            this.uiLabel3.TabIndex = 163;
            this.uiLabel3.Text = "Đến ngày";
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(16, 46);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(84, 25);
            this.uiLabel2.TabIndex = 162;
            this.uiLabel2.Text = "Từ ngày";
            // 
            // SoDuyet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1238, 680);
            this.Controls.Add(this.cboTrangThaiBaiBao);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.cboChuyenMuc);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.cboNgonNgu);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.dateDenNgay);
            this.Controls.Add(this.dateTuNgay);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.btnXemFile);
            this.Controls.Add(this.grvBaiBao);
            this.Controls.Add(this.uiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SoDuyet";
            this.Text = "SoDuyet";
            ((System.ComponentModel.ISupportInitialize)(this.grvBaiBao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIDatePicker uiDatePicker1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDataGridView grvBaiBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBaiBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBaiBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGui;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private Sunny.UI.UIButton btnXemFile;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UIComboBox cboTrangThaiBaiBao;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboBox cboChuyenMuc;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIComboBox cboNgonNgu;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIDatePicker dateDenNgay;
        private Sunny.UI.UIDatePicker dateTuNgay;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
    }
}