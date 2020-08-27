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
    public partial class ventanaABM_Empleado : ventanaABM_Padre
    {
        public ventanaABM_Empleado()
        {
            InitializeComponent();
        }


        //instancia de objetos 

        Empleado emple = new Empleado();
        Puesto pue = new Puesto();
        Hotel ho = new Hotel();
        Usuario usu = new Usuario();
        DataTable tabla = new DataTable();
        validar_Estados valida = new validar_Estados();



        private void ventanaABM_Empleado_Load(object sender, EventArgs e)
        {
            //inicializa ya con este estado predeterminado
            //borra todo
            txtLegajoEmpleado.Clear();
            txt_nomEmpleado.Clear();
            txt_apeEmpleado.Clear();
            txt_FechaIngresoEmpleado.Clear();
            cbo_Puesto.SelectedIndex = -1;
            cbo_Hotel.SelectedIndex = -1;

            //control de botones habilitados al iniciar
            this.btn_Nuevo.Enabled = true;
            this.btn_Guardar.Enabled = false;
            this.btn_Actualizar.Enabled = false;
            this.btn_Menu.Enabled = true;
            this.btn_Limpiar.Enabled = false;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Consultar.Enabled = true;
            this.btn_Eliminar.Enabled = false;
            this.txtLegajoEmpleado.Focus();



            //COMBOBOXES

            this.cbo_Hotel.DataSource = this.ho.consultarHotel();
            this.cbo_Hotel.DisplayMember = "nombre";
            this.cbo_Hotel.ValueMember = "id_hotel";
            this.cbo_Hotel.SelectedIndex = -1;

            this.cbo_Puesto.DataSource = this.pue.ConsultarPuesto();
            this.cbo_Puesto.DisplayMember = "descripcion";
            this.cbo_Puesto.ValueMember = "id_puesto";
            this.cbo_Puesto.SelectedIndex = -1;
            //**************************************************
        }


        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            //borra todo
            txtLegajoEmpleado.Clear();
            txt_nomEmpleado.Clear();
            txt_apeEmpleado.Clear();
            txt_FechaIngresoEmpleado.Clear();
            cbo_Puesto.SelectedIndex = -1;
            cbo_Hotel.SelectedIndex = -1;

            //control de botones habilitados al iniciar
            this.btn_Guardar.Enabled = true;
            this.btn_Actualizar.Enabled = false;
            this.btn_Menu.Enabled = true;
            this.btn_Limpiar.Enabled = true;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Eliminar.Enabled = false;
            this.btn_Consultar.Enabled = true;
            this.txtLegajoEmpleado.Enabled = true;
            this.txtLegajoEmpleado.Focus();
        }








        
        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    emple.legajo_e = Convert.ToInt32(this.txtLegajoEmpleado.Text);
            //    emple.nombre_e = this.txt_nomEmpleado.Text;
            //    emple.apellido_e = this.txt_apeEmpleado.Text;
            //    emple.fecha_ingreso_e = this.txt_FechaIngresoEmpleado.Text;
            //    emple.id_puesto_e = int.Parse(this.cbo_Puesto.SelectedValue.ToString());
            //    emple.id_hotel_e = int.Parse(this.cbo_Hotel.SelectedValue.ToString());


            //    this.emple.GrabarEmpleado();
            //    MessageBox.Show("Se han ingresado los Datos correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    tabla = emple.consultarEmpleados();
            //    dgv_Empleado.DataSource = tabla;

            //}

            //catch (Exception Error)
            //{
            //    MessageBox.Show("Error al guardar los datos del empleado\n" + Error.Message , "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            //}

            try
            {

                if ((valida.ValidarCampoVacio(txtLegajoEmpleado.Text)) == true)
                {
                    valida.MensajeSalida("Legajo");

                }
                else

                    if ((valida.ValidarCampoVacio(txt_nomEmpleado.Text)) == true || (valida.ValidarTextoLetra(txt_nomEmpleado.Text) == false))
                    {
                       valida.MensajeSalida("Nombre");
                    }
                    else

                        if ((valida.ValidarCampoVacio(txt_apeEmpleado.Text)) == true || (valida.ValidarTextoLetra(txt_apeEmpleado.Text) == false))
                        {
                            valida.MensajeSalida("apellido");
                        }
                        else
                            if (this.txt_FechaIngresoEmpleado.Text == "" || (valida.Validar_fecha(txt_FechaIngresoEmpleado.Text) == false))
                            {
                                valida.MensajeSalida("Fecha");
                            }
                            else
                                if (cbo_Hotel.SelectedIndex == -1)
                                {
                                   valida.MensajeSalidaCombos("Hotel");
                                }
                                else
                                    if (cbo_Puesto.SelectedIndex == -1)
                                    {

                                        valida.MensajeSalidaCombos("Puesto");
                                    }

                                    else
                                    {
                                        emple.legajo_e = int.Parse(this.txtLegajoEmpleado.Text);
                                        emple.nombre_e = this.txt_nomEmpleado.Text;
                                        emple.apellido_e = this.txt_apeEmpleado.Text;
                                        emple.fecha_ingreso_e = this.txt_FechaIngresoEmpleado.Text;
                                        emple.id_puesto_e = int.Parse(this.cbo_Puesto.SelectedValue.ToString());
                                        emple.id_hotel_e = int.Parse(this.cbo_Hotel.SelectedValue.ToString());

                                        this.emple.GrabarEmpleado();
                                        MessageBox.Show("Se han ingresado los Datos correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
                                        tabla = emple.consultarEmpleados();
                                        dgv_Empleado.DataSource = tabla;
                                    }
            }

            
            catch (Exception Error)
            {
                MessageBox.Show("Error al guardar los datos del empleado\n" + Error.Message, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        






        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int lega = Convert.ToInt32(txtLegajoEmpleado.Text);

                if (MessageBox.Show("Está seguro de Eliminar el Empleado ", "Importante", MessageBoxButtons.YesNo
                     , MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    emple.EliminarEmpleado(lega);

                    MessageBox.Show("Se han Eliminado los Datos correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
                   

                    tabla = emple.consultarEmpleados();
                    dgv_Empleado.DataSource = tabla;
                    txtLegajoEmpleado.Clear();
                    txt_nomEmpleado.Clear();
                    txt_apeEmpleado.Clear();
                    txt_FechaIngresoEmpleado.Clear();
                    cbo_Puesto.SelectedIndex = -1;
                    cbo_Hotel.SelectedIndex = -1;

                }
            }

            catch (Exception err)
            {
                MessageBox.Show("Error no se ha podido Eliminar el empleado\n" + err.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void btn_Actualizar_Click_1(object sender, EventArgs e)
        {

            //try
            //{
            //    int leg = int.Parse(this.txtLegajoEmpleado.Text);

            //    emple.nombre_e = this.txt_nomEmpleado.Text;
            //    emple.apellido_e = this.txt_apeEmpleado.Text;
            //    emple.fecha_ingreso_e = this.txt_FechaIngresoEmpleado.Text;
            //    emple.id_puesto_e = Convert.ToInt32(this.cbo_Puesto.SelectedValue.ToString());
            //    emple.id_hotel_e = Convert.ToInt32(this.cbo_Hotel.SelectedValue.ToString());

            //    emple.ModificarEmpleado(leg);
            //    MessageBox.Show("Se ha actualizado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    tabla = emple.consultarEmpleados();
            //    dgv_Empleado.DataSource = tabla;
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show("Error no se ha podido Actualizar el empleado" + err.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            try
            {
                int leg = int.Parse(this.txtLegajoEmpleado.Text);


                if ((valida.ValidarCampoVacio(txt_nomEmpleado.Text)) == true || (valida.ValidarTextoLetra(txt_nomEmpleado.Text) == false))
                {
                    valida.MensajeSalida("Nombre");
                }
                else

                    if ((valida.ValidarCampoVacio(txt_apeEmpleado.Text)) == true || (valida.ValidarTextoLetra(txt_apeEmpleado.Text) == false))
                    {
                        valida.MensajeSalida("apellido");
                    }
                    else
                        if (this.txt_FechaIngresoEmpleado.Text == "" || (valida.Validar_fecha(txt_FechaIngresoEmpleado.Text) == false))
                        {
                           valida.MensajeSalida("Fecha");
                        }
                        else
                            if (cbo_Hotel.SelectedIndex == -1)
                            {
                                valida.MensajeSalidaCombos("Hotel");
                            }
                            else
                                if (cbo_Puesto.SelectedIndex == -1)
                                {

                                    valida.MensajeSalidaCombos("Puesto");
                                }

                                else
                                {
                                    emple.nombre_e = this.txt_nomEmpleado.Text;
                                    emple.apellido_e = this.txt_apeEmpleado.Text;
                                    emple.fecha_ingreso_e = this.txt_FechaIngresoEmpleado.Text;
                                    emple.id_puesto_e = Convert.ToInt32(this.cbo_Puesto.SelectedValue.ToString());
                                    emple.id_hotel_e = Convert.ToInt32(this.cbo_Hotel.SelectedValue.ToString());


                                    emple.ModificarEmpleado(leg);
                                    MessageBox.Show("Se ha actualizado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
                                    tabla = emple.consultarEmpleados();
                                    dgv_Empleado.DataSource = tabla;
                                }
            }

            catch (Exception Error)
            {
                MessageBox.Show("Error al Actualizar los datos del empleado\n" + Error.Message, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }


        }




        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {


              
              DataTable tabla = new DataTable();
                int leg_aux = Convert.ToInt32(this.txtLegajoEmpleado.Text);
                this.txtLegajoEmpleado.Enabled = true;
                tabla = this.emple.BuscarEmpleado_X_Id(leg_aux);
                this.txt_nomEmpleado.Text = tabla.Rows[0]["nombre"].ToString();
                this.txt_apeEmpleado.Text = tabla.Rows[0]["apellido"].ToString();
                this.txt_FechaIngresoEmpleado.Text = tabla.Rows[0]["fecha_ingreso"].ToString();
                this.cbo_Puesto.SelectedValue = tabla.Rows[0]["id_puesto"];
                this.cbo_Hotel.SelectedValue = tabla.Rows[0]["id_hotel"];
                //botones
                this.btn_Buscar_Logo.Enabled = false;
                this.txtLegajoEmpleado.Enabled = false;
                this.btn_Eliminar.Enabled = true;
                this.btn_Limpiar.Enabled = true;
                this.btn_Actualizar.Enabled = true;
                this.btn_Guardar.Enabled = false;


            }

            catch (Exception errr)
            {
             
                MessageBox.Show("El id está vacío o algo inesperado a ocurrido \n" + errr.Message + " \n Ingrese un valor para buscar..", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
               
                return;
             

            }


        }


        private void btn_Limpiar_Click(object sender, EventArgs e)
        {

            txtLegajoEmpleado.Clear();
            txtLegajoEmpleado.Enabled = true;
            txt_nomEmpleado.Clear();
            txt_apeEmpleado.Clear();
            txt_FechaIngresoEmpleado.Clear();
            cbo_Puesto.SelectedIndex = -1;
            cbo_Hotel.SelectedIndex = -1;
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            tabla = emple.consultarEmpleados();
            dgv_Empleado.DataSource = tabla;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;

        }

        private void btn_Buscar_Logo_Click_1(object sender, EventArgs e)
        {
            //el codigo anterior ya viene precargado en el form Padre
            this.txtLegajoEmpleado.Focus();

        }




    


        //doble click
        private void dgv_Empleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //opcion1
            //txt_pk.Text = grid1.CurrentRow.Cells[0].Value.ToString();
            //txt_n_criticidad.Text = grid1.CurrentRow.Cells[1].Value.ToString();

            //la diferencia esta en que yo utilizo una variable llamada fila de la cual tebgo el indice 
            //al cual accedo a todo el contenido de las celdas
            //opcion2
            DataGridViewRow fila = dgv_Empleado.Rows[e.RowIndex];
            this.txtLegajoEmpleado.Text = fila.Cells["legajo"].Value.ToString();
            this.txt_nomEmpleado.Text = fila.Cells["nombre"].Value.ToString();
            this.txt_apeEmpleado.Text = fila.Cells["apellido"].Value.ToString();
            this.txt_FechaIngresoEmpleado.Text = fila.Cells["fecha_ingreso"].Value.ToString();
            this.cbo_Puesto.SelectedValue = fila.Cells["id_puesto"].Value;
            this.cbo_Hotel.SelectedValue = fila.Cells["id_hotel"].Value;
            //    //botones
            this.btn_Buscar_Logo.Enabled = true;
            this.txtLegajoEmpleado.Enabled = false;
            this.btn_Limpiar.Enabled = true;
            this.btn_Actualizar.Enabled = true;
            this.btn_Guardar.Enabled = false;
            this.btn_Eliminar.Enabled = true;
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {

        }



    }
}


    //no usar esto!!

    //private void dgv_Empleado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)

    //{

    //}

             

        //Propiedades de dataGridView

        //    //esto permite agregar eleiminar o modifcar las filas estando en ejecucuion
        //    Allow user toAdd Rows =false
        //    Allow user toDelete Rows =false
        //    Allow user toModifi Rows =false

        //   Alternating-RowStyleDefault:modifica la forma de ver la celda como elcolor

        //    selectedmode =FullRowsSelect
        //    ScrollBar=permite seleccionar la forma del scroll 

        //    autosize column mode=Fill;
        
    





      //  private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
      //  {
      //      if ((char.IsDigit(e.KeyChar)!=true)&&(char.IsControl(e.KeyChar)!=true))
      //      {
      //          MessageBox.Show("No es un valor permitido");
      //          e.Handled = true;
      //      }
      //  }






//evento doble clic del DGV
//ventana blanquear   
//ventana Buscar 
//ventana Eliminar
//ventana Consultar
//ventana Buscar Logo

//ventana Limpiar
//ventana actualizar
//ventana guardar
//ventana nuevo
//ventana load