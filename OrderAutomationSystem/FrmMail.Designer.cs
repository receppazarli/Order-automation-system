
namespace OrderAutomationSystem
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.label3 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMailAdresi = new DevExpress.XtraEditors.TextEdit();
            this.txtKonu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.rctxtMesaj = new DevExpress.XtraRichEdit.RichEditControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnGönder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtMailAdresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(287, -27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "MAIL SENDING PANEL ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(32, 216);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(148, 31);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Mail Adresi:";
            // 
            // txtMailAdresi
            // 
            this.txtMailAdresi.Location = new System.Drawing.Point(186, 221);
            this.txtMailAdresi.Name = "txtMailAdresi";
            this.txtMailAdresi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMailAdresi.Properties.Appearance.Options.UseFont = true;
            this.txtMailAdresi.Size = new System.Drawing.Size(361, 28);
            this.txtMailAdresi.TabIndex = 24;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(186, 273);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKonu.Properties.Appearance.Options.UseFont = true;
            this.txtKonu.Size = new System.Drawing.Size(361, 28);
            this.txtKonu.TabIndex = 26;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(106, 270);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(74, 31);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Konu:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(100, 324);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 31);
            this.labelControl3.TabIndex = 27;
            this.labelControl3.Text = "Mesaj:";
            // 
            // rctxtMesaj
            // 
            this.rctxtMesaj.Location = new System.Drawing.Point(186, 315);
            this.rctxtMesaj.Name = "rctxtMesaj";
            this.rctxtMesaj.Size = new System.Drawing.Size(361, 192);
            this.rctxtMesaj.TabIndex = 28;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(218, 32);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(329, 165);
            this.pictureEdit1.TabIndex = 29;
            // 
            // btnGönder
            // 
            this.btnGönder.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGönder.Appearance.Options.UseFont = true;
            this.btnGönder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnGönder.Location = new System.Drawing.Point(318, 513);
            this.btnGönder.Name = "btnGönder";
            this.btnGönder.Size = new System.Drawing.Size(229, 45);
            this.btnGönder.TabIndex = 30;
            this.btnGönder.Text = "GÖNDER";
            this.btnGönder.Click += new System.EventHandler(this.btnGönder_Click);
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(567, 586);
            this.Controls.Add(this.btnGönder);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.rctxtMesaj);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtMailAdresi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMailAdresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKonu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMailAdresi;
        private DevExpress.XtraEditors.TextEdit txtKonu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraRichEdit.RichEditControl rctxtMesaj;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnGönder;
    }
}