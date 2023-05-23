using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
   public  class Proveedor
    {

        public string id { get; set; }
        public string Codigo_Proveedor { get; set; }
        public string CveEmpresa { get; set; }
        public string Nombre_Empresa { get; set; }
        public string CveEstamto { get; set; }

        public string Estacionamiento { get; set; }

        public string Determinante { get; set; }

        public bool Activo { get; set; }
    }
}
