using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary.Utility
{
   public class Tools
    {
        public Boolean email_Validacion(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";


            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
            public Boolean rfc_Validacion(String rfc)
            {
            Boolean resp = false;

            if (Regex.IsMatch(rfc, "[A-z]{4}[0-9]{6}[A-z0-9]{3}") || Regex.IsMatch(rfc, "[A-z]{3}[0-9]{6}[A-z0-9]{3}"))
            {
                resp = true;
            }
            else
            {
                resp = false;
            }

            return resp;

        }

         
        

    }
}
