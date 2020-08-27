using System;
using System.Collections.Generic;
using System.Data;
using tp_pav1.Back_End;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace tp_pav1.Modelo
{
    class Empleado
    {
        //variables declaradas
        public int legajo_e;
        public string nombre_e;
        public string apellido_e;
        public string fecha_ingreso_e;
        public int id_puesto_e = -1;
        public int id_hotel_e = -1;

        public int Id
        {
            get { return this.legajo_e; }
            set { this.legajo_e = value; }
        }

        public string Nombre
        {
            get { return this.nombre_e; }
            set { this.nombre_e = value; }
        }

        public string Apellido
        {
            get { return this.apellido_e; }
            set { this.apellido_e = value; }
        }

        public string FechaIngreso
        {
            get { return this.fecha_ingreso_e; }
            set { this.fecha_ingreso_e = value; }
        }
        public int IdHotel
        {
            get { return this.id_hotel_e; }
            set { this.id_hotel_e = value; }
        }

        public int IdPuesto
        {
            get { return this.id_puesto_e; }
            set { this.id_puesto_e = value; }
        }

        public Empleado()//constructor sin parametros
        {

        }
        //fin de declaracion de variables + metodos set/get

        acceso_DB DB = new acceso_DB();

        validar_Estados valide =new  validar_Estados();

        public DataTable consultarEmpleados()
        {
            return DB.consultaDB("SELECT * FROM EMPLEADO");
        }



        //public validar_Estados.Estado_Validacion validar_Empleado(Control.ControlCollection controles)
        //{
        //    validar_Estados validacion = new validar_Estados();
        //    return validacion.Validar_Caja_vacia(controles);
        //}


      //*************************************************************************************+

        //INSERTAR GRABAR
        public void GrabarEmpleado()
        {
          
                string SqlInsert = "";
                SqlInsert = @" INSERT INTO Empleado
                         ( legajo,nombre,apellido,fecha_ingreso,id_puesto,id_hotel)
                        VALUES ('" +
                              this.legajo_e.ToString() + "', '" +
                             this.nombre_e + "', '" +
                             this.apellido_e + "', '" +
                            this.fecha_ingreso_e + "', '" +
                             this.id_puesto_e.ToString() + "', '" +
                             this.id_hotel_e.ToString() +
                              "')";

                MessageBox.Show("Los datos Ingresados son \n" + SqlInsert);

                DB.Grabar_Modificar_Eliminar(SqlInsert);

          
        }

       //*****************************************************************************************

        //ACTUALIZAR
        public void ModificarEmpleado(int id)
        {


            string sqlupdate = "";
            sqlupdate = @"UPDATE Empleado
                         SET  nombre='" + this.nombre_e.ToString() + "'"
                         + ", apellido = '" + this.apellido_e + "'"
                         + ", fecha_ingreso = '" + this.fecha_ingreso_e + "'"
                         + ", id_puesto = " + this.id_puesto_e.ToString()
                         + ", id_hotel = " + this.id_hotel_e.ToString()
                         + " WHERE legajo = " + id;
                         ;
            DB.Grabar_Modificar_Eliminar(sqlupdate);

        }

        //***************************************************************************************


        public void EliminarEmpleado(int leg)
        {
            string sqldelete = "Delete From Empleado where legajo=" + leg.ToString();

            DB.Grabar_Modificar_Eliminar(sqldelete);
            
        }
        //******************************************************************************

            //buscar
           public DataTable BuscarEmpleado_X_Id (int leg)
        {
           return this.DB.consultaDB("SELECT * FROM Empleado WHERE legajo=" + leg);
        }

        //*********************************************************************************


       //******** verificadores de campo de texto y fecha

        //   public bool verificarFecha(string dato)
        //   {
        //       if(valide.Validar_fecha(dato)==false)
        //       {
        //           return false;
        //       }

        //       return true;
        //   }


        //public bool verificarCampoLetra(string dato)
        //   {
        //       bool salida;

        //       string cadena = dato;
        //    if(valide.ValidarTextoLetra(cadena)==false)
        //    {
        //        salida= false;
        //    }
        //    else { salida = true; }
        //    return salida; 
        //   }

        //public bool verificarCampoNumero(string  dato)
        //{


        //    string cadena = dato;
        //    if (valide.ValidarTextoNumero(cadena) ==false)
        //    {
        //        return false;
        //    }
           
        //        return true;
            
        //}
        
        //public bool campoVacio(String cadena)
        //{
        //    bool estado;
        //    if(valide.ValidarCampoVacio(cadena)==true)
        //    {
        //        estado=true;
        //    }
        //    else { estado = false; }
        //    return estado;
        //}


        //public void  mostrarMensaje(string campo)
        //{
        //    valide.MensajeSalida(campo);
        //}


        //public void mostrarMensajeCombo(string campo)
        //{
        //    valide.MensajeSalidaCombos(campo);
        //}
      }
    }
