using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datLocal
    {
        # region Instancia
        private static readonly datLocal instancia = new datLocal();

        public static datLocal GetInstancia => instancia;
        #endregion  Instancia

        #region Listar
        public List<entLocal> ListarLocal()
        {
            SqlCommand cmd = null;
            List<entLocal> lista = new List<entLocal>();
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("pa_listar_local", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entLocal Pe = new entLocal();

                    Pe.idLocal = Convert.ToInt32(dr["LocalID"]);
                    Pe.nombre = Convert.ToString(dr["nombre"]);

                    lista.Add(Pe);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        #endregion 
    }
}
