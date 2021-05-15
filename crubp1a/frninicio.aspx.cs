using crubp1a.clases.Archivos;
using crubp1a.clases.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crubp1a
{
    public partial class frninicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void cargarARchivoExterno()
        {
            string fuente = @"C:\Users\alumno\Desktop\cdfasa\crudDB.csv";
            ClsArchivo ar = new ClsArchivo();
            Conexion1 cn = new Conexion1();

            //obtener todo el archivo en un arreglo 
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string sentencia_sql = "";
            int NumeroLinea = 0;

           //iteramos sobre el arreglo, linea por linea para luego
           //convertirlo en datos individuales
            foreach(string Linea in ArregloNotas)
            {
                string[] datos = Linea.Split(';');
                if (NumeroLinea > 0)
                {
                    sentencia_sql += $"insert into tb_alumnos values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n";
                }
                NumeroLinea++;
            }//end foreach
            NumeroLinea = 0;
            cn.EjecutaSQLDirecto(sentencia_sql);
        }

        protected void ButtonCargaDatos_Click(object sender, EventArgs e)
        {
            cargarARchivoExterno();

        }

        public DataTable CargarDatosDB(String condicion = "1=1")
        {
            Conexion1 cn = new Conexion1();
            DataTable dt = new DataTable();
            string sentencia = $"select * from tb_alumnos where {condicion}";
            dt = cn.consultaTablaDirecta(sentencia);
            return dt;
        }

        protected void ButtonBuscarID_Click(object sender, EventArgs e)
        {
            string id = TextBoxID.Text.Trim();
            string condicion = $"correlativo = {id}";
            DataTable dt = CargarDatosDB(condicion);
            
            
            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<string>("nombre");
                TextBoxNombre.Text = nombre;
            }
            else
            {
                TextBoxNombre.Text = "NO HAY INFORMACION";
            }
        }

        protected void ButtonBuscarPorNombre_Click(object sender, EventArgs e)
        {
            string nombre = TextBoxNombre.Text.Trim();          
            string condicion = $"like ('%{nombre}%')";       
            DataTable dt = CargarDatosDB(condicion);

            if (dt.Rows.Count > 0)
            {
                int id = dt.Rows[0].Field<Int32>("correlativo");
                TextBoxID.Text = id+"";
            }
            else
            {
                TextBoxNombre.Text = "NO HAY INFORMACION";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}