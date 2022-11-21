using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logCategoriaProducto
    {
        #region Instancia
        private static readonly logCategoriaProducto instancia = new logCategoriaProducto();
        public static logCategoriaProducto GetInstancia => instancia;

        #endregion Instancia

        #region Listar Categoria Producto

        public List<entCategoriaProducto> ListarCategoriasProducto() => datCategoriaProducto.GetInstancia.ListarCategoriaProducto();

        #endregion Listar Categoria Producto

        #region Agregar Categoria Producto

        public void InsertarCategoriasProducto(entCategoriaProducto cate) => datCategoriaProducto.GetInstancia.AgregarCategoriaProducto(cate);

        #endregion Agregar Categoria Producto

        #region Modificar Categoria Producto

        public void ModificarCategoriasProducto(entCategoriaProducto cate) => datCategoriaProducto.GetInstancia.ModificarCategoriaProducto(cate);

        #endregion Modificar Categoria Producto

        #region Eliminar Categoria Producto

        public void EliminarCategoriasProducto(entCategoriaProducto cate) => datCategoriaProducto.GetInstancia.EliminarCategoriaProducto(cate);

        #endregion Eliminar Categoria Producto
    }
}
