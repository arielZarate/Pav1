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
    public partial class Registro : Form
    {
       Hotel obj_hotel = new Hotel();
       Huesped obj_huesped = new Huesped();
       Instalacion obj_instalacion = new Instalacion();
       Habitacion obj_habitacion = new Habitacion();
       Servicio obj_servicio = new Servicio();
        acceso_DB _DB = new acceso_DB();
        Estado obj_estado = new Estado();
        Registroh obj_registro = new Registroh();
        int huespedr = 0;
        int habitacionr = 0;
        int servicior = 0;
        int instalacionr = 0;
        int hotelr = 0;
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            this.grilla_huesped();
            //this.grilla_habitacion();
            this.grilla_instalacion();
            this.grilla_servicio();
            this.cmb_hotel.DataSource = obj_hotel.consultarHotel();
            this.cmb_hotel.DisplayMember = "nombre";
            this.cmb_hotel.ValueMember = "id_hotel";
            
        
        }
         private void grilla_huesped ()
               {
            DataTable tabla_grilla = new DataTable();
            tabla_grilla = obj_huesped.buscar_x_patron_huesped("1");
            if (tabla_grilla.Rows.Count == 0)
                 {
                MessageBox.Show("No se encontró usuario con ese patrón");
                return;
                 }
            this.Dgv_huesped.DataSource = tabla_grilla;
               }

        private void grilla_habitacion (int patron)
               {
            DataTable tabla_grilla = new DataTable();
            tabla_grilla = obj_habitacion.buscar_x_patron_habitacion(patron.ToString());
            if (tabla_grilla.Rows.Count == 0)
                 {
                MessageBox.Show("No se encontró usuario con ese patrón");
                return;
                 }
            this.Dgv_habitacion.DataSource = tabla_grilla;
               }
        private void grilla_instalacion()
        {
            DataTable tabla_grilla = new DataTable();
            tabla_grilla = obj_instalacion.buscar_x_patrones("1");
            if (tabla_grilla.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró usuario con ese patrón");
                return;
            }
            this.Dgv_Instalacion.DataSource = tabla_grilla;
        }
        private void grilla_servicio()
        {
            DataTable tabla_grilla = new DataTable();
            tabla_grilla = obj_servicio.buscar_x_patrones("1");
            if (tabla_grilla.Rows.Count == 0)
            {
                MessageBox.Show("No se encontró usuario con ese patrón");
                return;
            }
            this.Dgv_Servicio.DataSource = tabla_grilla;
        }

        private void Dgv_huesped_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtNumHuesped.Text = this.Dgv_huesped.CurrentRow.Cells[0].Value.ToString();
            huespedr = int.Parse( this.txtNumHuesped.Text);
            this.txtNomHuesped.Text = this.Dgv_huesped.CurrentRow.Cells[1].Value.ToString();
            this.txtNacionalidadHuesped.Text = this.Dgv_huesped.CurrentRow.Cells[6].Value.ToString();
            this.txtTarjetaHuesped.Text = this.Dgv_huesped.CurrentRow.Cells[5].Value.ToString();
            this.txtApellidoHuesped.Text = this.Dgv_huesped.CurrentRow.Cells[2].Value.ToString();
        }

        private void Dgv_habitacion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtHabitacionHuesped.Text = this.Dgv_habitacion.CurrentRow.Cells[0].Value.ToString();
            habitacionr = int.Parse(this.txtHabitacionHuesped.Text);
        }

        private void Dgv_Servicio_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtservicio.Text = this.Dgv_Servicio.CurrentRow.Cells[1].Value.ToString();
            servicior = int.Parse( this.Dgv_Servicio.CurrentRow.Cells[0].Value.ToString());
        }

        private void Dgv_Instalacion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtinstalacion.Text = this.Dgv_Instalacion.CurrentRow.Cells[1].Value.ToString();
            instalacionr = int.Parse(this.Dgv_Instalacion.CurrentRow.Cells[0].Value.ToString());
        }

        private void cmb_hotel_Click(object sender, EventArgs e)
        {
           //this.grilla_habitacion(int.Parse(this.cmb_hotel.SelectedValue.ToString()));
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            //this.grilla_habitacion(int.Parse(this.cmb_hotel.SelectedValue.ToString()));
            this.Dgv_habitacion.Enabled = false;
            this.Dgv_huesped.Enabled = false;
            this.Dgv_Instalacion.Enabled = false;
            this.Dgv_Servicio.Enabled = false;
            this.cmb_hotel.Enabled = false;
            this.btn_actualizar.Enabled = false;
            this.btn_buscar.Enabled = false;
            this.btn_grabar.Enabled = false;
            this.btn_nuevo.Enabled = true;
            this.btn_volver.Enabled = false;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            //_DB.cerrar_transaccion();
            _DB.iniciar_transaccion();
             this.lbl_estado.Visible=true;
             this.lbl_estado.Text = "Transacción iniciada";
             this.btn_grabar.Enabled = true;
             this.btn_actualizar.Enabled = true;
             this.Dgv_habitacion.Enabled = true;
             this.Dgv_huesped.Enabled = true;
             this.Dgv_Instalacion.Enabled = true;
             this.Dgv_Servicio.Enabled = true;
             this.cmb_hotel.Enabled = true;
             this.btn_buscar.Enabled = true;
             this.btn_nuevo.Enabled = false;
             //this.btn_volver.Enabled = false;
        
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            _DB.cerrar_transaccion();
            this.grilla_huesped();
            this.lbl_estado.Text = "Transacción Finalizada";
            this.btn_volver.Enabled = true;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
           string ocupado ="Ocupado";
            string sql1 = @"UPDATE Habitacion 
                       SET estado = '" + ocupado + "'"
                      + " WHERE id_habitacion = " + this.txtHabitacionHuesped.Text.ToString();
            
            _DB.Grabar_Modificar(sql1);
            string sql2 =@"UPDATE Huespedes
            SET habitacion ='" + txtHabitacionHuesped.Text.Trim() + "'"
                         + ", hotel = '" + this.cmb_hotel.SelectedValue.ToString() + "'"
            + " WHERE id_huesped = " + this.txtNumHuesped.Text.ToString();
            _DB.Grabar_Modificar(sql2);

            string sqlregistro =@" INSERT INTO Registro 
                         ( id_huesped, id_habitacion, id_servicio, id_instalacion, id_hotel) VALUES (" +
                         huespedr + ", " +
                         habitacionr + ", " +
                         servicior + ", " +
                         instalacionr + ", " +
                         hotelr + ")";
            _DB.Grabar_Modificar(sqlregistro);

//            string sql3 = @"INSERT INTO HuespedXHabitacion
//            (id_habitacion, id_tipo_doc, num_doc, fecha_hospedaje, id_hotel) 
//                           VALUES ("+this.txtHabitacionHuesped.Text.ToString() +","+ "'1'"+","+this.txtNumHuesped.Text.ToString()+","+"22/05/2019"+","+this.cmb_hotel.SelectedValue.ToString()+")";
//            _DB.Grabar_Modificar(sql3);

            this.grilla_habitacion(-1);
                   this.lbl_estado.Text = "Transacción en Proceso";
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.grilla_habitacion(int.Parse(this.cmb_hotel.SelectedValue.ToString()));
        }

        private void cmb_hotel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
     
    }
}
