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
    public partial class Informe_fectura_huesped : Form
    {
        public Informe_fectura_huesped()
        {
            InitializeComponent();
        }

        private void Informe_fectura_huesped_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acceso_DB _BD = new acceso_DB();
            DataTable tabla = new DataTable();
            string sql = "";
            sql = @"SELECT * FROM factura WHERE 1=1";

            //            sql = @"SELECT alumnos.legajo, alumnos.apellido, 
            //                               alumnos.nombres as nombre,
            //                               tipos_sexos.descripcion as sexo
            //                               FROM alumnos join tipos_sexos ON 
            //                                            alumnos.sexo = tipos_sexos.id_sexo
            //                               WHERE 1 = 1 ";

            if (!string.IsNullOrEmpty(txt_patron.Text))
            {
                int i;
                if (int.TryParse(txt_patron.Text, out i))
                {
                    sql += " AND id_huesped = " + txt_patron.Text;
                }
                else
                {
                    if (txt_patron.Text.IndexOf("-") != -1)
                    {
                        string[] datos;
                        datos = txt_patron.Text.Split('-');
                        sql += @" AND id_huesped BETWEEN " + datos[0]
                            + " AND " + datos[1];
                    }
                    else
                    {
                        sql += @" AND f_factura like '%"
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
            facturainformeBindingSource.DataSource = tabla;
            //huespedesinformeBindingSource.DataSource = tabla;
            this.reportViewer1.RefreshReport();
        }
    }
}
