using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace ParkAutoHome.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }

        }


        public byte[] Clave = Encoding.ASCII.GetBytes("Tu Clave");
        public byte[] IV = Encoding.ASCII.GetBytes("Devjoker7.37hAES");

        public string Encripta(string Cadena)
        {

            byte[] inputBytes = Encoding.ASCII.GetBytes(Cadena);
            byte[] encripted;
            RijndaelManaged cripto = new RijndaelManaged();
            using (MemoryStream ms = new MemoryStream(inputBytes.Length))
            {
                using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateEncryptor(Clave, IV), CryptoStreamMode.Write))
                {
                    objCryptoStream.Write(inputBytes, 0, inputBytes.Length);
                    objCryptoStream.FlushFinalBlock();
                    objCryptoStream.Close();
                }
                encripted = ms.ToArray();
            }
            return Convert.ToBase64String(encripted);
        }



        public string Desencripta(string Cadena)
        {
            byte[] inputBytes = Convert.FromBase64String(Cadena);
            byte[] resultBytes = new byte[inputBytes.Length];
            string textoLimpio = String.Empty;
            RijndaelManaged cripto = new RijndaelManaged();
            using (MemoryStream ms = new MemoryStream(inputBytes))
            {
                using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateDecryptor(Clave, IV), CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(objCryptoStream, true))
                    {
                        textoLimpio = sr.ReadToEnd();
                    }
                }
            }
            return textoLimpio;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

          var uu = Encripta(txtpass.Text); 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (txtusuario.Text == string.Empty && txtpass.Text == string.Empty)
            {
                Notificacion.VerMensaje("Ingrese Usuario y Contraseña.", 2);
                return;
            }
            if (txtusuario.Text == string.Empty)
            {
                Notificacion.VerMensaje("Ingrese Usuario.", 2);
                return;
            }
            if (txtpass.Text == string.Empty)
            {
                Notificacion.VerMensaje("Ingrese Contraseña.", 2);
                return;
            }            
            try
            {
                // quitar para implementacion 
                //ServicePointManager.ServerCertificateValidationCallback = delegate
               //(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

                WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
                //Notificacion.VerMensaje("El servicio no esta disponible, favor de intentarlo más tarde.", 3);
                string usuario = txtusuario.Text;
                string contra = Encripta(txtpass.Text);
                var resp = client.ValidaUsuarios(usuario, contra);
                if (resp == 1)
                    Response.Redirect("Configuracion.aspx");
                else
                    Notificacion.VerMensaje("Usuario y/o incorrecto.", 2);
            }
            catch (Exception ex)
            {
                Notificacion.VerMensaje(ex.Message.ToString(), 3);
            }
        }
    }
}