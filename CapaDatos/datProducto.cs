using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datProducto
    {
        #region sigleton
        private static readonly datProducto instancia = new datProducto();

        public static datProducto GetInstancia => instancia;

        #endregion sigleton

        #region metodos
        /////////////////////////ListaProductos
        public List<entProducto> ListarProducto()
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar; //singleton
                cmd = new SqlCommand("SP_Listar_Productos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProducto Pro = new entProducto();
                    Pro.ProductoID = Convert.ToInt32(dr["ProductoID"]);
                    Pro.CategoriaproductoID = Convert.ToInt32(dr["CategoriaproductoID"]);
                    Pro.LocalID = Convert.ToInt32(dr["LocalID"]);
                    Pro.nombre = Convert.ToString(dr["nombre"]);
                    Pro.stock = Convert.ToInt32(dr["stock"]);
                    Pro.precioUnitario = dr["precioUnitario"].ToString();
                    Pro.fechaCaducidad = Convert.ToDateTime(dr["fechaCaducidad"] is DBNull ? null : dr["fechaCaducidad"]);
                    lista.Add(Pro);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }



        /////////////////////////InsertaCliente
        public bool InsertarProducto(entProducto Pro)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("SP_Insertar_Producto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", Pro.ProductoID);
                cmd.Parameters.AddWithValue("@CategoriaproductoID", Pro.CategoriaproductoID);
                cmd.Parameters.AddWithValue("@LocalID", Pro.LocalID);
                cmd.Parameters.AddWithValue("@Nombre", Pro.nombre);
                cmd.Parameters.AddWithValue("@Stock", Pro.stock);
                cmd.Parameters.AddWithValue("@PrecioUnitario", Pro.precioUnitario);
                cmd.Parameters.AddWithValue("@FechaCaducidad", Pro.fechaCaducidad);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { cmd.Connection.Close(); }

            return inserta;
        }

        /////////////////////////EditarProducto
        public bool EditarProducto(entProducto Pro)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("SP_Actualizar_Producto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", Pro.ProductoID);
                cmd.Parameters.AddWithValue("@CategoriaproductoID", Pro.CategoriaproductoID);
                cmd.Parameters.AddWithValue("@LocalID", Pro.LocalID);
                cmd.Parameters.AddWithValue("@Nombre", Pro.nombre);
                cmd.Parameters.AddWithValue("@Stock", Pro.stock);
                cmd.Parameters.AddWithValue("@PrecioUnitario", Pro.precioUnitario);
                cmd.Parameters.AddWithValue("@FechaCaducidad", Pro.fechaCaducidad);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { cmd.Connection.Close(); }

            return edita;
        }




        /////////////////////////EliminarProducto
        public bool EliminarProducto(entProducto Pro)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("SP_Eliminar_Producto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductoID", Pro.ProductoID);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception ex) { 
                Console.WriteLine("Error: " + ex.Message); 
            }
            finally { cmd.Connection.Close(); }

            return delete;
        }


        # endregion metodos
    }
}
