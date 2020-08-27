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
    class Habitacion
    {
       

        acceso_DB _DB = new acceso_DB();
        int _id_habitacion=-1;
        string _descripcion_habitacion="";
        int _precio = -1;

        public DataTable consultarHabitacion()
        {
            return this._DB.consultaDB("SELECT * FROM Habitacion");
        }

        public int id_habitacion
    {
            get{return this._id_habitacion;}
            set {this._id_habitacion = value;}
    }

        public string descripcion_habitacion
        {
            get { return this._descripcion_habitacion; }
            set { this._descripcion_habitacion = value; }
        }

        public int precio_habitacion
        {
            get { return this._precio; }
            set { this._precio = value; }
        }


        public Boolean validar_habitacion()
        {
            if (this._id_habitacion == -1)
            {
                MessageBox.Show("El ID está vacío");
                return false;
            }

            if (this._descripcion_habitacion == "")
            {
                MessageBox.Show("La Descripcion está vacía");
                return false;
            }

            if(_precio==-1)
            {
                MessageBox.Show("El precio esta vacío");
                return false;
            }
            
            return true;
        }

        public DataTable buscar_habitacion_X_ID(string id)
        {
            return this._DB.consultaDB("SELECT * FROM Habitacion WHERE id_habitacion=" + id);

        }
        public DataTable buscar_x_patron_habitacion(string patron)
        {
            string sqlpatron = "";
            sqlpatron = @"SELECT * FROM Habitacion ";
            return _DB.consultaDB(sqlpatron);
        }
        public void grabar_habitacion()
        {
            string SqlInsert = "";
            SqlInsert = @" INSERT INTO Habitacion 
                         ( id_habitacion,
                         descripcion_habitacion,
                          costo_habitacion) VALUES (" +
                         this._id_habitacion.ToString()+ ",'" +
                         this._descripcion_habitacion +"',"+
                          this._precio.ToString()  +")";
            //MessageBox.Show(SqlInsert);
           this._DB.Grabar_Modificar_Eliminar(SqlInsert);
        }

       

        public void modificar_habitacion (int id)
        {
            string sqlupdate = "";
            sqlupdate = @"UPDATE Habitacion 
                         SET descripcion_habitacion = '" + this._descripcion_habitacion + "'"
                           +    ", costo_habitacion = " + this._precio + ""
                         + " WHERE id_habitacion = " + id.ToString();
            this._DB.Grabar_Modificar_Eliminar(sqlupdate);
        }


//       



//        @"UPDATE Hotel 
//                         SET nombre ='" + this._nombre + "'"
//                          + ", descripcion = '" + this._descripcion + "'"
//                           + ", Registrado = '" + this._registrado + "'"
//                          + " WHERE id_hotel = " + id;

        public void borrar_habitacion (int id)
        {
            string sqlupdate = "";
            sqlupdate = @"DELETE Habitacion 
                          WHERE id_habitacion = " + id;
            this._DB.Grabar_Modificar_Eliminar(sqlupdate);
        }
    }
}
