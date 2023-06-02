using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using ClassLibrary.Entities;
using Newtonsoft.Json;

namespace ParkAutoHome.Pages
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //MaintainScrollPositionOnPostBack = true;
            if (!IsPostBack)
            {
                fillgrilla();
                Inicio();
            }
            else
            {
                if (Valida.Value == "1")
                {
                    btnEditar_Click(sender, e);
                }
            }
        }


        private void fillgrilla()
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();

            WsPA.Users entUser = new WsPA.Users();
            entUser.Nombre = TxtBNombre.Text;
            entUser.Usuario = TxtBUsuario.Text;


            GridView1.DataSource = client.CatalogoUsuario(entUser);
            GridView1.DataBind();
            //GridViewRow row = GridView1.SelectedRow;
            txtid.Enabled = false;
            txtnombre.Enabled = false;
            txtusuario.Enabled = false;
            txtcontraseña.Enabled = false;
            ckEstatus.Enabled = false;
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.PageIndex = e.NewPageIndex;
            fillgrilla();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtid.Text = GridView1.SelectedRow.Cells[0].Text;
            this.txtnombre.Text = GridView1.SelectedRow.Cells[1].Text;
            this.txtusuario.Text = GridView1.SelectedRow.Cells[2].Text;
            this.txtcontraseña.Text = GridView1.SelectedRow.Cells[3].Text;
            this.txtConfirmar.Text = GridView1.SelectedRow.Cells[3].Text;
            var dd = (GridView1.SelectedRow.Cells[4]).Text;
            this.ckEstatus.Checked = Convert.ToBoolean(dd);
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            txtid.Enabled = false;
            txtnombre.Enabled = false;
            txtusuario.Enabled = false;
            txtcontraseña.Enabled = false;
            ckEstatus.Enabled = false;

            btnGuardar.Text = "Actualizar";
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
            fillgrilla();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            txtid.Enabled = false;
            txtnombre.Enabled = true;
            txtusuario.Enabled = true;
            txtcontraseña.Enabled = true;
            ckEstatus.Enabled = true;


            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;

            btnEditar.Enabled = false;

            txtConfirmar.Enabled = true;



        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Inicio();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtid.Enabled = false;
            txtnombre.Focus();
            txtnombre.Enabled = true;
            txtusuario.Enabled = true;
            txtcontraseña.Enabled = true;
            ckEstatus.Enabled = true;
            txtConfirmar.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;




        }


        public void Inicio()
        {
            txtid.Enabled = false;
            txtnombre.Enabled = false;
            txtusuario.Enabled = false;
            txtcontraseña.Enabled = false;
            ckEstatus.Enabled = false;
            this.txtConfirmar.Enabled = false;

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnNuevo.Text = "Nuevo";
            btnEditar.Enabled = false;

            this.txtid.Text = "";
            this.txtnombre.Text = "";
            this.txtusuario.Text = "";
            this.txtcontraseña.Text = "";
            this.ckEstatus.Checked = false;
            this.txtConfirmar.Text = "";
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text.Contains("Guardar"))
            {
                WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
                Users osu = new Users();
                osu.Nombre = txtnombre.Text;
                osu.Usuario = txtusuario.Text;
                osu.Contraseña = ViewState["pw"].ToString();
                string ResponseJson = JsonConvert.SerializeObject(osu);
                var c = client.UserNew(ResponseJson);
                fillgrilla();
                Inicio();
                Notificacion.VerMensaje("Usuario registrado.", 1);
                Valida.Value = "0";
            }
            if (btnGuardar.Text.Contains("Actualizar"))
            {
                WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
                Users osu = new Users();
                osu.id = txtid.Text;
                osu.Nombre = txtnombre.Text;
                osu.Usuario = txtusuario.Text;
                osu.Contraseña = ViewState["pw"].ToString();
                osu.Activo = ckEstatus.Checked;
                var totusaurio = client.ValidaUsuarios(osu.Usuario, Encripta(osu.Contraseña));
                string ResponseJson = JsonConvert.SerializeObject(osu);
                var c = client.UpdaterNew(ResponseJson);
                fillgrilla();
                Notificacion.VerMensaje("Usuario actualizado.", 1);
                Valida.Value = "0";
                Inicio();
            }
        }


        public bool ValidaContraseña(string pas1, string pas2)
        {
            bool val = false;


            if (pas1 == pas2)
            {
                val = true;

            }
            else
            {
                val = false;
            }



            return val;
        }


        public string Encripta(string Cadena)
        {
            byte[] Clave = Encoding.ASCII.GetBytes("Tu Clave");
            byte[] IV = Encoding.ASCII.GetBytes("Devjoker7.37hAES");

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

        protected void BtnBusqueda_Click(object sender, EventArgs e)
        {
            fillgrilla();
        }

        protected void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBUsuario.Text = string.Empty;
            TxtBNombre.Text = string.Empty;
            fillgrilla();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text.Contains("Guardar"))
            {
                WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
                Users osu = new Users();
                osu.Nombre = txtnombre.Text;
                osu.Usuario = txtusuario.Text;
                osu.Contraseña = txtcontraseña.Text ;
                ViewState["pw"] = osu.Contraseña;
                if (txtnombre.Text == string.Empty || txtusuario.Text == string.Empty || txtcontraseña.Text == string.Empty || txtcontraseña.Text == string.Empty)
                {
                    Notificacion.VerMensaje("Capture todos los campos.", 2);
                }
                else
                {
                    var Passok = ValidaContraseña(txtConfirmar.Text, osu.Contraseña);
                    if (Passok)
                    {
                        string contra = Encripta(osu.Contraseña);
                        var totusaurio = client.ValidaUsuarios2(osu.Usuario);
                        if (totusaurio >= 1)
                        {
                            Notificacion.VerMensaje("El usuario ya se encuentra registrado.", 2);
                        }
                        else
                        {
                            Valida.Value = "1";
                            string varmensaje = string.Format("verMsgPregunta('{0}');", "¿Están correctos todos sus datos?");
                            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "", varmensaje, true);
                        }
                    }
                    else
                    {
                        Notificacion.VerMensaje("Verifique el Password, debe ser identica en la confirmación.", 2);
                    }
                }
            }
            if (btnGuardar.Text.Contains("Actualizar"))
            {
                WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
                Users osu = new Users();
                osu.id = txtid.Text;
                osu.Nombre = txtnombre.Text;
                osu.Usuario = txtusuario.Text;
                osu.Contraseña = txtcontraseña.Text;
                ViewState["pw"] = osu.Contraseña;
                osu.Activo = ckEstatus.Checked;
                var totusaurio = client.ValidaUsuarios(osu.Usuario, Encripta(osu.Contraseña));

                if (txtnombre.Text == string.Empty || txtusuario.Text == string.Empty || txtcontraseña.Text == string.Empty || txtcontraseña.Text == string.Empty)
                {
                    Notificacion.VerMensaje("Capture todos los campos.", 2);
                }
                else
                {
                    var Passok = ValidaContraseña(txtConfirmar.Text, osu.Contraseña);

                    if (Passok)
                    {
                        if (totusaurio >= 1)
                        {
                            Notificacion.VerMensaje("El Usuario ya se encuentra registrado.", 2);
                        }
                        else
                        {
                            Valida.Value = "1";
                            string varmensaje = string.Format("verMsgPregunta('{0}');", "¿Están correctos todos sus datos?");
                            ScriptManager.RegisterClientScriptBlock(this, typeof(Page), "", varmensaje, true);
                        }
                    }
                    else
                    {
                        Notificacion.VerMensaje("Verifique el password, debe ser identica en la confirmación.", 2);
                    }
                }
            }


        }
    }

}
