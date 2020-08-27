using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_pav1.Back_End;
using tp_pav1.Modelo;

namespace tp_pav1.Vista
{
    public partial class ventanaFecha : Form
    {
        public ventanaFecha()
        {
            InitializeComponent();
        }



        acceso_DB DB = new acceso_DB();
        validar_Estados va = new validar_Estados();


        private void btnFecha_Click(object sender, EventArgs e)
        {

            //texFecha.Text = DateTime.Now.ToShortDateString();

            DataTable tabla=new DataTable();
            tabla=DB.RecuperarFechaActual();


            texFecha.Text = tabla.Rows[0][0].ToString();


            //fecha de la base de datos
            // texFecha.Text=DB.fecha_a_String();

          


           
        }







        //Usando DATETIME.COMPARE
 

        private void btnCompareFecha_Click(object sender, EventArgs e)
        {

            DateTime fecha = DateTime.ParseExact(txt_fechaingresada.Text, "dd/MM/yyyy", null);

            int dif = DateTime.Compare(fecha, DateTime.Today);

            if (dif > 0)
            {
                MessageBox.Show("error fecha incorrecta ", "<Inportante>", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                MessageBox.Show("ha ingresado correctamente la fecha ","Titulo",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            }
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            if(va.ValidarTextoNumero(txtNumero.Text)==false)
            {

                MessageBox.Show("ha ingresado mal no es numero ", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }

            else
            {
                MessageBox.Show("Correcto es numero ", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }


        
        public bool ValidarTextoLetra(String cadena)
        {

            bool salida = true; 
            char[] texto = cadena.ToCharArray();

            for (int i = 0; i < texto.Length;i++ )
            {
                if (char.IsLetter(texto[i]) == false || this.ValidarCampoVacio(cadena) == true)
                {
                    salida = false;
                }
           
            }
            return salida;
        }





        public bool ValidarTextoNumero(string cadena)
        {

            bool salida = true; 
            Char [] texto = cadena.ToCharArray();

            for (int i = 0; i < texto.Length; i++)
            {
                if ((Char.IsDigit(texto[i]))==false  || this.ValidarCampoVacio(cadena) == true)
                {
                    salida= false;
                }
               
               
            }
            return salida;
        }



        public bool ValidarCampoVacio(String campo)
        {
            if (campo.Equals(""))
            {
                return true;
            }
            else
            return false;
        }



        public void MensajeSalida(String campo)
        {
            MessageBox.Show("Verifique el " + campo + " Puede estar vacio o ha ingresado incorrectamente ", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            if (va.ValidarTextoLetra(txtTexto.Text) == false)
            {
                MessageBox.Show("ha ingresado mal no es texto ", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }

            else
            {
                MessageBox.Show("Correcto es TEXTO", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
            }
        }



    }
}





