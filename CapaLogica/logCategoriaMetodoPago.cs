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
        #region Instancia
        private static readonly logCategoriaMetodoPago instancia = new logCategoriaMetodoPago();
        public static logCategoriaMetodoPago GetInstancia => instancia;

        #endregion Instancia

        #region Listar Categoria MetodoPago

        public List<entCategoriaMetodoPago> ListarCategoriasMetodoPago() => datCategoriaMetodoPago.GetInstancia.ListarCategoriaMetodoPago();

        #endregion Listar Categoria MetodoPago

        #region Agregar Categoria MetodoPago

        public void InsertarCategoriasMetodoPago(entCategoriaMetodoPago cate) => datCategoriaMetodoPago.GetInstancia.AgregarCategoriaMetodoPago(cate);

        #endregion Agregar Categoria MetodoPago

        #region Modificar Categoria MetodoPago

        public void ModificarCategoriasMetodoPago(entCategoriaMetodoPago cate) => datCategoriaMetodoPago.GetInstancia.ModificarCategoriaMetodoPago(cate);

        #endregion Modificar Categoria MetodoPago

        #region Eliminar Categoria MetodoPago

        public void EliminarCategoriasMetodoPago(entCategoriaMetodoPago cate) => datCategoriaMetodoPago.GetInstancia.EliminarCategoriaMetodoPago(cate);

        #endregion Eliminar Categoria MetodoPago
    }
}
