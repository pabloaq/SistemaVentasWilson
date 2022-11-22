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
    public class datDetallePedido
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datDetallePedido _instancia = new datDetallePedido();
        //privado para evitar la instanciación directa
        public static datDetallePedido Instancia
        {
            get
            {
                return datDetallePedido._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //------------------------------listado detalle Pedido--------------------------------------
        public List<entDetallePedido> ListarDetallePedido()
        {
            SqlCommand cmd = null;
            List<entDetallePedido> lista = new List<entDetallePedido>();
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar; //singleton
                cmd = new SqlCommand("spListaDetallePedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entDetallePedido detPedido = new entDetallePedido();
                    detPedido.PedidoId = Convert.ToInt32(dr["PedidoID"]);
                    detPedido.ProductoId = Convert.ToInt32(dr["ProductoID"]);
                    detPedido.cantidad = Convert.ToInt32(dr["cantidad"]);
                    lista.Add(detPedido);
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        //------------------------------Insertar Detalle Pedido--------------------------------------
        public Boolean InsertarDetallePedido(entDetallePedido detPedido)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spInsertaDetallePedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pedidoId", detPedido.PedidoId);
                cmd.Parameters.AddWithValue("@productoId", detPedido.ProductoId);
                cmd.Parameters.AddWithValue("@cantidad", detPedido.cantidad);
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

        //------------------------------Actualizar Detalle Pedido--------------------------------------
        public Boolean EditarDetallePedido(entDetallePedido detPedido)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spEditarDetallePedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pedidoId", detPedido.PedidoId);
                cmd.Parameters.AddWithValue("@productoId", detPedido.ProductoId);
                cmd.Parameters.AddWithValue("@cantidad", detPedido.cantidad);
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

        //-------------------------------Eliminar Detalle Pedido---------------------------------------------
        public Boolean EliminarDetallePedido(entDetallePedido detPedido)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("spEliminarDetallePedido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pedidoId", detPedido.PedidoId);
                cmd.Parameters.AddWithValue("@productoId", detPedido.ProductoId);
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
