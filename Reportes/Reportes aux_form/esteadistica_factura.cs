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
    public partial class esteadistica_factura : Form
    {
        public esteadistica_factura()
        {
            InitializeComponent();
        }

        private void esteadistica_factura_Load(object sender, EventArgs e)
        {
            acceso_DB _BD = new acceso_DB();
            string sql = "";

            sql = @"SELECT huespedes.nombre as Descriptor
                 , count(*) as Datos
                 FROM factura join huespedes ON 
                        factura.id_huesped = huespedes.id_huesped
                 GROUP BY huespedes.nombre";

            //            EstadisticaBindingSource.DataSource = _BD.consulta(sql);
            //            reportViewer2.RefreshReport();
            //estadisticaBindingSource.DataSource = _BD.consultaDB(sql);
            //this.reportViewer1.RefreshReport();
            estadisticaBindingSource.DataSource = _BD.consultaDB(sql);
            this.reportViewer1.RefreshReport();
        }
    }
}
