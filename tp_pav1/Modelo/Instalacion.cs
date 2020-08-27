using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_pav1.Back_End;

namespace tp_pav1.Modelo
{
    class Instalacion
    {

        acceso_DB _DB = new acceso_DB();


        //variables declaradas
        int _id_instalacion = 0;
        string _descripcion = "";
        string _estado = "";


        public int id_instalacion
        {
            get { return this._id_instalacion; }
            set { this._id_instalacion = value; }
        }

        public string descripcion
        {
            get { return this._descripcion; }
            set { this._descripcion = value; }
        }

        public string estado
        {
            get { return this._estado; }
            set { this._estado = value; }
        }

        public DataTable consultarInstalacion()
        {
            return this._DB.consultaDB("SELECT * FROM Instalacion");
        }



        public Instalacion()//constructor sin parametros
        {

        }

        public DataTable buscar_x_patrones(string patron)
        {
            string sqlpatron = "";
            sqlpatron = @"SELECT * FROM Instalacion ";
            return _DB.consultaDB(sqlpatron);
        }


        //buscar
        public DataTable Buscar_x_Id(string id)
        {   //_DB
            return this._DB.consultaDB("SELECT * FROM Instalacion WHERE id_instalacion=" + id);
        }


        public Boolean validarInstalacion()
        {
            if (this._id_instalacion == -1)
            {
                MessageBox.Show("El ID está vacío");
                return false;
            }

            if (this._descripcion == "")
            {
                MessageBox.Show("La Descripcion  está vacío");
                return false;
            }
            if (this._estado == "")
            {
                MessageBox.Show("El Estado está vacío");
                return false;
            }
            return true;

        }


        //INSERTAR GRABAR GUARDAR
        public void Grabar_Instalacion()
        {
            string SqlInsert = "";

            SqlInsert = @" INSERT INTO Instalacion
                        ( id_instalacion,descripcion_instalacion,habilitada) VALUES ('" +
                        this.id_instalacion + "', '" +
                        this._descripcion + "', '" +
                        this._estado +
                        "')";


            //MessageBox.Show("Los datos Ingresados son \n" + SqlInsert);
            //se ejcuta en el backEnd el método "grabar_modificar" que ejecuta comandos del 
            //tipo INSERT o UPDATE de SQL 
            this._DB.Grabar_Modificar_Eliminar(SqlInsert);

        }
        //ACTUALIZAR

        public void Modificar_Instalacion(int id)
        {
            string sqlupdate = "";
            sqlupdate = @"UPDATE Instalacion
                         SET  descripcion_instalacion= '" + this._descripcion + "'"
                         + ", habilitada= '" + this._estado + "'"
                         + " WHERE id_instalacion = " + id;

            //MessageBox.Show("Los datos Ingresados son \n" + sqlupdate);

            this._DB.Grabar_Modificar_Eliminar(sqlupdate);

        }


        public void borrar_Instalacion(int id)
        {
            string sqlupdate = "";
            sqlupdate = @"DELETE Instalacion
                          WHERE id_instalacion = " + id;
            this._DB.Grabar_Modificar_Eliminar(sqlupdate);
        }


    }
}
