namespace tp_pav1.Vista
{
    partial class ventana_Facturacion
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
            this.btn_Colocar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Huesped = new System.Windows.Forms.Button();
            this.btn_Facturar = new System.Windows.Forms.Button();
            this.btn_ConsultarFactu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Huesped = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dni_huesped = new System.Windows.Forms.TextBox();
            this.txt_nombre_huesped = new System.Windows.Forms.TextBox();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txt_vendedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dgv_factu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.dgv_huesped = new System.Windows.Forms.DataGridView();
            this.dgv_habitacion = new System.Windows.Forms.DataGridView();
            this.dgv_servicio = new System.Windows.Forms.DataGridView();
            this.dgv_instalacion = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.cbo_hotel = new System.Windows.Forms.ComboBox();
            this.txt_n_factura = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_refrescar_huesped = new System.Windows.Forms.Button();
            this.group_huesped = new System.Windows.Forms.GroupBox();
            this.txt_tipo_Doc = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_factu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_huesped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_habitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instalacion)).BeginInit();
            this.group_huesped.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Colocar
            // 
            this.btn_Colocar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Colocar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Colocar.Location = new System.Drawing.Point(613, 399);
            this.btn_Colocar.Name = "btn_Colocar";
            this.btn_Colocar.Size = new System.Drawing.Size(141, 38);
            this.btn_Colocar.TabIndex = 0;
            this.btn_Colocar.Text = "Colocar";
            this.btn_Colocar.UseVisualStyleBackColor = true;
            this.btn_Colocar.Click += new System.EventHandler(this.btn_Colocar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Eliminar.Location = new System.Drawing.Point(613, 458);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(141, 38);
            this.btn_Eliminar.TabIndex = 1;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Huesped
            // 
            this.btn_Huesped.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Huesped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huesped.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Huesped.Location = new System.Drawing.Point(643, 139);
            this.btn_Huesped.Name = "btn_Huesped";
            this.btn_Huesped.Size = new System.Drawing.Size(141, 40);
            this.btn_Huesped.TabIndex = 2;
            this.btn_Huesped.Text = "Nuevo Huesped";
            this.btn_Huesped.UseVisualStyleBackColor = false;
            this.btn_Huesped.Click += new System.EventHandler(this.btn_Huesped_Click);
            // 
            // btn_Facturar
            // 
            this.btn_Facturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Facturar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Facturar.Location = new System.Drawing.Point(613, 586);
            this.btn_Facturar.Name = "btn_Facturar";
            this.btn_Facturar.Size = new System.Drawing.Size(141, 38);
            this.btn_Facturar.TabIndex = 6;
            this.btn_Facturar.Text = "Facturar";
            this.btn_Facturar.UseVisualStyleBackColor = true;
            this.btn_Facturar.Click += new System.EventHandler(this.btn_Facturar_Click);
            // 
            // btn_ConsultarFactu
            // 
            this.btn_ConsultarFactu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ConsultarFactu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConsultarFactu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ConsultarFactu.Location = new System.Drawing.Point(33, 257);
            this.btn_ConsultarFactu.Name = "btn_ConsultarFactu";
            this.btn_ConsultarFactu.Size = new System.Drawing.Size(269, 31);
            this.btn_ConsultarFactu.TabIndex = 7;
            this.btn_ConsultarFactu.Text = "Consultar Facturacion";
            this.btn_ConsultarFactu.UseVisualStyleBackColor = false;
            this.btn_ConsultarFactu.Click += new System.EventHandler(this.btn_ConsultarFactu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hotel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lo Atiende:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Huesped
            // 
            this.Huesped.AutoSize = true;
            this.Huesped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Huesped.Location = new System.Drawing.Point(6, 66);
            this.Huesped.Name = "Huesped";
            this.Huesped.Size = new System.Drawing.Size(75, 16);
            this.Huesped.TabIndex = 12;
            this.Huesped.Text = "Huesped:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(822, 725);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total:";
            // 
            // txt_dni_huesped
            // 
            this.txt_dni_huesped.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dni_huesped.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_dni_huesped.Location = new System.Drawing.Point(271, 21);
            this.txt_dni_huesped.Name = "txt_dni_huesped";
            this.txt_dni_huesped.Size = new System.Drawing.Size(171, 24);
            this.txt_dni_huesped.TabIndex = 15;
            this.txt_dni_huesped.TextChanged += new System.EventHandler(this.txt_ID_Codigo_TextChanged);
            // 
            // txt_nombre_huesped
            // 
            this.txt_nombre_huesped.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_huesped.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_nombre_huesped.Location = new System.Drawing.Point(84, 58);
            this.txt_nombre_huesped.Name = "txt_nombre_huesped";
            this.txt_nombre_huesped.Size = new System.Drawing.Size(330, 24);
            this.txt_nombre_huesped.TabIndex = 16;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Nuevo.Location = new System.Drawing.Point(612, 336);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(141, 38);
            this.btn_Nuevo.TabIndex = 18;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(862, 709);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(79, 29);
            this.textBox5.TabIndex = 21;
            // 
            // txt_vendedor
            // 
            this.txt_vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vendedor.Location = new System.Drawing.Point(284, 42);
            this.txt_vendedor.Name = "txt_vendedor";
            this.txt_vendedor.Size = new System.Drawing.Size(151, 24);
            this.txt_vendedor.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nº:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tipo Documento:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // dgv_factu
            // 
            this.dgv_factu.AllowUserToAddRows = false;
            this.dgv_factu.AllowUserToDeleteRows = false;
            this.dgv_factu.AllowUserToResizeColumns = false;
            this.dgv_factu.AllowUserToResizeRows = false;
            this.dgv_factu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_factu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dgv_factu.Location = new System.Drawing.Point(33, 340);
            this.dgv_factu.Name = "dgv_factu";
            this.dgv_factu.ReadOnly = true;
            this.dgv_factu.RowHeadersVisible = false;
            this.dgv_factu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_factu.Size = new System.Drawing.Size(555, 272);
            this.dgv_factu.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 11.41883F;
            this.Column1.HeaderText = "codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 86.0317F;
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 190;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 59.42231F;
            this.Column3.HeaderText = "Costo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 89.32005F;
            this.Column5.HeaderText = "Cantidad";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 253.8071F;
            this.Column4.HeaderText = "Importe";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtCod.Location = new System.Drawing.Point(33, 307);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(76, 26);
            this.txtCod.TabIndex = 31;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtDesc.Location = new System.Drawing.Point(113, 307);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(187, 26);
            this.txtDesc.TabIndex = 32;
            // 
            // txtCosto
            // 
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtCosto.Location = new System.Drawing.Point(306, 307);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(75, 26);
            this.txtCosto.TabIndex = 33;
            // 
            // dgv_huesped
            // 
            this.dgv_huesped.AllowUserToAddRows = false;
            this.dgv_huesped.AllowUserToDeleteRows = false;
            this.dgv_huesped.AllowUserToResizeColumns = false;
            this.dgv_huesped.AllowUserToResizeRows = false;
            this.dgv_huesped.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_huesped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_huesped.Location = new System.Drawing.Point(818, 58);
            this.dgv_huesped.Name = "dgv_huesped";
            this.dgv_huesped.ReadOnly = true;
            this.dgv_huesped.RowHeadersVisible = false;
            this.dgv_huesped.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_huesped.Size = new System.Drawing.Size(304, 115);
            this.dgv_huesped.TabIndex = 34;
            this.dgv_huesped.DoubleClick += new System.EventHandler(this.dgv_huesped_DoubleClick);
            // 
            // dgv_habitacion
            // 
            this.dgv_habitacion.AllowUserToAddRows = false;
            this.dgv_habitacion.AllowUserToDeleteRows = false;
            this.dgv_habitacion.AllowUserToResizeColumns = false;
            this.dgv_habitacion.AllowUserToResizeRows = false;
            this.dgv_habitacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_habitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_habitacion.Location = new System.Drawing.Point(818, 365);
            this.dgv_habitacion.Name = "dgv_habitacion";
            this.dgv_habitacion.ReadOnly = true;
            this.dgv_habitacion.RowHeadersVisible = false;
            this.dgv_habitacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_habitacion.Size = new System.Drawing.Size(303, 119);
            this.dgv_habitacion.TabIndex = 35;
            this.dgv_habitacion.DoubleClick += new System.EventHandler(this.dgv_habitacion_DoubleClick);
            // 
            // dgv_servicio
            // 
            this.dgv_servicio.AllowUserToAddRows = false;
            this.dgv_servicio.AllowUserToDeleteRows = false;
            this.dgv_servicio.AllowUserToResizeColumns = false;
            this.dgv_servicio.AllowUserToResizeRows = false;
            this.dgv_servicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_servicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_servicio.Location = new System.Drawing.Point(818, 212);
            this.dgv_servicio.Name = "dgv_servicio";
            this.dgv_servicio.ReadOnly = true;
            this.dgv_servicio.RowHeadersVisible = false;
            this.dgv_servicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_servicio.Size = new System.Drawing.Size(304, 121);
            this.dgv_servicio.TabIndex = 36;
            this.dgv_servicio.DoubleClick += new System.EventHandler(this.dgv_servicio_DoubleClick);
            // 
            // dgv_instalacion
            // 
            this.dgv_instalacion.AllowUserToAddRows = false;
            this.dgv_instalacion.AllowUserToDeleteRows = false;
            this.dgv_instalacion.AllowUserToResizeColumns = false;
            this.dgv_instalacion.AllowUserToResizeRows = false;
            this.dgv_instalacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_instalacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_instalacion.Location = new System.Drawing.Point(818, 524);
            this.dgv_instalacion.Name = "dgv_instalacion";
            this.dgv_instalacion.ReadOnly = true;
            this.dgv_instalacion.RowHeadersVisible = false;
            this.dgv_instalacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_instalacion.Size = new System.Drawing.Size(303, 123);
            this.dgv_instalacion.TabIndex = 37;
            this.dgv_instalacion.DoubleClick += new System.EventHandler(this.dgv_instalacion_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(818, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Listado Huesped";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(815, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Listado Habitacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(818, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Listado Servicio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(815, 508);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Listado Instalacion";
            // 
            // txtCant
            // 
            this.txtCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtCant.Location = new System.Drawing.Point(387, 307);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(65, 26);
            this.txtCant.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Desktop;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(31, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "Codigo     ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Desktop;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(375, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 47;
            this.label13.Text = "Cantidad";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Desktop;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(300, 340);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 48;
            this.label14.Text = "Costo    ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Desktop;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(117, 340);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 20);
            this.label15.TabIndex = 49;
            this.label15.Text = "Descripcion                ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Desktop;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(455, 340);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 20);
            this.label16.TabIndex = 50;
            this.label16.Text = "Importe            ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(426, 624);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 24);
            this.label10.TabIndex = 51;
            this.label10.Text = "Total ";
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(488, 619);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 29);
            this.txt_total.TabIndex = 52;
            this.txt_total.Text = "$";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Guardar.Location = new System.Drawing.Point(613, 520);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(140, 38);
            this.btn_Guardar.TabIndex = 54;
            this.btn_Guardar.Text = "Guardar DB";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // cbo_hotel
            // 
            this.cbo_hotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_hotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_hotel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbo_hotel.FormattingEnabled = true;
            this.cbo_hotel.Location = new System.Drawing.Point(91, 83);
            this.cbo_hotel.Name = "cbo_hotel";
            this.cbo_hotel.Size = new System.Drawing.Size(152, 26);
            this.cbo_hotel.TabIndex = 55;
            // 
            // txt_n_factura
            // 
            this.txt_n_factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_n_factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n_factura.ForeColor = System.Drawing.Color.White;
            this.txt_n_factura.Location = new System.Drawing.Point(117, 42);
            this.txt_n_factura.Name = "txt_n_factura";
            this.txt_n_factura.Size = new System.Drawing.Size(65, 29);
            this.txt_n_factura.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 56;
            this.label12.Text = "NºFactura:";
            // 
            // btn_refrescar_huesped
            // 
            this.btn_refrescar_huesped.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_refrescar_huesped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refrescar_huesped.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_refrescar_huesped.Location = new System.Drawing.Point(643, 198);
            this.btn_refrescar_huesped.Name = "btn_refrescar_huesped";
            this.btn_refrescar_huesped.Size = new System.Drawing.Size(141, 40);
            this.btn_refrescar_huesped.TabIndex = 58;
            this.btn_refrescar_huesped.Text = "Refrescar Huesped";
            this.btn_refrescar_huesped.UseVisualStyleBackColor = false;
            this.btn_refrescar_huesped.Click += new System.EventHandler(this.btn_refrescar_huesped_Click);
            // 
            // group_huesped
            // 
            this.group_huesped.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.group_huesped.Controls.Add(this.txt_tipo_Doc);
            this.group_huesped.Controls.Add(this.label4);
            this.group_huesped.Controls.Add(this.Huesped);
            this.group_huesped.Controls.Add(this.txt_nombre_huesped);
            this.group_huesped.Controls.Add(this.txt_dni_huesped);
            this.group_huesped.Controls.Add(this.label3);
            this.group_huesped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_huesped.Location = new System.Drawing.Point(33, 125);
            this.group_huesped.Name = "group_huesped";
            this.group_huesped.Size = new System.Drawing.Size(505, 97);
            this.group_huesped.TabIndex = 60;
            this.group_huesped.TabStop = false;
            this.group_huesped.Text = "                          Datos del Huesped";
            // 
            // txt_tipo_Doc
            // 
            this.txt_tipo_Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo_Doc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txt_tipo_Doc.Location = new System.Drawing.Point(128, 19);
            this.txt_tipo_Doc.Name = "txt_tipo_Doc";
            this.txt_tipo_Doc.Size = new System.Drawing.Size(57, 24);
            this.txt_tipo_Doc.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::tp_pav1.Properties.Resources.logo_hotel;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(546, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 88);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // ventana_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.btn_ConsultarFactu);
            this.Controls.Add(this.group_huesped);
            this.Controls.Add(this.btn_refrescar_huesped);
            this.Controls.Add(this.txt_n_factura);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbo_hotel);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_instalacion);
            this.Controls.Add(this.dgv_servicio);
            this.Controls.Add(this.dgv_habitacion);
            this.Controls.Add(this.dgv_huesped);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.dgv_factu);
            this.Controls.Add(this.txt_vendedor);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Facturar);
            this.Controls.Add(this.btn_Huesped);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Colocar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventana_Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.ventanaABM_Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_factu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_huesped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_habitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_instalacion)).EndInit();
            this.group_huesped.ResumeLayout(false);
            this.group_huesped.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Colocar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Huesped;
        private System.Windows.Forms.Button btn_Facturar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Huesped;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txt_vendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridView dgv_huesped;
        private System.Windows.Forms.DataGridView dgv_habitacion;
        private System.Windows.Forms.DataGridView dgv_servicio;
        private System.Windows.Forms.DataGridView dgv_instalacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_refrescar_huesped;
        private System.Windows.Forms.GroupBox group_huesped;
        public System.Windows.Forms.DataGridView dgv_factu;
        public System.Windows.Forms.ComboBox cbo_hotel;
        public System.Windows.Forms.TextBox txt_dni_huesped;
        public System.Windows.Forms.TextBox txt_nombre_huesped;
        public System.Windows.Forms.TextBox txtCod;
        public System.Windows.Forms.TextBox txtDesc;
        public System.Windows.Forms.TextBox txtCosto;
        public System.Windows.Forms.TextBox txtCant;
        public System.Windows.Forms.TextBox txt_total;
        public System.Windows.Forms.TextBox txt_n_factura;
        public System.Windows.Forms.TextBox txt_tipo_Doc;
        public System.Windows.Forms.Button btn_ConsultarFactu;
    }
}