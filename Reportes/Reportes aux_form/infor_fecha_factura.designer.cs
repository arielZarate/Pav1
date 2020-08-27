namespace tp_pav1.Vista
{
    partial class infor_fecha_factura
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.informe_hotel = new tp_pav1.Datos.informe_hotel();
            this.facturainformeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txt_patron = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.informe_hotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturainformeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "fecha_factura";
            reportDataSource2.Value = this.facturainformeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "tp_pav1.Reportes.infor_fecha_fac.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(33, 52);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(714, 384);
            this.reportViewer1.TabIndex = 0;
            // 
            // informe_hotel
            // 
            this.informe_hotel.DataSetName = "informe_hotel";
            this.informe_hotel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturainformeBindingSource
            // 
            this.facturainformeBindingSource.DataMember = "factura_informe";
            this.facturainformeBindingSource.DataSource = this.informe_hotel;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar según el Patrón";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_patron
            // 
            this.txt_patron.Location = new System.Drawing.Point(145, 12);
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(161, 20);
            this.txt_patron.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Patrón de Busqueda";
            // 
            // infor_fecha_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 517);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_patron);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "infor_fecha_factura";
            this.Text = "Informe de Facturas por Fecha";
            this.Load += new System.EventHandler(this.infor_fecha_factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informe_hotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturainformeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource facturainformeBindingSource;
        private Datos.informe_hotel informe_hotel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_patron;
        private System.Windows.Forms.Label label1;
    }
}