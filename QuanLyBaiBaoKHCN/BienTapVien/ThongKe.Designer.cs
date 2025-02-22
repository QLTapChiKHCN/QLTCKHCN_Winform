
namespace QuanLyBaiBaoKHCN.BienTapVien
{
    partial class ThongKe
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
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLoc_Ngay = new Sunny.UI.UIButton();
            this.DatePick_DenNgay = new Sunny.UI.UIDatePicker();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.btnLoc_Quy = new Sunny.UI.UIButton();
            this.PieChart_ThongKe = new Sunny.UI.UIPieChart();
            this.cboChonQuy = new Sunny.UI.UIComboBox();
            this.DatePick_Year_Quy = new Sunny.UI.UIDatePicker();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.DatePick_TuNgay = new Sunny.UI.UIDatePicker();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(0, 0);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(1291, 791);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabIndex = 0;
            this.uiTabControl1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLoc_Ngay);
            this.tabPage2.Controls.Add(this.DatePick_DenNgay);
            this.tabPage2.Controls.Add(this.uiLabel4);
            this.tabPage2.Controls.Add(this.btnLoc_Quy);
            this.tabPage2.Controls.Add(this.PieChart_ThongKe);
            this.tabPage2.Controls.Add(this.cboChonQuy);
            this.tabPage2.Controls.Add(this.DatePick_Year_Quy);
            this.tabPage2.Controls.Add(this.uiLabel3);
            this.tabPage2.Controls.Add(this.DatePick_TuNgay);
            this.tabPage2.Controls.Add(this.uiLabel2);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1291, 751);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLoc_Ngay
            // 
            this.btnLoc_Ngay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoc_Ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLoc_Ngay.Location = new System.Drawing.Point(496, 15);
            this.btnLoc_Ngay.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLoc_Ngay.Name = "btnLoc_Ngay";
            this.btnLoc_Ngay.Size = new System.Drawing.Size(82, 29);
            this.btnLoc_Ngay.TabIndex = 9;
            this.btnLoc_Ngay.Text = "Lọc";
            this.btnLoc_Ngay.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLoc_Ngay.Click += new System.EventHandler(this.btnLoc_Ngay_Click);
            // 
            // DatePick_DenNgay
            // 
            this.DatePick_DenNgay.DateFormat = "dd-MM-yyyy";
            this.DatePick_DenNgay.DateYearMonthFormat = "MM-yyyy";
            this.DatePick_DenNgay.FillColor = System.Drawing.Color.White;
            this.DatePick_DenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DatePick_DenNgay.Location = new System.Drawing.Point(346, 15);
            this.DatePick_DenNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatePick_DenNgay.MaxLength = 10;
            this.DatePick_DenNgay.MinimumSize = new System.Drawing.Size(63, 0);
            this.DatePick_DenNgay.Name = "DatePick_DenNgay";
            this.DatePick_DenNgay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.DatePick_DenNgay.Size = new System.Drawing.Size(143, 29);
            this.DatePick_DenNgay.SymbolDropDown = 61555;
            this.DatePick_DenNgay.SymbolNormal = 61555;
            this.DatePick_DenNgay.SymbolSize = 24;
            this.DatePick_DenNgay.TabIndex = 5;
            this.DatePick_DenNgay.Text = "01-11-2024";
            this.DatePick_DenNgay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.DatePick_DenNgay.Value = new System.DateTime(2024, 11, 1, 0, 0, 0, 0);
            this.DatePick_DenNgay.Watermark = "";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(254, 17);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(98, 27);
            this.uiLabel4.TabIndex = 4;
            this.uiLabel4.Text = "Đến ngày";
            // 
            // btnLoc_Quy
            // 
            this.btnLoc_Quy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoc_Quy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLoc_Quy.Location = new System.Drawing.Point(1197, 15);
            this.btnLoc_Quy.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLoc_Quy.Name = "btnLoc_Quy";
            this.btnLoc_Quy.Size = new System.Drawing.Size(82, 29);
            this.btnLoc_Quy.TabIndex = 8;
            this.btnLoc_Quy.Text = "Lọc";
            this.btnLoc_Quy.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLoc_Quy.Click += new System.EventHandler(this.btnLoc_Quy_Click);
            // 
            // PieChart_ThongKe
            // 
            this.PieChart_ThongKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PieChart_ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.PieChart_ThongKe.LegendFont = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.PieChart_ThongKe.Location = new System.Drawing.Point(0, 52);
            this.PieChart_ThongKe.MinimumSize = new System.Drawing.Size(1, 1);
            this.PieChart_ThongKe.Name = "PieChart_ThongKe";
            this.PieChart_ThongKe.Size = new System.Drawing.Size(1291, 699);
            this.PieChart_ThongKe.SubFont = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.PieChart_ThongKe.TabIndex = 7;
            this.PieChart_ThongKe.Text = "uiPieChart1";
            // 
            // cboChonQuy
            // 
            this.cboChonQuy.DataSource = null;
            this.cboChonQuy.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cboChonQuy.FillColor = System.Drawing.Color.White;
            this.cboChonQuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboChonQuy.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cboChonQuy.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cboChonQuy.Location = new System.Drawing.Point(973, 15);
            this.cboChonQuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboChonQuy.MinimumSize = new System.Drawing.Size(63, 0);
            this.cboChonQuy.Name = "cboChonQuy";
            this.cboChonQuy.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cboChonQuy.Size = new System.Drawing.Size(128, 29);
            this.cboChonQuy.SymbolSize = 24;
            this.cboChonQuy.TabIndex = 6;
            this.cboChonQuy.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cboChonQuy.Watermark = "";
            // 
            // DatePick_Year_Quy
            // 
            this.DatePick_Year_Quy.DateYearMonthFormat = "MM-yyyy";
            this.DatePick_Year_Quy.FillColor = System.Drawing.Color.White;
            this.DatePick_Year_Quy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DatePick_Year_Quy.Location = new System.Drawing.Point(1109, 15);
            this.DatePick_Year_Quy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatePick_Year_Quy.MaxLength = 4;
            this.DatePick_Year_Quy.MinimumSize = new System.Drawing.Size(63, 0);
            this.DatePick_Year_Quy.Name = "DatePick_Year_Quy";
            this.DatePick_Year_Quy.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.DatePick_Year_Quy.ShowType = Sunny.UI.UIDateType.Year;
            this.DatePick_Year_Quy.Size = new System.Drawing.Size(81, 29);
            this.DatePick_Year_Quy.SymbolDropDown = 61555;
            this.DatePick_Year_Quy.SymbolNormal = 61555;
            this.DatePick_Year_Quy.SymbolSize = 24;
            this.DatePick_Year_Quy.TabIndex = 5;
            this.DatePick_Year_Quy.Text = "2024";
            this.DatePick_Year_Quy.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.DatePick_Year_Quy.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.DatePick_Year_Quy.Watermark = "";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(881, 17);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(107, 27);
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "Chọn quý";
            // 
            // DatePick_TuNgay
            // 
            this.DatePick_TuNgay.DateFormat = "dd-MM-yyyy";
            this.DatePick_TuNgay.DateYearMonthFormat = "MM-yyyy";
            this.DatePick_TuNgay.FillColor = System.Drawing.Color.White;
            this.DatePick_TuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DatePick_TuNgay.Location = new System.Drawing.Point(94, 15);
            this.DatePick_TuNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatePick_TuNgay.MaxLength = 10;
            this.DatePick_TuNgay.MinimumSize = new System.Drawing.Size(63, 0);
            this.DatePick_TuNgay.Name = "DatePick_TuNgay";
            this.DatePick_TuNgay.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.DatePick_TuNgay.Size = new System.Drawing.Size(143, 29);
            this.DatePick_TuNgay.SymbolDropDown = 61555;
            this.DatePick_TuNgay.SymbolNormal = 61555;
            this.DatePick_TuNgay.SymbolSize = 24;
            this.DatePick_TuNgay.TabIndex = 3;
            this.DatePick_TuNgay.Text = "01-11-2024";
            this.DatePick_TuNgay.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.DatePick_TuNgay.Value = new System.DateTime(2024, 11, 1, 0, 0, 0, 0);
            this.DatePick_TuNgay.Watermark = "";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(3, 17);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(89, 27);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "Từ ngày";
            // 
            // ThongKe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1291, 791);
            this.Controls.Add(this.uiTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UIDatePicker DatePick_Year_Quy;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIDatePicker DatePick_TuNgay;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox cboChonQuy;
        private Sunny.UI.UIButton btnLoc_Quy;
        private Sunny.UI.UIPieChart PieChart_ThongKe;
        private Sunny.UI.UIDatePicker DatePick_DenNgay;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton btnLoc_Ngay;
    }
}