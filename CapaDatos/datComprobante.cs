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
    public class datComprobante
    {
        # region Instancia
        private static readonly datComprobante instancia = new datComprobante();

        public static datComprobante GetInstancia => instancia;
        #endregion  Instancia

        #region Datos Comprobante

        public bool InsertaDatosComprobante(entComprobante comprobante)
        {
            SqlCommand cmd = null;
            Boolean insertar = false;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("pa_insert_comprobante", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LocalID", comprobante.LocalID);
                cmd.Parameters.AddWithValue("@PedidoID", comprobante.PedidoID);
                cmd.Parameters.AddWithValue("@MetodopagoID", comprobante.MetodopagoID);
                cmd.Parameters.AddWithValue("@montoTotal", comprobante.montoTotal);

                cn.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    insertar = true;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            finally
            {
                cmd.Connection.Close();
            }
            return insertar;
        }

        #endregion Datos Comprobante

    }
}
