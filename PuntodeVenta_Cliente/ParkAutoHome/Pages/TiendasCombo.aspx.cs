using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkAutoHome.Pages
{
    public partial class TiendasCombo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Inicio();
                CargarEstamosActivas();
            }
        }

        protected void GvTarifas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void GvTarifas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnGuardar.Text = "Actualizar";
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
            DeterminantesConsulta();
            ddlDeterminante.Enabled = true;
            ddlDeterminante.SelectedValue = GvTiendasCombo.SelectedRow.Cells[2].Text;
            ddlDeterminante.Enabled = false;
            var estatus = (GvTiendasCombo.SelectedRow.Cells[4]).Text;
            ChkEstatus.Checked = Convert.ToBoolean(estatus);
            Session["Id"] = GvTiendasCombo.SelectedRow.Cells[0].Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ChkEstatus.Enabled = true;
            ddlDeterminante.Enabled = true;
            btnGuardar.Text = "Guardar";
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            DeterminantesConsulta();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            WsPA.ComboDeterminantes ent = new WsPA.ComboDeterminantes();
            ent.NumeroCombo = "";
            ent.Determinante = ddlDeterminante.SelectedValue;
            WsPA.ComboDeterminantes[] lst =  client.CatalogoCombosdeterminantes(ent);
            List<WsPA.ComboDeterminantes> lstC = new List<WsPA.ComboDeterminantes>(lst);
            
            if (lstC.Where(x => x.NumeroCombo != DdlCombo.SelectedValue).Count() > 0 )
            {
                foreach (var item in lstC.Where(x => x.NumeroCombo != DdlCombo.SelectedValue))
                {
                    Notificacion.VerMensaje("La determinante " + item.NombrePlaza + " ya se encuentra registrada en el número de combo " + item.NumeroCombo + ".", 2);
                    break;
                }
            }
            else
            {
                if (btnGuardar.Text.Contains("Guardar"))
                {
                    client = new WsPA.WSPanelControlSoapClient();
                    ent = new WsPA.ComboDeterminantes();
                    ent.Opcion = 1;
                    ent.id = "0";
                    ent.NumeroCombo = DdlCombo.SelectedValue;
                    ent.Determinante = ddlDeterminante.SelectedValue;
                    ent.Activo = ChkEstatus.Checked;
                    string ResponseJson = JsonConvert.SerializeObject(ent);
                    var c = client.ComboDeterminanteReg_Act(ResponseJson);
                    if (c <= 0)
                    {
                        Notificacion.VerMensaje("Error al realizar el  registro.", 3);
                    }
                    else
                    {
                        Notificacion.VerMensaje("Tienda registrada correctamente.", 1);
                        Inicio();
                        ComboConsulta();
                    }                    
                }
                else if (btnGuardar.Text.Contains("Actualizar"))
                {
                    client = new WsPA.WSPanelControlSoapClient();
                    ent = new WsPA.ComboDeterminantes();
                    ent.Opcion = 2;
                    ent.id = Session["Id"].ToString();
                    ent.NumeroCombo = DdlCombo.SelectedValue;
                    ent.Determinante = ddlDeterminante.SelectedValue;
                    ent.Activo = ChkEstatus.Checked;

                    string ResponseJson = JsonConvert.SerializeObject(ent);
                    var c = client.ComboDeterminanteReg_Act(ResponseJson);
                    if (c <= 0)
                    {
                        Notificacion.VerMensaje("Combo no se actualizó.", 3);
                    }
                    else
                    {
                        Notificacion.VerMensaje("Combo actualizado correctamente.", 1);
                        Inicio();
                        ComboConsulta();
                    }
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ddlDeterminante.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            ChkEstatus.Enabled = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Inicio();
            ComboConsulta();
        }

        public void CargarEstamosActivas()
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            WsPA.Combos ent = new WsPA.Combos();
            ent.Combo = "";
            ent.DescripcionCombo = "";
            this.DdlCombo.DataSource = client.CatalogoCombos(ent);
            this.DdlCombo.DataTextField = "DescripcionCombo";
            this.DdlCombo.DataValueField = "Combo";
            this.DdlCombo.DataBind();
        }

        public void DeterminantesConsulta()
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            WsPA.Determinantes entDet = new WsPA.Determinantes();
            entDet.CveEmpresa = "";
            entDet.Nombre_Empresa = "";
            entDet.CveEstamto = "";
            entDet.Estacionamiento = "";
            ddlDeterminante.DataSource = client.DeterminantesActivas(entDet);
            ddlDeterminante.DataTextField = "Estacionamiento";
            ddlDeterminante.DataValueField = "Determinante";
            ddlDeterminante.DataBind();
        }
        public void Inicio()
        {
            ddlDeterminante.Enabled = false;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnNuevo.Text = "Nuevo";
            btnEditar.Enabled = false;
            btnGuardar.Text = "Guardar";
            ChkEstatus.Checked = false;
            ChkEstatus.Enabled = false;
        }

        public void ComboConsulta()
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            WsPA.ComboDeterminantes ent = new WsPA.ComboDeterminantes();
            ent.NumeroCombo= DdlCombo.SelectedValue;
            ent.Determinante= "";
            GvTiendasCombo.DataSource = null;
            GvTiendasCombo.DataSource = client.CatalogoCombosdeterminantes(ent);
            GvTiendasCombo.DataBind();
            List<string> lst = new List<string>();
            ddlDeterminante.DataSource = lst.ToList();
            ddlDeterminante.DataBind();
        }      

        protected void DdlCombo_TextChanged(object sender, EventArgs e)
        {
            ComboConsulta();
        }
    }
}