using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVenta_Cliente.Entidades.Response
{
   public  class consultaBoleto
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

    public class Application
    {
        public consultaBoleto consultaBoleto { get; set; }



    }

}
