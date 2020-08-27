using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp_pav1.Back_End;
using System.Data;

namespace tp_pav1.Modelo
{
    class Estado
    {
        public DataTable consultar_estado()
        {
            return this._BD.consultaDB("SELECT * FROM Estado");
        }



        acceso_DB _BD = new acceso_DB();
        int _id_estado = 0;
        string _descripcion;
        public int id_estado
        {
            get { return this._id_estado; }
            set { this._id_estado = value; }
        }
        
        public string descripcion
        {
            get { return this._descripcion; }
            set { this._descripcion = value; }
        }       

    }
}
