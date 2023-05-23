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
            if (!IsPostBack)
            {
                fillgrilla();
                Inicio();
            }
            else


            {


            }
        }


        private void fillgrilla()
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();

            GridView1.DataSource = client.CatalogoUsuario();
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
            this.txtnombre.Text ="";
            this.txtusuario.Text  = "";
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
                osu.Contraseña = txtcontraseña.Text;




             




                if (txtnombre.Text == string.Empty || txtusuario.Text == string.Empty || txtcontraseña.Text == string.Empty || txtcontraseña.Text == string.Empty)

                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Capture todos los campos');", true);

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

                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El Usuario ya se encuentra registrado ');", true);
                        }
                        else
                        {

                            string ResponseJson = JsonConvert.SerializeObject(osu);
                            var c = client.UserNew(ResponseJson);
                            fillgrilla();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Usuario Registrado');", true);
                            Inicio();
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Verifique el Password, debe ser identica en la confirmación');", true);

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
                osu.Activo = ckEstatus.Checked;


               



                var totusaurio = client.ValidaUsuarios(osu.Usuario, Encripta(osu.Contraseña));

                if (txtnombre.Text == string.Empty || txtusuario.Text == string.Empty || txtcontraseña.Text == string.Empty || txtcontraseña.Text == string.Empty)

                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Capture todos los campos');", true);

                }
                else
                {
                    var Passok = ValidaContraseña(txtConfirmar.Text, osu.Contraseña);

                    if (Passok)
                    {
                        if (totusaurio >= 1)
                        {

                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El Usuario ya se encuentra registrado ');", true);
                        }
                        else
                        {


                            string ResponseJson = JsonConvert.SerializeObject(osu);
                            var c = client.UpdaterNew(ResponseJson);
                            fillgrilla();
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Usuario Actualizado');", true);
                            Inicio();
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Verifique el Password, debe ser identica en la confirmación');", true);

                    }

                }



















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

    }

}
