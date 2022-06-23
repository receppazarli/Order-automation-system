
namespace OrderAutomationSystem
{
    partial class FrmHomePage
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.stocksTableAdapter = new OrderAutomationSystem.OrderAutomationSystemDataSetTableAdapters.StocksTableAdapter();
            this.stocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderAutomationSystemDataSet = new OrderAutomationSystem.OrderAutomationSystemDataSet();
            this.tablo = new DevExpress.XtraLayout.LayoutControl();
            this.txtToplamPara = new DevExpress.XtraEditors.TextEdit();
            this.txtSipariş = new DevExpress.XtraEditors.TextEdit();
            this.txtMüşteriSayısı = new DevExpress.XtraEditors.TextEdit();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.grcCustomer = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderAutomationSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.tablo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamPara.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSipariş.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMüşteriSayısı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(2, 23);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1058, 327);
            this.webBrowser1.TabIndex = 0;
            // 
            // chartControl1
            // 
            this.chartControl1.AppearanceNameSerializable = "The Trees";
            this.chartControl1.BorderOptions.Thickness = 2;
            this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.DataAdapter = this.stocksTableAdapter;
            this.chartControl1.DataSource = this.stocksBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.TextVisible = false;
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(12, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteName = "Verve";
            this.chartControl1.SeriesDataMember = "StockId";
            series1.LegendTextPattern = "{S}";
            series1.Name = "Series 1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "StockName";
            this.chartControl1.SeriesTemplate.SeriesDataMember = "StockId";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "UnitInStock";
            this.chartControl1.Size = new System.Drawing.Size(347, 318);
            this.chartControl1.TabIndex = 0;
            chartTitle1.Text = "Ürünler Tablosu";
            chartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // stocksTableAdapter
            // 
            this.stocksTableAdapter.ClearBeforeFill = true;
            // 
            // stocksBindingSource
            // 
            this.stocksBindingSource.DataMember = "Stocks";
            this.stocksBindingSource.DataSource = this.orderAutomationSystemDataSet;
            // 
            // orderAutomationSystemDataSet
            // 
            this.orderAutomationSystemDataSet.DataSetName = "OrderAutomationSystemDataSet";
            this.orderAutomationSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablo
            // 
            this.tablo.Controls.Add(this.txtToplamPara);
            this.tablo.Controls.Add(this.txtSipariş);
            this.tablo.Controls.Add(this.txtMüşteriSayısı);
            this.tablo.Controls.Add(this.webBrowser2);
            this.tablo.Controls.Add(this.grcCustomer);
            this.tablo.Controls.Add(this.chartControl1);
            this.tablo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablo.Location = new System.Drawing.Point(0, 0);
            this.tablo.Name = "tablo";
            this.tablo.Root = this.Root;
            this.tablo.Size = new System.Drawing.Size(1086, 376);
            this.tablo.TabIndex = 1;
            this.tablo.Text = "layoutControl1";
            // 
            // txtToplamPara
            // 
            this.txtToplamPara.Location = new System.Drawing.Point(869, 334);
            this.txtToplamPara.Name = "txtToplamPara";
            this.txtToplamPara.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamPara.Properties.Appearance.Options.UseFont = true;
            this.txtToplamPara.Properties.ReadOnly = true;
            this.txtToplamPara.Size = new System.Drawing.Size(205, 30);
            this.txtToplamPara.StyleController = this.tablo;
            this.txtToplamPara.TabIndex = 8;
            // 
            // txtSipariş
            // 
            this.txtSipariş.Location = new System.Drawing.Point(543, 334);
            this.txtSipariş.Name = "txtSipariş";
            this.txtSipariş.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSipariş.Properties.Appearance.Options.UseFont = true;
            this.txtSipariş.Properties.ReadOnly = true;
            this.txtSipariş.Size = new System.Drawing.Size(142, 30);
            this.txtSipariş.StyleController = this.tablo;
            this.txtSipariş.TabIndex = 7;
            // 
            // txtMüşteriSayısı
            // 
            this.txtMüşteriSayısı.Location = new System.Drawing.Point(192, 334);
            this.txtMüşteriSayısı.Name = "txtMüşteriSayısı";
            this.txtMüşteriSayısı.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMüşteriSayısı.Properties.Appearance.Options.UseFont = true;
            this.txtMüşteriSayısı.Properties.ReadOnly = true;
            this.txtMüşteriSayısı.Size = new System.Drawing.Size(167, 30);
            this.txtMüşteriSayısı.StyleController = this.tablo;
            this.txtMüşteriSayısı.TabIndex = 6;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(689, 12);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(385, 318);
            this.webBrowser2.TabIndex = 5;
            // 
            // grcCustomer
            // 
            this.grcCustomer.Location = new System.Drawing.Point(363, 12);
            this.grcCustomer.MainView = this.gridView1;
            this.grcCustomer.Name = "grcCustomer";
            this.grcCustomer.Size = new System.Drawing.Size(322, 318);
            this.grcCustomer.TabIndex = 4;
            this.grcCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.grcCustomer;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1086, 376);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chartControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(351, 322);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grcCustomer;
            this.layoutControlItem2.Location = new System.Drawing.Point(351, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(326, 322);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.webBrowser2;
            this.layoutControlItem3.Location = new System.Drawing.Point(677, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(389, 322);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.txtMüşteriSayısı;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 322);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(351, 34);
            this.layoutControlItem4.Text = "Müşteri Sayısı:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(177, 24);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.txtSipariş;
            this.layoutControlItem5.Location = new System.Drawing.Point(351, 322);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(326, 34);
            this.layoutControlItem5.Text = "Bekleyen Siparişler:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(177, 24);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.txtToplamPara;
            this.layoutControlItem6.Location = new System.Drawing.Point(677, 322);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(389, 34);
            this.layoutControlItem6.Text = "Toplam Para:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(177, 24);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(147, 376);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(100, 20);
            this.textEdit1.TabIndex = 2;
            // 
            // FrmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 376);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.tablo);
            this.Name = "FrmHomePage";
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.FrmHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderAutomationSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.tablo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtToplamPara.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSipariş.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMüşteriSayısı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraLayout.LayoutControl tablo;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private DevExpress.XtraGrid.GridControl grcCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txtSipariş;
        private DevExpress.XtraEditors.TextEdit txtMüşteriSayısı;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit txtToplamPara;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private OrderAutomationSystemDataSetTableAdapters.StocksTableAdapter stocksTableAdapter;
        private OrderAutomationSystemDataSet orderAutomationSystemDataSet;
        private System.Windows.Forms.BindingSource stocksBindingSource;
    }
}