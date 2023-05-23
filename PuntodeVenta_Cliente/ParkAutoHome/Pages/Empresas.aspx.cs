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
    public partial class Empresas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                fillgrilla();
                Inicio();
              


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

        protected void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GVEmpresas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GVEmpresas.EditIndex = -1;
            GVEmpresas.PageIndex = e.NewPageIndex;
            fillgrilla();
        }

        protected void GVEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {

            Session["Idempresa"] = GVEmpresas.SelectedRow.Cells[0].Text;

            this.txtnomEmpresa.Text = GVEmpresas.SelectedRow.Cells[1].Text;
            this.txtrfc.Text = GVEmpresas.SelectedRow.Cells[2].Text;


           

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
        

            txtnomEmpresa.Enabled = false;
            txtrfc.Enabled = false;


            btnGuardar.Text = "Actualizar";
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtnomEmpresa.Enabled = true;

            txtrfc.Enabled = true;

            btnGuardar.Text = "Guardar";
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {

            if (txtnomEmpresa.Text == "" || txtrfc.Text =="")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Capture todos los campos ');", true);

            }
            else
            {



                if (btnGuardar.Text.Contains("Guardar"))
                {



                    Tools ot = new Tools();
                    var resp = ot.rfc_Validacion(txtrfc.Text);
                    if (!resp)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Rfc Invalido  ');", true);

                    }
                    else
                    {
                        WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();


                        var ValRfc = client.ValidaEmpresa(txtrfc.Text);

                        if (ValRfc >= 1)

                        {

                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El Rfc ya esta registrado  ');", true);


                        }
                        else
                        {


                            Empresa oemp = new Empresa();


                            oemp.NombreEmpresa = txtnomEmpresa.Text.ToUpper();
                            oemp.Rfc = txtrfc.Text;

                            string ResponseJson = JsonConvert.SerializeObject(oemp);


                            var c = client.NewEmpresa(ResponseJson);

                            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Empresa  Registrada');", true);


                            fillgrilla();
                            Inicio();
                        }

                    }
                }

            if (btnGuardar.Text.Contains("Actualizar"))
            {
                Tools ot = new Tools();
                var resp = ot.rfc_Validacion(txtrfc.Text);

                if (!resp)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Rfc Invalido ');", true);

                }
                else
                { 

                WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();


                Empresa oemp = new Empresa();

                oemp.idEmpresa = (string)(Session["Idempresa"]);

                    oemp.NombreEmpresa = txtnomEmpresa.Text.ToUpper(); 
                    oemp.Rfc = txtrfc.Text.ToUpper(); ;

                string ResponseJson = JsonConvert.SerializeObject(oemp);


                var c = client.UpdaterEmpresa(ResponseJson);

                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Empresa  Actualizado');", true);
                Session["Idempresa"] = "";
                
                fillgrilla();
                Inicio();
                }
            }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtnomEmpresa.Enabled = true;

            txtrfc.Enabled = true;

            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;

            btnEditar.Enabled = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Inicio();
          
            fillgrilla();
        }

        private void fillgrilla()
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();

            GVEmpresas.DataSource = client.CatalogEmpresa();
            GVEmpresas.DataBind();

            txtnomEmpresa.Enabled = false;
            txtrfc.Enabled = false;

        }

        public void Inicio()
        {
            txtnomEmpresa.Enabled = false;

            txtrfc.Enabled = false;

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnNuevo.Text = "Nuevo";
            btnEditar.Enabled = false;
            btnGuardar.Text = "Guardar";
            //   this.txtid.Text = "";

            this.txtnomEmpresa.Text = "";
            this.txtrfc.Text = "";






        }

    }
}