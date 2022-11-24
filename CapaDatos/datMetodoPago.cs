using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class datMetodoPago
    {
        #region Instancia
        private static readonly datMetodoPago instancia = new datMetodoPago();
        public static datMetodoPago GetInstancia => instancia;
        #endregion Instancia

        #region Listar MetodoPago
        public List<entMetodoPago> ListarMetodoPago()
        {
            SqlCommand cmd = null;
            List<entMetodoPago> lista = new List<entMetodoPago>();

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;

                cmd = new SqlCommand("pa_listar_metodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    entMetodoPago cate = new entMetodoPago
                    {
                        MetodopagoID = Convert.ToInt32(reader["MetodopagoID"]),
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
        public bool AgregarMetodoPago(entMetodoPago cate)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;

                cmd = new SqlCommand("pa_insertar_metodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MetodopagoID", cate.MetodopagoID);
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
        public bool ModificarMetodoPago(entMetodoPago cate)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;

                cmd = new SqlCommand("pa_update_metodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MetodopagoID", cate.MetodopagoID);
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

        public bool EliminarMetodoPago(entMetodoPago cate)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;

                cmd = new SqlCommand("pa_eliminar_metodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MetodopagoID", cate.MetodopagoID);

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
