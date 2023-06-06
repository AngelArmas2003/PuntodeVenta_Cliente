using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParkAutoHome.Pages
{
    public partial class TarifaExcedente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEstamosActivas();
                TarifasConsulta();
                Inicio();
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            TxtMinutos.Enabled = true;
            txtImporte.Enabled = true;
            TxtDeterminante.Text = ddlEmpresas.SelectedValue.ToString();
            btnGuardar.Text = "Guardar";
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            TarifasConsulta();
            #region Obtenter clave

            WsPA.Tarifas tarifa = new WsPA.Tarifas();
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            string clave = "";
            tarifa.Determinante = TxtDeterminante.Text;
            tarifa.Opcion = 2;
            clave = client.TarifaCveConsulta(tarifa);
            txtCveTarifa.Text = Convert.ToInt32(clave).ToString("D2");

            #endregion
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {                
                WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
                WsPA.Tarifas tarifa = new WsPA.Tarifas();
                tarifa.CveTarifa = txtCveTarifa.Text;
                tarifa.Minutos = Convert.ToInt32(TxtMinutos.Text);
                tarifa.ImporteMinutos = Convert.ToInt32(txtImporte.Text);
                tarifa.MinutoInicial = Convert.ToInt32(TxtMinI.Text);
                tarifa.MinutoFinal = Convert.ToInt32(TxtMinF.Text);
                tarifa.TotalAcumulado = Convert.ToDouble(TxtTotalA.Text);
                tarifa.Determinante = TxtDeterminante.Text;

                if (btnGuardar.Text.Contains("Guardar"))
                {
                    tarifa.Opcion = 3;
                    tarifa.id = "0";

                    string ResponseJson = JsonConvert.SerializeObject(tarifa);
                    var g = client.TarifaDetExceReg_Act(ResponseJson);
                    if (g <= 0)
                    {
                        Notificacion.VerMensaje("Error al realizar el  registro.", 3);
                    }
                    else
                    {
                        Notificacion.VerMensaje("Tarifa excedente registrada correctamente.", 1);
                        TarifasConsulta();
                        Inicio();
                        
                    }
                }
                else if (btnGuardar.Text.Contains("Actualizar"))
                {
                    tarifa.Opcion = 4;
                    tarifa.id = Session["Id"].ToString();
                    string ResponseJson = JsonConvert.SerializeObject(tarifa);
                    var a = client.TarifaDetExceReg_Act(ResponseJson);
                    if (a <= 0)
                    {
                        Notificacion.VerMensaje("Error al realizar el  registro.", 3);
                    }
                    else
                    {
                        Notificacion.VerMensaje("Tarifa excedente actualizada correctamente.", 1);                        
                        TarifasConsulta();
                        Inicio();
                    }
                }

            }
            catch (Exception ex)
            {
                Notificacion.VerMensaje(ex.ToString(), 3);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TxtMinutos.Enabled = true;
            txtImporte.Enabled = true;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Inicio();
            TarifasConsulta();
            if (GvTarifas.Rows.Count > 0)
                btnNuevo.Enabled = false;
            else
                btnNuevo.Enabled = true;
        }

        protected void ddlEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlEmpresas_TextChanged(object sender, EventArgs e)
        {
            TarifasConsulta();
            Inicio();
        }

        public void Inicio()
        {
            txtCveTarifa.Enabled = false;
            TxtMinutos.Enabled = false;
            TxtMinI.Enabled = false;
            TxtMinF.Enabled = false;
            TxtTotalA.Enabled = false;
            txtImporte.Enabled = false;
            TxtDeterminante.Enabled = false;

            txtCveTarifa.Text = string.Empty;
            TxtMinutos.Text = string.Empty;
            TxtMinI.Text = string.Empty;
            TxtMinF.Text = string.Empty;
            TxtTotalA.Text = string.Empty;
            txtImporte.Text = string.Empty;
            TxtDeterminante.Text = string.Empty;
            if (GvTarifas.Rows.Count > 0)
                btnNuevo.Enabled = false;
            else
                btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnNuevo.Text = "Nuevo";
            btnEditar.Enabled = false;
            btnGuardar.Text = "Guardar";
        }

        public void TarifasConsulta()
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            WsPA.Tarifas entT = new WsPA.Tarifas();
            entT.Determinante = ddlEmpresas.SelectedValue;
            entT.Opcion = 2;
            GvTarifas.DataSource = client.TafiasDeterminantes(entT);
            GvTarifas.DataBind();
        }

        protected void GvTarifas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnGuardar.Text = "Actualizar";
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = true;
            txtCveTarifa.Enabled = false;
            TxtMinutos.Enabled = false;
            TxtMinI.Enabled = false;
            TxtMinF.Enabled = false;
            TxtTotalA.Enabled = false;
            txtImporte.Enabled = false;
            TxtDeterminante.Enabled = false;
            Session["Id"] = GvTarifas.SelectedRow.Cells[0].Text;
            txtCveTarifa.Text = GvTarifas.SelectedRow.Cells[1].Text;
            TxtMinutos.Text = GvTarifas.SelectedRow.Cells[2].Text;
            TxtMinI.Text = GvTarifas.SelectedRow.Cells[4].Text;
            TxtMinF.Text = GvTarifas.SelectedRow.Cells[5].Text;
            TxtTotalA.Text = GvTarifas.SelectedRow.Cells[6].Text;
            txtImporte.Text = GvTarifas.SelectedRow.Cells[3].Text;
            TxtDeterminante.Text = GvTarifas.SelectedRow.Cells[7].Text;
        }

        protected void BtnAsigna_Click(object sender, EventArgs e)
        {
            TxtMinI.Text = "0";
            TxtMinF.Text = TxtMinutos.Text;
            TxtTotalA.Text = txtImporte.Text;
            btnGuardar.Enabled = true;
            TxtMinutos.Enabled = false;
            txtImporte.Enabled = false;
            txtCveTarifa.Enabled = false;
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCveTarifa.Text == "" || TxtMinutos.Text == "" || txtImporte.Text == "" || TxtMinI.Text == "" || TxtMinF.Text == "" || TxtTotalA.Text == "")
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