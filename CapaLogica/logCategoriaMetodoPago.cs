using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCategoriaMetodoPago
    {
        #region sigleton

        private static readonly logCategoriaMetodoPago _instancia = new logCategoriaMetodoPago();

        public static logCategoriaMetodoPago Instancia
        {
            get
            {
                return logCategoriaMetodoPago._instancia;
            }
        }
        #endregion singleton

        #region metodos

        //--------------------------listado-----------------------------------

        public List<entCategoriaMetodoPago> ListarCategoriaMetodoPago()
        {
            return datCategoriaMetodoPago.Instancia.ListarCategoriaMetodoPago();
        }
        //------------------------insertar------------------------------------
        public void InsertaCategoriaMetodoPago(entCategoriaMetodoPago catMetodoPago)
        {
            datCategoriaMetodoPago.Instancia.InsertarCategoriaMetodoPago(catMetodoPago);
        }

        //------------------------editar----------------------------------------
        public void EditaCategoriaMetodoPago(entCategoriaMetodoPago catMetodoPago)
        {
            datCategoriaMetodoPago.Instancia.EditarCategoriaMetodoPago(catMetodoPago);
        }
        //------------------------eliminar--------------------------------------
        public void EliminaCategoriaMetodoPago(entCategoriaMetodoPago catMetodoPago)
        {
            datCategoriaMetodoPago.Instancia.EliminarCategoriaMetodoPago(catMetodoPago);
        }
        #endregion metodos
    }
}
