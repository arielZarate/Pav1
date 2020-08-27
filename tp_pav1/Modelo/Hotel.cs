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
    class Hotel
    {

        
        public DataTable consultarHotel()
        {
            return this._BD.consultaDB("SELECT * FROM Hotel");
        }



         acceso_DB _BD = new acceso_DB();
        int _id_hotel =0;
        string _nombre;
        string _descripcion;
        string _registrado;

        public int id_hotel
        {
            get { return this._id_hotel; }
            set { this._id_hotel = value; }
        }
        public string nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public string descripcion
        {
            get { return this._descripcion; }
            set { this._descripcion = value; }
        }       


        public string registrado
        {
            get { return this._registrado; }
            set { this._registrado = value; }
        }


         public DataTable buscar_por_id (string id)
        {
           return this._BD.consultaDB("SELECT * FROM Hotel WHERE id_hotel=" + id);
        }

         public Boolean validar_hotel()
         {
             if (this._id_hotel == -1)
             {
                 MessageBox.Show("El ID está vacío");
                 return false;
             }

             if (this._nombre == "")
             {
                 MessageBox.Show("El nombre está vacío");
                 return false;
             }
             if (this._descripcion == "")
             {
                 MessageBox.Show("La descripcion está vacía");
                 return false;
             }
          
             return true;
         }
         public void grabar_hotel()
         {
             //se define una variable del tipo string con la que se escrite el comando INSERT
             //SQL con el que se inserta un nuevo registro en la base de datos. 
             string SqlInsert = "";
             SqlInsert = @" INSERT INTO Hotel 
                         ( id_hotel,
                         nombre, descripcion,Registrado) VALUES (" +
                          this._id_hotel.ToString() + ", '" +
                          this._nombre + "', '" +
                              this._descripcion + "', '" +
                          this._registrado + "')";
             //MessageBox.Show(SqlInsert);
             //se ejcuta en el backEnd el método "grabar_modificar" que ejecuta comandos del 
             //tipo INSERT o UPDATE de SQL 
             this._BD.Grabar_Modificar_Eliminar(SqlInsert);
         }
         public void modificar_hotel (int id)
         {
             string sqlupdate = "";
             sqlupdate = @"UPDATE Hotel 
                         SET nombre ='" + this._nombre + "'"
                          + ", descripcion = '" + this._descripcion + "'"
                           + ", Registrado = '" + this._registrado + "'"
                          + " WHERE id_hotel = " + id;
             this._BD.Grabar_Modificar_Eliminar(sqlupdate);
         }
         public void borrar_hotel(int id)
         {
             string sqlupdate = "";
             sqlupdate = @"DELETE Hotel 
                          WHERE id_hotel = " + id;
             this._BD.Grabar_Modificar_Eliminar(sqlupdate);
         }

        //***********************************++

         public void Registar_Hotel()
         {
             string sql_reg = string.Format("update Hotel set nombre='{1}',descripcion='{2}',Registrado='{3}' where id_hotel={0}", new string[] { this._id_hotel.ToString(),this._nombre,this._descripcion,this._registrado});
             _BD.Grabar_Modificar_Eliminar(sql_reg);
         

         }

         public void Eliminar_Registro_Hotel()
         {
             string sql_reg = string.Format("update Hotel set nombre='{1}',descripcion='{2}',Registrado='{3}' where id_hotel={0}", new string[] { this._id_hotel.ToString(), this._nombre, this._descripcion,"" });
             _BD.Grabar_Modificar_Eliminar(sql_reg);


         }
    }
    }

