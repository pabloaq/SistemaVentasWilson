using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logTipoPersonal
    {
        #region Instancia
        private static readonly logTipoPersonal instancia = new logTipoPersonal();
        public static logTipoPersonal GetInstancia => instancia;
        #endregion

        public List<entTipoPersonal> ListarTipoPersonal() => datTipoPersonal.GetInstancia.ListarTipoPersonal();
       
    }
}
