using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        private static readonly Conexion instancia = new Conexion();

        public static Conexion GetInstancia => Conexion.instancia;

        public SqlConnection Conectar => new SqlConnection("Data Source=Vargas\\SQLEXPRESS;Initial Catalog=DBCliente;Integrated Security=true;");

    }
}
