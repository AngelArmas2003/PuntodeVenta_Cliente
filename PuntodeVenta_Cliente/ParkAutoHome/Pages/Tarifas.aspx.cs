using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkAutoHome.Pages
{
    public partial class Tarifas : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                //fillgrilla();
                //Inicio();
               
                CargarEstamosActivas();
                ddlEmpresas_TextChanged(sender, e);

                try
                {
                
                }
                catch (Exception ex)
                {
               
                }
            }
        }

        public void CargarEstamosActivas()
        {
            List<Empresas> oEmpresa = new List<Empresas>();

            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();



            this.ddlEmpresas.DataSource = client.EstamtosActivos();
            this.ddlEmpresas.DataTextField = "NombreEstamto";
            this.ddlEmpresas.DataValueField = "CveEstamto";

            this.ddlEmpresas.DataBind();



        }


        private void fillgrilla()
        {
           
        }
        protected void GvTarifas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void GvTarifas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            CargarEstamosActivas();
            ddlEmpresas_TextChanged(sender, e);
        }

        protected void ddlEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {



        }


        

        protected void ddlEmpresas_TextChanged(object sender, EventArgs e)
        {
            string dete = ddlEmpresas.SelectedValue;

            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();

            GvTarifas.DataSource = client.TafiasDeterminantes(dete);
            GvTarifas.DataBind();

        }
    }
}