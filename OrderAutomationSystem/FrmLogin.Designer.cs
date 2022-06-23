
namespace OrderAutomationSystem
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullanıcıAdı = new DevExpress.XtraEditors.TextEdit();
            this.txtŞifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnGiriş = new DevExpress.XtraEditors.SimpleButton();
            this.btnKayıtOl = new DevExpress.XtraEditors.SimpleButton();
            this.btnÇıkış = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanıcıAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtŞifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(119, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(123, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kullanıcı Adı:";
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(248, 53);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanıcıAdı.Properties.Appearance.Options.UseFont = true;
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(258, 28);
            this.txtKullanıcıAdı.TabIndex = 1;
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(248, 87);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtŞifre.Properties.Appearance.Options.UseFont = true;
            this.txtŞifre.Properties.UseSystemPasswordChar = true;
            this.txtŞifre.Size = new System.Drawing.Size(258, 28);
            this.txtŞifre.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(193, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Şifre:";
            // 
            // btnGiriş
            // 
            this.btnGiriş.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.btnGiriş.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiriş.Appearance.Options.UseBackColor = true;
            this.btnGiriş.Appearance.Options.UseFont = true;
            this.btnGiriş.Location = new System.Drawing.Point(381, 121);
            this.btnGiriş.Name = "btnGiriş";
            this.btnGiriş.Size = new System.Drawing.Size(125, 28);
            this.btnGiriş.TabIndex = 4;
            this.btnGiriş.Text = "GİRİŞ";
            this.btnGiriş.Click += new System.EventHandler(this.btnGiriş_Click);
            // 
            // btnKayıtOl
            // 
            this.btnKayıtOl.Appearance.BackColor = System.Drawing.Color.SlateBlue;
            this.btnKayıtOl.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıtOl.Appearance.Options.UseBackColor = true;
            this.btnKayıtOl.Appearance.Options.UseFont = true;
            this.btnKayıtOl.Location = new System.Drawing.Point(248, 121);
            this.btnKayıtOl.Name = "btnKayıtOl";
            this.btnKayıtOl.Size = new System.Drawing.Size(125, 28);
            this.btnKayıtOl.TabIndex = 5;
            this.btnKayıtOl.Text = "KAYIT OL";
            this.btnKayıtOl.Click += new System.EventHandler(this.btnKayıtOl_Click);
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.Appearance.BackColor = System.Drawing.Color.Wheat;
            this.btnÇıkış.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇıkış.Appearance.Options.UseBackColor = true;
            this.btnÇıkış.Appearance.Options.UseFont = true;
            this.btnÇıkış.Location = new System.Drawing.Point(381, 155);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.Size = new System.Drawing.Size(125, 28);
            this.btnÇıkış.TabIndex = 6;
            this.btnÇıkış.Text = "ÇIKIŞ";
            this.btnÇıkış.Click += new System.EventHandler(this.btnÇıkış_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(38, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(587, 32);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "AYAZILIM SİPARİŞ OTOMASYON SİSTEMİ";
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnGiriş;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(654, 434);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnÇıkış);
            this.Controls.Add(this.btnKayıtOl);
            this.Controls.Add(this.btnGiriş);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanıcıAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtŞifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKullanıcıAdı;
        private DevExpress.XtraEditors.TextEdit txtŞifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnGiriş;
        private DevExpress.XtraEditors.SimpleButton btnKayıtOl;
        private DevExpress.XtraEditors.SimpleButton btnÇıkış;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}