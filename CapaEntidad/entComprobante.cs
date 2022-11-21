using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entComprobante
    {
        public int ComprobanteID { get; set; }
        public int LocalID { get; set; }
        public int PedidoID { get; set; }
        public int MetodopagoID { get; set; }
        public float montoTotal { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
