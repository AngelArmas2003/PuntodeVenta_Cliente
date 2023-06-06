using ClassLibrary.Entities;
using ClassLibrary.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkAutoHome.Pages
{
    public partial class Determinantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEstamtosCombo();
                CargarEmpresaCombo();
                fillgrilla();
                Inicio();
            }
        }

        protected void GvDeterminantes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GvDeterminantes.EditIndex = -1;
            GvDeterminantes.PageIndex = e.NewPageIndex;
            fillgrilla();
        }

        protected void GvDeterminantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["id"] = GvDeterminantes.SelectedRow.Cells[0].Text;

            this.txtProveedor.Text = GvDeterminantes.SelectedRow.Cells[1].Text;
            this.ddlEmpresa.Text = GvDeterminantes.SelectedRow.Cells[2].Text;
            this.ddlEstamto.Text = GvDeterminantes.SelectedRow.Cells[4].Text;
            this.txtDeterminante.Text = GvDeterminantes.SelectedRow.Cells[6].Text;
            var dd = (GvDeterminantes.SelectedRow.Cells[7]).Text;
            ViewState["DeterminanteAnt"] = GvDeterminantes.SelectedRow.Cells[6].Text;
            this.ckEstatus.Checked = Convert.ToBoolean(dd);
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            txtProveedor.Enabled = false;
            ddlEmpresa.Enabled = false;
            txtDeterminante.Enabled = false;
            ddlEstamto.Enabled = false;
            ckEstatus.Enabled = false;
            btnGuardar.Text = "Actualizar";
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtProveedor.Enabled = true;
            ddlEmpresa.Enabled = true;
            txtDeterminante.Enabled = true;
            ddlEstamto.Enabled = true;
            ckEstatus.Enabled = true;
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
                WsPA.Determinantes entDet = new WsPA.Determinantes();
                client = new WsPA.WSPanelControlSoapClient();
                Proveedor oPro = new Proveedor();
                oPro.Codigo_Proveedor = txtProveedor.Text;
                oPro.CveEmpresa = ddlEmpresa.SelectedValue;
                oPro.Determinante = txtDeterminante.Text;
                oPro.CveEstamto = ddlEstamto.SelectedValue;
                oPro.Activo = ckEstatus.Checked;
                string ResponseJson = JsonConvert.SerializeObject(oPro);
                var c = client.NewProveedor(ResponseJson);
                Notificacion.VerMensaje("Determinante registrada.", 1);
            }
            else if (btnGuardar.Text.Contains("Actualizar"))
            {
                client = new WsPA.WSPanelControlSoapClient();
                Proveedor oPro = new Proveedor();
                oPro.id = (string)(Session["id"]);
                oPro.Codigo_Proveedor = txtProveedor.Text;
                oPro.CveEmpresa = ddlEmpresa.SelectedValue;
                oPro.Determinante = txtDeterminante.Text;
                oPro.CveEstamto = ddlEstamto.SelectedValue;
                oPro.Activo = ckEstatus.Checked;
                string ResponseJson = JsonConvert.SerializeObject(oPro);
                var c = client.UpdateProveedor(ResponseJson);
                Notificacion.VerMensaje("Determinante actualizada.", 1);
                fillgrilla();
                Inicio();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            txtProveedor.Enabled = true;
            ddlEmpresa.Enabled = true;
            txtDeterminante.Enabled = true;
            ckEstatus.Enabled = true;
            ddlEstamto.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }
        private void fillgrilla()
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            WsPA.Determinantes entDet = new WsPA.Determinantes();
            entDet.CveEmpresa = "";
            entDet.Nombre_Empresa = TxtBEmpresa.Text;
            entDet.CveEstamto = "";
            entDet.Estacionamiento = TxtBEstacionamiento.Text;
            GvDeterminantes.DataSource = client.DeterminantesActivas(entDet);
            GvDeterminantes.DataBind();
            GridViewRow row = GvDeterminantes.SelectedRow;
            txtDeterminante.Enabled = false;
            ddlEmpresa.Enabled = false;
            txtProveedor.Enabled = false;
        }

        public void Inicio()
        {
            txtDeterminante.Enabled = false;
            ddlEmpresa.Enabled = false;
            txtProveedor.Enabled = false;
            ckEstatus.Enabled = false;
            ddlEstamto.Enabled = false;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnNuevo.Text = "Nuevo";
            btnEditar.Enabled = false;
            btnGuardar.Text = "Guardar";
            this.txtDeterminante.Text = "";
            this.txtProveedor.Text = "";
            this.ckEstatus.Checked = false;
        }
        public void CargarEmpresaCombo()
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            WsPA.Empresas entEmp = new WsPA.Empresas();
            entEmp.NombreEmpresa = "";
            entEmp.Rfc = "";
            this.ddlEmpresa.DataSource = client.CatalogEmpresa(entEmp);
            this.ddlEmpresa.DataTextField = "NombreEmpresa";
            this.ddlEmpresa.DataValueField = "idEmpresa";
            this.ddlEmpresa.DataBind();
        }

        public void CargarEstamtosCombo()
        {

            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            WsPA.Estamtos ent = new WsPA.Estamtos();
            ent.NombreEstamto = "";
            ent.NombreEmpresa = "";
            this.ddlEstamto.DataSource = client.CatalogEstamtos(ent);
            this.ddlEstamto.DataTextField = "NombreEstamto";
            this.ddlEstamto.DataValueField = "CveEstamto";
            this.ddlEstamto.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            CargarEstamtosCombo();
            CargarEmpresaCombo();
            fillgrilla();
            Inicio();
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
            string prov = txtProveedor.Text;
            string dete = txtDeterminante.Text;
            if (prov == "" || dete == "")
            {
                Notificacion.VerMensaje("Capture todos los campos.", 2);
            }
            else
            {
                WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
                WsPA.Determinantes entDet = new WsPA.Determinantes();
                if (btnGuardar.Text.Contains("Guardar"))
                {
                    entDet = new WsPA.Determinantes();
                    entDet.CveEmpresa = "";
                    entDet.Nombre_Empresa = "";
                    entDet.CveEstamto = ddlEstamto.SelectedValue;
                    entDet.Estacionamiento = "";
                    WsPA.Determinantes[] entLDet = client.DeterminantesActivas(entDet);
                    if (entLDet.Count() > 0)
                    {
                        if (entLDet[0].CveEmpresa != "" && entLDet[0].CveEstamto != "")
                        {
                            Notificacion.VerMensaje("El estacionamiento " + entLDet[0].Estacionamiento + " ya se encuentra registrado en la empresa " + entLDet[0].Nombre_Empresa + ".", 2);
                            return;
                        }
                    }
                    entDet = new WsPA.Determinantes();
                    entDet.CveEmpresa = "";
                    entDet.Nombre_Empresa = "";
                    entDet.CveEstamto = "";
                    entDet.Estacionamiento = "";
                    entDet.Determinante = txtDeterminante.Text;
                    entLDet = client.DeterminantesActivas(entDet);
                    if (entLDet.Count() > 0)
                    {
                        if (entLDet[0].CveEmpresa != "" && entLDet[0].CveEstamto != "")
                        {
                            Notificacion.VerMensaje("La determinante " + entLDet[0].Determinante + " ya se encuentra registrado en el estacionamiento " + entLDet[0].Estacionamiento + " con la empresa " + entLDet[0].Nombre_Empresa + ".", 2);
                            return;
                        }
                    }
                    ModalMsj.Show();
                }
                else if (btnGuardar.Text.Contains("Actualizar"))
                {
                    WsPA.Determinantes[] entLDet;
                    if (txtDeterminante.Text != ViewState["DeterminanteAnt"].ToString())
                    {
                        entDet = new WsPA.Determinantes();
                        entDet.CveEmpresa = "";
                        entDet.Nombre_Empresa = "";
                        entDet.CveEstamto = "";
                        entDet.Estacionamiento = "";
                        entDet.Determinante = txtDeterminante.Text;
                        entLDet = client.DeterminantesActivas(entDet);
                        if (entLDet.Count() > 0)
                        {
                            if (entLDet[0].CveEmpresa != "" && entLDet[0].CveEstamto != "")
                            {
                                Notificacion.VerMensaje("La determinante " + entLDet[0].Determinante + " ya se encuentra registrado en el estacionamiento " + entLDet[0].Estacionamiento + " con la empresa " + entLDet[0].Nombre_Empresa + ".", 2);
                                return;
                            }
                        }
                    }
                    entDet = new WsPA.Determinantes();
                    entDet.CveEmpresa = "";
                    entDet.Nombre_Empresa = "";
                    entDet.CveEstamto = ddlEstamto.SelectedValue;
                    entDet.Estacionamiento = "";
                    entLDet = client.DeterminantesActivas(entDet);
                    if (entLDet.Count() > 0)
                    {
                        if (entLDet[0].CveEmpresa != "" && entLDet[0].CveEstamto != "")
                        {
                            Notificacion.VerMensaje("El estacionamiento " + entLDet[0].Estacionamiento + " ya se encuentra registrado en la empresa " + entLDet[0].Nombre_Empresa + ".", 2);
                            return;
                        }
                    }
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