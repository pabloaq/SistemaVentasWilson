using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMantenedorMetodoPago
    {
        #region Instancia
        private static readonly logMantenedorMetodoPago instancia = new logMantenedorMetodoPago();
        public static logMantenedorMetodoPago GetInstancia => instancia;

        #endregion Instancia

        #region Listar MetodoPago

        public List<entMantenedorMetodoPago> ListarMetodoPago() => datMantenedorMetodoPago.GetInstancia.ListarMetodoPago();

        #endregion Listar MetodoPago

        #region Agregar MetodoPago

        public void InsertarMetodoPago(entMantenedorMetodoPago cate) => datMantenedorMetodoPago.GetInstancia.AgregarMetodoPago(cate);

        #endregion Agregar MetodoPago

        #region Modificar MetodoPago

        public void ModificarMetodoPago(entMantenedorMetodoPago cate) => datMantenedorMetodoPago.GetInstancia.ModificarMetodoPago(cate);

        #endregion Modificar MetodoPago

        #region Eliminar MetodoPago

        public void EliminarMetodoPago(entMantenedorMetodoPago cate) => datMantenedorMetodoPago.GetInstancia.EliminarMetodoPago(cate);

        #endregion Eliminar MetodoPago
    }
}
