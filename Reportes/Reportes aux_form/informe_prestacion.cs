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
    public partial class informe_prestacion : Form
    {
        public informe_prestacion()
        {
            InitializeComponent();
        }

        private void informe_prestacion_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acceso_DB _BD = new acceso_DB();
            DataTable tabla = new DataTable();
            string sql = "";
            sql = @"SELECT * FROM detalle_factura WHERE 1=1";

          
            if (!string.IsNullOrEmpty(txt_patron.Text))
            {
                int i;
                if (int.TryParse(txt_patron.Text, out i))
                {
                    sql += " AND codigo = " + txt_patron.Text;
                }
                else
                {
                    if (txt_patron.Text.IndexOf("-") != -1)
                    {
                        string[] datos;
                        datos = txt_patron.Text.Split('-');
                        sql += @" AND codigo BETWEEN " + datos[0]
                            + " AND " + datos[1];
                    }
                    else
                    {
                        sql += @" AND descipcion like '%"
                            + txt_patron.Text.Trim() + "%'";
                    }
                }
            }

            tabla = _BD.consultaDB(sql);
            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para mostrar");
                return;
            }
            detalleBindingSource.DataSource = tabla;

            //huespedesinformeBindingSource.DataSource = tabla;
            this.reportViewer1.RefreshReport();
        }
    }
}
