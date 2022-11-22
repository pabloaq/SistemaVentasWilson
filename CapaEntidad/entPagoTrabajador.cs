using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPagoTrabajador
    {
        public int FichaID { get; set; }
        public DateTime fechaRegistro { get; set; }
        public int PersonalID { get; set; }
        public float sueldo { get; set; }
    }
}
