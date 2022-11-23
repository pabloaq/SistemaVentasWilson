using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class datPagoTrabajador
    {
        #region Instancia
        private static readonly datPagoTrabajador instancia = new datPagoTrabajador();

        public static datPagoTrabajador GetInstancia => instancia;

        #endregion Instancia

        #region Listar Pago Trabajador

        public List<entPagoTrabajador> ListarPagoTrabajador()
        {
            SqlCommand cmd = null;
            List<entPagoTrabajador> lista = new List<entPagoTrabajador>();

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("pa_listar_pago_trabajador", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    entPagoTrabajador entPago = new entPagoTrabajador
                    {
                        fechaRegistro = Convert.ToDateTime(reader["fechaRegistro"]),
                        PersonalID = Convert.ToInt32(reader["PersonalID"]),
                        sueldo = Convert.ToSingle(reader["sueldo"])
                    };

                    lista.Add(entPago);
                }
            }catch(Exception ex) { 
                Console.WriteLine(ex.Message); 
            }
            finally
            {
                cmd.Connection.Close();
            }

            return lista;
        }

        #endregion Listar Pago Trabajador

        #region Insertar Pago Trabajador

        public bool InsertarPagoTrabajador(entPagoTrabajador entPago)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.GetInstancia.Conectar;
                cmd = new SqlCommand("pa_insertar_pago_trabajador", cn);

                cmd.Parameters.AddWithValue("@fechaRegistro", entPago.fechaRegistro);
                cmd.Parameters.AddWithValue("@PersonalID", entPago.PersonalID);
                cmd.Parameters.AddWithValue("@sueldo", entPago.sueldo);

                cn.Open();

                if(cmd.ExecuteNonQuery() > 0) { return true; };
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }

            return false;
        }

        #endregion Insertar Pago Trabajador

        //#region Eliminar Pago Trabajador
        
        //public bool EliminarPagoTrabajador(entPagoTrabajador entPago)
        //{
        //    SqlCommand cmd = null;

        //    try
        //    {
        //        SqlConnection cn = Conexion.GetInstancia.Conectar;
        //        cmd = new SqlCommand("pa_eliminar_pago_trabajador", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@FichaID", entPago.FichaID);

        //        cn.Open();

        //        if(cmd.ExecuteNonQuery() > 0) { return true; };

        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        cmd.Connection.Close();
        //    }

        //    return false;
        //}

        //#endregion Eliminar Pago Trabajador

    }
}
