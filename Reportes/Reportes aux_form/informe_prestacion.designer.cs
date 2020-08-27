namespace tp_pav1.Vista
{
    partial class informe_prestacion
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_patron = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.detalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informe_hotel = new tp_pav1.Datos.informe_hotel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informe_hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar según el Patrón";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_patron
            // 
            this.txt_patron.Location = new System.Drawing.Point(172, 25);
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(161, 20);
            this.txt_patron.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patrón de Busqueda";
            // 
            // detalleBindingSource
            // 
            this.detalleBindingSource.DataMember = "detalle";
            this.detalleBindingSource.DataSource = this.informe_hotel;
            // 
            // informe_hotel
            // 
            this.informe_hotel.DataSetName = "informe_hotel";
            this.informe_hotel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Detalle";
            reportDataSource1.Value = this.detalleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "tp_pav1.Reportes.detalle_informe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(37, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(686, 373);
            this.reportViewer1.TabIndex = 10;
            // 
            // informe_prestacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 495);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_patron);
            this.Controls.Add(this.label1);
            this.Name = "informe_prestacion";
            this.Text = "Informe Factura por Prestación";
            this.Load += new System.EventHandler(this.informe_prestacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informe_hotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_patron;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource detalleBindingSource;
        private Datos.informe_hotel informe_hotel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}