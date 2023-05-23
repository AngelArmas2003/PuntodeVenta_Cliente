using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVenta_Cliente.Entidades.Request
{
    public class consultaBoletoRequest
    {
        public string idBoleto { get; set; }
        public string te { get; set; }
        public string tr { get; set; }
        public string tda { get; set; }

    }

    public class Application
    {
        public consultaBoletoRequest consultaBoletoRequest { get; set; }



    }


}
