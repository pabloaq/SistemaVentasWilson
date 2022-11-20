using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logPedido
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logPedido _instancia = new logPedido();
        private object datCliente;

        //privado para evitar la instanciación directa
        public static logPedido Instancia
        {
            get
            {
                return logPedido._instancia;
            }
        }
        #endregion singleton

        #region metodos
        //-----------------------------listado----------------------------------
        public List<entPedido> ListarPedido()
        {
            return datPedido.Instancia.ListarPedido();
        }

        //-----------------------------Insertar----------------------------------
        public void InsertaPedido(entPedido Pedido)
        {
            datPedido.Instancia.InsertarPedido(Pedido);
        }

        //-----------------------------editar----------------------------------
        public void EditaPedido(entPedido Pedido)
        {
            datPedido.Instancia.EditarPedido(Pedido);
        }

        //-----------------------------deshabiliar----------------------------------
        public void DeshabilitarPedido(entPedido Pedido)
        {
            datPedido.Instancia.DeshabilitarPedido(Pedido);
        }
        #endregion metodos
    }
}
