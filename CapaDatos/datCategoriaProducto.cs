using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class datCategoriaProducto
    {
        #region Instancia
        private static readonly datCategoriaProducto instancia = new datCategoriaProducto();
        public static datCategoriaProducto GetInstancia => instancia;
        #endregion Instancia

        #region Listar Categoria Producto
        public List<entCategoriaProducto> ListarCategoriaProducto()
        {
            SqlCommand cmd = null;
            List<entCategoriaProducto> lista = new List<entCategoriaProducto>();

            try{
                SqlConnection cn = Conexion.GetInstancia.Conectar;

                cmd = new SqlCommand("pa_listar_categoria_producto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    entCategoriaProducto cate = new entCategoriaProducto
                    {
                        idCategoriaProducto = Convert.ToInt32(reader["CategoriaproductoID"]),
                        nombreCategoria = Convert.ToString(reader["nombre"]),
                        descripcion = Convert.ToString(reader["descripcion"])
                    };

                    lista.Add(cate);
                }
            }
            catch (Exception e){
                Console.WriteLine("Error: " + e);

            }
            finally{
                cmd.Connection.Close();
            }

            return lista;
        }



        #endregion Listar Categoria Producto

        #region Agregar Categoria Producto
        public bool AgregarCategoriaProducto(entCategoriaProducto cate){
            SqlCommand cmd = null;

            try{
                SqlConnection cn = Conexion.GetInstancia.Conectar;

                cmd = new SqlCommand("pa_insertar_categoria_producto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoriaproductoID", cate.idCategoriaProducto);
                cmd.Parameters.AddWithValue("@nombre", cate.nombreCategoria);
                cmd.Parameters.AddWithValue("@descripcion", cate.descripcion);

                cn.Open();

                if (cmd.ExecuteNonQuery() > 0) { return true; }
            }
            catch(Exception e){
                Console.WriteLine("Error: " + e);
            }
            finally{
                cmd.Connection.Close();
            }

            return false;
        }


        #endregion Agregar Categoria Producto

        #region Modificar Categoria Producto
            public bool ModificarCategoriaProducto(entCategoriaProducto cate){
                SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;

                cmd = new SqlCommand("pa_modificar_categoria_producto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", cate.nombreCategoria);
                cmd.Parameters.AddWithValue("@descripcion", cate.descripcion);

                cn.Open();

                if (cmd.ExecuteNonQuery() > 0) { return true; }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            finally
            {
                cmd.Connection.Close();
            }

            return false;
        }


        #endregion Modificar Categoria Producto

        #region Eliminar Categoria Producto

        public bool EliminarCategoriaProducto(entCategoriaProducto cate)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;

                cmd = new SqlCommand("pa_eliminar_categoria_producto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoriaproductoID", cate.idCategoriaProducto);

                cn.Open();

                if (cmd.ExecuteNonQuery() > 0) { return true; }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            finally 
            { 
                cmd.Connection.Close();  
            }

            return false;
        }

        #endregion Eliminar Categoria Producto

    }
}
