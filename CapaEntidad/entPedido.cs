using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPedido
    {
        public int PeidoId { get; set; }
        public string nombreCliente { get; set; }
        public DateTime fechaRegistro { get; set; }
        public int estado { get; set; }
    }
}
