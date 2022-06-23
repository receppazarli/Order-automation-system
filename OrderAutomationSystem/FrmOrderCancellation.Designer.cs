
namespace OrderAutomationSystem
{
    partial class FrmOrderCancellation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderCancellation));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSiparişId = new DevExpress.XtraEditors.TextEdit();
            this.btnSiparişİptal2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparişId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sipariş Id:";
            // 
            // txtSiparişId
            // 
            this.txtSiparişId.Location = new System.Drawing.Point(102, 29);
            this.txtSiparişId.Name = "txtSiparişId";
            this.txtSiparişId.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSiparişId.Properties.Appearance.Options.UseFont = true;
            this.txtSiparişId.Size = new System.Drawing.Size(170, 28);
            this.txtSiparişId.TabIndex = 1;
            // 
            // btnSiparişİptal2
            // 
            this.btnSiparişİptal2.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparişİptal2.Appearance.Options.UseFont = true;
            this.btnSiparişİptal2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSiparişİptal2.ImageOptions.SvgImage")));
            this.btnSiparişİptal2.Location = new System.Drawing.Point(102, 63);
            this.btnSiparişİptal2.Name = "btnSiparişİptal2";
            this.btnSiparişİptal2.Size = new System.Drawing.Size(170, 48);
            this.btnSiparişİptal2.TabIndex = 3;
            this.btnSiparişİptal2.Text = "İPTAL ET";
            this.btnSiparişİptal2.Click += new System.EventHandler(this.btnSiparişİptal2_Click);
            // 
            // FrmOrderCancellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(292, 141);
            this.Controls.Add(this.btnSiparişİptal2);
            this.Controls.Add(this.txtSiparişId);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrderCancellation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrderCancellation";
            ((System.ComponentModel.ISupportInitialize)(this.txtSiparişId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSiparişId;
        private DevExpress.XtraEditors.SimpleButton btnSiparişİptal2;
    }
}