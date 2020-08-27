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

namespace tp_pav1.Vista
{
    public partial class estadistica_montos : Form
    {
        public estadistica_montos()
        {
            InitializeComponent();
        }

        private void estadistica_montos_Load(object sender, EventArgs e)
        {
            acceso_DB _BD = new acceso_DB();
            string sql = "";

            sql = @"SELECT factura.total as Descriptor
                 , count(*) as Datos
                 FROM huespedes join factura ON 
                        huespedes.id_huesped = factura.id_huesped
                 GROUP BY factura.total";

            //            EstadisticaBindingSource.DataSource = _BD.consulta(sql);
            //            reportViewer2.RefreshReport();
            estadisticaBindingSource.DataSource = _BD.consultaDB(sql);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
