using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using tp_pav1.Back_End;


namespace tp_pav1
{
    class Usuario
    {
        acceso_DB DB = new acceso_DB();
        public DataTable Ejecutar(String acu, String pas)
        {
           
                string sqlText = string.Format("Select * from Usuario where cuenta_user='{0}' and pass_user='{1}'", acu.Trim(), pas.Trim());
                //@"SELECT * FROM Usuario WHERE cuenta_user = '" + txtCuenta.Text + "'"
                //                         + " AND pass_user = '" + txtPass.Text + "'";


                return DB.consultaDB(sqlText);


            }


        }

    }




