using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary.Entities;

namespace ParkAutoHome.Pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillgrilla();
                Inicio();
            }
        }
        private void fillgrilla()
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            WsPA.Combos ent = new WsPA.Combos();
            ent.Combo = TxtBNoCombo.Text;
            ent.DescripcionCombo = TxtBCombo.Text;
            GVCombo.DataSource = client.CatalogoCombos(ent);
            GVCombo.DataBind();
            txtNumCombo.Enabled = false;
            txtNumCombo.Enabled = false;
            ckEstatus.Enabled = false;
        }

        protected void GVEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {

            Session["IdCombo"] = GVCombo.SelectedRow.Cells[0].Text;
            this.txtNumCombo.Text = GVCombo.SelectedRow.Cells[1].Text;
            this.txtDescripcion.Text = GVCombo.SelectedRow.Cells[2].Text;
            var dd = (GVCombo.SelectedRow.Cells[3]).Text;
            this.ckEstatus.Checked = Convert.ToBoolean(dd);
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            txtNumCombo.Enabled = false;
            txtDescripcion.Enabled = false;
            btnGuardar.Text = "Actualizar";
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtNumCombo.Enabled = true;
            txtDescripcion.Enabled = true;
            ckEstatus.Enabled = true;
            btnGuardar.Text = "Guardar";
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text.Contains("Guardar"))
            {
                WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
                Combos ocom = new Combos();
                ocom.Combo = txtNumCombo.Text.ToUpper();
                ocom.DescripcionCombo = txtDescripcion.Text.ToUpper(); ;
                ocom.Activo = ckEstatus.Checked;
                string ResponseJson = JsonConvert.SerializeObject(ocom);
                var c = client.NewCombo(ResponseJson);
                if (c == -1)
                {
                    Notificacion.VerMensaje("El combo ya se encuentra registrado.", 2);
                }
                else
                {
                    Notificacion.VerMensaje("Combo registrado correctamente.", 1);
                }
                fillgrilla();
                Inicio();
            }
            else if (btnGuardar.Text.Contains("Actualizar"))
            {
                WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
                Combos oCom = new Combos();
                oCom.id = (string)(Session["IdCombo"]);
                oCom.Combo = txtNumCombo.Text;
                oCom.DescripcionCombo = txtDescripcion.Text.ToUpper();
                oCom.Activo = ckEstatus.Checked;

                string ResponseJson = JsonConvert.SerializeObject(oCom);
                var c = client.Updatecombo(ResponseJson);

                if (c == 0)
                {
                    Notificacion.VerMensaje("Combo no se actualizó.", 2);
                }
                else
                {
                    Notificacion.VerMensaje("Combo actualizado correctamente.", 1);
                }
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Determinante   Actualizad');", true);
                fillgrilla();
                Inicio();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtNumCombo.Enabled = true;
            txtDescripcion.Enabled = true;
            ckEstatus.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            fillgrilla();
            Inicio();
        }
        public void Inicio()
        {
            txtNumCombo.Enabled = false;
            txtDescripcion.Enabled = false;
            ckEstatus.Enabled = false;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnNuevo.Text = "Nuevo";
            btnEditar.Enabled = false;
            btnGuardar.Text = "Guardar";
            this.txtDescripcion.Text = "";
            this.txtNumCombo.Text = "";
            this.ckEstatus.Checked = false;
        }
        protected void BtnBusqueda_Click(object sender, EventArgs e)
        {
            fillgrilla();
        }

        protected void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBNoCombo.Text = string.Empty;
            TxtBCombo.Text = string.Empty;
            fillgrilla();
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string Numcombo = txtNumCombo.Text;
            string descr = txtDescripcion.Text;
            if (Numcombo == "" || descr == "")
            {
                Notificacion.VerMensaje("Capture todos los campos.", 2);
                return;
            }
            ModalMsj.Show();
        }
        protected void BtnCloseM_Click(object sender, EventArgs e)
        {
            ModalMsj.Hide();
        }
    }
}