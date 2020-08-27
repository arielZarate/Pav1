namespace tp_pav1.Reportes
{
    partial class Reporte_Facturacion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Datos_FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_control = new System.Windows.Forms.TabControl();
            this.pagina_reporte = new System.Windows.Forms.TabPage();
            this.txt_num_fac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.reportViewer_facturacion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pagina_estadistica = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_FacturaBindingSource)).BeginInit();
            this.tab_control.SuspendLayout();
            this.pagina_reporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // Datos_FacturaBindingSource
            // 
            this.Datos_FacturaBindingSource.DataMember = "Datos_Factura";
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.pagina_reporte);
            this.tab_control.Controls.Add(this.pagina_estadistica);
            this.tab_control.Location = new System.Drawing.Point(12, 12);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(940, 600);
            this.tab_control.TabIndex = 0;
            // 
            // pagina_reporte
            // 
            this.pagina_reporte.Controls.Add(this.txt_num_fac);
            this.pagina_reporte.Controls.Add(this.label1);
            this.pagina_reporte.Controls.Add(this.btn_buscar);
            this.pagina_reporte.Controls.Add(this.reportViewer_facturacion);
            this.pagina_reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagina_reporte.Location = new System.Drawing.Point(4, 22);
            this.pagina_reporte.Name = "pagina_reporte";
            this.pagina_reporte.Padding = new System.Windows.Forms.Padding(3);
            this.pagina_reporte.Size = new System.Drawing.Size(932, 574);
            this.pagina_reporte.TabIndex = 0;
            this.pagina_reporte.Text = "Reporte";
            this.pagina_reporte.UseVisualStyleBackColor = true;
            // 
            // txt_num_fac
            // 
            this.txt_num_fac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_num_fac.Location = new System.Drawing.Point(114, 20);
            this.txt_num_fac.Name = "txt_num_fac";
            this.txt_num_fac.Size = new System.Drawing.Size(127, 26);
            this.txt_num_fac.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nº Factura:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(298, 23);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(201, 23);
            this.btn_buscar.TabIndex = 6;
            this.btn_buscar.Text = "Buscar y Generar Factura";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // reportViewer_facturacion
            // 
            this.reportViewer_facturacion.DocumentMapWidth = 98;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Datos_FacturaBindingSource;
            this.reportViewer_facturacion.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer_facturacion.LocalReport.ReportEmbeddedResource = "tp_pav1.Reportes_Facturacion.Informe_Facturacion.rdlc";
            this.reportViewer_facturacion.Location = new System.Drawing.Point(0, 82);
            this.reportViewer_facturacion.Name = "reportViewer_facturacion";
            this.reportViewer_facturacion.Size = new System.Drawing.Size(932, 490);
            this.reportViewer_facturacion.TabIndex = 0;
            this.reportViewer_facturacion.Load += new System.EventHandler(this.reportViewer_facturacion_Load);
            // 
            // pagina_estadistica
            // 
            this.pagina_estadistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagina_estadistica.Location = new System.Drawing.Point(4, 22);
            this.pagina_estadistica.Name = "pagina_estadistica";
            this.pagina_estadistica.Padding = new System.Windows.Forms.Padding(3);
            this.pagina_estadistica.Size = new System.Drawing.Size(932, 574);
            this.pagina_estadistica.TabIndex = 1;
            this.pagina_estadistica.Text = "Estadistica";
            this.pagina_estadistica.UseVisualStyleBackColor = true;
            // 
            // Reporte_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 665);
            this.Controls.Add(this.tab_control);
            this.Name = "Reporte_Facturacion";
            this.Text = "Reporte_Facturacion";
            this.Load += new System.EventHandler(this.Reporte_Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datos_FacturaBindingSource)).EndInit();
            this.tab_control.ResumeLayout(false);
            this.pagina_reporte.ResumeLayout(false);
            this.pagina_reporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage pagina_reporte;
        private System.Windows.Forms.TabPage pagina_estadistica;
        private System.Windows.Forms.BindingSource Datos_FacturaBindingSource;
        //private DataSetReporte_Facturacion DataSetReporte_Facturacion;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer_facturacion;
        private System.Windows.Forms.TextBox txt_num_fac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;

    }
}