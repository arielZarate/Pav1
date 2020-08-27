namespace tp_pav1.Vista
{
    partial class ventanaFecha
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
            this.btnFecha = new System.Windows.Forms.Button();
            this.texFecha = new System.Windows.Forms.TextBox();
            this.txt_fechaingresada = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompareFecha = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnNumero = new System.Windows.Forms.Button();
            this.btnTexto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFecha
            // 
            this.btnFecha.Location = new System.Drawing.Point(37, 12);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(190, 23);
            this.btnFecha.TabIndex = 0;
            this.btnFecha.Text = "mostrar Fecha Actual";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // texFecha
            // 
            this.texFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texFecha.Location = new System.Drawing.Point(37, 54);
            this.texFecha.Name = "texFecha";
            this.texFecha.Size = new System.Drawing.Size(189, 29);
            this.texFecha.TabIndex = 1;
            // 
            // txt_fechaingresada
            // 
            this.txt_fechaingresada.Location = new System.Drawing.Point(47, 142);
            this.txt_fechaingresada.Mask = "00/00/0000";
            this.txt_fechaingresada.Name = "txt_fechaingresada";
            this.txt_fechaingresada.Size = new System.Drawing.Size(122, 20);
            this.txt_fechaingresada.TabIndex = 2;
            this.txt_fechaingresada.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ingrese fecha a comparar";
            // 
            // btnCompareFecha
            // 
            this.btnCompareFecha.Location = new System.Drawing.Point(47, 182);
            this.btnCompareFecha.Name = "btnCompareFecha";
            this.btnCompareFecha.Size = new System.Drawing.Size(146, 23);
            this.btnCompareFecha.TabIndex = 4;
            this.btnCompareFecha.Text = "Comparar Fechas";
            this.btnCompareFecha.UseVisualStyleBackColor = true;
            this.btnCompareFecha.Click += new System.EventHandler(this.btnCompareFecha_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(50, 281);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(143, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(50, 338);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(143, 20);
            this.txtTexto.TabIndex = 6;
            // 
            // btnNumero
            // 
            this.btnNumero.Location = new System.Drawing.Point(199, 281);
            this.btnNumero.Name = "btnNumero";
            this.btnNumero.Size = new System.Drawing.Size(75, 23);
            this.btnNumero.TabIndex = 7;
            this.btnNumero.Text = "numero";
            this.btnNumero.UseVisualStyleBackColor = true;
            this.btnNumero.Click += new System.EventHandler(this.btnNumero_Click);
            // 
            // btnTexto
            // 
            this.btnTexto.Location = new System.Drawing.Point(199, 335);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(75, 23);
            this.btnTexto.TabIndex = 8;
            this.btnTexto.Text = "texto";
            this.btnTexto.UseVisualStyleBackColor = true;
            this.btnTexto.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // frmFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 438);
            this.Controls.Add(this.btnTexto);
            this.Controls.Add(this.btnNumero);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnCompareFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_fechaingresada);
            this.Controls.Add(this.texFecha);
            this.Controls.Add(this.btnFecha);
            this.Name = "frmFecha";
            this.Text = "frmFecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.TextBox texFecha;
        private System.Windows.Forms.MaskedTextBox txt_fechaingresada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompareFecha;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnNumero;
        private System.Windows.Forms.Button btnTexto;
    }
}