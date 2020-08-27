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
    class Facturacion
    {
        int num_factu;
      public  string fecha;
        int id_hotel;
        //huesped
        int tipo_doc;
        int num_doc;
        string nombre;
        int cod_pro;
        string desc;
        float precio;
        float cant;
        int id_hab;
        int id_serv;
        int id_inst;

        public int NumeroFactura
        {
            set { this.num_factu = value; }
            get { return this.num_factu; }
        }

        public string FechaFactura
        {
            set { this.fecha = value; }
            get { return this.fecha; }
        }
        public int ID_Hotel
        {
            get { return this.id_hotel; }
            set { this.id_hotel = value; }
        }

        public int NumDocumento
        {
            get { return this.num_doc; }
            set { this.num_doc = value; }
        }
        public int ID_TipoDocumento
        {
            get { return this.tipo_doc; }
            set { this.tipo_doc = value; }
        }

        public string NombreHuesped
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

       
        public string  DescripcionProducto
        {
            get { return this.desc; }
            set { this.desc= value; }
        }

        public int  CodigoProducto
        {
            get { return this.cod_pro; }
            set { this.cod_pro = value; }
        }


        public float PrecioVendido
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

          public float CantidadVendida
        {
            get { return this.cant; }
            set { this.cant = value; }
        }

       


        public int id_habitacion
        {
            get { return this.id_hab; }
            set { this.id_hab = value; }
        }

        public int id_servicio
        {
            get { return this.id_serv; }
            set { this.id_serv = value; }
        }

        public int id_instalacion
        {
            get { return this.id_inst; }
            set { this.id_inst = value; }
        }

    




      
        acceso_DB DB = new acceso_DB();
        Servicio ser = new Servicio();

        public DataTable consultar_Huesped()
        {
            DataTable tabla = new DataTable();
            string sql = "select h.id_tipoDoc as 'Tipo Doc',h.num_doc as 'Numero DNI',(h.nombre_huesped + h.apellido_huesped) as Nombre  from Huesped h";
            tabla = DB.consultaDB(sql);
            return tabla;
        }

        public DataTable consultar_Habitacion()
        {
            DataTable tabla = new DataTable();
            string sql = "select H.id_habitacion as 'ID',H.descripcion_habitacion as 'Descripcion',costo_habitacion as 'Costo' from Habitacion H";
            tabla = DB.consultaDB(sql);
            return tabla;
        }


        public DataTable consultar_Instalacion()
        {
            DataTable tabla = new DataTable();
             string sql = "select id_instalacion as 'ID' ,descripcion_instalacion as 'Descripcion' , habilitada as 'Habilitada 'from Instalacion";
             tabla = DB.consultaDB(sql);
             return tabla;
        }

        public DataTable consultar_Servicio()
        {
            DataTable tabla = new DataTable();
            string sql = "select s.id_servicio as 'ID ' ,s.descripcion_servicio as 'Descripcion ',t.costo as Costo from Servicio s JOIN TipoServicio t  ON (s.id_tipo_servicio=t.id_tipo_servicio)";
            tabla=DB.consultaDB(sql);
            return tabla;
          
         }


        public DataTable ObtenerNumeroFactu()
        {
            string max = "select MAX(num_factu) as 'Numero' from Factura";

            //Solucionado no debo pasar el numero de factura
            DataTable tabla = new DataTable();
            tabla = DB.consultaDB(max);
            //string num = tabla.Rows[0]["Numero"].ToString();
            //MessageBox.Show("el numero mayor es " + num);
            return tabla;
           
        }

       
        public DataTable Estadistica_Facturacion(int mes ,float monto)
        {
            string sql = "select d.num_fac as 'descriptor',Sum(d.precio_vend*d.cant_vend)as 'dato' from  Detalle_Factura d" ;
            MessageBox.Show("Estadistica _ realizada");
            return DB.consultaDB(sql);

            
        }


        public void ActualizarFactura()
        {
            string sql_insert = "";

            sql_insert = string.Format("insert into Factura values({0},'{1}',{2},{3},{4},'{5}')", new string[] { NumeroFactura.ToString(),FechaFactura.ToString(), ID_Hotel.ToString(), ID_TipoDocumento.ToString(), NumDocumento.ToString(),NombreHuesped });
            DB.Grabar_Modificar_Eliminar(sql_insert);
         
            this.DB.consultaDB("select * from Factura where num_factu=" + NumeroFactura.ToString());
           
         }


        public void ActualizarDetalleFactura()
        {
            string sql_insert = "";
            sql_insert = string.Format("insert into Detalle_Factura values({0},{1},'{2}',{3},{4})", new string[] {NumeroFactura.ToString(),CodigoProducto.ToString(),DescripcionProducto,PrecioVendido.ToString(),CantidadVendida.ToString()});
            DB.Grabar_Modificar_Eliminar(sql_insert);

        }


        public DataTable Buscar_NumeroFactura(string Numero)
        {
            string buscar="select F.*,D.cod,D.descrip,D.precio_vend,D.cant_vend,(D.precio_vend*D.cant_vend) as Importe from Factura F Join Detalle_Factura D on F.num_factu=D.num_fac where num_factu=" + Numero;
            return DB.consultaDB(buscar);
        }

        public DataTable Datos_Factura()
        {
            //esto solo selecciona
            string datos = "";
            datos = "select F.num_factu as'Nº Fac',F.fecha_fact as 'Fecha',id_hotel_factu as 'ID Hotel' ,tipo_doc_hue as 'Tipo Doc',num_doc_hue as 'Numero DNI',nombre_huesped as 'Nombre' ,D.cod as 'Codigo',D.descrip as 'Descripcion',D.precio_vend as 'Precio',D.cant_vend as 'Cantidad',(D.precio_vend*D.cant_vend) as Importe from Factura F inner Join Detalle_Factura D on F.num_factu=D.num_fac";
            
            return DB.consultaDB(datos);


        }
    }
}
