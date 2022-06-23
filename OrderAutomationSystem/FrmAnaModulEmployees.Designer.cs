
namespace OrderAutomationSystem
{
    partial class FrmAnaModulEmployees
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaModulEmployees));
            this.MdiAnaModul = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.rbnpgSiparişOtomasyon = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_Products = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Customers = new DevExpress.XtraBars.BarButtonItem();
            this.btn_HomePage = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Employees = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Safe = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Invoices = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Settings = new DevExpress.XtraBars.BarButtonItem();
            this.btnWareHouse = new DevExpress.XtraBars.BarButtonItem();
            this.btnShipper = new DevExpress.XtraBars.BarButtonItem();
            this.btnSupplier = new DevExpress.XtraBars.BarButtonItem();
            this.btnOrders = new DevExpress.XtraBars.BarButtonItem();
            this.rbnpage_CommercialAutomation = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.MdiAnaModul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // MdiAnaModul
            // 
            this.MdiAnaModul.MdiParent = this;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.ImageOptions.Image")));
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(180, 120);
            this.Root.TextVisible = false;
            // 
            // rbnpgSiparişOtomasyon
            // 
            this.rbnpgSiparişOtomasyon.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbnpgSiparişOtomasyon.Appearance.Options.UseFont = true;
            this.rbnpgSiparişOtomasyon.Name = "rbnpgSiparişOtomasyon";
            this.rbnpgSiparişOtomasyon.Text = "SİPARİŞ OTOMASYON";
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.ExpandCollapseItem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonControl2.ExpandCollapseItem.ImageOptions.SvgImage")));
            this.ribbonControl2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.ribbonControl2.SearchEditItem,
            this.btn_Products,
            this.btn_Customers,
            this.btn_HomePage,
            this.btn_Employees,
            this.btn_Safe,
            this.btn_Invoices,
            this.btn_Settings,
            this.btnWareHouse,
            this.btnShipper,
            this.btnSupplier,
            this.btnOrders});
            this.ribbonControl2.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl2.MaxItemId = 20;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbnpage_CommercialAutomation});
            this.ribbonControl2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl2.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl2.ShowToolbarCustomizeItem = false;
            this.ribbonControl2.Size = new System.Drawing.Size(1102, 160);
            this.ribbonControl2.Toolbar.ShowCustomizeItem = false;
            // 
            // btn_Products
            // 
            this.btn_Products.Caption = "STOKLAR";
            this.btn_Products.Id = 1;
            this.btn_Products.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Products.ImageOptions.SvgImage")));
            this.btn_Products.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Products.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_Products.Name = "btn_Products";
            this.btn_Products.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Products_ItemClick);
            // 
            // btn_Customers
            // 
            this.btn_Customers.Caption = "MÜŞTERİLER";
            this.btn_Customers.Id = 3;
            this.btn_Customers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Customers.ImageOptions.SvgImage")));
            this.btn_Customers.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Customers.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_Customers.Name = "btn_Customers";
            this.btn_Customers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Customers_ItemClick);
            // 
            // btn_HomePage
            // 
            this.btn_HomePage.Caption = "ANASAYFA";
            this.btn_HomePage.Id = 5;
            this.btn_HomePage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_HomePage.ImageOptions.Image")));
            this.btn_HomePage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_HomePage.ImageOptions.LargeImage")));
            this.btn_HomePage.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_HomePage.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_HomePage.Name = "btn_HomePage";
            this.btn_HomePage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_HomePage_ItemClick);
            // 
            // btn_Employees
            // 
            this.btn_Employees.Caption = "PERSONELLER";
            this.btn_Employees.Id = 6;
            this.btn_Employees.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Employees.ImageOptions.SvgImage")));
            this.btn_Employees.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Employees.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_Employees.Name = "btn_Employees";
            this.btn_Employees.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Employees_ItemClick);
            // 
            // btn_Safe
            // 
            this.btn_Safe.Caption = "KASA";
            this.btn_Safe.Id = 8;
            this.btn_Safe.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Safe.ImageOptions.SvgImage")));
            this.btn_Safe.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Safe.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_Safe.Name = "btn_Safe";
            this.btn_Safe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Safe_ItemClick);
            // 
            // btn_Invoices
            // 
            this.btn_Invoices.Caption = "FATURALAR";
            this.btn_Invoices.Id = 12;
            this.btn_Invoices.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Invoices.ImageOptions.SvgImage")));
            this.btn_Invoices.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Invoices.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_Invoices.Name = "btn_Invoices";
            this.btn_Invoices.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Invoices_ItemClick);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Caption = "AYARLAR";
            this.btn_Settings.Id = 13;
            this.btn_Settings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Settings.ImageOptions.SvgImage")));
            this.btn_Settings.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Settings.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Settings_ItemClick);
            // 
            // btnWareHouse
            // 
            this.btnWareHouse.Caption = "DEPOLAR";
            this.btnWareHouse.Id = 16;
            this.btnWareHouse.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnWareHouse.ImageOptions.SvgImage")));
            this.btnWareHouse.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWareHouse.ItemAppearance.Normal.Options.UseFont = true;
            this.btnWareHouse.Name = "btnWareHouse";
            this.btnWareHouse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnWareHouse_ItemClick);
            // 
            // btnShipper
            // 
            this.btnShipper.Caption = "KARGOCULAR";
            this.btnShipper.Id = 17;
            this.btnShipper.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnShipper.ImageOptions.SvgImage")));
            this.btnShipper.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShipper.ItemAppearance.Normal.Options.UseFont = true;
            this.btnShipper.Name = "btnShipper";
            this.btnShipper.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShipper_ItemClick);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Caption = "TEDARİKÇİLER";
            this.btnSupplier.Id = 18;
            this.btnSupplier.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSupplier.ImageOptions.SvgImage")));
            this.btnSupplier.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSupplier.ItemAppearance.Normal.Options.UseFont = true;
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSupplier_ItemClick);
            // 
            // btnOrders
            // 
            this.btnOrders.Caption = "SİPARİŞLER";
            this.btnOrders.Id = 19;
            this.btnOrders.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOrders.ImageOptions.SvgImage")));
            this.btnOrders.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrders.ItemAppearance.Normal.Options.UseFont = true;
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOrders_ItemClick);
            // 
            // rbnpage_CommercialAutomation
            // 
            this.rbnpage_CommercialAutomation.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbnpage_CommercialAutomation.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.rbnpage_CommercialAutomation.Appearance.Options.UseFont = true;
            this.rbnpage_CommercialAutomation.Appearance.Options.UseForeColor = true;
            this.rbnpage_CommercialAutomation.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbnpage_CommercialAutomation.Name = "rbnpage_CommercialAutomation";
            this.rbnpage_CommercialAutomation.Text = "AYAZILIM SİPARİŞ OTOMASYON";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_HomePage, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_Customers);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_Products);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_Employees);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_Safe);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnOrders);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSupplier);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnWareHouse);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnShipper);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_Invoices);
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_Settings);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // FrmAnaModulEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1102, 561);
            this.Controls.Add(this.ribbonControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "FrmAnaModulEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAnaModulEmployees_FormClosed);
            this.Load += new System.EventHandler(this.FrmAnaModulEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MdiAnaModul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MdiAnaModul;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnpgSiparişOtomasyon;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl2;
        private DevExpress.XtraBars.BarButtonItem btn_Products;
        private DevExpress.XtraBars.BarButtonItem btn_Customers;
        private DevExpress.XtraBars.BarButtonItem btn_HomePage;
        private DevExpress.XtraBars.BarButtonItem btn_Employees;
        private DevExpress.XtraBars.BarButtonItem btn_Safe;
        private DevExpress.XtraBars.BarButtonItem btn_Invoices;
        private DevExpress.XtraBars.BarButtonItem btn_Settings;
        private DevExpress.XtraBars.BarButtonItem btnWareHouse;
        private DevExpress.XtraBars.BarButtonItem btnShipper;
        private DevExpress.XtraBars.BarButtonItem btnSupplier;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbnpage_CommercialAutomation;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnOrders;
    }
}