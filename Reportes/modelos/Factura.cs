using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp_pav1.Back_End;
using System.Data;
using System.Windows.Forms;

namespace tp_pav1.Modelo
{
    class Factura
    {
        acceso_DB _DB = new acceso_DB();

        public int _n_factura = 0;
        public double _total = 0.00;
        public int _descuento = 0;
        public string _f_factura = "";
        public int _id_huesped = 0;

        public DataTable consultarfactura()
        {
            return this._DB.consultaDB("SELECT * FROM factura");
        }

        public int id_huesped
        {
            get { return this._id_huesped; }
            set { this._id_huesped = value; }
        }
        public string f_factura
        {
            get { return this._f_factura; }
            set { this._f_factura = value; }
        }
        public int n_factura
        {
            get { return this._n_factura; }
            set { this._n_factura = value; }
        }
        public double total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        public int descuento
        {
            get { return this._descuento; }
            set { this._descuento = value; }
        }
        public Boolean validar_factua()
        {
            if (this._id_huesped == 0)
            {
                MessageBox.Show("El numero de huesped está vacío");
                return false;
            }
            if (this._f_factura == "")
            {
                MessageBox.Show("La fecha está vacía");
                return false;
            }
            if (this._n_factura == 0)
            {
                MessageBox.Show("El numero de factura está vacío");
                return false;
            }
            
            return true;
        }

        //INSERTAR factura

        public void grabar_factura()
        {
            string SqlInsert = "";
            if (validar_factua() == true)
            {
                SqlInsert = @" INSERT INTO factura 
                         ( id_huesped, n_factura, descuento, f_factura, total) VALUES (" +
                             this._id_huesped.ToString() + ", " +
                             this._n_factura.ToString() + ", " +
                             this._descuento.ToString() + ", '" +
                             this._f_factura.ToString() + "', " +
                             this._total.ToString() + ")";

                //MessageBox.Show("Los datos Ingresados son \n" + SqlInsert);

                _DB.Grabar_Modificar(SqlInsert);
            }
        }

        public DataTable buscar_x_patron_factura(string id)
        {
            return this._DB.consultaDB("SELECT * FROM factura WHERE n_factura=" + id);

        }

        public DataTable buscar_factura()
        {
            string sqlpatron = "";
            sqlpatron = @"SELECT * FROM factura ";
            return _DB.consultaDB(sqlpatron);
        }

        //MODIFICAR factura

//        public void modificar_registro(string id)
//        {
//            string sqlupdate = "";
//            sqlupdate = @"UPDATE Registro
//                         SET  id_habitacion='" + this._id_habitacion + "'"
//                         + ", id_servicio = '" + this._id_servicio + "'"
//                         + ", id_instalacion = '" + this._id_instalacion + "'"
//                         + ", id_hotel =" + this._id_hotel
//                         + " WHERE id_huesped = " + id;

//            _DB.Grabar_Modificar(sqlupdate);
//        }

        //BORRAR factura

        public void borrar_factura(string _id)
        {
            string sqlupdate = "";
            sqlupdate = @"DELETE factura
                          WHERE n_factura = " + _id;
            this._DB.Grabar_Modificar(sqlupdate);
        }


    }
}
