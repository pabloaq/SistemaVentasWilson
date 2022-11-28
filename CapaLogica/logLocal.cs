using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logLocal
    {
        #region Instancia
        private static readonly logLocal instancia = new logLocal();

        public static logLocal GetInstancia => instancia;

        #endregion Instancia

        public List<entLocal> ListarLocal() => datLocal.GetInstancia.ListarLocal();

    }
}
