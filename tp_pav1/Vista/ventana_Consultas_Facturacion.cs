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
    public partial class ventana_Consultas_Facturacion : Form
    {
        public ventana_Consultas_Facturacion()
        {
            InitializeComponent();
        }
        
        Facturacion facturacion = new Facturacion();


   
        private void dgv_Facturas_DoubleClick(object sender, EventArgs e)
        {
           
     
            
        }


        private void ventana_Consultas_Facturacion_Load(object sender, EventArgs e)
        {
             DataTable t = new DataTable();

            t = facturacion.Datos_Factura();

            dgv_Facturas.DataSource = t;
        }

        private void dgv_Facturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        //ventana_Facturacion fact = new ventana_Facturacion();
        //    fact.  dgv_Facturas.CurrentRow.Cells[0].Value.ToString();
        //    fact.cbo_hotel.SelectedValue = dgv_Facturas.CurrentRow.Cells[3].Value.ToString();

           
            

        }

        private void dgv_Facturas_DoubleClick_1(object sender, EventArgs e)
        {
            string num_fac = dgv_Facturas.CurrentRow.Cells[0].Value.ToString();
            ventana_Facturacion fact = new ventana_Facturacion(num_fac);
        }

     
        }
    }

