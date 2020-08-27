namespace tp_pav1.Reportes_Facturacion
{
    partial class Estadistica_Facturacion
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
            this.Datos_EstadisticaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer_estad_factu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mes = new System.Windows.Forms.MaskedTextBox();
            this.txt_monto = new System.Windows.Forms.MaskedTextBox();
            this.Estadistica_FactuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Reportes_Facturacion = new tp_pav1.Reportes_Facturacion.DataSet_Reportes_Facturacion();
            ((System.ComponentModel.ISupportInitialize)(this.Datos_EstadisticaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Estadistica_FactuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Reportes_Facturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // Datos_EstadisticaBindingSource
            // 
            this.Datos_EstadisticaBindingSource.DataMember = "Datos Estadistica";
            // 
            // reportViewer_estad_factu
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Datos_EstadisticaBindingSource;
            this.reportViewer_estad_factu.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer_estad_factu.LocalReport.ReportEmbeddedResource = "tp_pav1.Reportes_Facturacion._Informe_Estadistica_factu.rdlc";
            this.reportViewer_estad_factu.Location = new System.Drawing.Point(26, 173);
            this.reportViewer_estad_factu.Name = "reportViewer_estad_factu";
            this.reportViewer_estad_factu.Size = new System.Drawing.Size(774, 367);
            this.reportViewer_estad_factu.TabIndex = 0;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(222, 83);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(148, 54);
            this.btn_calcular.TabIndex = 1;
            this.btn_calcular.Text = "Calcular Estadistica";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(627, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Devuelve  el total por numero de factura permitiendo definir por parametro el mes" +
    " y monto";
            // 
            // txt_mes
            // 
            this.txt_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mes.Location = new System.Drawing.Point(93, 83);
            this.txt_mes.Mask = "99";
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(56, 26);
            this.txt_mes.TabIndex = 7;
            // 
            // txt_monto
            // 
            this.txt_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto.Location = new System.Drawing.Point(93, 129);
            this.txt_monto.Mask = "9999999";
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(73, 26);
            this.txt_monto.TabIndex = 8;
            // 
            // Estadistica_FactuBindingSource
            // 
            this.Estadistica_FactuBindingSource.DataMember = "Estadistica_Factu";
            this.Estadistica_FactuBindingSource.DataSource = this.DataSet_Reportes_Facturacion;
            // 
            // DataSet_Reportes_Facturacion
            // 
            this.DataSet_Reportes_Facturacion.DataSetName = "DataSet_Reportes_Facturacion";
            this.DataSet_Reportes_Facturacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Estadistica_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 559);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.txt_mes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.reportViewer_estad_factu);
            this.Name = "Estadistica_Facturacion";
            this.Text = "Estadistica de Facturacion";
            this.Load += new System.EventHandler(this.Estadistica_Total_x_numFAc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datos_EstadisticaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Estadistica_FactuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Reportes_Facturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txt_mes;
        private System.Windows.Forms.MaskedTextBox txt_monto;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer_estad_factu;
        private System.Windows.Forms.BindingSource Datos_EstadisticaBindingSource;
        private System.Windows.Forms.BindingSource Estadistica_FactuBindingSource;
        private DataSet_Reportes_Facturacion DataSet_Reportes_Facturacion;
        //    private DataSet_Estadistica_Factura DataSet_Estadistica_Factura;
        //}
    }
}