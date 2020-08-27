using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_pav1.Vista
{
    public partial class ventanaABM_Padre : Form
    {
        public ventanaABM_Padre()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }



        public virtual void Nuevo()
        {

        }



        public virtual void Guardar()
        {
          

        }


        public virtual void Actualizar()
        {

        }



  
        public virtual void Consultar()
        {

        }


        private void btn_Menu_Click_1(object sender, EventArgs e)
        {
            ventanaMenu Menu = new ventanaMenu();
            this.Hide();
            Menu.ShowDialog();


        }

        private void btn_Buscar_Logo_Click(object sender, EventArgs e)
        {
            this.btn_Buscar.Enabled = true;
            this.btn_Buscar.Visible = true;
           
            //falta el focus del priumer textBox
        } 


    }
}
