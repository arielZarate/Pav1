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
    public partial class estadistica_detalle : Form
    {
        public estadistica_detalle()
        {
            InitializeComponent();
        }

        private void estadistica_detalle_Load(object sender, EventArgs e)
        {
            acceso_DB _BD = new acceso_DB();
            string sql = "";

            sql = @"SELECT detalle_factura.descipcion as Descriptor
                 , count(*) as Datos
                 FROM factura join detalle_factura ON 
                        factura.n_factura = detalle_factura.n_factura
                 GROUP BY detalle_factura.descipcion";

            //            EstadisticaBindingSource.DataSource = _BD.consulta(sql);
            //            reportViewer2.RefreshReport();
            estadisticaBindingSource.DataSource = _BD.consultaDB(sql);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
