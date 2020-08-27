namespace tp_pav1.Vista
{
    partial class ventana_Consultas_Facturacion
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
            this.dgv_Facturas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Facturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Facturas
            // 
            this.dgv_Facturas.AllowUserToAddRows = false;
            this.dgv_Facturas.AllowUserToDeleteRows = false;
            this.dgv_Facturas.AllowUserToResizeColumns = false;
            this.dgv_Facturas.AllowUserToResizeRows = false;
            this.dgv_Facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Facturas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Facturas.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_Facturas.Location = new System.Drawing.Point(12, 68);
            this.dgv_Facturas.MultiSelect = false;
            this.dgv_Facturas.Name = "dgv_Facturas";
            this.dgv_Facturas.ReadOnly = true;
            this.dgv_Facturas.RowHeadersVisible = false;
            this.dgv_Facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Facturas.Size = new System.Drawing.Size(883, 290);
            this.dgv_Facturas.TabIndex = 36;
            this.dgv_Facturas.DoubleClick += new System.EventHandler(this.dgv_Facturas_DoubleClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "Listado de Facturas";
            // 
            // ventana_Consultas_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Facturas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventana_Consultas_Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.ventana_Consultas_Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Facturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgv_Facturas;
    }
}