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
using tp_pav1.Reportes;

namespace tp_pav1.Vista
{
    public  partial  class  ventana_Facturacion : Form
    {
        public ventana_Facturacion()
        {
            InitializeComponent();
        }

        public ventana_Facturacion(string num)
        {
            InitializeComponent();
            txt_n_factura.Text = num;
        }

        ventanaLogin log = new ventanaLogin();
        validar_Estados valida = new validar_Estados();
        acceso_DB DB = new acceso_DB();
        Hotel ho = new Hotel();
     
        Facturacion factu = new Facturacion();
        Huesped hu = new Huesped();
        Habitacion hab = new Habitacion();
        TipoDocumento tipo = new TipoDocumento();
      

        private void ventanaABM_Facturacion_Load(object sender, EventArgs e)
        {
            this.blanquear_txt_Factura();
            txt_n_factura.Enabled = false;
            txt_tipo_Doc.Enabled = false;
            txt_dni_huesped.Enabled = false;
            txt_nombre_huesped.Enabled = false;
            this.cargar_Hotel();
            //this.cargar_ID_Empleado();
           
            this.cargar_Huesped();
            this.cargar_Habitacion();
            this.cargar_servicio();
            this.cargar_Instalacion();
      
           

        }


        private void cargar_Hotel()
        {
            DataTable tabla = new DataTable();
            tabla = ho.consultarHotel();
            cbo_hotel.DataSource = tabla;
            cbo_hotel.DisplayMember = "nombre";
            cbo_hotel.ValueMember = "id_hotel";
            cbo_hotel.SelectedIndex = -1;
        }


        private void cargar_ID_Empleado()
        {

            DataTable tabla = new DataTable();
            tabla = DB.consultaDB("select * from Usuario where id_user=" + ventanaLogin.id);
            txt_vendedor.Text = tabla.Rows[0]["nombre_user"].ToString().Trim();

    
        }


      
        


        private void btn_Huesped_Click(object sender, EventArgs e)
        {
            ventanaABM_Huesped hue = new ventanaABM_Huesped();
            hue.Show();
        }


        private void blanquear_objetos_Huespedes()
        {

            txt_tipo_Doc.Clear();
            txt_dni_huesped.Clear();
            txt_nombre_huesped.Clear();
        }


        public void cargar_servicio()
        {
            DataTable tabla = new DataTable();
            tabla=factu.consultar_Servicio();
            this.dgv_servicio.DataSource = tabla;
        }


        public void cargar_Huesped()
        {
            DataTable tabla = new DataTable();
            tabla = factu.consultar_Huesped();
            this.dgv_huesped.DataSource = tabla;
        }

        public void cargar_Habitacion()
        {
            DataTable tabla = new DataTable();
            tabla = factu.consultar_Habitacion();
            this.dgv_habitacion.DataSource = tabla;
        }


        public void cargar_Instalacion()
        {
            DataTable tabla = new DataTable();
            tabla = factu.consultar_Instalacion();
            this.dgv_instalacion.DataSource = tabla;
        }



