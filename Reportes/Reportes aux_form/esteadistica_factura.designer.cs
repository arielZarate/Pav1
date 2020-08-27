namespace tp_pav1.Vista
{
    partial class esteadistica_factura
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
            this.estadisticaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informe_hotel = new tp_pav1.Datos.informe_hotel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informe_hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // estadisticaBindingSource
            // 
            this.estadisticaBindingSource.DataMember = "Estadistica";
            this.estadisticaBindingSource.DataSource = this.informe_hotel;
            // 
            // informe_hotel
            // 
            this.informe_hotel.DataSetName = "informe_hotel";
            this.informe_hotel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Estadistica_huesped";
            reportDataSource1.Value = this.estadisticaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "tp_pav1.Reportes.factura_estadistica.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(31, 34);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(769, 382);
            this.reportViewer1.TabIndex = 0;
            // 
            // esteadistica_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 428);
            this.Controls.Add(this.reportViewer1);
            this.Name = "esteadistica_factura";
            this.Text = "esteadistica_factura";
            this.Load += new System.EventHandler(this.esteadistica_factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informe_hotel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource estadisticaBindingSource;
        private Datos.informe_hotel informe_hotel;
    }
}