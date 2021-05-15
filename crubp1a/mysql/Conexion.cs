using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace crubp1a.mysql
{
   class Conexion
   {
       public static MySqlConnection obtenerConexion()
        {
          MySqlConnection conexion = new MySqlConnection("server=3306;database=Csharp1;Uid=root;pwd=Umg$2019;");
            conexion.Open();
            return conexion;
        }

    }
}