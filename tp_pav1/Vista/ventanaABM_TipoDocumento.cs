using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_pav1.Back_End;
using tp_pav1.Modelo;

namespace tp_pav1.Vista
{
    public partial class ventanaABM_TipoDocumento : ventanaABM_Padre
    {
        public ventanaABM_TipoDocumento()
        {
            InitializeComponent();
        }

        TipoDocumento tipo = new TipoDocumento();
        DataTable tabla = new DataTable();
        acceso_DB DB = new acceso_DB();
        validar_Estados valida = new validar_Estados();

        private void ventanaABM_TipoDocumento_Load(object sender, EventArgs e)
        {
            this.blanquear_objetos();



            this.btn_Nuevo.Enabled = true;
            this.btn_Guardar.Enabled = false;
            this.btn_Actualizar.Enabled = false;
            this.btn_Menu.Enabled = true;
            this.btn_Limpiar.Enabled = true;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Consultar.Enabled = true;
            this.btn_Eliminar.Enabled = false;

        }



        private void blanquear_objetos()
        {
            this.txt_Id_Tipo.Text = "";
            this.txt_TipoDocumento.Text = "";

            this.txt_Id_Tipo.Focus();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            this.blanquear_objetos();
            this.txt_Id_Tipo.Enabled = true;
            this.txt_Id_Tipo.Focus();
            this.btn_Guardar.Enabled = true;
            this.btn_Actualizar.Enabled = false;
            this.btn_Menu.Enabled = true;
            this.btn_Limpiar.Enabled = true;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Eliminar.Enabled = false;
            this.btn_Consultar.Enabled = true;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (valida.ValidarCampoVacio(txt_Id_Tipo.Text) == true)
                {
                    valida.MensajeSalida("ID");

                }
                else
                    if ((valida.ValidarCampoVacio(this.txt_TipoDocumento.Text)) == true)
                    {
                        valida.MensajeSalida("Tipo Documento");
                    }
                    else
                    {


                        tipo.ID_TipoDocumento = int.Parse(txt_Id_Tipo.Text);
                        tipo.Descripcion = txt_TipoDocumento.Text;

                        tipo.Grabar_tipoDocumento();
                        MessageBox.Show("Se han ingresado los Datos correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tabla = tipo.Consultar_TipoDocumento();
                        dgv_tipoDoc.DataSource = tabla;
                        this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
                        this.blanquear_objetos();

                    }

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error al guardar los datos del Tipo Documento\n" + Error.Message, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }


        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(txt_Id_Tipo.Text);
                if (valida.ValidarCampoVacio(txt_Id_Tipo.Text) == true)
                {
                    valida.MensajeSalida("ID");

                }
                else
                    if ((valida.ValidarCampoVacio(this.txt_TipoDocumento.Text)) == true)
                    {
                        valida.MensajeSalida("Tipo Documento");
                    }
                    else
                    {

                        tipo.Descripcion = txt_TipoDocumento.Text;
                        tipo.Modificar_tipoDocumento(id);
                        MessageBox.Show("Se han Modificado los Datos del TipoDocumento correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabla = tipo.Consultar_TipoDocumento();
                        dgv_tipoDoc.DataSource = tabla;
                        this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
                        this.blanquear_objetos();
                    }

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error al Actualizar los datos del TipoDocumento\n" + Error.Message, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            this.blanquear_objetos();
        }

        private void btn_Buscar_Logo_Click(object sender, EventArgs e)
        {
            
            this.blanquear_objetos();
            this.txt_Id_Tipo.Enabled = true;

        }



        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            tabla = tipo.Consultar_TipoDocumento();
            dgv_tipoDoc.DataSource = tabla;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Limpiar.Enabled = true;

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_Id_Tipo.Text);
                if (MessageBox.Show("Está seguro de Eliminar el Tipo Documento ", "Importante", MessageBoxButtons.YesNo
                             , MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    tipo.Eliminar_tipoDocumento(id);
                    MessageBox.Show("Se han Eliminado los Datos del Tipo Documento correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
                    tabla = tipo.Consultar_TipoDocumento();
                    dgv_tipoDoc.DataSource = tabla;
                    this.blanquear_objetos();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error no se ha podido Eliminar el tipo Documento\n" + err.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {

            if (this.txt_Id_Tipo.Text == "")
            {

                MessageBox.Show("El id está vacío \n Ingrese un valor para buscar..", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                int id = int.Parse(txt_Id_Tipo.Text);
                tabla = tipo.Buscar_tipoDocumento_X_Id(id);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado ningún tipo de Documento con ese Id", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    this.blanquear_objetos();
                    return;
                }

                txt_Id_Tipo.Text = tabla.Rows[0]["id_tipoD"].ToString();
                txt_TipoDocumento.Text = tabla.Rows[0]["descripcion_tipoDoc"].ToString();

                this.btn_Buscar_Logo.Enabled = false;

                this.btn_Limpiar.Enabled = true;
                this.btn_Actualizar.Enabled = true;
                this.btn_Eliminar.Enabled = true;
                this.btn_Guardar.Enabled = false;
                txt_Id_Tipo.Focus();


            }

        }

        private void dgv_tipoDoc_DoubleClick(object sender, EventArgs e)
        {
            txt_Id_Tipo.Text = dgv_tipoDoc.CurrentRow.Cells[0].Value.ToString();
            txt_TipoDocumento.Text = dgv_tipoDoc.CurrentRow.Cells[1].Value.ToString();
            this.txt_Id_Tipo.Enabled = false;
            this.btn_Buscar_Logo.Enabled = true;
            this.btn_Guardar.Enabled = false;
            this.btn_Limpiar.Enabled = true;
            this.btn_Eliminar.Enabled = true;
            this.btn_Actualizar.Enabled = true;

        }

        private void ventanaABM_TipoDocumento_FormClosing(object sender, FormClosingEventArgs e)
        {
            ventanaMenu menu = new ventanaMenu();
            menu.Show();
            ventanaABM_Huesped hue = new ventanaABM_Huesped();
            hue.ShowDialog();
        }


    }
}