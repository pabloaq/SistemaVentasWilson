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

        #region Listar Categoria MetodoPago

        public List<entMantenedorMetodoPago> ListarCategoriasMetodoPago() => datMantenedorMetodoPago.GetInstancia.ListarCategoriaMetodoPago();

        #endregion Listar Categoria MetodoPago

        #region Agregar Categoria MetodoPago

        public void InsertarCategoriasMetodoPago(entMantenedorMetodoPago cate) => datMantenedorMetodoPago.GetInstancia.AgregarCategoriaMetodoPago(cate);

        #endregion Agregar Categoria MetodoPago

        #region Modificar Categoria MetodoPago

        public void ModificarCategoriasMetodoPago(entMantenedorMetodoPago cate) => datMantenedorMetodoPago.GetInstancia.ModificarCategoriaMetodoPago(cate);

        #endregion Modificar Categoria MetodoPago

        #region Eliminar Categoria MetodoPago

        public void EliminarCategoriasMetodoPago(entMantenedorMetodoPago cate) => datMantenedorMetodoPago.GetInstancia.EliminarCategoriaMetodoPago(cate);

        #endregion Eliminar Categoria MetodoPago
    }
}
