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
    class Registroh
    {
         acceso_DB _DB = new acceso_DB();

        public int _id_huesped = 0;
        public int _id_hotel = 0;
        public int _id_habitacion = 0;
        public int _id_servicio = 0;
        public int _id_instalacion = 0;


        public DataTable consultarHuesped()
        {
            return this._DB.consultaDB("SELECT * FROM Registro");
        }

        public int id_huesped
        {
            get { return this._id_huesped; }
            set { this._id_huesped = value; }
        }
        public int id_habitacion
        {
            get { return this._id_habitacion; }
            set { this._id_habitacion = value; }
        }
        public int id_servicio
        {
            get { return this._id_servicio; }
            set { this._id_servicio = value; }
        }
        public int id_instalacion
        {
            get { return this._id_instalacion; }
            set { this._id_instalacion = value; }
        }

        public int id_hotel
        {
            get { return this._id_hotel; }
            set { this._id_hotel = value; }
        }
        public Boolean validar_registro()
        {
            if (this._id_huesped == 0)
            {
                MessageBox.Show("El numero de huesped está vacío");
                return false;
            }
            if (this._id_habitacion == 0)
            {
                MessageBox.Show("El numero de habitacion está vacío");
                return false;
            }
            if (this._id_servicio == 0)
            {
                MessageBox.Show("El numero de servicio está vacío");
                return false;
            }
            if (this._id_instalacion == 0)
            {
                MessageBox.Show("El numero de instalacion está vacío");
                return false;
            }
            if (this._id_hotel == 0)
            {
                MessageBox.Show("El numero de hotel está vacío");
                return false;
            }
            return true;
        }

        //INSERTAR registro

        public void grabar_registro()
        {
            string SqlInsert = "";
            SqlInsert = @" INSERT INTO Registro 
                         ( id_huesped, id_habitacion, id_servicio, id_instalacion, id_hotel) VALUES (" +
                         this._id_huesped.ToString() + ", '" +
                         this._id_habitacion.ToString() + ", '" +
                         this._id_servicio.ToString() + ", '" +
                         this._id_instalacion.ToString() + ", '" +
                         this._id_hotel.ToString() + "')";

            MessageBox.Show("Los datos Ingresados son \n" + SqlInsert);

            _DB.Grabar_Modificar(SqlInsert);
        }

        public DataTable buscar_x_patron_registro(string id)
        {
            return this._DB.consultaDB("SELECT * FROM Registro WHERE id_huesped=" + id);

        }

        public DataTable buscar_registro()
        {
            string sqlpatron = "";
            sqlpatron = @"SELECT * FROM Huespedes ";
            return _DB.consultaDB(sqlpatron);
        }

        //MODIFICAR registro

        public void modificar_registro(string id)
        {
            string sqlupdate = "";
            sqlupdate = @"UPDATE Registro
                         SET  id_habitacion='" + this._id_habitacion + "'"
                         + ", id_servicio = '" + this._id_servicio + "'"
                         + ", id_instalacion = '" + this._id_instalacion + "'"
                         + ", id_hotel =" + this._id_hotel
                         + " WHERE id_huesped = " + id;

            _DB.Grabar_Modificar(sqlupdate);
        }

        //BORRAR registro

        public void borrar_registro(string _id)
        {
            string sqlupdate = "";
            sqlupdate = @"DELETE Registro
                          WHERE id_huesped = " + _id;
            this._DB.Grabar_Modificar(sqlupdate);
        }



    }
}
