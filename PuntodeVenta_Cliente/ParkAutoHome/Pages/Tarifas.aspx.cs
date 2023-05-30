﻿using Newtonsoft.Json;
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
            BtnAgregar.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            TarifasConsulta();

            #region Obtenter clave
            Button btn = (Button)sender;
            switch (btn.ID)
            {
                case "btnNuevo":
                    WsPA.Tarifas tarifa = new WsPA.Tarifas();
                    WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
                    string clave = "";
                    tarifa.Determinante = TxtDeterminante.Text;
                    tarifa.Opcion = 1;
                    clave = client.TarifaCveConsulta(tarifa);
                    txtCveTarifa.Text = Convert.ToInt32(clave).ToString("D2");
                    break;
                case "BtnAgregar":
                    txtCveTarifa.Text = Convert.ToInt32(GvTarifas.Rows[0].Cells[1].Text.ToString()).ToString("D2");
                    break;
            }

            #endregion

        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCveTarifa.Text == "" || TxtMinutos.Text == "" || txtImporte.Text == "" || TxtMinI.Text == "" || TxtMinF.Text == "" || TxtTotalA.Text == "")
                {
                    Notificacion.VerMensaje("Capture todos los campos.", 2);
                    return;
                }
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
                    tarifa.Opcion = 1;
                    tarifa.id = "0";

                    string ResponseJson = JsonConvert.SerializeObject(tarifa);
                    var g = client.TarifaDetExceReg_Act(ResponseJson);
                    if (g <= 0)
                    {
                        Notificacion.VerMensaje("Error al realizar el  registro.", 3);
                    }
                    else
                    {
                        Notificacion.VerMensaje("Tarifa determinante registrada correctamente.", 1);                        
                        TarifasConsulta();
                        Inicio();
                    }
                }
                else if (btnGuardar.Text.Contains("Actualizar"))
                {
                    tarifa.Opcion = 2;
                    tarifa.id = Session["Id"].ToString();
                    string ResponseJson = JsonConvert.SerializeObject(tarifa);
                    var a = client.TarifaDetExceReg_Act(ResponseJson);
                    if (a <= 0)
                    {
                        Notificacion.VerMensaje("Error al realizar el  registro.", 3);
                    }
                    else
                    {
                        Notificacion.VerMensaje("Tarifa determinante actualizada correctamente.", 1);                        
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
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Inicio();
            TarifasConsulta();
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

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            if (GvTarifas.Rows.Count > 0)
                BtnAgregar.Enabled = true;
            else
                BtnAgregar.Enabled = false;
            btnNuevo.Text = "Nuevo";
            btnEditar.Enabled = false;
            btnGuardar.Text = "Guardar";
        }

        public void TarifasConsulta()
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            WsPA.Tarifas entT = new WsPA.Tarifas();
            entT.Determinante= ddlEmpresas.SelectedValue;
            entT.Opcion = 1;
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
            BtnAgregar.Enabled = false;
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
            if(GvTarifas.Rows.Count > 0)
            {
                if(BtnAgregar.Text.Contains("Agregar"))
                {
                    int minFAnt = 0;
                    double totAcuAnt = 0;
                    minFAnt = Convert.ToInt32(GvTarifas.Rows[GvTarifas.Rows.Count - 1].Cells[5].Text.ToString());
                    totAcuAnt = Convert.ToDouble(GvTarifas.Rows[GvTarifas.Rows.Count - 1].Cells[6].Text.ToString());

                    TxtMinI.Text = (minFAnt + 1).ToString();
                    TxtMinF.Text = (minFAnt + Convert.ToInt32(TxtMinutos.Text)).ToString();
                    TxtTotalA.Text = (totAcuAnt + Convert.ToInt32(txtImporte.Text)).ToString();
                }
                else
                {
                    TxtMinI.Text = "0";
                    TxtMinF.Text = TxtMinutos.Text;
                    TxtTotalA.Text = txtImporte.Text;
                }                
            }
            else
            {
                TxtMinI.Text = "0";
                TxtMinF.Text = TxtMinutos.Text;
                TxtTotalA.Text = txtImporte.Text;
            }   
        }
    }
}