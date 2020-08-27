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
    class Servicio
    {
         acceso_DB _DB = new acceso_DB();
      
        //variables declaradas
        int _id_servicio = 0;
        string _descripcion="";
        int _id_tipoServicio = 0;
        

        public int id_servicio
        {
            get { return this._id_servicio; }
            set { this._id_servicio = value; }
        }

        public string descripcion
        {
            get { return this._descripcion; }
            set { this._descripcion = value; }
        }

        public int ID_tipo_Servicio
        {
            get { return this._id_tipoServicio; }
            set { this._id_tipoServicio = value; }
        }


        public Servicio()//constructor sin parametros
        {

        }

        public DataTable buscar_x_patrones(string patron)
        {
            string sqlpatron = "";
            sqlpatron = @"SELECT * FROM Servicio ";
            return _DB.consultaDB(sqlpatron);
        }


        public DataTable consultarServicio()
        {
            return this._DB.consultaDB("SELECT * FROM Servicio");
        }


        //buscar
        public DataTable Buscar_x_Id(string id)
        {   //_DB
            return this._DB.consultaDB("SELECT * FROM Servicio WHERE id_servicio=" + id);
        }

       
        public Boolean validarServicio()
        {
            if (this._id_servicio == -1)
            {
                MessageBox.Show("El ID está vacío");
                return false;
            }

            if (this._descripcion == "")
            {
                MessageBox.Show("La Descripcion  está vacío");
                return false;
            }
            if (this._id_tipoServicio == -1)
            {
                MessageBox.Show("El Costo está vacío");
                return false;
            }
            return true;
            
         }


        //INSERTAR GRABAR GUARDAR
        public void Grabar_Servicio()
        {
            string SqlInsert = "";

            SqlInsert = @" INSERT INTO Servicio
                        ( id_servicio,descripcion_servicio,id_tipo_servicio) VALUES ('" +
                        this.id_servicio.ToString() + "', '" +
                        this._descripcion + "', '" +
                        this._id_tipoServicio.ToString()+ "')";



            //MessageBox.Show("Los datos Ingresados son \n" + SqlInsert);
            //se ejcuta en el backEnd el método "grabar_modificar" que ejecuta comandos del 
            //tipo INSERT o UPDATE de SQL 
            this._DB.Grabar_Modificar_Eliminar(SqlInsert);

       }
        //ACTUALIZAR
       
        public void Modificar_Servicio(int _id)
        {
            string sqlupdate = "";
            sqlupdate = @"UPDATE Servicio
                         SET  descripcion_servicio= '" + this._descripcion + "'"
                         + ", id_tipo_servicio= '" + this._id_tipoServicio.ToString() + "'"
                         + " WHERE id_servicio = " + _id.ToString();

            //MessageBox.Show("Los datos Ingresados son \n" + sqlupdate);
            
            this._DB.Grabar_Modificar_Eliminar(sqlupdate);

        }

        public void Borrar_Servicio(int _id)
        {
            string sqlupdate = "";
            sqlupdate = @"DELETE Servicio 
                          WHERE id_servicio = " + _id.ToString();
            this._DB.Grabar_Modificar_Eliminar(sqlupdate);
        }
          
    

    }
}
