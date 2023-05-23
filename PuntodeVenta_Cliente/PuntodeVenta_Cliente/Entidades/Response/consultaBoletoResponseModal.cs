using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVenta_Cliente.Entidades.Response
{
  public class consultaBoletoResponseModal
    {
        public string idBoleto { get; set; }
        public string impresionPantalla { get; set; }
        public string impresionTicket { get; set; }
        public string monto { get; set; }
        public string codRepuesta { get; set; }
        public string codigoError { get; set; }
        public string descripcionError { get; set; }
        public string numAutorizacion { get; set; }
    }
}
