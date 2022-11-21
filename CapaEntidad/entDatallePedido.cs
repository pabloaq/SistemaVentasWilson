using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetallePedido
    {
        public int PedidoId { get; set; }
        public int ProductoId { get; set; }
        public int cantidad { get; set; }
    }
}
