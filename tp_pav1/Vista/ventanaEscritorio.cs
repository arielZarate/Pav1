using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_pav1;


namespace tp_pav1
{
    public partial class ventanaEscritorio : Form
    {

        public static ventanaEscritorio escritorio;


        string _usuario;
        string _password;

        //aca gurade el id del login 
        string _id ;

        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        //***************************************************


        
        
        public ventanaEscritorio()
        {
            InitializeComponent();
        }

        private void ventanaEscritorio_Load(object sender, EventArgs e)
        {

            ventanaLogin login = new ventanaLogin();
            login.ShowDialog();
            this.Hide();

            int ID = int.Parse(login.GetId);

            if ( ID == 0)
            {
                //se envía mensaje a pantalla
                MessageBox.Show("Intente nuevamente si quiere ingresar al sistema");
                //se mata el formulario frm_login con Dispose
                login.Dispose();
                //se cierra el formulario escritorio con Close

                this.Close();

            }
            else
            {
                //envia mensaje a pantalla
                //MessageBox.Show("Usuario: " + login.usuario + '\n'
                //    + "Password: " + login.password+'\n'
                //    + "id usuario:"+login.Id.ToString());
                //recupera el valor de las propiedades publicas: password, usuario, id del formulario 
                //frm_login a las variables locales del mismo nombre con prefijo guion bajo.


                this._password = login.password;
                this._usuario = login.usuario;
                this._id = login.GetId;
            }
            //elimina el formulario frm_login con el comando Dispose

            login.Dispose();
            this.Close();

            
        }

    }
}