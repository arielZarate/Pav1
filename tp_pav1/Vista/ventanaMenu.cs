using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_pav1.Reportes_Facturacion;
using tp_pav1.Vista;


//importadas


namespace tp_pav1
{
    public partial class ventanaMenu : Form
    {
        public ventanaMenu()
        {
            InitializeComponent();
        }

        private void ventanaMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quiere salir del sistema "
               , "Atencion ", MessageBoxButtons.YesNo
               , MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                //por verdadero se asigna al parametro de entrada el valor de falso
                //para que el programa finalice
                e.Cancel =false;


               // this.Close();
               // this.Dispose();
             }
        }



       

        private void ventanaMenu_Load(object sender, EventArgs e)
        {

        }

        private void newHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventanaABM_Hotel hotel = new ventanaABM_Hotel();
            //this.Hide();   No se debe ocultar la ventana de menu ya que queremos que este visible como  fondo del formulario
            hotel.ShowDialog();
            
        }



        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventanaABM_Empleado empleado = new ventanaABM_Empleado();
            //this.Hide();   No se debe ocultar la ventana de menu ya que queremos que este visible como  fondo del formulario
            empleado.ShowDialog();
        }

        private void habitacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ventanaABM_Habitacion habi = new ventanaABM_Habitacion();
            //this.Hide();   No se debe ocultar la ventana de menu ya que queremos que este visible como  fondo del formulario
             habi.ShowDialog();
        }

        private void instalacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ventanaABM_Instalacion insta = new ventanaABM_Instalacion();
            //this.Hide();   No se debe ocultar la ventana de menu ya que queremos que este visible como  fondo del formulario
            insta.ShowDialog();
        }

        private void serviciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ventanaABM_Servicio servi = new ventanaABM_Servicio();
            //this.Hide();   No se debe ocultar la ventana de menu ya que queremos que este visible como  fondo del formulario
            servi.ShowDialog();
        }

     

        private void huespedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventanaABM_Huesped huesped = new ventanaABM_Huesped();
            //this.Hide();   No se debe ocultar la ventana de menu ya que queremos que este visible como  fondo del formulario
             huesped.ShowDialog();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventana_Facturacion factu = new ventana_Facturacion();
            factu.ShowDialog();
        }

        private void estadisticasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Estadistica_Facturacion esta = new Estadistica_Facturacion();
            esta.ShowDialog();
        }

        
      
    }
}
