using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace tp_pav1
{
    public partial class ventanaLogin : Form
    {

       // public static ventanaLogin login;
        String cuenta;
          String   pass;

          public  static  string  id;


      
        //se crean las propiedades públicas <usuario> y <password> que son enlasadas con el contenido con el
        //de las cajas de textos <txt_usuario> y <txt_password>
        public string usuario
        {
            get { return this.txtCuenta.Text; }
            set { this.txtCuenta.Text= value; }
        }
        public string password
        {
            get { return this.txtPass.Text; }
            set { this.txtPass.Text = value; }
        }

        public string GetId
        {
            set { id = value; }

            get { return id; }
        }

       

        public ventanaLogin()
        {
            InitializeComponent();
            this.txtCuenta.Focus();
        }

        Usuario U = new Usuario();

        DataTable tabla = new DataTable();
        private void btnIniciarLogin_Click(object sender, EventArgs e)
        {

            try
            {
                tabla = U.Ejecutar(txtCuenta.Text, txtPass.Text);

                cuenta = tabla.Rows[0]["cuenta_user"].ToString().Trim();
                pass = tabla.Rows[0]["pass_user"].ToString().Trim();


                if (tabla.Rows.Count == 1)
                {
                    //recupero el id
                    id = tabla.Rows[0]["id_user"].ToString();

                }
               

                if (txtCuenta.Text.Trim() == cuenta && txtPass.Text.Trim() == pass)
                {
                    MessageBox.Show("inicio correcto");
                    this.Hide();
                     this.Dispose();

                  
                }

                ventanaMenu menu = new ventanaMenu();
                menu.ShowDialog();

               
            }

            catch (Exception ex)
            {
                MessageBox.Show("No ha podido iniciar\n Verifique los campos ingresados \n Error: " + ex.Message );
            }
        }




        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //se utiliza <MessageBox> como una funcion que devuelve un valor 
            //de <Yes> o <No> y es comparado con un valor de <Yes>
            if (MessageBox.Show("Está seguro de Salir del Login "
                , "Importante", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                //por verdadero se asigna al parametro de entrada el valor de falso
                //para que el programa finalice

                e.Cancel = false;

            }


            this.Dispose();
        

            
        }

    

        private void ventanaLogin_Load(object sender, EventArgs e)
        {

        }
       
    }


}