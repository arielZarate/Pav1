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

namespace tp_pav1.Reportes
{
    public partial class Reporte_Facturacion : Form
    {
        public Reporte_Facturacion()
        {
            InitializeComponent();
        }

        private void Reporte_Facturacion_Load(object sender, EventArgs e)
        {

            this.reportViewer_facturacion.RefreshReport();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            acceso_DB BD = new acceso_DB();
            DataTable tabla = new DataTable();
            Facturacion fac = new Facturacion();



            if (this.txt_num_fac.Text == "")
            {
                MessageBox.Show("El Num Factura esta vacio \n Ingrese un valor para buscar..", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                tabla = fac.Buscar_NumeroFactura(txt_num_fac.Text);

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado ninguna Factura con ese Numero", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    txt_num_fac.Clear();
                    txt_num_fac.Focus();
                    return;
                }

                //Reportes_AlumnosBindingSource.DataSource = tabla;
                //reportViewer1.RefreshReport();

                Datos_FacturaBindingSource.DataSource = tabla;
                reportViewer_facturacion.RefreshReport();


            }
        }

        private void reportViewer_facturacion_Load(object sender, EventArgs e)
        {

        }
    }
}
