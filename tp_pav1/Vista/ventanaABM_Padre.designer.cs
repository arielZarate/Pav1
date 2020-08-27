namespace tp_pav1.Vista
{
    partial class ventanaABM_Padre
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
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Buscar_Logo = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = global::tp_pav1.Properties.Resources.Limpiar_1;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Eliminar.Location = new System.Drawing.Point(495, 50);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(48, 42);
            this.btn_Eliminar.TabIndex = 38;
            this.toolTip1.SetToolTip(this.btn_Eliminar, "Atencion Elimina un elemento");
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(431, 139);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(92, 32);
            this.btn_Buscar.TabIndex = 39;
            this.btn_Buscar.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btn_Buscar, "permite la busqueda ppor algun patron");
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackgroundImage = global::tp_pav1.Properties.Resources.consultar;
            this.btn_Consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Consultar.Location = new System.Drawing.Point(429, 50);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(48, 42);
            this.btn_Consultar.TabIndex = 37;
            this.toolTip1.SetToolTip(this.btn_Consultar, "Realiza una consulta de datos y los muestra en la grilla");
            this.btn_Consultar.UseVisualStyleBackColor = true;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackgroundImage = global::tp_pav1.Properties.Resources.actualizar;
            this.btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Actualizar.Enabled = false;
            this.btn_Actualizar.Location = new System.Drawing.Point(168, 50);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(48, 42);
            this.btn_Actualizar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btn_Actualizar, "Actualiza los datos modificados ");
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackgroundImage = global::tp_pav1.Properties.Resources.inicio;
            this.btn_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Menu.Location = new System.Drawing.Point(233, 50);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(48, 42);
            this.btn_Menu.TabIndex = 36;
            this.toolTip1.SetToolTip(this.btn_Menu, "vuelve al Menu Principal");
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click_1);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackgroundImage = global::tp_pav1.Properties.Resources.agregar;
            this.btn_Nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Nuevo.Location = new System.Drawing.Point(38, 50);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(48, 42);
            this.btn_Nuevo.TabIndex = 6;
            this.btn_Nuevo.Tag = "Condiciones para crear un nuevo registro";
            this.toolTip1.SetToolTip(this.btn_Nuevo, "Nuevo: habilita el tecleado de datos para luego guardarlos");
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundImage = global::tp_pav1.Properties.Resources.Guardar;
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.Location = new System.Drawing.Point(102, 50);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(48, 42);
            this.btn_Guardar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_Guardar, "Guarda los datos en el DB");
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar_Logo
            // 
            this.btn_Buscar_Logo.BackgroundImage = global::tp_pav1.Properties.Resources.buscar2;
            this.btn_Buscar_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Buscar_Logo.Location = new System.Drawing.Point(364, 50);
            this.btn_Buscar_Logo.Name = "btn_Buscar_Logo";
            this.btn_Buscar_Logo.Size = new System.Drawing.Size(48, 42);
            this.btn_Buscar_Logo.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btn_Buscar_Logo, "habilita la opcion de filtros");
            this.btn_Buscar_Logo.UseVisualStyleBackColor = true;
            this.btn_Buscar_Logo.Click += new System.EventHandler(this.btn_Buscar_Logo_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackgroundImage = global::tp_pav1.Properties.Resources.clear;
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Limpiar.Location = new System.Drawing.Point(298, 50);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(48, 42);
            this.btn_Limpiar.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btn_Limpiar, "Limpia el formulario");
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // ventanaABM_Padre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 439);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Buscar_Logo);
            this.Controls.Add(this.btn_Limpiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaABM_Padre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM_Padre";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_Actualizar;
        public System.Windows.Forms.Button btn_Menu;
        public System.Windows.Forms.Button btn_Guardar;
        public System.Windows.Forms.Button btn_Limpiar;
        public System.Windows.Forms.Button btn_Buscar_Logo;
        public System.Windows.Forms.Button btn_Nuevo;
        public System.Windows.Forms.Button btn_Buscar;
        public System.Windows.Forms.Button btn_Consultar;
        public System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}