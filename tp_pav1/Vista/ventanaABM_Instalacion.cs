using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_pav1.Modelo;

namespace tp_pav1.Vista
{
    public partial class ventanaABM_Instalacion : ventanaABM_Padre
    {
        public ventanaABM_Instalacion()
        {
            InitializeComponent();
        }
        Instalacion instal = new Instalacion();
        validar_Estados valida = new validar_Estados();
        DataTable tabla = new DataTable();






        //ventana load
        //ventana nuevo




        private void ventanaABM_Instalacion_Load(object sender, EventArgs e)
        {
            this.blanquear_objetos();
            this.txt_IdInstalacion.Enabled = true;
            this.txt_Descripcion.Enabled = true;
            this.txt_Estado.Enabled = true;
            this.txt_IdInstalacion.Focus();


            this.btn_Nuevo.Enabled = true;
            this.btn_Guardar.Enabled = false;
            this.btn_Actualizar.Enabled = false;
            this.btn_Menu.Enabled = true;
            this.btn_Limpiar.Enabled = true;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Consultar.Enabled = true;
            this.btn_Eliminar.Enabled = false;

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            this.blanquear_objetos();
            this.txt_IdInstalacion.Enabled =true;
            this.txt_Descripcion.Enabled = true;
            this.txt_Estado.Enabled = true;
            this.txt_IdInstalacion.Focus();


            this.btn_Guardar.Enabled = true;
            this.btn_Actualizar.Enabled = false;
            this.btn_Menu.Enabled = true;
            this.btn_Limpiar.Enabled = true;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Eliminar.Enabled = false;
            this.btn_Consultar.Enabled = true;
              
        }


        private void blanquear_objetos()
        {
            this.txt_IdInstalacion.Text = "";
            this.txt_Descripcion.Text = "";
            this.txt_Estado.Text = "";
        }


        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            try
            {
                if ((valida.ValidarCampoVacio(txt_IdInstalacion.Text) == true))
                {
                    valida.MensajeSalida("ID");
                }
                else
                if ((valida.ValidarCampoVacio(txt_Descripcion.Text) == true))
                {
                    valida.MensajeSalida("Descripcion");
                }
                //else
                //    if ((valida.ValidarCampoVacio(txt_descripcion.Text)) == true)
                //    {
                //        valida.MensajeSalida("Descripcion");
                //    }
                    else
                {
                    instal.descripcion = this.txt_Descripcion.Text;
                    instal.estado = this.txt_Estado.Text;
                    this.instal.Grabar_Instalacion();
                    MessageBox.Show("Se han guardado los Datos correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabla = instal.consultarInstalacion();
                    dgv_Instalacion.DataSource = tabla;


                 }

             }
                    catch (Exception Error)
                    {
                        MessageBox.Show("Error al guardar los datos de la instalacion \n" + Error.Message, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    }
                }
           
              

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {


            try
            {

                int id = int.Parse(txt_IdInstalacion.Text);

                if ((valida.ValidarCampoVacio(txt_Descripcion.Text) == true))
                {
                    valida.MensajeSalida("Descripcion");
                }
                else
                {
                    instal.descripcion = this.txt_Descripcion.Text;
                    instal.estado = this.txt_Estado.Text;
                    instal.Modificar_Instalacion(id);
                    MessageBox.Show("Se han Modificado los Datos del hotel correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabla = instal.consultarInstalacion();
                    dgv_Instalacion.DataSource = tabla;

                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error al Actualizar los datos del Hotel\n" + Error.Message, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

        }

        //*******************+
            
        

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            this.txt_IdInstalacion.Text = "";
            this.txt_Descripcion.Text = "";
            this.txt_Estado.Text = "";

        }

        private void btn_Buscar_Logo_Click(object sender, EventArgs e)
        {

            this.txt_IdInstalacion.Focus();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_IdInstalacion.Text);
                if (MessageBox.Show("Está seguro de Eliminar la Instalacion ", "Importante", MessageBoxButtons.YesNo
                             , MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    instal.borrar_Instalacion(id);
                    MessageBox.Show("Se han Eliminado los Datos del Hotel correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
                    this.blanquear_objetos();
                    tabla = instal.consultarInstalacion();
                    dgv_Instalacion.DataSource = tabla;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error no se ha podido Eliminar la instalacion\n" + err.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Hand);


            }

        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            tabla =instal.consultarInstalacion();
            dgv_Instalacion.DataSource = tabla;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Limpiar.Enabled = true;

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            
   

            if (this.txt_IdInstalacion.Text == "")
            {
        MessageBox.Show("El id está vacío \n Ingrese un valor para buscar..", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
         
                tabla = this.instal.Buscar_x_Id(this.txt_IdInstalacion.Text);

                if (tabla.Rows.Count == 0)
                {
            MessageBox.Show("No se ha encontrado ningún hotel con ese Id", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    this.blanquear_objetos();
                    return;
                }

                this.txt_Descripcion.Text = tabla.Rows[0]["descripcion_instalacion"].ToString();
                this.txt_Estado.Text = tabla.Rows[0]["habilitada"].ToString();

                //if (this.btn_Buscar.Visible == true)
                //{
                //    this.txt_Descripcion.Enabled = true;
                //    this.txt_Estado.Enabled = true;
                //    this.txt_IdInstalacion.Enabled = false;
                //    this.btn_Buscar.Visible = false;

                //}
                this.btn_Buscar_Logo.Enabled = false;

                this.btn_Limpiar.Enabled = true;
                this.btn_Actualizar.Enabled = true;
                this.btn_Guardar.Enabled = false;
                this.btn_Eliminar.Enabled = true;
                this.txt_IdInstalacion.Enabled = true;
                this.txt_IdInstalacion.Focus();

           
            }

        }

        private void dgv_Instalacion_DoubleClick(object sender, EventArgs e)
        {
            txt_IdInstalacion.Text =dgv_Instalacion.CurrentRow.Cells[0].Value.ToString();
            txt_Descripcion.Text = dgv_Instalacion.CurrentRow.Cells[1].Value.ToString();
            txt_Estado.Text = dgv_Instalacion.CurrentRow.Cells[2].Value.ToString();
            this.txt_IdInstalacion.Enabled=false;
          
            this.btn_Buscar_Logo.Enabled = true;
            this.btn_Guardar.Enabled = false;
            this.btn_Limpiar.Enabled = true;
            this.btn_Eliminar.Enabled = true;
            this.btn_Eliminar.Enabled = true;
            this.btn_Actualizar.Enabled = true;

        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {

        }

    }
}
