using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVenta_Cliente.Entidades.Request
{
   public  class consultaSafeModal
    {
        public string id_transaccion { get; set; }


        public string id_proveedor { get; set; }
        public string idboleto { get; set; }
        public string tienda { get; set; }
        public string caja { get; set; }

        public string transaccion { get; set; }
        public string hora_entrada { get; set; }
        public string fecha_entrada { get; set; }

        public string monto { get; set; }
        public string cod_autorizacion { get; set; }
        public string cod_error { get; set; }
        public string motivo { get; set; }
        public string hora_cobro { get; set; }
        public string fecha_cobro { get; set; }
        public string duracion { get; set; }
    }
}
