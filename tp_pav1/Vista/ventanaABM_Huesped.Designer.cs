namespace tp_pav1.Vista
{
    partial class ventanaABM_Huesped
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
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lbl_DNI = new System.Windows.Forms.Label();
            this.txt_Dni = new System.Windows.Forms.MaskedTextBox();
            this.dgv_Huesped = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_tipoDocumento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Id_TipoDocumento = new System.Windows.Forms.TextBox();
            this.txt_numTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.btn_tipoDocumento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Huesped)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
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
            this.btn_Buscar_Logo.Location = new System.Drawing.Point(496, 50);
            this.btn_Buscar_Logo.Click += new System.EventHandler(this.btn_Buscar_Logo_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(310, 203);
            this.btn_Buscar.Size = new System.Drawing.Size(144, 32);
            this.btn_Buscar.Text = "Buscar por Dni";
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(366, 50);
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(428, 50);
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Enabled = false;
            this.txt_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido.Location = new System.Drawing.Point(109, 308);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(179, 26);
            this.txt_Apellido.TabIndex = 88;
            this.txt_Apellido.TextChanged += new System.EventHandler(this.txt_Estado_TextChanged);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(103, 258);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(301, 26);
            this.txt_Nombre.TabIndex = 87;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.txt_Descripcion_TextChanged);
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descripcion.Location = new System.Drawing.Point(36, 268);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(67, 16);
            this.lbl_Descripcion.TabIndex = 86;
            this.lbl_Descripcion.Text = "Nombre:";
            this.lbl_Descripcion.Click += new System.EventHandler(this.lbl_Descripcion_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(36, 318);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(70, 16);
            this.lblEstado.TabIndex = 85;
            this.lblEstado.Text = "Apellido:";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // lbl_DNI
            // 
            this.lbl_DNI.AutoSize = true;
            this.lbl_DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DNI.Location = new System.Drawing.Point(36, 219);
            this.lbl_DNI.Name = "lbl_DNI";
            this.lbl_DNI.Size = new System.Drawing.Size(38, 16);
            this.lbl_DNI.TabIndex = 84;
            this.lbl_DNI.Text = "DNI:";
            this.lbl_DNI.Click += new System.EventHandler(this.lbl_IdInstalacion_Click);
            // 
            // txt_Dni
            // 
            this.txt_Dni.Enabled = false;
            this.txt_Dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Dni.Location = new System.Drawing.Point(86, 209);
            this.txt_Dni.Mask = "99999999";
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(130, 26);
            this.txt_Dni.TabIndex = 83;
            // 
            // dgv_Huesped
            // 
            this.dgv_Huesped.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgv_Huesped.AllowUserToAddRows = false;
            this.dgv_Huesped.AllowUserToDeleteRows = false;
            this.dgv_Huesped.AllowUserToResizeColumns = false;
            this.dgv_Huesped.AllowUserToResizeRows = false;
            this.dgv_Huesped.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Huesped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Huesped.Location = new System.Drawing.Point(38, 417);
            this.dgv_Huesped.MultiSelect = false;
            this.dgv_Huesped.Name = "dgv_Huesped";
            this.dgv_Huesped.RowHeadersVisible = false;
            this.dgv_Huesped.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Huesped.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Huesped.Size = new System.Drawing.Size(547, 222);
            this.dgv_Huesped.TabIndex = 89;
            this.dgv_Huesped.DoubleClick += new System.EventHandler(this.dgv_Huesped_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 90;
            this.label1.Text = "Nº Tarjeta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 91;
            this.label2.Text = "ID tipo Dni:";
            // 
            // cbo_tipoDocumento
            // 
            this.cbo_tipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipoDocumento.FormattingEnabled = true;
            this.cbo_tipoDocumento.Location = new System.Drawing.Point(168, 153);
            this.cbo_tipoDocumento.Name = "cbo_tipoDocumento";
            this.cbo_tipoDocumento.Size = new System.Drawing.Size(343, 28);
            this.cbo_tipoDocumento.TabIndex = 92;
            this.cbo_tipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cbo_tipoDocumento_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 93;
            this.label3.Text = "Tipo Documento:";
            // 
            // txt_Id_TipoDocumento
            // 
            this.txt_Id_TipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id_TipoDocumento.Location = new System.Drawing.Point(126, 115);
            this.txt_Id_TipoDocumento.Name = "txt_Id_TipoDocumento";
            this.txt_Id_TipoDocumento.Size = new System.Drawing.Size(77, 26);
            this.txt_Id_TipoDocumento.TabIndex = 94;
            // 
            // txt_numTarjeta
            // 
            this.txt_numTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numTarjeta.Location = new System.Drawing.Point(125, 352);
            this.txt_numTarjeta.Mask = "99999999";
            this.txt_numTarjeta.Name = "txt_numTarjeta";
            this.txt_numTarjeta.Size = new System.Drawing.Size(136, 26);
            this.txt_numTarjeta.TabIndex = 95;
            // 
            // btn_tipoDocumento
            // 
            this.btn_tipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tipoDocumento.Location = new System.Drawing.Point(428, 330);
            this.btn_tipoDocumento.Name = "btn_tipoDocumento";
            this.btn_tipoDocumento.Size = new System.Drawing.Size(131, 48);
            this.btn_tipoDocumento.TabIndex = 96;
            this.btn_tipoDocumento.Text = "Tipo Documento";
            this.btn_tipoDocumento.UseVisualStyleBackColor = true;
            this.btn_tipoDocumento.Click += new System.EventHandler(this.btn_tipoDocumento_Click);
            // 
            // ventanaABM_Huesped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 651);
            this.Controls.Add(this.btn_tipoDocumento);
            this.Controls.Add(this.txt_numTarjeta);
            this.Controls.Add(this.txt_Id_TipoDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbo_tipoDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Huesped);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lbl_DNI);
            this.Name = "ventanaABM_Huesped";
            this.Text = "Huesped";
            this.Load += new System.EventHandler(this.ventanaABM_Huesped_Load);
            this.Controls.SetChildIndex(this.lbl_DNI, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.txt_Dni, 0);
            this.Controls.SetChildIndex(this.lbl_Descripcion, 0);
            this.Controls.SetChildIndex(this.txt_Nombre, 0);
            this.Controls.SetChildIndex(this.txt_Apellido, 0);
            this.Controls.SetChildIndex(this.btn_Limpiar, 0);
            this.Controls.SetChildIndex(this.btn_Buscar_Logo, 0);
            this.Controls.SetChildIndex(this.btn_Guardar, 0);
            this.Controls.SetChildIndex(this.btn_Nuevo, 0);
            this.Controls.SetChildIndex(this.btn_Menu, 0);
            this.Controls.SetChildIndex(this.btn_Actualizar, 0);
            this.Controls.SetChildIndex(this.btn_Consultar, 0);
            this.Controls.SetChildIndex(this.btn_Buscar, 0);
            this.Controls.SetChildIndex(this.btn_Eliminar, 0);
            this.Controls.SetChildIndex(this.dgv_Huesped, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbo_tipoDocumento, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt_Id_TipoDocumento, 0);
            this.Controls.SetChildIndex(this.txt_numTarjeta, 0);
            this.Controls.SetChildIndex(this.btn_tipoDocumento, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Huesped)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lbl_DNI;
        private System.Windows.Forms.MaskedTextBox txt_Dni;
        private System.Windows.Forms.DataGridView dgv_Huesped;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_tipoDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Id_TipoDocumento;
        private System.Windows.Forms.MaskedTextBox txt_numTarjeta;
        private System.Windows.Forms.Button btn_tipoDocumento;
    }
}