using ClassLibrary.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkAutoHome.Pages
{
    public partial class Estacionamientos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillgrilla();
                Inicio();
                CargarEmpresaCombo();
            }
        }

        protected void GVEstamots_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ddlEmpresa.Text = GVEstamots.SelectedRow.Cells[0].Text;
            Session["CveEstamto"] = GVEstamots.SelectedRow.Cells[1].Text;
            this.txtEstamto.Text = GVEstamots.SelectedRow.Cells[2].Text.Replace("&#160;&#160;", " ").Replace("&#160;", "");
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            ddlEmpresa.Enabled = false;
            txtEstamto.Enabled = false;
            btnGuardar.Text = "Actualizar";
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
        }
        protected void GVEstamots_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GVEstamots.EditIndex = -1;
            GVEstamots.PageIndex = e.NewPageIndex;
            fillgrilla();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            ddlEmpresa.Enabled = true;
            txtEstamto.Enabled = true;
            btnGuardar.Text = "Guardar";
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            if (btnGuardar.Text.Contains("Guardar"))
            {
                client = new WsPA.WSPanelControlSoapClient();
                Estamtos oesta = new Estamtos();
                oesta.CveEmpresa = ddlEmpresa.SelectedValue;
                oesta.NombreEstamto = txtEstamto.Text.ToUpper();
                string ResponseJson = JsonConvert.SerializeObject(oesta);
                var c = client.NewEstamto(ResponseJson);
                Notificacion.VerMensaje("Estacionamiento registrado.", 1);
                CargarEmpresaCombo();
                fillgrilla();
                Inicio();
            }
            if (btnGuardar.Text.Contains("Actualizar"))
            {
                client = new WsPA.WSPanelControlSoapClient();
                Estamtos oesta = new Estamtos();
                oesta.CveEstamto = (string)(Session["CveEstamto"]);
                oesta.NombreEstamto = txtEstamto.Text.ToUpper();
                string ResponseJson = JsonConvert.SerializeObject(oesta);
                var c = client.UpdateEstamto(ResponseJson);
                Notificacion.VerMensaje("Estacionamiento actualizado.", 1);
                Session["CveEstamto"] = "";
                CargarEmpresaCombo();
                fillgrilla();
                Inicio();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            ddlEmpresa.Enabled = false;
            txtEstamto.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Inicio();
            CargarEmpresaCombo();
            fillgrilla();
        }

        public void Inicio()
        {
            ddlEmpresa.Enabled = false;
            txtEstamto.Enabled = false;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnNuevo.Text = "Nuevo";
            btnEditar.Enabled = false;
            btnGuardar.Text = "Guardar";
            this.txtEstamto.Text = "";
        }
        private void fillgrilla()
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            WsPA.Estamtos ent = new WsPA.Estamtos();
            ent.NombreEstamto = TxtBEstacionamiento.Text;
            ent.NombreEmpresa = TxtBEmpresa.Text;
            GVEstamots.DataSource = client.CatalogEstamtos(ent);
            GVEstamots.DataBind();
            ddlEmpresa.SelectedValue = "01";
            txtEstamto.Enabled = false;
        }
        public void CargarEmpresaCombo()
        {
            List<Empresas> oEmpresa = new List<Empresas>();
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            WsPA.Empresas entEmp = new WsPA.Empresas();
            entEmp.NombreEmpresa = "";
            entEmp.Rfc = "";
            this.ddlEmpresa.DataSource = client.CatalogEmpresa(entEmp);
            this.ddlEmpresa.DataTextField = "NombreEmpresa";
            this.ddlEmpresa.DataValueField = "idEmpresa";
            this.ddlEmpresa.DataBind();
        }
        protected void BtnBusqueda_Click(object sender, EventArgs e)
        {
            fillgrilla();
        }
        protected void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBEmpresa.Text = string.Empty;
            TxtBEstacionamiento.Text = string.Empty;
            fillgrilla();
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            if (txtEstamto.Text == "")
            {
                Notificacion.VerMensaje("Captute el nombre del estacionamiento.", 2);
            }
            else
            {
                if (btnGuardar.Text.Contains("Guardar"))
                {
                    WsPA.Estamtos ent = new WsPA.Estamtos();
                    ent.NombreEstamto = txtEstamto.Text;
                    ent.NombreEmpresa = "";
                    WsPA.Estamtos[] entL = client.CatalogEstamtos(ent);
                    if(entL.Length > 0 )
                    {
                        if (entL[0].NombreEstamto == txtEstamto.Text)
                        {
                            Notificacion.VerMensaje("El estacionamiento ya se encuentra registrado.", 2);
                            return;
                        }
                    }
                    
                    ModalMsj.Show();
                }

                if (btnGuardar.Text.Contains("Actualizar"))
                {
                    ModalMsj.Show();
                }
            }
        }
        protected void BtnCloseM_Click(object sender, EventArgs e)
        {
            ModalMsj.Hide();
        }
    }
}