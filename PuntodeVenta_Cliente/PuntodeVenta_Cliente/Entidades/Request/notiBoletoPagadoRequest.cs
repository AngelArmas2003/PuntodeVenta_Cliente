using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVenta_Cliente.Entidades.Request
{
   public class notiBoletoPagadoRequest
    {
        public string idBoleto { get; set; }
        public string te { get; set; }
        public string tr { get; set; }
        public string tda { get; set; }
    }
}
