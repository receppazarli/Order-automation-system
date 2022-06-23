
namespace OrderAutomationSystem
{
    partial class FrmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomers));
            this.grcMüşteriler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtBanka = new DevExpress.XtraEditors.TextEdit();
            this.txtAdres = new DevExpress.XtraEditors.TextEdit();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtIban = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkupİlçe = new DevExpress.XtraEditors.LookUpEdit();
            this.lkupİl = new DevExpress.XtraEditors.LookUpEdit();
            this.tablo = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.grcMüşteriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupİlçe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupİl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.tablo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // grcMüşteriler
            // 
            resources.ApplyResources(this.grcMüşteriler, "grcMüşteriler");
            this.grcMüşteriler.MainView = this.gridView1;
            this.grcMüşteriler.Name = "grcMüşteriler";
            this.grcMüşteriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = ((System.Drawing.Color)(resources.GetObject("gridView1.Appearance.Row.BackColor2")));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.grcMüşteriler;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtBanka);
            this.groupControl1.Controls.Add(this.txtAdres);
            this.groupControl1.Controls.Add(this.btnTemizle);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnGüncelle);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtMail);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.txtTelefon);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txtIban);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtTC);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtAd);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtSoyad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.lkupİlçe);
            this.groupControl1.Controls.Add(this.lkupİl);
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            // 
            // txtBanka
            // 
            resources.ApplyResources(this.txtBanka, "txtBanka");
            this.txtBanka.Name = "txtBanka";
            this.txtBanka.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtBanka.Properties.Appearance.Font")));
            this.txtBanka.Properties.Appearance.Options.UseFont = true;
            // 
            // txtAdres
            // 
            resources.ApplyResources(this.txtAdres, "txtAdres");
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtAdres.Properties.Appearance.Font")));
            this.txtAdres.Properties.Appearance.Options.UseFont = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnTemizle.Appearance.Font")));
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.ImageOptions.Image")));
            resources.ApplyResources(this.btnTemizle, "btnTemizle");
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnSil.Appearance.Font")));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            resources.ApplyResources(this.btnSil, "btnSil");
            this.btnSil.Name = "btnSil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnGüncelle.Appearance.Font")));
            this.btnGüncelle.Appearance.Options.UseFont = true;
            this.btnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGüncelle.ImageOptions.Image")));
            resources.ApplyResources(this.btnGüncelle, "btnGüncelle");
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnKaydet.Appearance.Font")));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            resources.ApplyResources(this.btnKaydet, "btnKaydet");
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl11.Appearance.Font")));
            this.labelControl11.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl11, "labelControl11");
            this.labelControl11.Name = "labelControl11";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl10.Appearance.Font")));
            this.labelControl10.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl10, "labelControl10");
            this.labelControl10.Name = "labelControl10";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl9.Appearance.Font")));
            this.labelControl9.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl9, "labelControl9");
            this.labelControl9.Name = "labelControl9";
            // 
            // txtMail
            // 
            resources.ApplyResources(this.txtMail, "txtMail");
            this.txtMail.Name = "txtMail";
            this.txtMail.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtMail.Properties.Appearance.Font")));
            this.txtMail.Properties.Appearance.Options.UseFont = true;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl8.Appearance.Font")));
            this.labelControl8.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl8, "labelControl8");
            this.labelControl8.Name = "labelControl8";
            // 
            // txtTelefon
            // 
            resources.ApplyResources(this.txtTelefon, "txtTelefon");
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtTelefon.Properties.Appearance.Font")));
            this.txtTelefon.Properties.Appearance.Options.UseFont = true;
            this.txtTelefon.Properties.Mask.EditMask = resources.GetString("txtTelefon.Properties.Mask.EditMask");
            this.txtTelefon.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtTelefon.Properties.Mask.MaskType")));
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl7.Appearance.Font")));
            this.labelControl7.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl7, "labelControl7");
            this.labelControl7.Name = "labelControl7";
            // 
            // txtIban
            // 
            resources.ApplyResources(this.txtIban, "txtIban");
            this.txtIban.Name = "txtIban";
            this.txtIban.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtIban.Properties.Appearance.Font")));
            this.txtIban.Properties.Appearance.Options.UseFont = true;
            this.txtIban.Properties.Mask.EditMask = resources.GetString("txtIban.Properties.Mask.EditMask");
            this.txtIban.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtIban.Properties.Mask.MaskType")));
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl6.Appearance.Font")));
            this.labelControl6.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl6, "labelControl6");
            this.labelControl6.Name = "labelControl6";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl5.Appearance.Font")));
            this.labelControl5.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl5, "labelControl5");
            this.labelControl5.Name = "labelControl5";
            // 
            // txtTC
            // 
            resources.ApplyResources(this.txtTC, "txtTC");
            this.txtTC.Name = "txtTC";
            this.txtTC.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtTC.Properties.Appearance.Font")));
            this.txtTC.Properties.Appearance.Options.UseFont = true;
            this.txtTC.Properties.Mask.EditMask = resources.GetString("txtTC.Properties.Mask.EditMask");
            this.txtTC.Properties.Mask.MaskType = ((DevExpress.XtraEditors.Mask.MaskType)(resources.GetObject("txtTC.Properties.Mask.MaskType")));
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl4.Appearance.Font")));
            this.labelControl4.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Name = "labelControl4";
            // 
            // txtAd
            // 
            resources.ApplyResources(this.txtAd, "txtAd");
            this.txtAd.Name = "txtAd";
            this.txtAd.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtAd.Properties.Appearance.Font")));
            this.txtAd.Properties.Appearance.Options.UseFont = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl3.Appearance.Font")));
            this.labelControl3.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl3, "labelControl3");
            this.labelControl3.Name = "labelControl3";
            // 
            // txtSoyad
            // 
            resources.ApplyResources(this.txtSoyad, "txtSoyad");
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtSoyad.Properties.Appearance.Font")));
            this.txtSoyad.Properties.Appearance.Options.UseFont = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl2.Appearance.Font")));
            this.labelControl2.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // lkupİlçe
            // 
            resources.ApplyResources(this.lkupİlçe, "lkupİlçe");
            this.lkupİlçe.Name = "lkupİlçe";
            this.lkupİlçe.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lkupİlçe.Properties.Appearance.Font")));
            this.lkupİlçe.Properties.Appearance.Options.UseFont = true;
            this.lkupİlçe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lkupİlçe.Properties.Buttons"))))});
            this.lkupİlçe.Properties.NullText = resources.GetString("lkupİlçe.Properties.NullText");
            // 
            // lkupİl
            // 
            resources.ApplyResources(this.lkupİl, "lkupİl");
            this.lkupİl.Name = "lkupİl";
            this.lkupİl.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lkupİl.Properties.Appearance.Font")));
            this.lkupİl.Properties.Appearance.Options.UseFont = true;
            this.lkupİl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lkupİl.Properties.Buttons"))))});
            this.lkupİl.Properties.NullText = resources.GetString("lkupİl.Properties.NullText");
            this.lkupİl.EditValueChanged += new System.EventHandler(this.lkupİl_EditValueChanged);
            // 
            // tablo
            // 
            this.tablo.Controls.Add(this.groupControl1);
            this.tablo.Controls.Add(this.grcMüşteriler);
            resources.ApplyResources(this.tablo, "tablo");
            this.tablo.Name = "tablo";
            this.tablo.Root = this.Root;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1086, 376);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grcMüşteriler;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(747, 356);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.groupControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(747, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(319, 356);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // FrmCustomers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablo);
            this.Name = "FrmCustomers";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcMüşteriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBanka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupİlçe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupİl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.tablo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcMüşteriler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtTC;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtIban;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.TextEdit txtAdres;
        private DevExpress.XtraEditors.TextEdit txtBanka;
        private DevExpress.XtraEditors.LookUpEdit lkupİlçe;
        private DevExpress.XtraEditors.LookUpEdit lkupİl;
        private DevExpress.XtraLayout.LayoutControl tablo;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}