using CapaEntidad;
using System;
using System.Data.SqlClient;
using System.Data;

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

        #region Verificar Monto Total

        public float VerificarMontoTotal (entComprobante comprobante)
        {

            SqlCommand cmd = null;

            float total = 0;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("MontoTotalPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pedido_Id", comprobante.PedidoID);
                SqlParameter totalPago = new SqlParameter("@TOTAL", 0);
                totalPago.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(totalPago);

                cn.Open();
                cmd.ExecuteNonQuery();
                total = float.Parse(cmd.Parameters["@TOTAL"].Value.ToString());

            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

            finally
            {
                cmd.Connection.Close();
            }
            return total;

        }


        #endregion Verificar Monto Total
    }
}
