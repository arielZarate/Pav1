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
    public partial class estadistica_fecha_factura : Form
    {
        public estadistica_fecha_factura()
        {
            InitializeComponent();
        }

        private void estadistica_fecha_factura_Load(object sender, EventArgs e)
        {
            acceso_DB _BD = new acceso_DB();
            string sql = "";

            sql = @"SELECT factura.f_factura as Descriptor
                 , count(*) as Datos
                 FROM factura join detalle_factura ON 
                        factura.n_factura = detalle_factura.n_factura
                 GROUP BY factura.f_factura";

            //            EstadisticaBindingSource.DataSource = _BD.consulta(sql);
            //            reportViewer2.RefreshReport();
            estadisticaBindingSource.DataSource = _BD.consultaDB(sql);

            this.reportViewer1.RefreshReport();
        }
    }
}
