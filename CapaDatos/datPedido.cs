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
    public class datPedido
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datPedido _instancia = new datPedido();
        //privado para evitar la instanciación directa
        public static datPedido Instancia
        {
            get
            {
                return datPedido._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //------------------------------listado de Pedido--------------------------------------
        public List<entPedido> ListarPedido()
        {
            SqlCommand cmd = null;
            List<entPedido> lista = new List<entPedido>();
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar; //singleton
                cmd = new SqlCommand("spListaPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPedido Pedido = new entPedido();
                    Pedido.PeidoId = Convert.ToInt32(dr["PedidoID"]);
                    Pedido.nombreCliente = dr["nombreCliente"].ToString();
                    Pedido.fechaRegistro = Convert.ToDateTime(dr["fechaRegistro"]);
                    Pedido.estado = Convert.ToInt32(dr["estado"]);
                    lista.Add(Pedido);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        //------------------------------Insertar Pedido--------------------------------------
        public Boolean InsertarPedido(entPedido Pedido)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spInsertaPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreCliente", Pedido.nombreCliente);
                cmd.Parameters.AddWithValue("@pedidoId", Pedido.PeidoId);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        //------------------------------Actualizar Pedido--------------------------------------
        public Boolean EditarPedido(entPedido Pedido)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spEditarPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pedidoId", Pedido.PeidoId);
                cmd.Parameters.AddWithValue("@nombreCliente", Pedido.nombreCliente);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

        //-------------------------------deshabilitar Cliente---------------------------------------------
        public Boolean DeshabilitarPedido(entPedido Pedido)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spActualizarEstadoPedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pedidoID", Pedido.PeidoId);
                cmd.Parameters.AddWithValue("@estado", Pedido.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
        #endregion metodos
    }
}
