namespace QuanLyBaiBaoKHCN.BienTapVien
{
    partial class Frm_YeuCauChinhSua
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
            this.btnGui = new Sunny.UI.UISymbolButton();
            this.btnGuifile = new Sunny.UI.UIButton();
            this.lbfile = new Sunny.UI.UILabel();
            this.uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            this.txtNoiDung = new Sunny.UI.UIRichTextBox();
            this.SuspendLayout();
            // 
            // btnGui
            // 
            this.btnGui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGui.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnGui.Location = new System.Drawing.Point(134, 342);
            this.btnGui.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(157, 41);
            this.btnGui.Style = Sunny.UI.UIStyle.Custom;
            this.btnGui.StyleCustomMode = true;
            this.btnGui.TabIndex = 81;
            this.btnGui.Text = "Gửi yêu cầu";
            this.btnGui.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnGuifile
            // 
            this.btnGuifile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuifile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGuifile.Location = new System.Drawing.Point(13, 273);
            this.btnGuifile.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGuifile.Name = "btnGuifile";
            this.btnGuifile.Size = new System.Drawing.Size(100, 35);
            this.btnGuifile.TabIndex = 3;
            this.btnGuifile.Text = "Upload";
            this.btnGuifile.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnGuifile.Click += new System.EventHandler(this.btnGuifile_Click);
            // 
            // lbfile
            // 
            this.lbfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbfile.Location = new System.Drawing.Point(119, 285);
            this.lbfile.Name = "lbfile";
            this.lbfile.Size = new System.Drawing.Size(279, 23);
            this.lbfile.TabIndex = 82;
            this.lbfile.Text = "file";
            // 
            // uiSmoothLabel1
            // 
            this.uiSmoothLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSmoothLabel1.Location = new System.Drawing.Point(74, 25);
            this.uiSmoothLabel1.Name = "uiSmoothLabel1";
            this.uiSmoothLabel1.Size = new System.Drawing.Size(300, 29);
            this.uiSmoothLabel1.TabIndex = 3;
            this.uiSmoothLabel1.Text = "Nội dung cần chỉnh sửa";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.FillColor = System.Drawing.Color.White;
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNoiDung.Location = new System.Drawing.Point(13, 79);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoiDung.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Padding = new System.Windows.Forms.Padding(2);
            this.txtNoiDung.ShowText = false;
            this.txtNoiDung.Size = new System.Drawing.Size(395, 186);
            this.txtNoiDung.TabIndex = 83;
            this.txtNoiDung.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_YeuCauChinhSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 436);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.uiSmoothLabel1);
            this.Controls.Add(this.lbfile);
            this.Controls.Add(this.btnGuifile);
            this.Controls.Add(this.btnGui);
            this.Name = "Frm_YeuCauChinhSua";
            this.Text = "Frm_YeuCauChinhSua";
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton btnGui;
        private Sunny.UI.UIButton btnGuifile;
        private Sunny.UI.UILabel lbfile;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Sunny.UI.UIRichTextBox txtNoiDung;
    }
}