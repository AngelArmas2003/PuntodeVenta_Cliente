using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVenta_Cliente.Entidades.Response
{
    public  class notiBoletoPagadoResponseModal
    {
        public string idBoleto { get; set; }
        public string impresionPantalla { get; set; }
        public string impresionTicket { get; set; }
        public string fechaEntrada { get; set; }
        public string horaEntrada { get; set; }
        public string fechaCobro { get; set; }
        public string horaCobro { get; set; }
        public string duracion { get; set; }
        public string codRepuesta { get; set; }
        public string codigoError { get; set; }
        public string descripcionError { get; set; }
        public string montoNuevo { get; set; }
        public string tiempoAdicional { get; set; }
        public string numAutorizacion { get; set; }
    }
}
