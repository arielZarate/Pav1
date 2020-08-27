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
    public partial class estadistica_hues_serv : Form
    {
        public estadistica_hues_serv()
        {
            InitializeComponent();
        }

        private void estadistica_hues_serv_Load(object sender, EventArgs e)
        {
            acceso_DB _BD = new acceso_DB();
            string sql = "";

            sql = @"SELECT huespedes.nombre as Descriptor
                 , count(*) as Datos
                 FROM registro join huespedes ON 
                        registro.id_huesped = huespedes.id_huesped
                 GROUP BY huespedes.nombre";

            //            EstadisticaBindingSource.DataSource = _BD.consulta(sql);
            //            reportViewer2.RefreshReport();
           estadisticaBindingSource.DataSource = _BD.consultaDB(sql);
            //this.reportViewer1.RefreshReport();
           
            this.reportViewer1.RefreshReport();
           
        }
    }
}
