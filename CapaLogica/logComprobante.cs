using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logComprobante
    {

        #region Instancia
        private static readonly logComprobante instancia = new logComprobante();

        public static logComprobante GetInstancia => logComprobante.instancia;

        #endregion Instancia


        #region Datos Comprobante

        public void InsertarDatosComprobante(entComprobante comprobante) => datComprobante.GetInstancia.InsertaDatosComprobante(comprobante);

        #endregion Datos Comprobante


        #region Verifica Total

        public float VerificarMontoTotal(entComprobante comprobante) => datComprobante.GetInstancia.VerificarMontoTotal(comprobante);

        #endregion Verifica Total



    }
}
