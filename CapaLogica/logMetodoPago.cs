using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logMetodoPago
    {
        #region Instancia
        private static readonly logMetodoPago instancia = new logMetodoPago();
        public static logMetodoPago GetInstancia => instancia;

        #endregion Instancia

        #region Listar MetodoPago

        public List<entMetodoPago> ListarMetodoPago() => datMetodoPago.GetInstancia.ListarMetodoPago();

        #endregion Listar MetodoPago

        #region Agregar MetodoPago

        public void InsertarMetodoPago(entMetodoPago cate) => datMetodoPago.GetInstancia.AgregarMetodoPago(cate);

        #endregion Agregar MetodoPago

        #region Modificar MetodoPago

        public void ModificarMetodoPago(entMetodoPago cate) => datMetodoPago.GetInstancia.ModificarMetodoPago(cate);

        #endregion Modificar MetodoPago

        #region Eliminar MetodoPago

        public void EliminarMetodoPago(entMetodoPago cate) => datMetodoPago.GetInstancia.EliminarMetodoPago(cate);

        #endregion Eliminar MetodoPago
    }
}
