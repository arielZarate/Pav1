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
    class Tipo_Servicio
    {

        private int  _idTipo;
        private string _descripcion_tipo;
        private int _costo;


        public int _Id
        {
            set { this._idTipo= value; }
            get { return this._idTipo;}
        }

        public string _Descripcion_tipo
        {
            set { this._descripcion_tipo = value; }
            get { return this._descripcion_tipo; }
           
        }
        public int _Costo
        {
            set { this._costo = value; }
            get { return this._costo; }
        }



        acceso_DB DB  = new acceso_DB();
        validar_Estados valide = new validar_Estados();

        public DataTable consultar_tipoServicios()
        {
            return this.DB.consultaDB("SELECT * FROM TipoServicio");
        }



        //INSERTAR GRABAR
        public void Grabar_tipoServicio()
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
            SqlInsert = string.Format("INSERT INTO TipoServicio VALUES({0},'{1}',{2})", new string[] {this._idTipo.ToString(),this._descripcion_tipo,this._costo.ToString() });
            //MessageBox.Show("Los datos Ingresados son \n" + SqlInsert);

            DB.Grabar_Modificar_Eliminar(SqlInsert);


        }

        //*****************************************************************************************

        //ACTUALIZAR
        public void Modificar_TipoServicio(int id)
        {


            string sqlupdate = "";
            sqlupdate = @"UPDATE TipoServicio
                         SET desc_tipo_servicio = '" +this._descripcion_tipo + "'"
                         + ", costo= '" + this._costo.ToString() + "'"
                        + " WHERE id_tipo_servicio = " + id;
            
            DB.Grabar_Modificar_Eliminar(sqlupdate);

        }

        //***************************************************************************************


        public void Eliminar_tipoServicio(int id)
        {
            string sqldelete = "Delete From Servicio where id_tipo_servicio=" + id.ToString();

            DB.Grabar_Modificar_Eliminar(sqldelete);

        }
        //******************************************************************************

        //buscar
        public DataTable Buscar_tipoServicio_X_Id(int id_tipo)
        {
            return this.DB.consultaDB("SELECT * FROM TipoServicio WHERE id_tipo_servicio=" + id_tipo.ToString());
        }



        //algpo improvisado
        public DataTable BuscarId_X_Servicio(string descripcion)
        {
            return DB.consultaDB("select * from TipoServicio where desc_tipo_servicio=" + descripcion);
        }
       

    }
}
