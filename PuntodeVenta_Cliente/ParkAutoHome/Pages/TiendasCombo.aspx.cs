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
                //Inicio();
                CargarEstamosActivas();
                ddlCombo_TextChanged(sender, e);
            }


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

        }

        public void CargarEstamosActivas()
        {
          

            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            WsPA.Combos ent = new WsPA.Combos();
            ent.Combo = "";
            ent.DescripcionCombo = "";
            this.ddlCombo.DataSource = client.CatalogoCombos(ent);
            this.ddlCombo.DataTextField = "DescripcionCombo";
            this.ddlCombo.DataValueField = "Combo";

            this.ddlCombo.DataBind();



        }

        protected void ddlCombo_TextChanged(object sender, EventArgs e)
        {
            string dete = ddlCombo.SelectedValue;

            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();

            GvTiendasCombo.DataSource = client.CatalogoCombosdeterminantes(dete);
            GvTiendasCombo.DataBind();

        }
    }
}