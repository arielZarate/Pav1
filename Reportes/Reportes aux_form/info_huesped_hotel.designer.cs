namespace tp_pav1.Vista
{
    partial class info_huesped_hotel
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
            this.huespedesinformeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txt_patron = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.informe_hotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huespedesinformeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "hotel_hues";
            reportDataSource1.Value = this.huespedesinformeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "tp_pav1.Reportes.hues_hotel_infor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 44);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(741, 392);
            this.reportViewer1.TabIndex = 0;
            // 
            // informe_hotel
            // 
            this.informe_hotel.DataSetName = "informe_hotel";
            this.informe_hotel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // huespedesinformeBindingSource
            // 
            this.huespedesinformeBindingSource.DataMember = "huespedes_informe";
            this.huespedesinformeBindingSource.DataSource = this.informe_hotel;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar según el Patrón";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_patron
            // 
            this.txt_patron.Location = new System.Drawing.Point(147, 16);
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(161, 20);
            this.txt_patron.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Patrón de Busqueda";
            // 
            // info_huesped_hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_patron);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "info_huesped_hotel";
            this.Text = "Informe de Huesped por Hotel";
            this.Load += new System.EventHandler(this.info_huesped_hotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informe_hotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huespedesinformeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource huespedesinformeBindingSource;
        private Datos.informe_hotel informe_hotel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_patron;
        private System.Windows.Forms.Label label1;
    }
}