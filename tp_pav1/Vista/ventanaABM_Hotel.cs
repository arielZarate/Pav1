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
    public partial class ventanaABM_Hotel : ventanaABM_Padre
    {
        public ventanaABM_Hotel()
        {
            InitializeComponent();
        }
        Hotel obj_hotel = new Hotel();

        validar_Estados valida = new validar_Estados();
        DataTable tabla = new DataTable();


        //VARIABLE PUBLICA ESTATICA
        public static int id_hotel;

        public int GetID_hotel
        {
            set { id_hotel = value; }
            get { return id_hotel; }
        }

        //ventana load
        private void ventanaABM_Hotel_Load(object sender, EventArgs e)
        {

            this.blanquear_objetos();
            this.txt_id.Focus();

            txt_registrado.Enabled = false;
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
            this.txt_id.Enabled = true;
            this.txt_nombre.Enabled = true;
            this.txt_descripcion.Enabled = true;

            this.txt_id.Focus();

            this.btn_Guardar.Enabled = true;
            this.btn_Actualizar.Enabled =false;
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
                if (valida.ValidarCampoVacio(txt_id.Text) == true || (valida.ValidarTextoNumero(txt_id.Text))==false)
                {
                    valida.MensajeSalida("ID");

                }
                else

                    if ((valida.ValidarCampoVacio(txt_nombre.Text)) == true )
                    {
                        valida.MensajeSalida("Nombre");
                    }
                    else
                        if ((valida.ValidarCampoVacio(txt_descripcion.Text)) == true)
                        {
                            valida.MensajeSalida("Descripcion");
                        }
                        else
                        {



                            obj_hotel.id_hotel = int.Parse(this.txt_id.Text.ToString());
                            obj_hotel.nombre = this.txt_nombre.Text;
                            obj_hotel.descripcion = this.txt_descripcion.Text;
                            obj_hotel.registrado = this.txt_registrado.Text;

                            this.obj_hotel.grabar_hotel();
                            MessageBox.Show("Se han ingresado los Datos correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
                            tabla = obj_hotel.consultarHotel();
                            dgv_Hotel.DataSource = tabla;
                        }

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error al guardar los datos del empleado\n" + Error.Message, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }


        //ventana actualizar
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {

            try
            {
               
               int id  = int.Parse(this.txt_id.Text.ToString());

                if((valida.ValidarCampoVacio(txt_id.Text)==true||(valida.ValidarTextoNumero(txt_id.Text))==false))
                {
                    valida.MensajeSalida("ID");
                }else
                    if ((valida.ValidarCampoVacio(txt_nombre.Text) == true))
                    {
                        valida.MensajeSalida("Nombre");
                    }
                    else
                        if ((valida.ValidarCampoVacio(txt_descripcion.Text) == true) )
                        {
                            valida.MensajeSalida("Descripcion");
                        }
                    else
                    {
                        obj_hotel.nombre = this.txt_nombre.Text;
                        obj_hotel.descripcion = this.txt_descripcion.Text;
                        this.obj_hotel.modificar_hotel(id);
                        MessageBox.Show("Se han Modificado los Datos del hotel correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabla = obj_hotel.consultarHotel();
                        dgv_Hotel.DataSource = tabla;

                    }

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error al Actualizar los datos del Hotel\n" + Error.Message, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

        }

     

        //ventana Limpiar
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            this.txt_id.Text = "";
            this.txt_nombre.Text = "";
            this.txt_descripcion.Text = "";
            this.txt_registrado.Text = "";
            this.txt_id.Focus();
        }



        //ventana Buscar Logo
        private void btn_Buscar_Logo_Click(object sender, EventArgs e)
        {
          
            this.txt_id.Focus();
        }



    //ventana Consultar

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            

            tabla = obj_hotel.consultarHotel();
            this.dgv_Hotel.DataSource=tabla;
            this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
            this.btn_Limpiar.Enabled = true;



        }

    
        //ventana Eliminar

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            try
            {
                int id =Convert.ToInt32(txt_id.Text);
                if (MessageBox.Show("Está seguro de Eliminar el hotel ", "Importante", MessageBoxButtons.YesNo
                             , MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    obj_hotel.borrar_hotel(id);
                    MessageBox.Show("Se han Eliminado los Datos del Hotel correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.btn_Buscar_Logo.Enabled = true; this.btn_Buscar.Visible = false;
                    this.blanquear_objetos();
                    tabla = obj_hotel.consultarHotel();
                    this.dgv_Hotel.DataSource = tabla;
                }
            }
                catch (Exception err)
                {
                    MessageBox.Show("Error no se ha podido Eliminar el hotel\n" + err.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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

                tabla = this.obj_hotel.buscar_por_id(this.txt_id.Text);

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado ningún hotel con ese Id", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    this.blanquear_objetos();
                    return;
                }

                this.txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
                this.txt_descripcion.Text = tabla.Rows[0]["descripcion"].ToString();

                this.btn_Buscar_Logo.Enabled = false;
              
                this.btn_Limpiar.Enabled = true;
                this.btn_Actualizar.Enabled = true;
                this.btn_Eliminar.Enabled = true;
                this.btn_Guardar.Enabled = false;
                this.txt_id.Enabled = true;
                this.txt_id.Focus();




            }
        }

        
        //ventana blanquear

              private void blanquear_objetos()
        {
            this.txt_id.Text = "";
            this.txt_nombre.Text = "";
            this.txt_descripcion.Text = "";
            this.txt_registrado.Text = "";
        }



        //evento doble clic del DGV
              private void dgv_Hotel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
              {
                  //opcion1
                  //txt_pk.Text = grid1.CurrentRow.Cells[0].Value.ToString();
                  //txt_n_criticidad.Text = grid1.CurrentRow.Cells[1].Value.ToString();

                  txt_id.Text = dgv_Hotel.CurrentRow.Cells[0].Value.ToString();
                  txt_nombre.Text = dgv_Hotel.CurrentRow.Cells[1].Value.ToString();
                  txt_descripcion.Text = dgv_Hotel.CurrentRow.Cells[2].Value.ToString();
                  txt_registrado.Text = dgv_Hotel.CurrentRow.Cells[3].Value.ToString();
                  this.txt_id.Enabled = false;
                  this.btn_Buscar_Logo.Enabled = true;
                  this.btn_Guardar.Enabled = false;
                  this.btn_Limpiar.Enabled = true;
                  this.btn_Eliminar.Enabled = true;
                  this.btn_Actualizar.Enabled = true;


               
              }

              private void btn_selec_hotel_Click(object sender, EventArgs e)
              {
                  id_hotel = int.Parse(txt_id.Text);

                  obj_hotel.id_hotel = id_hotel;
                  obj_hotel.nombre = this.txt_nombre.Text;
                  obj_hotel.descripcion = this.txt_descripcion.Text;
                  obj_hotel.registrado = txt_nombre.Text;
                
                  obj_hotel.Registar_Hotel();

                  MessageBox.Show("Hotel Registrado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  this.blanquear_objetos();
                  tabla = obj_hotel.consultarHotel();
                  this.dgv_Hotel.DataSource = tabla;

                  MessageBox.Show("El ID del Hotel guardado es: " + id_hotel);

                
              }

              private void btn_EliminarRegistro_Click(object sender, EventArgs e)
              {
                  obj_hotel.id_hotel = int.Parse(txt_id.Text);
                  obj_hotel.nombre = this.txt_nombre.Text;
                  obj_hotel.descripcion = this.txt_descripcion.Text;
                  obj_hotel.registrado ="";

                  obj_hotel.Eliminar_Registro_Hotel();

                  MessageBox.Show("Se ha eliminado el Registro correctamente","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                  this.blanquear_objetos();
                  tabla = obj_hotel.consultarHotel();
                  this.dgv_Hotel.DataSource = tabla;
                  MessageBox.Show("El ID Eliminado del Registro es: " + id_hotel);
              }
    }
}
