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
        #region sigleton

        private static readonly datCategoriaMetodoPago _instancia = new datCategoriaMetodoPago();

        public static datCategoriaMetodoPago Instancia
        {
            get
            {
                return datCategoriaMetodoPago._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //-------------------------listado Categoria Metodo Pago-----------------------------------
        public List<entCategoriaMetodoPago> ListarCategoriaMetodoPago()
        {
            SqlCommand cmd = null;
            List<entCategoriaMetodoPago> lista = new List<entCategoriaMetodoPago>();
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("pa_listar_Categoriametodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCategoriaMetodoPago catMetodoPago = new entCategoriaMetodoPago();
                    catMetodoPago.idCategoriaMetodoPago = Convert.ToInt32(dr["CategoriametodopagoID"]);
                    catMetodoPago.nombreCategoria = Convert.ToString(dr["nombre"]);
                    catMetodoPago.descripcion = Convert.ToString(dr["descripcion"]);
                    lista.Add(catMetodoPago);
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
        //----------------------------Insertar Categoria Metodo Pago-------------------------------
        public Boolean InsertarCategoriaMetodoPago(entCategoriaMetodoPago catMetodoPago)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("pa_insert_Categoriametodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", catMetodoPago.nombreCategoria);
                cmd.Parameters.AddWithValue("@descripcion", catMetodoPago.descripcion);
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


        //-------------------------------Actualizar Categoria Metodo Pago----------------------------
        public Boolean EditarCategoriaMetodoPago(entCategoriaMetodoPago catMetodoPago)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("pa_update_Categoriametodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CategoriametodopagoID", catMetodoPago.idCategoriaMetodoPago);
                cmd.Parameters.AddWithValue("@nombre", catMetodoPago.nombreCategoria);
                cmd.Parameters.AddWithValue("@descripcion", catMetodoPago.descripcion);

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

        //------------------------------Eliminar Categoria Metodo Pago -----------------------------

        public Boolean EliminarCategoriaMetodoPago(entCategoriaMetodoPago catMetodoPago)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("pa_delete_Categoriametodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriametodopagoID", catMetodoPago.idCategoriaMetodoPago);

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
