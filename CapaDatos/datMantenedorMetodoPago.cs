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
    public class datMantenedorMetodoPago
    {
        #region Instancia
        private static readonly datMantenedorMetodoPago instancia = new datMantenedorMetodoPago();
        public static datMantenedorMetodoPago GetInstancia => instancia;
        #endregion Instancia

        #region Listar MetodoPago
        public List<entMantenedorMetodoPago> ListarMetodoPago()
        {
            SqlCommand cmd = null;
            List<entMantenedorMetodoPago> lista = new List<entMantenedorMetodoPago>();

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;

                cmd = new SqlCommand("pa_listar_metodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    entMantenedorMetodoPago cate = new entMantenedorMetodoPago
                    {
                        MetodopagoID = Convert.ToInt32(reader["metodopagoID"]),
                        CategoriametodopagoID = Convert.ToInt32(reader["CategoriametodopagoID"]),
                        nombre = Convert.ToString(reader["nombre"]),
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



        #endregion Listar MetodoPago

        #region Agregar MetodoPago
        public bool AgregarMetodoPago(entMantenedorMetodoPago cate)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;

                cmd = new SqlCommand("pa_insertar_metodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@metodopagoID", cate.MetodopagoID);
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


        #endregion Agregar MetodoPago

        #region Modificar MetodoPago
        public bool ModificarMetodoPago(entMantenedorMetodoPago cate)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;

                cmd = new SqlCommand("pa_update_metodopago", cn);
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


        #endregion Modificar MetodoPago

        #region Eliminar MetodoPago

        public bool EliminarMetodoPago(entMantenedorMetodoPago cate)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;

                cmd = new SqlCommand("pa_eliminar_metodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@metodopagoID", cate.MetodopagoID);

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

        #endregion Eliminar MetodoPago

    }


}
