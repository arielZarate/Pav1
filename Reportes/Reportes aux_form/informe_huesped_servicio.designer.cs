namespace tp_pav1.Vista
{
    partial class informe_huesped_servicio
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_patron = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.huespedesinformeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.informe_hotel = new tp_pav1.Datos.informe_hotel();
            ((System.ComponentModel.ISupportInitialize)(this.huespedesinformeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informe_hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar según el Patrón";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_patron
            // 
            this.txt_patron.Location = new System.Drawing.Point(158, 19);
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(161, 20);
            this.txt_patron.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patrón de Busqueda";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "hues_x_serv";
            reportDataSource2.Value = this.huespedesinformeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "tp_pav1.Reportes.hues_x_serv_informe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(51, 47);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(849, 392);
            this.reportViewer1.TabIndex = 7;
            // 
            // huespedesinformeBindingSource
            // 
            this.huespedesinformeBindingSource.DataMember = "huespedes_informe";
            this.huespedesinformeBindingSource.DataSource = this.informe_hotel;
            // 
            // informe_hotel
            // 
            this.informe_hotel.DataSetName = "informe_hotel";
            this.informe_hotel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // informe_huesped_servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 487);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_patron);
            this.Controls.Add(this.label1);
            this.Name = "informe_huesped_servicio";
            this.Text = "Informe";
            this.Load += new System.EventHandler(this.informe_huesped_servicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.huespedesinformeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informe_hotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_patron;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource huespedesinformeBindingSource;
        private Datos.informe_hotel informe_hotel;
    }
}