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
        private static readonly logProducto instancia = new logProducto();

        public static logProducto GetInstancia => instancia;
        #endregion sigleton

        #region metodos

        ///listado

        public List<entProducto> ListarProducto() => datProducto.GetInstancia.ListarProducto();

        ///inserta
        public void InsertaProducto(entProducto Pro) => datProducto.GetInstancia.InsertarProducto(Pro);
        
        //edita
        public void EditaProducto(entProducto Pro) => datProducto.GetInstancia.EditarProducto(Pro);

        /// elimina
        public void EliminarProducto(entProducto Pro) => datProducto.GetInstancia.EliminarProducto(Pro);

        #endregion metodos
    }
}
