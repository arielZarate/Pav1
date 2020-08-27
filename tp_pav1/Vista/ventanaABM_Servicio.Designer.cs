namespace tp_pav1.Vista
{
    partial class ventanaABM_Servicio
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
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.txt_IdServicio = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Servicio = new System.Windows.Forms.Label();
            this.btn_TipoServicio = new System.Windows.Forms.Button();
            this.dgv_Servicio = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID_tipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_tipoServicio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_costo2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Servicio)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.TabIndex = 6;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.TabIndex = 7;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.TabIndex = 8;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Buscar_Logo
            // 
            this.btn_Buscar_Logo.Click += new System.EventHandler(this.btn_Buscar_Logo_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.TabIndex = 4;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(258, 120);
            this.btn_Buscar.TabIndex = 12;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.TabIndex = 10;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.TabIndex = 11;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Enabled = false;
            this.txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.Location = new System.Drawing.Point(131, 168);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(219, 26);
            this.txt_Descripcion.TabIndex = 1;
            this.txt_Descripcion.TextChanged += new System.EventHandler(this.txt_Descripcion_TextChanged);
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.Location = new System.Drawing.Point(39, 176);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(99, 16);
            this.lbl_Descripcion.TabIndex = 72;
            this.lbl_Descripcion.Text = "Descripcion :";
            this.lbl_Descripcion.Click += new System.EventHandler(this.lbl_Descripcion_Click);
            // 
            // txt_IdServicio
            // 
            this.txt_IdServicio.Enabled = false;
            this.txt_IdServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdServicio.Location = new System.Drawing.Point(131, 126);
            this.txt_IdServicio.Mask = "9999";
            this.txt_IdServicio.Name = "txt_IdServicio";
            this.txt_IdServicio.Size = new System.Drawing.Size(76, 26);
            this.txt_IdServicio.TabIndex = 0;
            this.txt_IdServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_IdServicio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt_IdServicio_MaskInputRejected);
            // 
            // lbl_Servicio
            // 
            this.lbl_Servicio.AutoSize = true;
            this.lbl_Servicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Servicio.Location = new System.Drawing.Point(40, 132);
            this.lbl_Servicio.Name = "lbl_Servicio";
            this.lbl_Servicio.Size = new System.Drawing.Size(86, 16);
            this.lbl_Servicio.TabIndex = 70;
            this.lbl_Servicio.Text = "Id Servicio:";
            // 
            // btn_TipoServicio
            // 
            this.btn_TipoServicio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_TipoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TipoServicio.ForeColor = System.Drawing.Color.Navy;
            this.btn_TipoServicio.Location = new System.Drawing.Point(353, 271);
            this.btn_TipoServicio.Name = "btn_TipoServicio";
            this.btn_TipoServicio.Size = new System.Drawing.Size(190, 27);
            this.btn_TipoServicio.TabIndex = 3;
            this.btn_TipoServicio.Text = "ventana Tipo Servicio";
            this.btn_TipoServicio.UseVisualStyleBackColor = false;
            this.btn_TipoServicio.Click += new System.EventHandler(this.btn_TipoServicio_Click);
            // 
            // dgv_Servicio
            // 
            this.dgv_Servicio.AllowUserToAddRows = false;
            this.dgv_Servicio.AllowUserToDeleteRows = false;
            this.dgv_Servicio.AllowUserToResizeColumns = false;
            this.dgv_Servicio.AllowUserToResizeRows = false;
            this.dgv_Servicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Servicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Servicio.Location = new System.Drawing.Point(38, 304);
            this.dgv_Servicio.MultiSelect = false;
            this.dgv_Servicio.Name = "dgv_Servicio";
            this.dgv_Servicio.RowHeadersVisible = false;
            this.dgv_Servicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Servicio.Size = new System.Drawing.Size(505, 182);
            this.dgv_Servicio.TabIndex = 76;
            this.dgv_Servicio.DoubleClick += new System.EventHandler(this.dgv_Servicio_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 78;
            this.label1.Text = "ID:";
            // 
            // txt_ID_tipo
            // 
            this.txt_ID_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID_tipo.Location = new System.Drawing.Point(443, 213);
            this.txt_ID_tipo.Name = "txt_ID_tipo";
            this.txt_ID_tipo.Size = new System.Drawing.Size(69, 26);
            this.txt_ID_tipo.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "Tipo Servicio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbo_tipoServicio
            // 
            this.cbo_tipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipoServicio.FormattingEnabled = true;
            this.cbo_tipoServicio.Location = new System.Drawing.Point(146, 214);
            this.cbo_tipoServicio.Name = "cbo_tipoServicio";
            this.cbo_tipoServicio.Size = new System.Drawing.Size(230, 26);
            this.cbo_tipoServicio.TabIndex = 81;
            this.cbo_tipoServicio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 82;
            this.label3.Text = "Costo:";
            // 
            // txt_costo2
            // 
            this.txt_costo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costo2.Location = new System.Drawing.Point(88, 261);
            this.txt_costo2.Name = "txt_costo2";
            this.txt_costo2.Size = new System.Drawing.Size(62, 26);
            this.txt_costo2.TabIndex = 83;
            this.txt_costo2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ventanaABM_Servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 508);
            this.Controls.Add(this.txt_costo2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_tipoServicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ID_tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Servicio);
            this.Controls.Add(this.btn_TipoServicio);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.txt_IdServicio);
            this.Controls.Add(this.lbl_Servicio);
            this.Name = "ventanaABM_Servicio";
            this.Text = "Servicio";
            this.Load += new System.EventHandler(this.ventanaABM_Servicio_Load);
            this.Controls.SetChildIndex(this.btn_Limpiar, 0);
            this.Controls.SetChildIndex(this.btn_Buscar_Logo, 0);
            this.Controls.SetChildIndex(this.btn_Guardar, 0);
            this.Controls.SetChildIndex(this.btn_Nuevo, 0);
            this.Controls.SetChildIndex(this.btn_Menu, 0);
            this.Controls.SetChildIndex(this.btn_Actualizar, 0);
            this.Controls.SetChildIndex(this.btn_Consultar, 0);
            this.Controls.SetChildIndex(this.btn_Buscar, 0);
            this.Controls.SetChildIndex(this.btn_Eliminar, 0);
            this.Controls.SetChildIndex(this.lbl_Servicio, 0);
            this.Controls.SetChildIndex(this.txt_IdServicio, 0);
            this.Controls.SetChildIndex(this.lbl_Descripcion, 0);
            this.Controls.SetChildIndex(this.txt_Descripcion, 0);
            this.Controls.SetChildIndex(this.btn_TipoServicio, 0);
            this.Controls.SetChildIndex(this.dgv_Servicio, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_ID_tipo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbo_tipoServicio, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt_costo2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Servicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.MaskedTextBox txt_IdServicio;
        private System.Windows.Forms.Label lbl_Servicio;
        private System.Windows.Forms.Button btn_TipoServicio;
        private System.Windows.Forms.DataGridView dgv_Servicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID_tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_tipoServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_costo2;
    }
}