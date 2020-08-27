using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using tp_pav1.Back_End;
using tp_pav1.Modelo;

namespace tp_pav1.Vista
{
    public partial class Facturar : Form
    {

        Detalle_factura obj_detalle = new Detalle_factura();
        Registroh obj_registro = new Registroh();
        Factura obj_factura = new Factura();
        Huesped obj_huesped = new Huesped();
        Habitacion obj_habitacion = new Habitacion();
        Instalacion obj_instalacion = new Instalacion();
        Servicio obje_servicio = new Servicio();
        DataTable _detalle = new DataTable();
        
        public Facturar()
        {
            InitializeComponent();
        }
        private void grilla_detalle()
        {
            DataTable tabla_detalle = new DataTable();
            tabla_detalle = obj_detalle.buscar_x_patron_detalle("0");
            //if (tabla_detalle.Rows.Count == 0)
            //{
            //    MessageBox.Show("No se encontró usuario con ese patrón");
            //    return;
            //}
            this.dgv_detalle.DataSource = tabla_detalle;
        }
        private void combo_huesped()
        {
            this.cmb_huesped.DataSource = obj_huesped.consultarHuesped();
            this.cmb_huesped.DisplayMember = "nombre";
            this.cmb_huesped.ValueMember = "id_huesped";
        }
        int ccantidad = 0;
        int ccodigo = 0;
        double uunitario = 0.00;
        double pparcial = 0.00;
        double total1 = 0.00;
        double total2 = 0.00;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Facturar_Load(object sender, EventArgs e)
        {
            grilla_detalle();
            combo_huesped();
            this.txt_fecha.Text = DateTime.Today.ToString();
            //this.txt_huesped.Text = this.cmb_huesped.SelectedValue.ToString();
            DataTable tabla = new DataTable();
            tabla = obj_factura.consultarfactura();
            this.txt_numero.Text = (tabla.Rows.Count + 1).ToString();
        }

        private void txt_fecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_huesped_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txt_huesped.Text = this.cmb_huesped.SelectedValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable tablar = new DataTable();
            DataTable tablad = new DataTable();
            tablar = obj_registro.buscar_x_patron_registro(this.txt_huesped.Text);

            DataTable tabla_detalle = new DataTable();
            _detalle = obj_detalle.buscar_x_patron_detalle("0");
            tabla_detalle = obj_detalle.buscar_x_patron_detalle("0");
            tabla_detalle.Rows.Add();
            tabla_detalle.Rows[0][0] = this.txt_numero.Text.ToString();
            _detalle.Rows.Add();
            _detalle.Rows[0][0] = int.Parse(tabla_detalle.Rows[0][0].ToString());
            tabla_detalle.Rows[0][1] = 1;
            _detalle.Rows[0][1] = 1;
            tabla_detalle.Rows[0][2] = this.txt_cantidad.Text;
            _detalle.Rows[0][2] = int.Parse(this.txt_cantidad.Text);
            tabla_detalle.Rows[0][3] = tablar.Rows[0][1];
            _detalle.Rows[0][3] = int.Parse(tablar.Rows[0][1].ToString());
            tablad = obj_habitacion.buscar_habitacion_X_ID(tablar.Rows[0][1].ToString());
            _detalle.Rows[0][4] = tablad.Rows[0][1].ToString();
            tabla_detalle.Rows[0][4] = tablad.Rows[0][1];
            _detalle.Rows[0][5] = double.Parse(tablad.Rows[0][4].ToString());
            tabla_detalle.Rows[0][5] = tablad.Rows[0][4];
            tabla_detalle.Rows[0][6] = int.Parse(tablad.Rows[0][4].ToString()) * int.Parse(this.txt_cantidad.Text);
            _detalle.Rows[0][6] = double.Parse(tabla_detalle.Rows[0][6].ToString());

            tabla_detalle.Rows.Add();
            _detalle.Rows.Add();
            tabla_detalle.Rows[1][0] = this.txt_numero.Text.ToString();
            _detalle.Rows[1][0] = this.txt_numero.Text.ToString();
            tabla_detalle.Rows[1][1] = 2;
            _detalle.Rows[1][1] = 2;
            tabla_detalle.Rows[1][2] = this.txt_cantidad.Text;
            _detalle.Rows[1][2] = this.txt_cantidad.Text;
            tabla_detalle.Rows[1][3] = tablar.Rows[0][2];
            _detalle.Rows[1][3] = tablar.Rows[0][2];
            tablad = obje_servicio.Buscar_x_Id(tablar.Rows[0][2].ToString());
            tabla_detalle.Rows[1][4] = tablad.Rows[0][1];
            _detalle.Rows[1][4] = tablad.Rows[0][1];
            tabla_detalle.Rows[1][5] = tablad.Rows[0][3];
            _detalle.Rows[1][5] = tablad.Rows[0][3];
            tabla_detalle.Rows[1][6] = int.Parse(tablad.Rows[0][3].ToString()) * int.Parse(this.txt_cantidad.Text);
            _detalle.Rows[1][6] = int.Parse(tablad.Rows[0][3].ToString()) * int.Parse(this.txt_cantidad.Text);

