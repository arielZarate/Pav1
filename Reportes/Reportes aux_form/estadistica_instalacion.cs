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
    public partial class estadistica_instalacion : Form
    {
        public estadistica_instalacion()
        {
            InitializeComponent();
        }

        private void estadistica_instalacion_Load(object sender, EventArgs e)
        {
            acceso_DB _BD = new acceso_DB();
            string sql = "";

            sql = @"SELECT Instalacion.descripcion_instalacion as Descriptor
                 , count(*) as Datos
                 FROM registro join Instalacion ON 
                        registro.id_instalacion = Instalacion.id_instalacion
                 GROUP BY Instalacion.descripcion_instalacion";

            //            EstadisticaBindingSource.DataSource = _BD.consulta(sql);
            //            reportViewer2.RefreshReport();
            estadisticaBindingSource.DataSource = _BD.consultaDB(sql);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
