using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logPersonal
    {
        #region Instancia
        private static readonly logPersonal instancia = new logPersonal();
        public static logPersonal GetInstancia => instancia;
        #endregion Instancia

        public List<entPersonal> ListarPersonal() => datPersonal.GetInstancia.ListarPersonal();
        
    }
}
    