            tabla_detalle.Rows.Add();
            _detalle.Rows.Add();
            tabla_detalle.Rows[2][0] = this.txt_numero.Text.ToString();
            _detalle.Rows[2][0] = this.txt_numero.Text.ToString();
            tabla_detalle.Rows[2][1] = 3;
            _detalle.Rows[2][1] = 3;
            tabla_detalle.Rows[2][2] = this.txt_cantidad.Text;
            _detalle.Rows[2][2] = this.txt_cantidad.Text;
            tabla_detalle.Rows[2][3] = tablar.Rows[0][3];
            _detalle.Rows[2][3] = tablar.Rows[0][3];
            tablad = obj_instalacion.Buscar_x_Id(tablar.Rows[0][3].ToString());
            tabla_detalle.Rows[2][4] = tablad.Rows[0][1];
            _detalle.Rows[2][4] = tablad.Rows[0][1];
            tabla_detalle.Rows[2][5] = tablad.Rows[0][3];
            _detalle.Rows[2][5] = tablad.Rows[0][3];
            tabla_detalle.Rows[2][6] = int.Parse(tablad.Rows[0][3].ToString()) * int.Parse(this.txt_cantidad.Text);
            _detalle.Rows[2][6] = int.Parse(tablad.Rows[0][3].ToString()) * int.Parse(this.txt_cantidad.Text);

            this.dgv_detalle.DataSource = tabla_detalle;
            this.txt_total.Text = (int.Parse(tabla_detalle.Rows[0][6].ToString()) + int.Parse(tabla_detalle.Rows[1][6].ToString()) + int.Parse(tabla_detalle.Rows[2][6].ToString())).ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            obj_factura._descuento = 0;
            obj_factura._id_huesped = int.Parse(this.txt_huesped.Text.ToString());
            obj_factura._f_factura = this.txt_fecha.Text.ToString();
            obj_factura._n_factura = int.Parse(this.txt_numero.Text.ToString());
            obj_factura._total = double.Parse(this.txt_total.Text.ToString());
            obj_factura.grabar_factura();

            obj_detalle._n_factura = int.Parse(_detalle.Rows[0][0].ToString());
            obj_detalle._n_detalle = int.Parse(_detalle.Rows[0][1].ToString());
            obj_detalle._cantidad = int.Parse(_detalle.Rows[0][2].ToString());
            obj_detalle._codigo = int.Parse(_detalle.Rows[0][3].ToString());
            obj_detalle._descripcion = _detalle.Rows[0][4].ToString();
            obj_detalle._unitario = double.Parse(_detalle.Rows[0][5].ToString());
            obj_detalle._total_detalle = double.Parse(_detalle.Rows[0][6].ToString());
            obj_detalle.grabar_detalle();

            obj_detalle._n_factura = int.Parse(_detalle.Rows[1][0].ToString());
            obj_detalle._n_detalle = int.Parse(_detalle.Rows[1][1].ToString());
            obj_detalle._cantidad = int.Parse(_detalle.Rows[1][2].ToString());
            obj_detalle._codigo = int.Parse(_detalle.Rows[1][3].ToString());
            obj_detalle._descripcion = _detalle.Rows[1][4].ToString();
            obj_detalle._unitario = double.Parse(_detalle.Rows[1][5].ToString());
            obj_detalle._total_detalle = double.Parse(_detalle.Rows[1][6].ToString());
            obj_detalle.grabar_detalle();

            obj_detalle._n_factura = int.Parse(_detalle.Rows[2][0].ToString());
            obj_detalle._n_detalle = int.Parse(_detalle.Rows[2][1].ToString());
            obj_detalle._cantidad = int.Parse(_detalle.Rows[2][2].ToString());
            obj_detalle._codigo = int.Parse(_detalle.Rows[2][3].ToString());
            obj_detalle._descripcion = _detalle.Rows[2][4].ToString();
            obj_detalle._unitario = double.Parse(_detalle.Rows[2][5].ToString());
            obj_detalle._total_detalle = double.Parse(_detalle.Rows[2][6].ToString());
            obj_detalle.grabar_detalle();
        }
    }
}
