namespace tp_pav1.Vista
{
    partial class ventanaABM_Hotel
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
            this.dgv_Hotel = new System.Windows.Forms.DataGridView();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_registrado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_selec_hotel = new System.Windows.Forms.Button();
            this.btn_EliminarRegistro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hotel)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(178, 67);
            this.btn_Actualizar.TabIndex = 6;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(243, 67);
            this.btn_Menu.TabIndex = 7;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(112, 67);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(308, 67);
            this.btn_Limpiar.TabIndex = 8;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Buscar_Logo
            // 
            this.btn_Buscar_Logo.Location = new System.Drawing.Point(374, 67);
            this.btn_Buscar_Logo.Click += new System.EventHandler(this.btn_Buscar_Logo_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(48, 67);
            this.btn_Nuevo.TabIndex = 4;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(255, 141);
            this.btn_Buscar.Size = new System.Drawing.Size(112, 32);
            this.btn_Buscar.TabIndex = 12;
            this.btn_Buscar.Text = "Buscar por ID";
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.Location = new System.Drawing.Point(439, 67);
            this.btn_Consultar.TabIndex = 10;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(505, 67);
            this.btn_Eliminar.TabIndex = 11;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // dgv_Hotel
            // 
            this.dgv_Hotel.AllowUserToAddRows = false;
            this.dgv_Hotel.AllowUserToDeleteRows = false;
            this.dgv_Hotel.AllowUserToResizeColumns = false;
            this.dgv_Hotel.AllowUserToResizeRows = false;
            this.dgv_Hotel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Hotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Hotel.Location = new System.Drawing.Point(48, 334);
            this.dgv_Hotel.MultiSelect = false;
            this.dgv_Hotel.Name = "dgv_Hotel";
            this.dgv_Hotel.RowHeadersVisible = false;
            this.dgv_Hotel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Hotel.Size = new System.Drawing.Size(505, 166);
            this.dgv_Hotel.TabIndex = 17;
            this.dgv_Hotel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Hotel_CellDoubleClick);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(142, 239);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(253, 26);
            this.txt_descripcion.TabIndex = 2;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre.Location = new System.Drawing.Point(119, 193);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(277, 26);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(119, 147);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 26);
            this.txt_id.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID Hotel:";
            // 
            // txt_registrado
            // 
            this.txt_registrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_registrado.Location = new System.Drawing.Point(142, 289);
            this.txt_registrado.Name = "txt_registrado";
            this.txt_registrado.Size = new System.Drawing.Size(214, 26);
            this.txt_registrado.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Registrado:";
            // 
            // btn_selec_hotel
            // 
            this.btn_selec_hotel.Location = new System.Drawing.Point(419, 239);
            this.btn_selec_hotel.Name = "btn_selec_hotel";
            this.btn_selec_hotel.Size = new System.Drawing.Size(134, 39);
            this.btn_selec_hotel.TabIndex = 18;
            this.btn_selec_hotel.Text = "Seleccionar  Registro";
            this.btn_selec_hotel.UseVisualStyleBackColor = true;
            this.btn_selec_hotel.Click += new System.EventHandler(this.btn_selec_hotel_Click);
            // 
            // btn_EliminarRegistro
            // 
            this.btn_EliminarRegistro.Location = new System.Drawing.Point(419, 284);
            this.btn_EliminarRegistro.Name = "btn_EliminarRegistro";
            this.btn_EliminarRegistro.Size = new System.Drawing.Size(134, 39);
            this.btn_EliminarRegistro.TabIndex = 21;
            this.btn_EliminarRegistro.Text = "Eliminar Registro";
            this.btn_EliminarRegistro.UseVisualStyleBackColor = true;
            this.btn_EliminarRegistro.Click += new System.EventHandler(this.btn_EliminarRegistro_Click);
            // 
            // ventanaABM_Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 512);
            this.Controls.Add(this.btn_EliminarRegistro);
            this.Controls.Add(this.txt_registrado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_selec_hotel);
            this.Controls.Add(this.dgv_Hotel);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ventanaABM_Hotel";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.ventanaABM_Hotel_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txt_id, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.txt_descripcion, 0);
            this.Controls.SetChildIndex(this.dgv_Hotel, 0);
            this.Controls.SetChildIndex(this.btn_selec_hotel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txt_registrado, 0);
            this.Controls.SetChildIndex(this.btn_Limpiar, 0);
            this.Controls.SetChildIndex(this.btn_Buscar_Logo, 0);
            this.Controls.SetChildIndex(this.btn_Guardar, 0);
            this.Controls.SetChildIndex(this.btn_Nuevo, 0);
            this.Controls.SetChildIndex(this.btn_Menu, 0);
            this.Controls.SetChildIndex(this.btn_Actualizar, 0);
            this.Controls.SetChildIndex(this.btn_Consultar, 0);
            this.Controls.SetChildIndex(this.btn_Buscar, 0);
            this.Controls.SetChildIndex(this.btn_Eliminar, 0);
            this.Controls.SetChildIndex(this.btn_EliminarRegistro, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Hotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Hotel;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_registrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_selec_hotel;
        private System.Windows.Forms.Button btn_EliminarRegistro;
    }
}