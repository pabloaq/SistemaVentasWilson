using CapaEntidad;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

namespace CapaDatos
{
    public class datPersonal
    {
        #region Instancia
        private static readonly datPersonal instancia = new datPersonal();
        public static datPersonal GetInstancia => instancia;

        #endregion

        #region Listar Personal
        public List<entPersonal> ListarPersonal()
        {
            SqlCommand cmd = null;
            List<entPersonal> lista = new List<entPersonal>();
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar; 
                cmd = new SqlCommand("pa_listar_personal", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPersonal Pe = new entPersonal();

                    Pe.PersonalId = Convert.ToInt32(dr["PersonalID"]);
                    Pe.nombre = dr["nombre"].ToString();

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