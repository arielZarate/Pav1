namespace tp_pav1.Vista
{
    partial class ventanaABM_Instalacion
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
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.txt_IdInstalacion = new System.Windows.Forms.MaskedTextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_IdInstalacion = new System.Windows.Forms.Label();
            this.dgv_Instalacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Instalacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Buscar_Logo
            // 
            this.btn_Buscar_Logo.Click += new System.EventHandler(this.btn_Buscar_Logo_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(263, 113);
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // txt_Estado
            // 
            this.txt_Estado.Enabled = false;
            this.txt_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Estado.Location = new System.Drawing.Point(101, 211);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(94, 26);
            this.txt_Estado.TabIndex = 62;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Enabled = false;
            this.txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Location = new System.Drawing.Point(136, 162);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(219, 26);
            this.txt_Descripcion.TabIndex = 61;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.Location = new System.Drawing.Point(33, 172);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(99, 16);
            this.lbl_Descripcion.TabIndex = 60;
            this.lbl_Descripcion.Text = "Descripcion :";
            // 
            // txt_IdInstalacion
            // 
            this.txt_IdInstalacion.Enabled = false;
            this.txt_IdInstalacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdInstalacion.Location = new System.Drawing.Point(144, 119);
            this.txt_IdInstalacion.Mask = "9999";
            this.txt_IdInstalacion.Name = "txt_IdInstalacion";
            this.txt_IdInstalacion.Size = new System.Drawing.Size(76, 26);
            this.txt_IdInstalacion.TabIndex = 56;
            this.txt_IdInstalacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(34, 221);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(61, 16);
            this.lblEstado.TabIndex = 58;
            this.lblEstado.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 59;
            // 
            // lbl_IdInstalacion
            // 
            this.lbl_IdInstalacion.AutoSize = true;
            this.lbl_IdInstalacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdInstalacion.Location = new System.Drawing.Point(34, 125);
            this.lbl_IdInstalacion.Name = "lbl_IdInstalacion";
            this.lbl_IdInstalacion.Size = new System.Drawing.Size(104, 16);
            this.lbl_IdInstalacion.TabIndex = 57;
            this.lbl_IdInstalacion.Text = "Id Instalacion:";
            // 
            // dgv_Instalacion
            // 
            this.dgv_Instalacion.AllowUserToAddRows = false;
            this.dgv_Instalacion.AllowUserToDeleteRows = false;
            this.dgv_Instalacion.AllowUserToResizeColumns = false;
            this.dgv_Instalacion.AllowUserToResizeRows = false;
            this.dgv_Instalacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Instalacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Instalacion.Location = new System.Drawing.Point(36, 266);
            this.dgv_Instalacion.MultiSelect = false;
            this.dgv_Instalacion.Name = "dgv_Instalacion";
            this.dgv_Instalacion.RowHeadersVisible = false;
            this.dgv_Instalacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Instalacion.Size = new System.Drawing.Size(519, 191);
            this.dgv_Instalacion.TabIndex = 63;
            this.dgv_Instalacion.DoubleClick += new System.EventHandler(this.dgv_Instalacion_DoubleClick);
            // 
            // ventanaABM_Instalacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 475);
            this.Controls.Add(this.dgv_Instalacion);
            this.Controls.Add(this.txt_Estado);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.txt_IdInstalacion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_IdInstalacion);
            this.Name = "ventanaABM_Instalacion";
            this.Text = "ventanaABM_Instalacion";
            this.Load += new System.EventHandler(this.ventanaABM_Instalacion_Load);
            this.Controls.SetChildIndex(this.btn_Limpiar, 0);
            this.Controls.SetChildIndex(this.btn_Buscar_Logo, 0);
            this.Controls.SetChildIndex(this.btn_Guardar, 0);
            this.Controls.SetChildIndex(this.btn_Nuevo, 0);
            this.Controls.SetChildIndex(this.btn_Menu, 0);
            this.Controls.SetChildIndex(this.btn_Actualizar, 0);
            this.Controls.SetChildIndex(this.btn_Consultar, 0);
            this.Controls.SetChildIndex(this.btn_Buscar, 0);
            this.Controls.SetChildIndex(this.btn_Eliminar, 0);
            this.Controls.SetChildIndex(this.lbl_IdInstalacion, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.txt_IdInstalacion, 0);
            this.Controls.SetChildIndex(this.lbl_Descripcion, 0);
            this.Controls.SetChildIndex(this.txt_Descripcion, 0);
            this.Controls.SetChildIndex(this.txt_Estado, 0);
            this.Controls.SetChildIndex(this.dgv_Instalacion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Instalacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.MaskedTextBox txt_IdInstalacion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_IdInstalacion;
        private System.Windows.Forms.DataGridView dgv_Instalacion;
    }
}