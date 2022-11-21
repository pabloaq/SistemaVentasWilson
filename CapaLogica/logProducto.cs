using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProducto
    {
        #region sigleton
        private static readonly logProducto _instancia = new logProducto();
        public static logProducto Instancia
        {
            get
            {
                return logProducto._instancia;
            }
        }
        #endregion sigleton

        #region metodos

        ///listado

        public List<entProducto> ListarProducto()
        {
            return datProductos.Instancia.ListarProducto();
        }
        ///inserta
        public void InsertaProducto(entProducto Pro)
        {
            datProductos.Instancia.InsertarProducto(Pro);
        }

        //edita
        public void EditaProducto(entProducto Pro)
        {
            datProductos.Instancia.EditarProducto(Pro);
        }
        public void EliminarProducto(entProducto Pro)
        {
            datProductos.Instancia.EliminarProducto(Pro);
        }
        #endregion metodos

    }
}
