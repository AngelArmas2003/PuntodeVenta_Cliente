using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    public class Users
    {
        public string id { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }

        public string Contraseña { get; set; }


        public bool Activo { get; set; }

    }
}
