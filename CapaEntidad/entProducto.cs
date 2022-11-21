using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProducto
    {
        public int ProductoID { get; set; }
        public int CategoriaproductoID { get; set; }
        public int LocalID { get; set; }
        public string nombre { get; set; }
        public int stock { get; set; }
        public string precioUnitario { get; set; }
        public DateTime fechaCaducidad { get; set; }
    }
}
