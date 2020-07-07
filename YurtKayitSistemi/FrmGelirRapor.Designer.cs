namespace YurtKayitSistemi
{
    partial class FrmGelirRapor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelirRapor));
            this.KasaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Proje_YurtOtomasyonuDataSet1 = new YurtKayitSistemi.Proje_YurtOtomasyonuDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KasaTableAdapter = new YurtKayitSistemi.Proje_YurtOtomasyonuDataSet1TableAdapters.KasaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KasaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proje_YurtOtomasyonuDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // KasaBindingSource
            // 
            this.KasaBindingSource.DataMember = "Kasa";
            this.KasaBindingSource.DataSource = this.Proje_YurtOtomasyonuDataSet1;
            // 
            // Proje_YurtOtomasyonuDataSet1
            // 
            this.Proje_YurtOtomasyonuDataSet1.DataSetName = "Proje_YurtOtomasyonuDataSet1";
            this.Proje_YurtOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KasaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YurtKayitSistemi.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1312, 387);
            this.reportViewer1.TabIndex = 0;
            // 
            // KasaTableAdapter
            // 
            this.KasaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGelirRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1312, 387);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGelirRapor";
            this.Text = "Gelir Rapor";
            this.Load += new System.EventHandler(this.FrmGelirRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KasaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proje_YurtOtomasyonuDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KasaBindingSource;
        private Proje_YurtOtomasyonuDataSet1 Proje_YurtOtomasyonuDataSet1;
        private Proje_YurtOtomasyonuDataSet1TableAdapters.KasaTableAdapter KasaTableAdapter;
    }
}