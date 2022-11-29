using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using CapaEntidad;

namespace CapaDatos
{
    public class datTipoPersonal
    {
        #region Instancia
        private static readonly datTipoPersonal instancia = new datTipoPersonal();
        public static datTipoPersonal GetInstancia => instancia;

        #endregion Instancia
    

        #region Listar Tipo Personal

        public List<entTipoPersonal> ListarTipoPersonal()
        {

            SqlCommand cmd = null;
            List<entTipoPersonal> lista = new List<entTipoPersonal>();
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar; 
                cmd = new SqlCommand("PA_Listar_Tipoe", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoPersonal Pe = new entTipoPersonal();
                    Pe.nombre = Convert.ToString(dr["nombre"]);
                    Pe.TipopersonalID = Convert.ToInt32(dr["TipoPersonalID"]);
                    lista.Add(Pe);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
