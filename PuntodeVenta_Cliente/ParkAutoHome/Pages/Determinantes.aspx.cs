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
               



                try
                {
                   
                }
                catch (Exception ex)
                {
                }
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
            this.ddlEstamto.Text  = GvDeterminantes.SelectedRow.Cells[4].Text;
            this.txtDeterminante.Text = GvDeterminantes.SelectedRow.Cells[6].Text;
            var dd = (GvDeterminantes.SelectedRow.Cells[7]).Text;
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
            string prov = txtProveedor.Text;
            string dete = txtDeterminante.Text;


            if (prov == "" || dete == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Capture todos los campos');", true);

            }
            else
            {


                if (btnGuardar.Text.Contains("Guardar"))
                {


                    WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();






                    Proveedor oPro = new Proveedor();




                    oPro.Codigo_Proveedor = txtProveedor.Text;
                    oPro.CveEmpresa = ddlEmpresa.SelectedValue;
                    oPro.Determinante = txtDeterminante.Text;
                    oPro.CveEstamto = ddlEstamto.SelectedValue;
                    oPro.Activo = ckEstatus.Checked;


                    string ResponseJson = JsonConvert.SerializeObject(oPro);


                    var c = client.NewProveedor(ResponseJson);

                    if (c== -1)
                    {

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('¨La Determinante  ya existe');", true);
                    }

                    else

                    {

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Determinante   Registrada');", true);
                    }

                   


                    fillgrilla();
                    Inicio();
                }

                else if (btnGuardar.Text.Contains("Actualizar"))
                {


                    WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();


                    Proveedor oPro = new Proveedor();

                    oPro.id = (string)(Session["id"]);

                    oPro.Codigo_Proveedor = txtProveedor.Text;
                    oPro.CveEmpresa = ddlEmpresa.SelectedValue;
                    oPro.Determinante = txtDeterminante.Text;
                    oPro.CveEstamto = ddlEstamto.SelectedValue;

                    oPro.Activo = ckEstatus.Checked;

                    string ResponseJson = JsonConvert.SerializeObject(oPro);


                    var c = client.UpdateProveedor(ResponseJson);

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Determinante   Actualizad');", true);


                    fillgrilla();
                    Inicio();
                }
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

            GvDeterminantes.DataSource = client.DeterminantesActivas();
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
            //   this.txtid.Text = "";

            this.txtDeterminante.Text = "";
         
            this.txtProveedor.Text = "";

            this.ckEstatus.Checked = false;






        }
        public void CargarEmpresaCombo()
        {
          

            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();


            this.ddlEmpresa.DataSource = client.CatalogEmpresa();
            this.ddlEmpresa.DataTextField = "NombreEmpresa";
            this.ddlEmpresa.DataValueField = "idEmpresa";

                
            this.ddlEmpresa.DataBind();



        }

        public void CargarEstamtosCombo()
        {


            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();


            this.ddlEstamto.DataSource = client.CatalogEstamtos();
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
    }
}