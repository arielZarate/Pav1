using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp_pav1.Back_End;

namespace tp_pav1.Modelo
{
       


    class Puesto
    {
        private int id_puesto;
        private string descripcion_puesto;


        public int IdPuesto
        {
            set { this.id_puesto = value; }
            get { return this.id_puesto; }
        }


        public string DescripcionPuesto
        {
            set { this.descripcion_puesto = value; }
            get { return this.descripcion_puesto; }
        }
        
        acceso_DB DB = new acceso_DB();

        public DataTable ConsultarPuesto()
        {
            return DB.consultaDB("SELECT * FROM Puesto");
        }
    }
}
