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
    public partial class ventanaABM_TipoServicio : ventanaABM_Padre
    {
        public ventanaABM_TipoServicio()
        {
            InitializeComponent();
        }

        Tipo_Servicio tipo = new Tipo_Servicio();
        validar_Estados valida = new validar_Estados();
        DataTable tabla = new DataTable();
   



        private void btn_Menu_Click(object sender, EventArgs e)
        {

        }

        //load
        private void ventanaABM_TipoServicio_Load(object sender, EventArgs e)
        {
            this.blanquear_objetos();
            txt_ID_tipoServicio.Enabled = true;
            this.txt_ID_tipoServicio.Focus();


       




            //configuracion de botones
            this.btn_Nuevo.Enabled = true;
            this.btn_Guardar.Enabled = false;
            this.btn_Actualizar.Enabled = false;
            this.btn_Menu.Enabled = true;
            this.btn_Limpiar.Enabled = true;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Consultar.Enabled = true;
            this.btn_Eliminar.Enabled = false;

        }


        //ventana blanquear

        private void blanquear_objetos()
        {
            this.txt_ID_tipoServicio.Text = "";
            this.txt_descripcion.Text = "";
            this.txt_costo.Text = "";
        }


        //nuevo
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            this.blanquear_objetos();
            this.txt_ID_tipoServicio.Enabled = true;
            this.txt_ID_tipoServicio.Focus();

            this.btn_Guardar.Enabled = true;
            this.btn_Actualizar.Enabled = false;
            this.btn_Menu.Enabled = true;
            this.btn_Limpiar.Enabled = true;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Eliminar.Enabled = false;
            this.btn_Consultar.Enabled = true;

        }

        //limpiar txt
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            this.txt_ID_tipoServicio.Text = "";
            this.txt_descripcion.Text = "";
            this.txt_costo.Text = "";
            txt_ID_tipoServicio.Enabled = true;
            this.txt_ID_tipoServicio.Focus();
        }


        //guardar
        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (valida.ValidarCampoVacio(txt_ID_tipoServicio.Text) == true)
                {
                    valida.MensajeSalida("ID");

                }
                else

                    if ((valida.ValidarCampoVacio(txt_descripcion.Text)) == true)
                    {
                        valida.MensajeSalida("Descripcion");
                    }
                    else
                        if ((valida.ValidarCampoVacio(txt_costo.Text)) == true)
                        {
                            valida.MensajeSalida("Costo");
                        }
                        else
                        {



                            tipo._Id = int.Parse(this.txt_ID_tipoServicio.Text);
                            tipo._Descripcion_tipo = this.txt_descripcion.Text;
                            tipo._Costo = int.Parse(this.txt_costo.Text);
                            tipo.Grabar_tipoServicio();
                            MessageBox.Show("Se han ingresado los Datos del tipo Servicio correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
                            //actualiza
                            tabla = tipo.consultar_tipoServicios();
                            this.dgv_TipoServicio.DataSource = tabla;
                        }

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error al guardar los datos del Tipo de Servicio\n" + Error.Message, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

        }

        //Actualziar
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {

            try
            {

                if ((valida.ValidarCampoVacio(txt_descripcion.Text)) == true)
                {
                    valida.MensajeSalida("Descripcion");
                }
                else
                    if ((valida.ValidarCampoVacio(txt_costo.Text)) == true)
                    {
                        valida.MensajeSalida("Costo");
                    }
                    else
                    {
                        int id = int.Parse(this.txt_ID_tipoServicio.Text);
                        tipo._Descripcion_tipo = this.txt_descripcion.Text;
                        tipo._Costo = Convert.ToInt32(this.txt_costo.Text);
                        this.tipo.Modificar_TipoServicio(id);
                        MessageBox.Show("Se han Modificado los Datos del tipo Servicio correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //update
                        tabla = tipo.consultar_tipoServicios();
                        this.dgv_TipoServicio.DataSource = tabla;
                    }

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error al Actualizar los datos del tipo Servicio\n" + Error.Message, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {

            tabla = tipo.consultar_tipoServicios();
            this.dgv_TipoServicio.DataSource = tabla;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Limpiar.Enabled = true;
        }


        //Eliminar 

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txt_ID_tipoServicio.Text);
                if (MessageBox.Show("Está seguro de Eliminar el Tipo de Servicio ", "Importante", MessageBoxButtons.YesNo
                             , MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    tipo.Eliminar_tipoServicio(id);
                    MessageBox.Show("Se han Eliminado los Datos del Tipo de Servicio correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
                    tabla = tipo.consultar_tipoServicios();
                    this.dgv_TipoServicio.DataSource = tabla;
                    this.blanquear_objetos();

                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error no se ha podido Eliminar el tipo Servicio\n" + err.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void dgv_TipoServicio_DoubleClick(object sender, EventArgs e)
        {

            txt_ID_tipoServicio.Text = dgv_TipoServicio.CurrentRow.Cells[0].Value.ToString();
            txt_descripcion.Text = dgv_TipoServicio.CurrentRow.Cells[1].Value.ToString();
            txt_costo.Text = dgv_TipoServicio.CurrentRow.Cells[2].Value.ToString();
            this.txt_ID_tipoServicio.Enabled = false; //super impòrtante
            this.btn_Buscar_Logo.Enabled = true;
            this.btn_Guardar.Enabled = false;
            this.btn_Limpiar.Enabled = true;
            this.btn_Eliminar.Enabled = true;
            this.btn_Actualizar.Enabled = true;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
          

            if (this.txt_ID_tipoServicio.Text == "")
            {

                MessageBox.Show("El id está vacío \n Ingrese un valor para buscar..", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                int id = int.Parse(txt_ID_tipoServicio.Text);
                tabla = tipo.Buscar_tipoServicio_X_Id(id);

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado ningún tipo de servicio con ese Id", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    this.blanquear_objetos();
                    return;
                }
                

                    this.txt_descripcion.Text = tabla.Rows[0]["desc_tipo_servicio"].ToString();
                    this.txt_costo.Text = tabla.Rows[0]["costo"].ToString();

                    this.btn_Buscar_Logo.Enabled = false;

                    this.btn_Limpiar.Enabled = true;
                    this.btn_Actualizar.Enabled = true;
                    this.btn_Eliminar.Enabled = true;
                    this.btn_Guardar.Enabled = false;
                    this.txt_ID_tipoServicio.Enabled = true;
                    this.txt_ID_tipoServicio.Focus();
                    
                }
            }




        

        private void btn_Buscar_Logo_Click(object sender, EventArgs e)
        {
             this.txt_ID_tipoServicio.Enabled = true;
             this.txt_ID_tipoServicio.Focus();
        }

        private void ventanaABM_TipoServicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            ventanaMenu menu = new ventanaMenu();
            menu.Show();
            ventanaABM_Servicio servi = new ventanaABM_Servicio();
            servi.ShowDialog();
        }
    }

}
