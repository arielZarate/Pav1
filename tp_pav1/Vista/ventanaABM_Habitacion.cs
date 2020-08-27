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
    public partial class ventanaABM_Habitacion : ventanaABM_Padre
    {
        public ventanaABM_Habitacion()
        {
            InitializeComponent();
        }
        Habitacion obj_habitacion = new Habitacion();
        validar_Estados valida = new validar_Estados();
        DataTable tabla = new DataTable();

   
        //ventana load

        private void ventanaABM_Habitacion_Load(object sender, EventArgs e)
        {
            this.blanquear_objetos();
            this.txt_id.Enabled = true;
            this.txt_descripcion.Enabled = true;
            this.txt_precio.Enabled = true;
            this.txt_id.Focus();

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
            //*****************************
            this.blanquear_objetos();
            this.txt_id.Enabled = true;
            this.txt_descripcion.Enabled = true;
            this.txt_precio.Enabled = true;
            this.txt_id.Focus();

            this.btn_Guardar.Enabled = true;
            this.btn_Actualizar.Enabled = false;
            this.btn_Menu.Enabled = true;
            this.btn_Limpiar.Enabled = true;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Eliminar.Enabled = false;
            this.btn_Consultar.Enabled = true;
        }



        //ventana guardar
        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            try
            {
                //todas los metodos se encuentran en la clase validar_estados

                if ((valida.ValidarCampoVacio(txt_id.Text) == true) || valida.ValidarTextoNumero(txt_id.Text) == false)
                {
                    valida.MensajeSalida("ID");

                }
                else

                    if ((valida.ValidarCampoVacio(txt_descripcion.Text))== true)
                    {
                        valida.MensajeSalida("Descripcion");
                    }

                    else

                        if ((valida.ValidarCampoVacio(txt_precio.Text) == true) || valida.ValidarTextoNumero(txt_precio.Text) == false)
                        {
                            valida.MensajeSalida("Precio");
                        }
                    else
                    {

                        obj_habitacion.id_habitacion = int.Parse(this.txt_id.Text.ToString());
                        obj_habitacion.descripcion_habitacion = this.txt_descripcion.Text;
                        obj_habitacion.precio_habitacion = int.Parse(this.txt_precio.Text);
                        this.obj_habitacion.grabar_habitacion();
                        MessageBox.Show("Se han ingresado los Datos de la Habitacion correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
                        tabla = obj_habitacion.consultarHabitacion();
                        this.dgv_habitacion.DataSource = tabla;
                       
                    }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Error al guardar los datos de la Habitacion \n" + Error.Message, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

     
        //ventana actualizar
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            try{

            int id = int.Parse(this.txt_id.Text.ToString());

              if((valida.ValidarCampoVacio(txt_id.Text)==true||(valida.ValidarTextoNumero(txt_id.Text))==false))
                {
                    valida.MensajeSalida("ID");
                }
                    else
                        if ((valida.ValidarCampoVacio(txt_descripcion.Text) == true) )
                        {
                            valida.MensajeSalida("Descripcion");
                        }

                        else

                            if ((valida.ValidarCampoVacio(txt_id.Text) == true) || valida.ValidarTextoNumero(txt_id.Text) == false)
                            {
                                valida.MensajeSalida("Precio");
                            }
                        else{

               obj_habitacion.descripcion_habitacion = this.txt_descripcion.Text;
               obj_habitacion.precio_habitacion = int.Parse(this.txt_precio.Text);
               this.obj_habitacion.modificar_habitacion(id);
         
                MessageBox.Show("Se han modificado los Datos de la habitacion correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                tabla = obj_habitacion.consultarHabitacion();
                this.dgv_habitacion.DataSource = tabla;
                 }
            }
              catch (Exception Error)
            {
                MessageBox.Show("Error al Actualizar los datos de la Habitacion\n" + Error.Message, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }


        }

          

        
        


        //ventana Limpiar

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            this.txt_id.Text = "";
            this.txt_descripcion.Text = "";
            this.txt_precio.Clear();
        }


        //ventana consultar
        private void btn_Consultar_Click(object sender, EventArgs e)
        {
        
            tabla = obj_habitacion.consultarHabitacion();
            this.dgv_habitacion.DataSource = tabla;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Limpiar.Enabled = true;

        }

        //flata el evento
        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) != true) && (char.IsControl(e.KeyChar) != true))
            {
                MessageBox.Show("No es un valor permitido");
                e.Handled = true;
            }
        }
        //ventana Buscar Logo
        private void btn_Buscar_Logo_Click(object sender, EventArgs e)
        {
            this.btn_Buscar_Logo.Visible = true;
            this.btn_Nuevo.Enabled = false;
            this.btn_Guardar.Enabled = false;
            this.btn_Actualizar.Enabled = true;
            this.txt_id.Enabled = true;
            this.blanquear_objetos();
            //  this.grilla();
            this.txt_id.Focus();
        }



        


        //ventana Eliminar

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            
            try
            {
                int id =Convert.ToInt32(txt_id.Text);
                if (MessageBox.Show("Está seguro de Eliminar la Habitacion ", "Importante", MessageBoxButtons.YesNo
                             , MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    obj_habitacion.borrar_habitacion(id);
                    MessageBox.Show("Se han Eliminado los Datos del Hotel correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
                    this.blanquear_objetos();
                    tabla = obj_habitacion.consultarHabitacion();
                      this.dgv_habitacion.DataSource = tabla;
                   
                }
            }
                catch (Exception err)
                {
                    MessageBox.Show("Error no se ha podido Eliminar la Habitacion\n" + err.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
        




        //ventana Buscar 

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (this.txt_id.Text == "")
            {
                MessageBox.Show("El id está vacío \n Ingrese un valor para buscar..", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
    
          
                tabla = this.obj_habitacion.buscar_habitacion_X_ID(this.txt_id.Text);

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado ningúna habitacion con ese Id", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    this.blanquear_objetos();

                    this.blanquear_objetos();
                    return;
                }

                this.txt_descripcion.Text = tabla.Rows[0]["descripcion_habitacion"].ToString();
                this.txt_precio.Text = tabla.Rows[0]["costo_habitacion"].ToString();

                this.btn_Buscar_Logo.Enabled = false;

                this.btn_Limpiar.Enabled = true;
                this.btn_Actualizar.Enabled = true;
                this.btn_Guardar.Enabled = false;
                this.btn_Eliminar.Enabled = true;
                this.txt_id.Enabled = false;
                this.txt_id.Focus();
            }
        }





        //ventana blanquear  

        private void blanquear_objetos()
        {
            this.txt_id.Text = "";
            this.txt_descripcion.Text = "";
            this.txt_precio.Clear();
        }



        //evento doble clic del DGV
    private void dgv_habitacion_DoubleClick(object sender, EventArgs e)
        {

            txt_id.Text = dgv_habitacion.CurrentRow.Cells[0].Value.ToString();
            txt_descripcion.Text = dgv_habitacion.CurrentRow.Cells[1].Value.ToString();
            txt_precio.Text = dgv_habitacion.CurrentRow.Cells[2].Value.ToString();
            this.txt_id.Enabled = false;
            this.txt_descripcion.Enabled = true;
            this.btn_Buscar_Logo.Enabled = true;
            this.btn_Guardar.Enabled = false;
            this.btn_Limpiar.Enabled = true;
            this.btn_Eliminar.Enabled = true;
            this.btn_Actualizar.Enabled = true;

        }






        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }


   

        private void label4_Click(object sender, EventArgs e)
        {

        }




        }
}


