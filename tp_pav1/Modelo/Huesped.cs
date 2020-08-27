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
    class Huesped
    {


        acceso_DB DB = new acceso_DB();

        public int num_dni;
        public int id_tipoDocumento;
        public string nombre;
        public string apellido;
        public int num_tarjeta;
       
   

        public int Num_Documento
        {
            get { return this.num_dni; }
            set { this.num_dni = value; }
        }
        public int ID_Tipo_Documento
        {
            get { return this.id_tipoDocumento; }
            set { this.id_tipoDocumento = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public int Numero_Tarjeta
        {
            get { return this.num_tarjeta; }
            set { this.num_tarjeta = value; }
        }
     





        public DataTable consultarHuesped()
        {
            return this.DB.consultaDB("SELECT * FROM Huesped");
        }


        public DataTable Buscar_por_NumeroDNI(int num)
        {
            return this.DB.consultaDB("SELECT * FROM Huesped WHERE id_tipoDoc=" + this.ID_Tipo_Documento.ToString().Trim() + " and num_doc="+ num.ToString().Trim());
        }


        public DataTable buscar_x_patron_huesped(string patron)
        {
            string sqlpatron = "";
            sqlpatron = @"SELECT * FROM Huespedes ";
            return DB.consultaDB(sqlpatron);
        }



        //INSERTAR GRABAR
        public void Grabar_Huesped()
        {

            string SqlInsert = "";
            SqlInsert = @" INSERT INTO Huesped
                         ( id_tipoDoc,num_doc,nombre_huesped,apellido_huesped,num_tarjeta)
                        VALUES ('" +
                          this.id_tipoDocumento.ToString() + "','" +
                         this.num_dni.ToString() + "', '" +
                           this.nombre + "', '" +
                         this.apellido+ "', '" +
                         this.num_tarjeta.ToString() +
                          "')";

            //MessageBox.Show("Los datos Ingresados son \n" + SqlInsert);

            DB.Grabar_Modificar_Eliminar(SqlInsert);


        }

        //*****************************************************************************************

        //ACTUALIZAR
        public void Modificar_Huesped(int id)
        {


            string sqlupdate = "";
//            sqlupdate = @"UPDATE Huesped
//                         SET  id_tipoDoc='" + this.ID_Tipo_Documento.ToString() +"'"
//                          + ", nombre_huesped='" +this.Nombre +"'"
//                         + ",apellido_huesped = '" + this.Apellido + "'"
//                      + ", num_tarjeta = " + this.Numero_Tarjeta.ToString() + "'"
//                         + ", WHERE id_tipoDoc = " + this.ID_Tipo_Documento.ToString() + "AND num_doc =" + id.ToString();


           
            sqlupdate = string.Format("Update Huesped set nombre_huesped='{2}' ,apellido_huesped='{3}',num_tarjeta={4} where id_tipoDoc={0} AND num_doc={1}", 
           new string[] { this.ID_Tipo_Documento.ToString(),this.Num_Documento.ToString(),this.Nombre,this.Apellido,this.Numero_Tarjeta.ToString() });
            DB.Grabar_Modificar_Eliminar(sqlupdate);

        }

        //***************************************************************************************

        //Eliminar
        public void Eliminar_Huesped(int num)
        {
            string sqldelete = "Delete From Huesped WHERE id_tipoDoc=" + this.id_tipoDocumento.ToString() + "and num_doc=" + num.ToString();

            DB.Grabar_Modificar_Eliminar(sqldelete);

        }

    
    }
}
