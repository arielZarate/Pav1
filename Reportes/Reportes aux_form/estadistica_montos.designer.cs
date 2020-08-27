namespace tp_pav1.Vista
{
    partial class estadistica_montos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.informe_hotel = new tp_pav1.Datos.informe_hotel();
            this.estadisticaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.informe_hotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "estadis_monto";
            reportDataSource1.Value = this.estadisticaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "tp_pav1.Reportes.estadistica_moto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(692, 416);
            this.reportViewer1.TabIndex = 0;
            // 
            // informe_hotel
            // 
            this.informe_hotel.DataSetName = "informe_hotel";
            this.informe_hotel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadisticaBindingSource
            // 
            this.estadisticaBindingSource.DataMember = "Estadistica";
            this.estadisticaBindingSource.DataSource = this.informe_hotel;
            // 
            // estadistica_montos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 500);
            this.Controls.Add(this.reportViewer1);
            this.Name = "estadistica_montos";
            this.Text = "Montos Estadisticos";
            this.Load += new System.EventHandler(this.estadistica_montos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informe_hotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadisticaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource estadisticaBindingSource;
        private Datos.informe_hotel informe_hotel;
    }
}