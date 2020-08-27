using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using tp_pav1.Back_End;

namespace tp_pav1.Modelo
{
    class Detalle_factura
    {
        acceso_DB _DB = new acceso_DB();

        public int _n_factura = 0;
        public int _n_detalle = 0;
        public int _cantidad = 0;
        public int _codigo = 0;
        public string _descripcion = "";
        public double _unitario = 0.00;
        public double _total_detalle = 0.00;

        public DataTable consultardetalle()
        {
            return this._DB.consultaDB("SELECT * FROM detalle_factura");
        }

        public int n_factura
        {
            get { return this._n_factura; }
            set { this._n_factura = value; }
        }
        public int n_detalle
        {
            get { return this._n_detalle; }
            set { this._n_detalle = value; }
        }
        public int cantidad
        {
            get { return this._cantidad; }
            set { this._cantidad = value; }
        }
        public int codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }

        public string descripcion
        {
            get { return this._descripcion; }
            set { this._descripcion = value; }
        }
        public double unitario
        {
            get { return this._unitario; }
            set { this._unitario = value; }
        }
        public double total_detalle
        {
            get { return this._total_detalle; }
            set { this._total_detalle = value; }
        }
        public Boolean validar_detalle()
        {
            if (this._n_factura == 0)
            {
                MessageBox.Show("El numero de factura está vacío");
                return false;
            }
            if (this._n_detalle == 0)
            {
                MessageBox.Show("El numero de detalle de factura está vacío");
                return false;
            }
            if (this._cantidad == 0)
            {
                MessageBox.Show("La cantidad está vacía");
                return false;
            }
            return true;
        }

        //INSERTAR registro

        public void grabar_detalle()
        {
            string SqlInsert = "";
            SqlInsert = @" INSERT INTO detalle_factura 
                         ( n_factura, n_detalle, cantidad, codigo, descipcion, unitario, d_total) VALUES (" +
                         this._n_factura.ToString() + ", " +
                         this._n_detalle.ToString() + ", " +
                         this._cantidad.ToString() + ", " +
                         this._codigo.ToString() + ", '" +
                         this._descripcion.ToString() + "', "+
                         this._unitario.ToString() + ", " +
                         this._total_detalle.ToString() + ")";

            //MessageBox.Show("Los datos Ingresados son \n" + SqlInsert);

            _DB.Grabar_Modificar(SqlInsert);
        }

        public DataTable buscar_x_patron_detalle(string id)
        {
            return this._DB.consultaDB("SELECT * FROM detalle_factura WHERE n_factura=" + id);

        }

        public DataTable buscar_detalle()
        {
            string sqlpatron = "";
            sqlpatron = @"SELECT * FROM detalle_factura ";
            return _DB.consultaDB(sqlpatron);
        }

        //MODIFICAR detalle

//        public void modificar_detalle(string id)
//        {
//            string sqlupdate = "";
//            sqlupdate = @"UPDATE detalle_factura
//                         SET  id_habitacion='" + this._id_habitacion + "'"
//                         + ", id_servicio = '" + this._id_servicio + "'"
//                         + ", id_instalacion = '" + this._id_instalacion + "'"
//                         + ", id_hotel =" + this._id_hotel
//                         + " WHERE id_huesped = " + id;

//            _DB.Grabar_Modificar(sqlupdate);
//        }

        //BORRAR detalle

        public void borrar_registro(string _id)
        {
            string sqlupdate = "";
            sqlupdate = @"DELETE detalle_factura
                          WHERE n_factura = " + _id;
            this._DB.Grabar_Modificar(sqlupdate);
        }



    }
}
