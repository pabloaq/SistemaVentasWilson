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
    public class datCategoriaMetodoPago
    {
        #region Instancia
        private static readonly datCategoriaMetodoPago instancia = new datCategoriaMetodoPago();
        public static datCategoriaMetodoPago GetInstancia => instancia;
        #endregion Instancia

        #region Listar Categoria MetodoPago
        public List<entCategoriaMetodoPago> ListarCategoriaMetodoPago()
        {
            SqlCommand cmd = null;
            List<entCategoriaMetodoPago> lista = new List<entCategoriaMetodoPago>();

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;

                cmd = new SqlCommand("pa_listar_categoria_metodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    entCategoriaMetodoPago cate = new entCategoriaMetodoPago
                    {
                        CategoriametodopagoID = Convert.ToInt32(reader["CategoriametodopagoID"]),
                        nombre = Convert.ToString(reader["nombreCategoria"]),
                        descripcion = Convert.ToString(reader["descripcion"])
                    };

                    lista.Add(cate);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);

            }
            finally
            {
                cmd.Connection.Close();
            }

            return lista;
        }



        #endregion Listar Categoria MetodoPago

        #region Agregar Categoria MetodoPago
        public bool AgregarCategoriaMetodoPago(entCategoriaMetodoPago cate)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;

                cmd = new SqlCommand("pa_insertar_categoria_metodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoriametodopagoID", cate.CategoriametodopagoID);
                cmd.Parameters.AddWithValue("@nombre", cate.nombre);
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


        #endregion Agregar Categoria MetodoPago

        #region Modificar Categoria MetodoPago
        public bool ModificarCategoriaMetodoPago(entCategoriaMetodoPago cate)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;

                cmd = new SqlCommand("pa_modificar_categoria_metodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", cate.nombre);
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


        #endregion Modificar Categoria MetodoPago

        #region Eliminar Categoria MetodoPago

        public bool EliminarCategoriaMetodoPago(entCategoriaMetodoPago cate)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;

                cmd = new SqlCommand("pa_eliminar_categoria_metodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoriametodopagoID", cate.CategoriametodopagoID);

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

        #endregion Eliminar Categoria MetodoPago

    }


}
