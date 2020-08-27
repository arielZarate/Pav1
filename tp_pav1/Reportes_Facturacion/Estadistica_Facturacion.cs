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

namespace tp_pav1.Reportes_Facturacion
{
    public partial class Estadistica_Facturacion : Form
    {
        public Estadistica_Facturacion()
        {
            InitializeComponent();
        }

        private void Estadistica_Total_x_numFAc_Load(object sender, EventArgs e)
        {

            this.reportViewer_estad_factu.RefreshReport();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
           
            acceso_DB BD = new acceso_DB();
            DataTable tabla = new DataTable();
            Facturacion fac = new Facturacion();



            if (this.txt_mes.Text == "")
            {
                MessageBox.Show("El campo mes esta vacio \n Ingrese un valor para buscar..", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            else

                if (this.txt_monto.Text == "")
                {
                    MessageBox.Show("El campo monto esta vacio \n Ingrese un valor para buscar..", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    return;
                }

                else
                {
                    int num=int.Parse(txt_mes.Text);
                    float x = float.Parse(txt_monto.Text);
                    tabla = fac.Estadistica_Facturacion(num, x);

                    if (tabla.Rows.Count == 0)
                    {
                      MessageBox.Show("No se ha encontrado ningun Monto con ese Numero", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        txt_mes.Clear();
                        txt_monto.Clear();
                        txt_mes.Focus();
                        return;
                    }

                    Datos_EstadisticaBindingSource.DataSource = tabla;
                   Estadistica_FactuBindingSource.DataSource = tabla;
                    reportViewer_estad_factu.RefreshReport();
                }
        }
    }
}

