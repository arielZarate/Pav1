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
    class TipoDocumento
    {
        int id_tipoDoc;
        string descripcion;



        public int ID_TipoDocumento
        {
            set { this.id_tipoDoc = value; }
            get { return this.id_tipoDoc; }
        }


        public string Descripcion
        {
            set { this.descripcion = value; }
            get { return this.descripcion; }
        }

        acceso_DB DB = new acceso_DB();




        public DataTable Consultar_TipoDocumento()
        {
            return DB.consultaDB("select * from TipoDocumento");
        }





        //INSERTAR GRABAR
        public void Grabar_tipoDocumento()
        {

            string SqlInsert = "";
//            SqlInsert = @" INSERT INTO TipoServicio
//                         ( id_tipo_servicio,desc_tipo_servicio,costo)
//                        VALUES ('" +
//                          this._idTipo.ToString() + "', '" +
//                         this._descripcion_tipo.ToString() + "', '" +
//                         this._costo.ToString() +
//                          "')";

            //    cmd  = new SqlCommand(string.Format("insert into Perfiles Values ({0},'{1}')", new string[] { id, nombre }), cnn);
            SqlInsert = string.Format("INSERT INTO TipoDocumento VALUES({0},'{1}')", new string[] {this.ID_TipoDocumento.ToString(),this.Descripcion });
            //MessageBox.Show("Los datos Ingresados son \n" + SqlInsert);

            DB.Grabar_Modificar_Eliminar(SqlInsert);


        }

        //*****************************************************************************************

        //ACTUALIZAR
        public void Modificar_tipoDocumento(int id)
        {


            string sqlupdate = "";
            sqlupdate = @"UPDATE TipoDocumento
                         SET id_tipoD = '" +this.ID_TipoDocumento.ToString()+ "'"
                        
                        + " WHERE id_tipoD= " + id;
            
            DB.Grabar_Modificar_Eliminar(sqlupdate);

        }

        //***************************************************************************************


        public void Eliminar_tipoDocumento(int id)
        {
            string sqldelete = "Delete From TipoDocumento where id_tipoD=" + id.ToString();

            DB.Grabar_Modificar_Eliminar(sqldelete);

        }
        //******************************************************************************

        //buscar
        public DataTable Buscar_tipoDocumento_X_Id(int id_tipo)
        {
            return this.DB.consultaDB("SELECT * FROM TipoDocumento WHERE id_tipoD=" + id_tipo.ToString());
        }



       

    
    }
}
