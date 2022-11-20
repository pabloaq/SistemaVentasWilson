using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logDetallePedido
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logDetallePedido _instancia = new logDetallePedido();

        //privado para evitar la instanciación directa
        public static logDetallePedido Instancia
        {
            get
            {
                return logDetallePedido._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //-----------------------------listado----------------------------------
        public List<entDetallePedido> ListarDetallePedido()
        {
            return datDetallePedido.Instancia.ListarDetallePedido();
        }

        //-----------------------------Insertar----------------------------------
        public void InsertaPedido(entDetallePedido detPedido)
        {
            datDetallePedido.Instancia.InsertarDetallePedido(detPedido);
        }

        //-----------------------------editar----------------------------------
        public void EditaPedido(entDetallePedido detPedido)
        {
            datDetallePedido.Instancia.EditarDetallePedido(detPedido);
        }

        //-----------------------------deshabiliar----------------------------------
        public void DeshabilitarPedido(entDetallePedido detPedido)
        {
            datDetallePedido.Instancia.EliminarDetallePedido(detPedido);
        }
        #endregion metodos
    }
}
