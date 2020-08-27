namespace tp_pav1.Vista
{
    partial class ventanaABM_Empleado
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
            this.txt_apeEmpleado = new System.Windows.Forms.TextBox();
            this.txt_nomEmpleado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_Empleado = new System.Windows.Forms.DataGridView();
            this.txt_FechaIngresoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.cbo_Hotel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLegajoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.cbo_Puesto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleado)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click_1);
            // 
            // btn_Menu
            // 
            this.btn_Menu.TabIndex = 9;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.TabIndex = 10;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Buscar_Logo
            // 
            this.btn_Buscar_Logo.TabIndex = 11;
            this.btn_Buscar_Logo.Click += new System.EventHandler(this.btn_Buscar_Logo_Click_1);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(317, 133);
            this.btn_Buscar.Size = new System.Drawing.Size(148, 32);
            this.btn_Buscar.Text = "Buscar por Legajo";
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.TabIndex = 12;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.TabIndex = 13;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // txt_apeEmpleado
            // 
            this.txt_apeEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apeEmpleado.Location = new System.Drawing.Point(106, 223);
            this.txt_apeEmpleado.MaxLength = 40;
            this.txt_apeEmpleado.Name = "txt_apeEmpleado";
            this.txt_apeEmpleado.Size = new System.Drawing.Size(299, 26);
            this.txt_apeEmpleado.TabIndex = 2;
            // 
            // txt_nomEmpleado
            // 
            this.txt_nomEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomEmpleado.Location = new System.Drawing.Point(106, 180);
            this.txt_nomEmpleado.MaxLength = 50;
            this.txt_nomEmpleado.Name = "txt_nomEmpleado";
            this.txt_nomEmpleado.Size = new System.Drawing.Size(359, 26);
            this.txt_nomEmpleado.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Lista de empleados";
            // 
            // dgv_Empleado
            // 
            this.dgv_Empleado.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgv_Empleado.AllowUserToAddRows = false;
            this.dgv_Empleado.AllowUserToDeleteRows = false;
            this.dgv_Empleado.AllowUserToResizeColumns = false;
            this.dgv_Empleado.AllowUserToResizeRows = false;
            this.dgv_Empleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Empleado.Location = new System.Drawing.Point(38, 439);
            this.dgv_Empleado.MultiSelect = false;
            this.dgv_Empleado.Name = "dgv_Empleado";
            this.dgv_Empleado.RowHeadersVisible = false;
            this.dgv_Empleado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Empleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Empleado.Size = new System.Drawing.Size(579, 226);
            this.dgv_Empleado.TabIndex = 55;
            this.dgv_Empleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Empleado_CellDoubleClick);
            // 
            // txt_FechaIngresoEmpleado
            // 
            this.txt_FechaIngresoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FechaIngresoEmpleado.Location = new System.Drawing.Point(147, 267);
            this.txt_FechaIngresoEmpleado.Mask = "00/00/0000";
            this.txt_FechaIngresoEmpleado.Name = "txt_FechaIngresoEmpleado";
            this.txt_FechaIngresoEmpleado.Size = new System.Drawing.Size(106, 26);
            this.txt_FechaIngresoEmpleado.TabIndex = 3;
            this.txt_FechaIngresoEmpleado.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txt_FechaIngresoEmpleado.ValidatingType = typeof(System.DateTime);
            // 
            // cbo_Hotel
            // 
            this.cbo_Hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Hotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Hotel.FormattingEnabled = true;
            this.cbo_Hotel.Location = new System.Drawing.Point(102, 318);
            this.cbo_Hotel.Name = "cbo_Hotel";
            this.cbo_Hotel.Size = new System.Drawing.Size(333, 28);
            this.cbo_Hotel.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 54;
            this.label8.Text = "Id Hotel:";
            // 
            // txtLegajoEmpleado
            // 
            this.txtLegajoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLegajoEmpleado.Location = new System.Drawing.Point(102, 135);
            this.txtLegajoEmpleado.Mask = "0000";
            this.txtLegajoEmpleado.Name = "txtLegajoEmpleado";
            this.txtLegajoEmpleado.Size = new System.Drawing.Size(76, 26);
            this.txtLegajoEmpleado.TabIndex = 0;
            this.txtLegajoEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbo_Puesto
            // 
            this.cbo_Puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Puesto.FormattingEnabled = true;
            this.cbo_Puesto.Location = new System.Drawing.Point(102, 364);
            this.cbo_Puesto.Name = "cbo_Puesto";
            this.cbo_Puesto.Size = new System.Drawing.Size(147, 28);
            this.cbo_Puesto.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 49;
            this.label7.Text = "Puesto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Fecha Ingreso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Legajo:";
            // 
            // ventanaABM_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 677);
            this.Controls.Add(this.txt_apeEmpleado);
            this.Controls.Add(this.txt_nomEmpleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgv_Empleado);
            this.Controls.Add(this.txt_FechaIngresoEmpleado);
            this.Controls.Add(this.cbo_Hotel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLegajoEmpleado);
            this.Controls.Add(this.cbo_Puesto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ventanaABM_Empleado";
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.ventanaABM_Empleado_Load);
            this.Controls.SetChildIndex(this.btn_Limpiar, 0);
            this.Controls.SetChildIndex(this.btn_Buscar_Logo, 0);
            this.Controls.SetChildIndex(this.btn_Guardar, 0);
            this.Controls.SetChildIndex(this.btn_Nuevo, 0);
            this.Controls.SetChildIndex(this.btn_Menu, 0);
            this.Controls.SetChildIndex(this.btn_Actualizar, 0);
            this.Controls.SetChildIndex(this.btn_Consultar, 0);
            this.Controls.SetChildIndex(this.btn_Buscar, 0);
            this.Controls.SetChildIndex(this.btn_Eliminar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cbo_Puesto, 0);
            this.Controls.SetChildIndex(this.txtLegajoEmpleado, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cbo_Hotel, 0);
            this.Controls.SetChildIndex(this.txt_FechaIngresoEmpleado, 0);
            this.Controls.SetChildIndex(this.dgv_Empleado, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txt_nomEmpleado, 0);
            this.Controls.SetChildIndex(this.txt_apeEmpleado, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Empleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_apeEmpleado;
        private System.Windows.Forms.TextBox txt_nomEmpleado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_Empleado;
        private System.Windows.Forms.MaskedTextBox txt_FechaIngresoEmpleado;
        private System.Windows.Forms.ComboBox cbo_Hotel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtLegajoEmpleado;
        private System.Windows.Forms.ComboBox cbo_Puesto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}