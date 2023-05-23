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
               

                try
                {
                    //this.txtid.Text = row.Cells[0].Text;
                    //this.txtnombre.Text = row.Cells[1].Text;
                    //this.txtusuario.Text = row.Cells[2].Text;
                    //this.txtcontraseña.Text = row.Cells[3].Text;
                    //this.ckEstatus.Text = row.Cells[4].Text;
                    //this.txtFecha.Text = row.Cells[5].Text;
                }
                catch (Exception ex)
                {
                }
            }

        }

        protected void GVEstamots_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            this.ddlEmpresa.Text = GVEstamots.SelectedRow.Cells[0].Text;
            Session["CveEstamto"] = GVEstamots.SelectedRow.Cells[1].Text;
            this.txtEstamto.Text = GVEstamots.SelectedRow.Cells[2].Text.Replace("&#160;&#160;"," ").Replace("&#160;","");
           
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

            if (txtEstamto.Text == "")
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Captute el Nombre del estacionamiento');", true);
            }
            else
            {

                if (btnGuardar.Text.Contains("Guardar"))
                {




                    WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();





                    Estamtos oesta = new Estamtos();

                    oesta.CveEmpresa = ddlEmpresa.SelectedValue;
                    oesta.NombreEstamto = txtEstamto.Text.ToUpper();

                    string ResponseJson = JsonConvert.SerializeObject(oesta);


                    var c = client.NewEstamto(ResponseJson);

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Estacionamiento  Registrado');", true);

                    CargarEmpresaCombo();
                    fillgrilla();
                    Inicio();

                }

                if (btnGuardar.Text.Contains("Actualizar"))
                {
                    WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();


                    Estamtos oesta = new Estamtos();

                    oesta.CveEstamto = (string)(Session["CveEstamto"]);


                    oesta.NombreEstamto = txtEstamto.Text.ToUpper();

                    string ResponseJson = JsonConvert.SerializeObject(oesta);


                    var c = client.UpdateEstamto(ResponseJson);

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Estacionamiento  Actualizado');", true);
                    Session["CveEstamto"] = "";
                    CargarEmpresaCombo();
                    fillgrilla();
                    Inicio();

                }
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
            //   this.txtid.Text = "";

            this.txtEstamto.Text = "";
       





        }
        private void fillgrilla()
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();

            GVEstamots.DataSource = client.CatalogEstamtos();
            GVEstamots.DataBind();

            //GridViewRow row = GVEstamots.SelectedRow;

            ddlEmpresa.SelectedValue = "01";
           
            txtEstamto.Enabled = false;
           
        }


        public void CargarEmpresaCombo()
        {
            List<Empresas> oEmpresa = new List<Empresas>();

        WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            
          

            this.ddlEmpresa.DataSource = client.CatalogEmpresa();
            this.ddlEmpresa.DataTextField = "NombreEmpresa";
            this.ddlEmpresa.DataValueField = "idEmpresa";
          
            this.ddlEmpresa.DataBind();



        }











}
}