        private void dgv_huesped_DoubleClick(object sender, EventArgs e)
        {

            this.blanquear_objetos_Huespedes();
           txt_tipo_Doc.Text= dgv_huesped.CurrentRow.Cells[0].Value.ToString();
           txt_dni_huesped.Text= dgv_huesped.CurrentRow.Cells[1].Value.ToString();
            txt_nombre_huesped.Text = dgv_huesped.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgv_servicio_DoubleClick(object sender, EventArgs e)
        {

            txtCant.Clear();
            txtCod.Text = dgv_servicio.CurrentRow.Cells[0].Value.ToString();
            txtDesc.Text = dgv_servicio.CurrentRow.Cells[1].Value.ToString();
            txtCosto.Text = dgv_servicio.CurrentRow.Cells[2].Value.ToString();
            txtCant.Focus();
        }

        private void dgv_habitacion_DoubleClick(object sender, EventArgs e)
        {
            txtCant.Clear();
            txtCod.Text = dgv_habitacion.CurrentRow.Cells[0].Value.ToString();
            txtDesc.Text = dgv_habitacion.CurrentRow.Cells[1].Value.ToString();
            txtCosto.Text = dgv_habitacion.CurrentRow.Cells[2].Value.ToString();
            txtCant.Focus();
        }

        private void dgv_instalacion_DoubleClick(object sender, EventArgs e)
        {
            txtCant.Clear();
            txtCod.Text = dgv_instalacion.CurrentRow.Cells[0].Value.ToString();
            txtDesc.Text = dgv_instalacion.CurrentRow.Cells[1].Value.ToString();
            txtCosto.Text = "0";
            txtCant.Focus();

        }

        public void blanquear_txt_Factura()
        {
            txt_n_factura.Text = "0";
            cbo_hotel.SelectedIndex = -1;
            txt_tipo_Doc.Clear();
            txt_dni_huesped.Clear();
            txt_nombre_huesped.Clear();
            txtCod.Clear();
            txtDesc.Clear();
            txtCosto.Clear();
            txtCant.Clear();
            cont_fila = 0;
            dgv_factu.Rows.Clear();
            txt_total.Clear();
            
            
        }


        public static int cont_fila=0;
        public static double total = 0;
        private void btn_Colocar_Click(object sender, EventArgs e)
        {

            bool existe = false;


            //primero valido los campos a cargar
            if (valida.ValidarCampoVacio(txtCod.Text) == true || valida.ValidarTextoNumero(txtCod.Text) == false)
            {
                valida.MensajeSalida("Codigo");
                txtCod.Focus();
            }
            else if (valida.ValidarCampoVacio(txtDesc.Text))
            {
                valida.MensajeSalida("Descripcion");
                txtDesc.Focus();
            }
            else if (valida.ValidarCampoVacio(txtCosto.Text) == true || valida.ValidarTextoNumero(txtCosto.Text) == false)
            {
                valida.MensajeSalida("Costo");
                txtCosto.Focus();
            }
            else if (valida.ValidarCampoVacio(txtCant.Text) == true || valida.ValidarTextoNumero(txtCant.Text) == false)
            {
                valida.MensajeSalida("cantidad");
                txtCant.Focus();
            }

            else //si to esta bien y el contador de filas es cero , es decir no hay ningun producto
            {
                if (cont_fila == 0)
                {
                    //agrega al dataGridView principal los datos de los txt
                    dgv_factu.Rows.Add(txtCod.Text, txtDesc.Text, txtCosto.Text, txtCant.Text);
                    //calcula para el importe 
                    double importe = Convert.ToDouble(dgv_factu.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dgv_factu.Rows[cont_fila].Cells[3].Value);
                    dgv_factu.Rows[cont_fila].Cells[4].Value = importe; //el importe esta en la celda 4
                    //   0           1         2      3       4
                    //Codigo  Descripcion  Costo  Cantdad importe
                    cont_fila++;
                }

                    //si es falso y lasfilas son distintas de cero guardo el indice de fila en una variable auxiliar num_fila
                else
                {
                    int num_fila = 0;

                    //recorro todas las filas y celdas
                    foreach (DataGridViewRow fila in dgv_factu.Rows)
                    {
                        //verifico si en cada fila recorrida si en la celda de la posicion cero del codigo es igual al txt
                        if (fila.Cells[0].Value.ToString() == txtCod.Text)
                        {
                            //si esverdad existe es true y guardo elindice
                            existe = true;
                            num_fila = fila.Index;
                        }
                    }

                    //ahora si existe solo actualizo la cantidad posicion 3
                    if (existe == true)
                    {
                        dgv_factu.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(txtCant.Text) + Convert.ToDouble(dgv_factu.Rows[num_fila].Cells[3].Value)).ToString();
                        //vuelvo a realizar elcalculo del importe
                        double importe = Convert.ToDouble(dgv_factu.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dgv_factu.Rows[num_fila].Cells[3].Value);
                        dgv_factu.Rows[num_fila].Cells[4].Value = importe;
                    }
                    else //si no existe el solo agrega el nuevo producto en una nueva fila abajo
                    {
                        dgv_factu.Rows.Add(txtCod.Text, txtDesc.Text, txtCosto.Text, txtCant.Text);
                        double importe = Convert.ToDouble(dgv_factu.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dgv_factu.Rows[cont_fila].Cells[3].Value);
                        dgv_factu.Rows[cont_fila].Cells[4].Value = importe;

                        cont_fila++;
                    }
                }


                //ahora calculo el total
                total = 0;
                foreach (DataGridViewRow fila in dgv_factu.Rows)
                {
                    total += Convert.ToDouble(fila.Cells[4].Value);
                }
                txt_total.Text ="$"+ total.ToString();
            }

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if(cont_fila> 0)
            {
                total = total - (Convert.ToDouble(dgv_factu.Rows[dgv_factu.CurrentRow.Index].Cells[4].Value));
                txt_total.Text = total.ToString();
                dgv_factu.Rows.RemoveAt(dgv_factu.CurrentRow.Index);

                cont_fila--;
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            this.blanquear_txt_Factura();
        }

        private void btn_refrescar_huesped_Click(object sender, EventArgs e)
        {
            this.cargar_Huesped();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (cbo_hotel.SelectedIndex == -1)
                {

                    MessageBox.Show("Debe seleccionar un Hotel de la lista", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                else
                    if (txt_nombre_huesped.Text == "")
                    {

                        MessageBox.Show("Debe seleccionar un Huesped de la Grilla", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    else
                        if (cont_fila == 0)
                        {
                            MessageBox.Show("Debe tener un producto en la lista para guardar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            return;
                        }

                        else
                        {

                            //creo una tabla
                            DataTable t = new DataTable();

                            t = factu.ObtenerNumeroFactu();

                            string num = t.Rows[0]["Numero"].ToString();

                            //MessageBox.Show("el numero mayor es " + num);

                            if (string.IsNullOrWhiteSpace(num))
                            {
                                factu.NumeroFactura = 0;
                                txt_n_factura.Text = factu.NumeroFactura.ToString();
                            }


                            else
                            {


                                factu.NumeroFactura = int.Parse(num) + 1;
                                txt_n_factura.Text = factu.NumeroFactura.ToString();
                            }


                            //debe ir el cierre delallave anterior si o si
                            DataTable tabla = new DataTable();
                            tabla = DB.RecuperarFechaActual();
                            factu.FechaFactura =tabla.Rows[0][0].ToString();

                            MessageBox.Show("La fecha es" + factu.FechaFactura.ToString() );

                            factu.ID_Hotel = int.Parse(cbo_hotel.SelectedValue.ToString());
                            factu.ID_TipoDocumento = int.Parse(txt_tipo_Doc.Text);
                            factu.NumDocumento = int.Parse(txt_dni_huesped.Text);
                            factu.NombreHuesped = txt_nombre_huesped.Text;

                            factu.ActualizarFactura();//guarda los datos en factura

                            foreach (DataGridViewRow fila in dgv_factu.Rows)
                            {

                                factu.CodigoProducto = int.Parse(fila.Cells[0].Value.ToString());
                                factu.DescripcionProducto = fila.Cells[1].Value.ToString();
                                factu.PrecioVendido = float.Parse(fila.Cells[2].Value.ToString());
                                factu.CantidadVendida = float.Parse(fila.Cells[3].Value.ToString());

                                factu.ActualizarDetalleFactura();


                            }
                            MessageBox.Show("Se ha ingresado con exito ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
            //}

            //catch (Exception)
            //{
            //    MessageBox.Show("No se Ha podido Realizar la Operacion", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            //}

        }



        private void btn_Facturar_Click(object sender, EventArgs e)
        {
            Reporte_Facturacion report = new Reporte_Facturacion();
           
            report.ShowDialog();
        }
        

        private void btn_ConsultarFactu_Click(object sender, EventArgs e)
        {
            ventana_Consultas_Facturacion cons = new ventana_Consultas_Facturacion();
            //this.Hide();
            cons.ShowDialog();
        }



        //eventos no programables
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_ID_Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


       
    }
}

