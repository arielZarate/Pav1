﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_pav1.Back_End;

namespace tp_pav1.Vista
{
    public partial class estadistica_huesped : Form
    {
        public estadistica_huesped()
        {
            InitializeComponent();
        }

        private void estadistica_huesped_Load(object sender, EventArgs e)
        {
            acceso_DB _BD = new acceso_DB();
            string sql = "";

            sql = @"SELECT Hotel.nombre as Descriptor
                 , count(*) as Datos
                 FROM huespedes join Hotel ON 
                        huespedes.hotel = Hotel.id_hotel
                 GROUP BY hotel.nombre";

//            EstadisticaBindingSource.DataSource = _BD.consulta(sql);
//            reportViewer2.RefreshReport();
            estadisticaBindingSource.DataSource= _BD.consultaDB(sql);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
