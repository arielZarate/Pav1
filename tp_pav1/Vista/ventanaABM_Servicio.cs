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
    public partial class ventanaABM_Servicio : ventanaABM_Padre
    {
        public ventanaABM_Servicio()
        {
            InitializeComponent();
        }
        Servicio servi = new Servicio();
        validar_Estados valida = new validar_Estados();
        DataTable tabla = new DataTable();
        Tipo_Servicio tipo = new Tipo_Servicio();



    
        //ventana load
        private void ventanaABM_Servicio_Load(object sender, EventArgs e)
        {
            this.blanquear_objetos();
            this.txt_IdServicio.Enabled = true;
            this.txt_Descripcion.Enabled = true;
            this.txt_ID_tipo.Enabled = false;

            this.txt_IdServicio.Focus();


            //ComboBox
            this.cbo_tipoServicio.DataSource = tipo.consultar_tipoServicios();
            this.cbo_tipoServicio.DisplayMember = "desc_tipo_servicio";
            this.cbo_tipoServicio.ValueMember = "id_tipo_servicio";
            //esto sirve para resetear el cbo
            this.cbo_tipoServicio.SelectedIndex = -1;

            //con esto quito el mesaje del selectedItem
            if (cbo_tipoServicio.SelectedItem == null)
            {
                txt_ID_tipo.Text = "";

            }


            this.btn_Nuevo.Enabled = true;
            this.btn_Guardar.Enabled = false;
            this.btn_Actualizar.Enabled = false;
            this.btn_Menu.Enabled = true;
            this.btn_Limpiar.Enabled = true;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Consultar.Enabled = true;
            this.btn_Eliminar.Enabled = false;

        }

   
        //ventana nuevo
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {

            this.blanquear_objetos();
            this.txt_IdServicio.Enabled = true;
            this.txt_IdServicio.Focus();

          
            //botones 
            this.btn_Guardar.Enabled = true;
            this.btn_Actualizar.Enabled = false;
            this.btn_Menu.Enabled = true;
            this.btn_Limpiar.Enabled = true;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Eliminar.Enabled = false;
            this.btn_Consultar.Enabled = true;
            }



        //blanquear los txt
        private void blanquear_objetos()
        {
            this.txt_IdServicio.Text = "";
            this.txt_Descripcion.Text = "";
            this.txt_ID_tipo.Text = "";
            cbo_tipoServicio.SelectedIndex = -1;

       
        }
      

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {

              
                if (valida.ValidarCampoVacio(txt_IdServicio.Text) == true)
                {
                    valida.MensajeSalida("ID");

                }
                else

                    if ((valida.ValidarCampoVacio(txt_Descripcion.Text)) == true)
                    {
                        valida.MensajeSalida("Descripcion");
                    }
                    else
                        if (cbo_tipoServicio.SelectedIndex==-1)
                        {
                            valida.MensajeSalidaCombos("Tipo Servicio");
                        }
                        else
                        {



                            servi.id_servicio = int.Parse(this.txt_IdServicio.Text);
                            servi.descripcion = this.txt_Descripcion.Text;
                            //asi saco el id del cbo
                         servi.ID_tipo_Servicio =int.Parse(cbo_tipoServicio.SelectedValue.ToString());

                         this.servi.Grabar_Servicio();
                         MessageBox.Show("Se han ingresado los Datos de Servicios correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tabla = servi.consultarServicio();
                            dgv_Servicio.DataSource = tabla;
                            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
                        }

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error al guardar los datos del Servicio\n" + Error.Message, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }
    

        // actualizar
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {

            try
            {

                if ((valida.ValidarCampoVacio(txt_Descripcion.Text) == true))
                {
                    valida.MensajeSalida("Descripcion");
                }
                else
                    if ((valida.ValidarCampoVacio(txt_ID_tipo.Text) == true))
                    {
                        valida.MensajeSalida("ID Tipo Servicio");
                    }
                    
                        else
                        {
                             int id = int.Parse(this.txt_IdServicio.Text);
                            servi.descripcion = this.txt_Descripcion.Text;
                            servi.ID_tipo_Servicio = int.Parse(this.txt_ID_tipo.Text);
                            this.servi.Modificar_Servicio(id);
                           MessageBox.Show("Se han Modificado los Datos del Servicio correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           tabla = servi.consultarServicio();
                           dgv_Servicio.DataSource = tabla;
                        }

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error al Actualizar los datos del Servicio\n" + Error.Message, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

            
         
        }




        //Eliminar
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(txt_IdServicio.Text);
                if (MessageBox.Show("Está seguro de Eliminar el Servicio ", "Importante", MessageBoxButtons.YesNo
                             , MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    servi.Borrar_Servicio(id);
                    MessageBox.Show("Se han Eliminado los Datos del Servicio correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
                    tabla = servi.consultarServicio();
                    dgv_Servicio.DataSource = tabla;
                    this.blanquear_objetos();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error no se ha podido Eliminar el Servicio\n" + err.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }
        


        //buscar
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            
          
            if(this.txt_IdServicio.Text=="")
            {
                 MessageBox.Show("El id está vacío \n Ingrese un valor para buscar..", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                 tabla = this.servi.Buscar_x_Id(this.txt_IdServicio.Text);
                                
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado ningún Servicio con ese Id", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    this.blanquear_objetos();
                    return;
                }
               
                this.txt_Descripcion.Text = tabla.Rows[0]["descripcion_servicio"].ToString();
                this.txt_ID_tipo.Text = tabla.Rows[0]["id_tipo_servicio"].ToString();
                //LASOLUCION MAGICA FUE ESTA
                //ahora hace una consulta buscando por el id que esta en el txt

                int id = int.Parse(txt_ID_tipo.Text);//convierto a int

                tabla = tipo.Buscar_tipoServicio_X_Id(id);//realiza la consulta

                this.cbo_tipoServicio.Text = tabla.Rows[0]["desc_tipo_servicio"].ToString();
              
                this.btn_Buscar_Logo.Enabled = false;

                this.btn_Limpiar.Enabled = true;
                this.btn_Actualizar.Enabled = true;
                this.btn_Eliminar.Enabled = true;
                this.btn_Guardar.Enabled = false;
                this.txt_IdServicio.Enabled = false;

                this.txt_IdServicio.Focus();
              
                //if (this.btn_Buscar_Logo.Visible == true)
                //{
                //    this.txt_Descripcion.Enabled = false;
                //    this.txt_IdServicio.Enabled = false;
                //    this.btn_Buscar_Logo.Visible= false;

                //}
            }
        }

        //limpiar los txt
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            this.txt_IdServicio.Text = "";
            this.txt_Descripcion.Text = "";
            this.cbo_tipoServicio.SelectedIndex = -1;
            this.txt_ID_tipo.Text = "";

            this.btn_Buscar_Logo.Enabled = true;
        }



        //buscar Logo
        private void btn_Buscar_Logo_Click(object sender, EventArgs e)
        {
            this.txt_IdServicio.Enabled = true;
            this.txt_IdServicio.Focus();
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
        
            tabla=servi.consultarServicio();
            dgv_Servicio.DataSource = tabla;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Limpiar.Enabled = true;

        }

      


        private void btn_Menu_Click(object sender, EventArgs e)
        {
            //ventanaABM_Servicio servi = new ventanaABM_Servicio();
            //servi.ShowDialog();
        }

        private void btn_TipoServicio_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //ventanaMenu menu = new ventanaMenu(); menu.ShowDialog();

            ventanaABM_TipoServicio tipo = new ventanaABM_TipoServicio();

            tipo.ShowDialog();
        }


        private void txt_IdServicio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lbl_Descripcion_Click(object sender, EventArgs e)
        {

        }
        private void txt_Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Servicio_DoubleClick(object sender, EventArgs e)
        {
   

            txt_IdServicio.Text=this.dgv_Servicio.CurrentRow.Cells[0].Value.ToString();
            txt_Descripcion.Text = this.dgv_Servicio.CurrentRow.Cells[1].Value.ToString();
            txt_ID_tipo.Text = this.dgv_Servicio.CurrentRow.Cells[2].Value.ToString();


            //LASOLUCION MAGICA FUE ESTA
           //ahora hace una consulta buscando por el id que esta en el txt

            int id = int.Parse(txt_ID_tipo.Text);//convierto a int

            tabla = tipo.Buscar_tipoServicio_X_Id(id);//realiza la consulta

            this.cbo_tipoServicio.Text = tabla.Rows[0]["desc_tipo_servicio"].ToString();
            txt_costo2.Text = tabla.Rows[0]["costo"].ToString();
            
       
            txt_IdServicio.Enabled= false;
            this.txt_costo2.Enabled = false;
            this.btn_Buscar_Logo.Enabled = true;
            this.btn_Guardar.Enabled = false;
            this.btn_Limpiar.Enabled = true;
            this.btn_Eliminar.Enabled = true;
            this.btn_Actualizar.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbo_tipoServicio.SelectedItem != null)
            {
                this.txt_ID_tipo.Text = cbo_tipoServicio.SelectedValue.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        }
}
