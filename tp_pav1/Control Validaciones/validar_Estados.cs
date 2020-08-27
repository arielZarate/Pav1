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
    class validar_Estados
    {

        acceso_DB DB = new acceso_DB();
        DataTable tabla = new DataTable();




        public bool ValidarTextoLetra(String dato)
        {
            bool estado=true; 
            //string cadena=dato;
            char[] texto = dato.ToCharArray();

            for (int i = 0; i < texto.Length; i++)
            {

               
                if ((char.IsLetter(texto[i]) ==false))
                {
                    estado = false;

                }
            }

            return estado;
        }


        public bool ValidarTextoNumero(String dato)
        {

            bool estado = true;
           // string cadena = dato;
            char[] texto = dato.ToCharArray();

            for (int i = 0; i < texto.Length; i++)
            {
                if ((char.IsDigit(texto[i]) ==false))
                {
                    estado = false;
                }

            }

            return estado;
        }



        public bool ValidarCampoVacio(String campo)
        {
            bool estado = false;
            if (campo=="")
            {
                estado = true;
            }

            return estado;
        }

        //dos mensajes uno para cada caso

        public void MensajeSalida(String campo)
        {
            MessageBox.Show("Verifique el campo "  + campo + "\nverifique si ha ingresado correctamente o esta vacio", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        public void MensajeSalidaCombos(String campo)
        {
            MessageBox.Show("Debe selecccionar una opcion de combo " + campo , "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }




        public bool Validar_fecha(string dato)
        {

            bool estado = true;
            //con esto convierto la fecha .Text en tipoDate
            DateTime fecha = DateTime.ParseExact(dato,"ddMMyyyy", null);


            int dif = DateTime.Compare(fecha, DateTime.Today);

            if (dif > 0)
            {
                return false;
            }

            return estado;


        }




    }
}

