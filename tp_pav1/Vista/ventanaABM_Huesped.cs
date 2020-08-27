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
    public partial class ventanaABM_Huesped : ventanaABM_Padre
    {
        public ventanaABM_Huesped()
        {
            InitializeComponent();
        }


        Huesped hu = new Huesped();
        DataTable tabla=new DataTable();
        TipoDocumento td = new TipoDocumento();
        validar_Estados valida = new validar_Estados();


        private void ventanaABM_Huesped_Load(object sender, EventArgs e)
        {
            //inicializa ya con este estado predeterminado
            //borra todo
            this.blanquear_objetos();
            this.txt_Id_TipoDocumento.Enabled = false;

            //COMBOBOXES

            this.cbo_tipoDocumento.DataSource= this.td.Consultar_TipoDocumento();
            this.cbo_tipoDocumento.DisplayMember = "descripcion_tipoDoc";
            this.cbo_tipoDocumento.ValueMember = "id_tipoD";
            this.cbo_tipoDocumento.SelectedIndex = -1;


            //con esto quito el mesaje del selectedItem
            if (this.cbo_tipoDocumento.SelectedItem == null)
            {
                txt_Id_TipoDocumento.Text = "";

            }
            
          
            //**************************************************
            //control de botones habilitados al iniciar
            this.btn_Nuevo.Enabled = true;
            this.btn_Guardar.Enabled = false;
            this.btn_Actualizar.Enabled = false;
            this.btn_Menu.Enabled = true;
            this.btn_Limpiar.Enabled = true;
            this.btn_Buscar_Logo.Visible = false; this.btn_Buscar.Visible = false;
            this.btn_Consultar.Enabled = true;
            this.btn_Eliminar.Enabled = false;
        }


        private void blanquear_objetos()
        {
            this.txt_Id_TipoDocumento.Text = "";
            //comboBox
            this.cbo_tipoDocumento.SelectedIndex = -1;

            this.txt_Dni.Text = "";
            this.txt_Nombre.Text = "";
            this.txt_Apellido.Text = "";
            this.txt_numTarjeta.Text ="";
           
            txt_Nombre.Enabled = true;
            txt_Apellido.Enabled = true;
            txt_Dni.Enabled = true;
            txt_Dni.Focus();
        }

        //nuevo
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {

            this.blanquear_objetos();
            //botones 
            this.btn_Guardar.Enabled = true;
            this.btn_Actualizar.Enabled = false;
            this.btn_Menu.Enabled = true;
            this.btn_Limpiar.Enabled = true;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Eliminar.Enabled = false;
            this.btn_Consultar.Enabled = true;

        }


        //guardar
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbo_tipoDocumento.SelectedIndex == -1)
                {
                    valida.MensajeSalidaCombos("Tipo Documento");

                }
                else
                if (valida.ValidarCampoVacio(txt_Dni.Text) == true)
                {
                    valida.MensajeSalida("Numero DNI");

                }
                else

                    if ((valida.ValidarCampoVacio(txt_Nombre.Text)) == true )
                    {
                        valida.MensajeSalida("Nombre");
                    }
                    else

                        if ((valida.ValidarCampoVacio(this.txt_Apellido.Text)) == true )
                        {
                            valida.MensajeSalida("Apellido");
                        }
                        else
                        {
                            if (valida.ValidarCampoVacio(txt_numTarjeta.Text) == true)
                            {
                                valida.MensajeSalida("Numero Tarjeta");

                            }
                            else
                            {


                                //asi obtengo el id del comboBox
                                hu.ID_Tipo_Documento = int.Parse(this.cbo_tipoDocumento.SelectedValue.ToString());
                                hu.Num_Documento = int.Parse(txt_Dni.Text);
                                hu.Nombre = txt_Nombre.Text;
                                hu.Apellido = txt_Apellido.Text;
                                hu.Numero_Tarjeta = int.Parse(txt_numTarjeta.Text);



                                // servi.ID_tipo_Servicio = int.Parse(cbo_tipoServicio.SelectedValue.ToString());

                                hu.Grabar_Huesped();
                                MessageBox.Show("Se han ingresado los Datos de Huesped correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.blanquear_objetos();
                                tabla = hu.consultarHuesped();
                                this.dgv_Huesped.DataSource = tabla;
                                this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;

                            }
                        }

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error al guardar los datos del Huesped\n" + Error.Message, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }



        //actualizar
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbo_tipoDocumento.SelectedIndex == -1)
                {
                    valida.MensajeSalidaCombos("Tipo Documento");

                }
                else
                    if (valida.ValidarCampoVacio(txt_Dni.Text) == true)
                    {
                        valida.MensajeSalida("Numero DNI");

                    }
                    else

                        if ((valida.ValidarCampoVacio(txt_Nombre.Text)) == true )
                        {
                            valida.MensajeSalida("Nombre");
                        }
                        else

                            if ((valida.ValidarCampoVacio(this.txt_Apellido.Text)) == true)
                            {
                                valida.MensajeSalida("Apellido");
                            }
                            else
                            {
                                if (valida.ValidarCampoVacio(txt_numTarjeta.Text) == true)
                                {
                                    valida.MensajeSalida("Numero Tarjeta");

                                }
                                else
                                {

                                    int dni = int.Parse(this.txt_Dni.Text);
                    
                                    hu.ID_Tipo_Documento = int.Parse(this.cbo_tipoDocumento.SelectedValue.ToString());
                                    //hu.ID_Tipo_Documento = int.Parse(txt_Id_TipoDocumento.Text);
                                    hu.Nombre = txt_Nombre.Text;
                                    hu.Apellido = txt_Apellido.Text;
                                    hu.Numero_Tarjeta = int.Parse(txt_numTarjeta.Text);


                                    this.hu.Modificar_Huesped(dni);
                                    MessageBox.Show("Se han Modificado los Datos del Huesped correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    tabla = hu.consultarHuesped();
                                    this.dgv_Huesped.DataSource = tabla;
                                    this.blanquear_objetos();

                                }
                            }

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error al Actualizar los datos del Huesped\n" + Error.Message, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

        }


        //limpiar
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            this.blanquear_objetos();
        }





        private void btn_Buscar_Logo_Click(object sender, EventArgs e)
        {
            this.btn_Buscar.Enabled = true;
            this.btn_Limpiar.Enabled = true;
            this.blanquear_objetos();
        }




        //consultar
        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            tabla = hu.consultarHuesped();
            this.dgv_Huesped.DataSource = tabla;
            this.blanquear_objetos();
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Limpiar.Enabled = true;


        }





        private void cbo_tipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.cbo_tipoDocumento.SelectedItem != null)
            {
                this.txt_Id_TipoDocumento.Text = this.cbo_tipoDocumento.SelectedValue.ToString();
                txt_Dni.Enabled = true;
                txt_Dni.Focus();
            }

        }




        //eliminar
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            try
            {
                int dni= Convert.ToInt32(txt_Dni.Text);
                hu.ID_Tipo_Documento = int.Parse(cbo_tipoDocumento.SelectedValue.ToString());
                if (MessageBox.Show("Está seguro de Eliminar el Huesped ", "Importante", MessageBoxButtons.YesNo
                             , MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    hu.Eliminar_Huesped(dni);
                    MessageBox.Show("Se han Eliminado los Datos del Huesped correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
                    tabla = hu.consultarHuesped();
                    this.dgv_Huesped.DataSource = tabla;
                    this.blanquear_objetos();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error no se ha podido Eliminar el Huesped\n" + err.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }





        private void btn_Buscar_Click(object sender, EventArgs e)
        {


            if (this.txt_Dni.Text == "")
            {
                MessageBox.Show("El DNI está vacío \n Ingrese un valor para buscar..", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                int num = int.Parse(txt_Dni.Text.Trim());
                hu.ID_Tipo_Documento = int.Parse(cbo_tipoDocumento.SelectedValue.ToString());
                tabla = this.hu.Buscar_por_NumeroDNI(num);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado ningún Huesped con ese Dni  ", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    this.blanquear_objetos();
                    return;
                }


                
              
               
                

                this.txt_Id_TipoDocumento.Text = tabla.Rows[0]["id_tipoDoc"].ToString();
                this.txt_Dni.Text = tabla.Rows[0]["num_doc"].ToString();
                this.txt_Nombre.Text = tabla.Rows[0]["nombre_huesped"].ToString();
                this.txt_Apellido.Text = tabla.Rows[0]["apellido_huesped"].ToString();
                this.txt_numTarjeta.Text = tabla.Rows[0]["num_tarjeta"].ToString();



                //LASOLUCION MAGICA FUE ESTA
                //ahora hace una consulta buscando por el id que esta en el txt

                int id = int.Parse(txt_Id_TipoDocumento.Text);//convierto a int
                DataTable tablaTipo = new DataTable();
                tablaTipo = td.Buscar_tipoDocumento_X_Id(id);//realiza la consulta

                this.cbo_tipoDocumento.Text = tablaTipo.Rows[0]["desc_tipo_servicio"].ToString();

                this.btn_Buscar_Logo.Enabled = false;

                this.btn_Limpiar.Enabled = true;
                this.btn_Actualizar.Enabled = true;
                this.btn_Eliminar.Enabled = true;
                this.btn_Guardar.Enabled = false;
                this.blanquear_objetos();

                //if (this.btn_Buscar_Logo.Visible == true)
                //{
                //    this.txt_Descripcion.Enabled = false;
                //    this.txt_IdServicio.Enabled = false;
                //    this.btn_Buscar_Logo.Visible= false;

                //}
            }
        }

        


       



        //*********************************************************

        private void lbl_IdInstalacion_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Descripcion_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void txt_Estado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Huesped_DoubleClick(object sender, EventArgs e)
        {
            this.txt_Id_TipoDocumento.Text = this.dgv_Huesped.CurrentRow.Cells[0].Value.ToString();
            this.txt_Dni.Text = this.dgv_Huesped.CurrentRow.Cells[1].Value.ToString();
            this.txt_Nombre.Text = this.dgv_Huesped.CurrentRow.Cells[2].Value.ToString();
            this.txt_Apellido.Text = this.dgv_Huesped.CurrentRow.Cells[3].Value.ToString();
            this.txt_numTarjeta.Text = this.dgv_Huesped.CurrentRow.Cells[4].Value.ToString();
          


            //LASOLUCION MAGICA FUE ESTA
            //ahora hace una consulta buscando por el id que esta en el txt

            int id = int.Parse(txt_Id_TipoDocumento.Text);//convierto a int

            tabla = td.Buscar_tipoDocumento_X_Id(id);//realiza la consulta

            cbo_tipoDocumento.Text = tabla.Rows[0]["descripcion_tipoDoc"].ToString().Trim();


            this.txt_Id_TipoDocumento.Enabled = false;
            this.btn_Buscar_Logo.Enabled = true;
            this.btn_Guardar.Enabled = false;
            this.btn_Limpiar.Enabled = true;
            this.btn_Eliminar.Enabled = true;
            this.btn_Actualizar.Enabled = true;
        }

        private void btn_tipoDocumento_Click(object sender, EventArgs e)
        {
            ventanaABM_TipoDocumento tipo = new ventanaABM_TipoDocumento();
            this.Hide();
            tipo.ShowDialog();
        }
         

      
    }
}
