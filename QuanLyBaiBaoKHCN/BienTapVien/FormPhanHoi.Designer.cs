namespace QuanLyBaiBaoKHCN.BienTapVien
{
    partial class FormPhanHoi
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
            this.txtNoiDung = new Sunny.UI.UIRichTextBox();
            this.uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            this.btnGui = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.FillColor = System.Drawing.Color.White;
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNoiDung.Location = new System.Drawing.Point(40, 93);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoiDung.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Padding = new System.Windows.Forms.Padding(2);
            this.txtNoiDung.ShowText = false;
            this.txtNoiDung.Size = new System.Drawing.Size(413, 267);
            this.txtNoiDung.TabIndex = 86;
            this.txtNoiDung.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSmoothLabel1
            // 
            this.uiSmoothLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSmoothLabel1.Location = new System.Drawing.Point(108, 28);
            this.uiSmoothLabel1.Name = "uiSmoothLabel1";
            this.uiSmoothLabel1.Size = new System.Drawing.Size(300, 29);
            this.uiSmoothLabel1.TabIndex = 84;
            this.uiSmoothLabel1.Text = "Nội dung cần chỉnh sửa";
            // 
            // btnGui
            // 
            this.btnGui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGui.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnGui.Location = new System.Drawing.Point(40, 379);
            this.btnGui.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(157, 41);
            this.btnGui.Style = Sunny.UI.UIStyle.Custom;
            this.btnGui.StyleCustomMode = true;
            this.btnGui.TabIndex = 85;
            this.btnGui.Text = "Gửi yêu cầu";
            this.btnGui.TipsFont = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // FormPhanHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 450);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.uiSmoothLabel1);
            this.Controls.Add(this.btnGui);
            this.Name = "FormPhanHoi";
            this.Text = "FormPhanHoi";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIRichTextBox txtNoiDung;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Sunny.UI.UISymbolButton btnGui;
    }
}