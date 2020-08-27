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
using System.Data;

namespace tp_pav1.Vista
{
    public partial class informe_factura : Form
    {
        Factura obj_factura = new Factura();
        Detalle_factura obj_detalle_factura = new Detalle_factura();
        public informe_factura()
        {
            InitializeComponent();
        }
        //private void grilla_factura()
        //{
        //    dgv_factura.DataSource = obj_factura.consultarfactura();
        //}
        //private void grilla_detalle()
        //{
        //    dgv_detalle.DataSource = obj_detalle_factura.consultardetalle();
        //}
        private void informe_factura_Load(object sender, EventArgs e)
        {
            //grilla_detalle();
            //grilla_factura();

            //this.reportViewer1.RefreshReport();
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
            factura_informeBindingSource.DataSource = tabla;
            //huespedesinformeBindingSource.DataSource = tabla;
            this.reportViewer1.RefreshReport();
        }
    }
}
