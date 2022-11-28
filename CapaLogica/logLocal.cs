using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logLocal
    {

        #region Instancia
        private static readonly logLocal instancia = new logLocal();

        public static logLocal GetInstancia => logLocal.instancia;

        #endregion Instancia


        #region metodos

        public List<entLocal> ListarLocal() => datLocal.GetInstancia.ListarLocal();

        #endregion metodos


    }
}
