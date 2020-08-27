using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;



//*************************
using System.Data;
using System.Data.OleDb;
using tp_pav1;
using System.Windows.Forms;

namespace tp_pav1.Back_End
{
    class acceso_DB
    {



        //ATENCION DEBE SER ESTATICO
        public enum resultado_acceso { error, correcto }
        public enum tipo_conexion { simple, transaccion }

        OleDbConnection cnn = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        resultado_acceso control_transaccion = resultado_acceso.correcto;
        tipo_conexion analisis_tipo_transaccion = tipo_conexion.simple;
        OleDbTransaction transaccion;

        //Data Source=CX215-PC\\SQLEXPRESS;Initial Catalog=DB_pav1;User ID=ariel;Password=gda
        
        string cadena = "Provider=SQLNCLI11;Data Source=CX215-PC\\SQLEXPRESS;Persist Security Info=True;User ID=ariel;Initial Catalog=DB_pav1;password=gda";


        private void conectar()
        {

            cnn.ConnectionString = cadena;
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;


        }

        private void cerrar()
        {

            cnn.Close();
        }

        public DataTable consultaDB(string sqlText)
        {

            this.conectar();

            cmd.CommandText = sqlText;

            DataTable tabla = new DataTable();

            tabla.Load(cmd.ExecuteReader());


            this.cerrar();

            return tabla;
        }

        //metodo que es invocado por las clases para grabar en la base de datos
        public void Grabar_Modificar_Eliminar(string sqlText)
        {
            conectar();
            cmd.CommandText = sqlText;
            cmd.ExecuteNonQuery();
            cerrar();
        }





       

        //********Metodos alternativos para la fecha ****************************


        public DataTable RecuperarFechaActual()
        {

           string fecha = "select CONVERT (char(10),GETDATE(),103)";
           // string sqlfecha = "select getdate()";
            return this.consultaDB(fecha);

            }


        public string fecha_a_String()
        {
            DataTable tabla = new DataTable();

            tabla = this.RecuperarFechaActual();

            string fecha = tabla.Rows[0][0].ToString();

            return fecha;
        }



      
        public void iniciar_transaccion()
        {
            analisis_tipo_transaccion = tipo_conexion.transaccion;
            control_transaccion = resultado_acceso.correcto;
        }
        public void cerrar_transaccion()
        {
            if (analisis_tipo_transaccion == tipo_conexion.simple)
                cerrar();
            if (control_transaccion == resultado_acceso.correcto)
            {
                transaccion.Commit();
                MessageBox.Show("Se modifico OK la Base de Datos");
            }
            else
            {
                transaccion.Rollback();
            }
            analisis_tipo_transaccion = tipo_conexion.simple;
            cerrar();
        }


        private void conectar_trasaccion()
        {
            if (cnn.State == System.Data.ConnectionState.Closed)
            {
                cnn.ConnectionString = cadena;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = System.Data.CommandType.Text;

                if (analisis_tipo_transaccion == tipo_conexion.transaccion)
                {
                    transaccion = cnn.BeginTransaction(IsolationLevel.ReadUncommitted);
                    cmd.Transaction = transaccion;
                }
            }
        }
        private void cerrar_trasanccion()
        {
            if (analisis_tipo_transaccion == tipo_conexion.simple)
            {
                cnn.Close();
            }

        }
        public resultado_acceso Grabar_Modificar(string comando)
        {
            conectar();
            cmd.CommandText = comando;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                control_transaccion = resultado_acceso.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                    + "En el comando:" + "\n"
                    + comando + "\n"
                    + "El mensaje es:" + "\n"
                    + e.Message);
                cerrar();
                return resultado_acceso.error;
            }
            cerrar();
            return resultado_acceso.correcto;
        }

        public DataTable consultaDB_Transaccion(string comando)
        {
            conectar();
            cmd.CommandText = comando;
            DataTable tabla = new DataTable();
            try
            {
                tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception e)
            {
                control_transaccion = resultado_acceso.error;
                MessageBox.Show("Error con la Base de Datos" + "\n"
                    + "En el comando:" + "\n"
                    + comando + "\n"
                    + "El mensaje es:" + "\n"
                    + e.Message);
                cerrar();
                return tabla;
                throw;
            }
            //MessageBox.Show("Se modifico OK la Base de Datos");
            cerrar();
            return tabla;
        }









        //public static DataTable Ejecutar(String consulta)
        //{

        //    string cadena = "Data Source=CX215-PC\\SQLEXPRESS;Initial Catalog=DB_pav1;User ID=ariel;Password=gda";
        //    //creo la conexion 
        //    SqlConnection cnn = new SqlConnection(cadena);
        //    cnn.Open();
        //    SqlCommand cmd=new SqlCommand(consulta,cnn);

        //    //creo el dataset
        //    DataSet DS = new DataSet();


        //    //creo el adaptador que me va convertir los datos de string para mostrarlos en data set
        //    SqlDataAdapter DA = new SqlDataAdapter(cmd);

        //    //ahora mos muestros en un dataset
        //    DA.Fill(DS,"tablas");

        //    cnn.Close();

        //    //ultimo return


        //    return DS.Tables["tablas"];
        //}
    }

}

