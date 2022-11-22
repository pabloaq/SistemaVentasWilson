using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logPagoTrabajador
    {
        #region Instancia
        private static readonly logPagoTrabajador instancia = new logPagoTrabajador();

        public static logPagoTrabajador GetInstancia => instancia;

        #endregion Instancia

        public List<entPagoTrabajador> ListarPagoTrabajador() => datPagoTrabajador.GetInstancia.ListarPagoTrabajador();

        public void InsertarPagoTrabajador(entPagoTrabajador entPago) => datPagoTrabajador.GetInstancia.InsertarPagoTrabajador(entPago);

        public void EliminarPagoTrabajador(entPagoTrabajador entPago) => datPagoTrabajador.GetInstancia.EliminarPagoTrabajador(entPago);
    
    }
}
