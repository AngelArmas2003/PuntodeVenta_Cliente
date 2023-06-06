using Newtonsoft.Json;
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
        public List<WsPA.Tarifas> LstTarifaP = new List<WsPA.Tarifas>();
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
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            TarifasConsulta();

            #region Obtenter clave
            Button btn = (Button)sender;
            switch (btn.ID)
            {
                case "btnNuevo":
                    //WsPA.Tarifas tarifa = new WsPA.Tarifas();
                    //WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
                    //string clave = "";
                    //tarifa.Determinante = TxtDeterminante.Text;
                    //tarifa.Opcion = 1;
                    //clave = client.TarifaCveConsulta(tarifa);
                    //txtCveTarifa.Text = Convert.ToInt32(clave).ToString("D2");
                    txtCveTarifa.Enabled = true;
                    break;
                case "BtnAgregar":
                    txtCveTarifa.Text = Convert.ToInt32(GvTarifas.Rows[GvTarifas.Rows.Count - 1].Cells[1].Text.ToString()).ToString("D2");
                    break;
            }

            #endregion
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
                WsPA.Tarifas tarifa = new WsPA.Tarifas();

                if (btnGuardar.Text.Contains("Guardar"))
                {
                    tarifa.Opcion = 1;
                    tarifa.id = "0";
                    tarifa.CveTarifa = txtCveTarifa.Text;
                    tarifa.Minutos = Convert.ToInt32(TxtMinutos.Text);
                    tarifa.ImporteMinutos = Convert.ToInt32(txtImporte.Text);
                    tarifa.MinutoInicial = Convert.ToInt32(TxtMinI.Text);
                    tarifa.MinutoFinal = Convert.ToInt32(TxtMinF.Text);
                    tarifa.TotalAcumulado = Convert.ToDouble(TxtTotalA.Text);
                    tarifa.Determinante = TxtDeterminante.Text;
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
                    LstTarifaP = new List<WsPA.Tarifas>();
                    List<WsPA.Tarifas> LstTarifaPAnt = new List<WsPA.Tarifas>();
                    LstTarifaP = (List<WsPA.Tarifas>)Session["LstTarifa"];
                    int i = 0;
                    foreach (var item in LstTarifaP.Where(x => x.TotalAcumulado >= Convert.ToDouble(HdTotA.Value)))
                    {
                        tarifa = new WsPA.Tarifas();                        
                        tarifa.Opcion = 2;
                        //para el primer registro
                        if (i == 0)
                        {
                            tarifa.id = Session["Id"].ToString();
                            tarifa.CveTarifa = txtCveTarifa.Text;
                            tarifa.Minutos = Convert.ToInt32(TxtMinutos.Text);
                            tarifa.ImporteMinutos = Convert.ToInt32(txtImporte.Text);
                            tarifa.MinutoInicial = Convert.ToInt32(TxtMinI.Text);
                            tarifa.MinutoFinal = Convert.ToInt32(TxtMinF.Text);
                            tarifa.TotalAcumulado = Convert.ToDouble(TxtTotalA.Text);
                            tarifa.Determinante = TxtDeterminante.Text;
                            string ResponseJson = JsonConvert.SerializeObject(tarifa);
                            var a = client.TarifaDetExceReg_Act(ResponseJson);
                        }
                        else
                        {//a partir del segundo registro                          
                            tarifa.id = item.id;
                            tarifa.CveTarifa = item.CveTarifa;
                            tarifa.Minutos = Convert.ToInt32(item.Minutos);
                            tarifa.ImporteMinutos = Convert.ToInt32(item.ImporteMinutos);
                            tarifa.MinutoInicial = Convert.ToInt32(LstTarifaPAnt.FirstOrDefault().MinutoFinal + 1);
                            tarifa.MinutoFinal = Convert.ToInt32(LstTarifaPAnt.FirstOrDefault().MinutoFinal + item.Minutos);
                            tarifa.TotalAcumulado = Convert.ToDouble(LstTarifaPAnt.FirstOrDefault().TotalAcumulado + item.ImporteMinutos);
                            tarifa.Determinante = TxtDeterminante.Text;
                            string ResponseJson = JsonConvert.SerializeObject(tarifa);
                            var a = client.TarifaDetExceReg_Act(ResponseJson);                            
                        }
                        LstTarifaPAnt = new List<WsPA.Tarifas>();
                        LstTarifaPAnt.Add(tarifa);
                        i = i + 1;
                    }
                    Notificacion.VerMensaje("Tarifa(s) determinante(s) actualizada(s) correctamente.", 1);
                    Session["LstTarifa"] = "";
                    TarifasConsulta();
                    Inicio();
                    HdTotA.Value = "";
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
        }

        protected void ddlEmpresas_TextChanged(object sender, EventArgs e)
        {
            TarifasConsulta();
            Inicio();
        }

        public void Inicio()
        {
            //if (GvTarifas.Rows.Count > 0)
            txtCveTarifa.Enabled = false;
            //else
            //    txtCveTarifa.Enabled = true;

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
            if (GvTarifas.Rows.Count > 0)
                btnNuevo.Enabled = false;
            else
                btnNuevo.Enabled = true;
            btnNuevo.Text = "Nuevo";
            btnEditar.Enabled = false;
            btnGuardar.Text = "Guardar";
        }

        public void TarifasConsulta()
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            WsPA.Tarifas entT = new WsPA.Tarifas();
            entT.Determinante = ddlEmpresas.SelectedValue;
            entT.Opcion = 1;
            WsPA.Tarifas[] entTR = client.TafiasDeterminantes(entT);
            if (entTR.Length > 0)
            {
                LstTarifaP = new List<WsPA.Tarifas>();
                LstTarifaP = entTR.ToList();
                Session["LstTarifa"] = LstTarifaP.ToList();
                GvTarifas.DataSource = LstTarifaP.ToList();
                GvTarifas.DataBind();
            }
            else
            {
                List<string> lstv = new List<string>();
                GvTarifas.DataSource = lstv.ToList();
                GvTarifas.DataBind();
            }
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
            Session["Index"] = GvTarifas.SelectedIndex;
            HdTotA.Value = GvTarifas.SelectedRow.Cells[6].Text;               
        }

        protected void BtnAsigna_Click(object sender, EventArgs e)
        {
            if (GvTarifas.Rows.Count > 0)
            {
                //if(GvTarifas.Rows[GvTarifas.Rows.Count - 1].Cells[1].Text.ToString() == txtCveTarifa.Text)
                //{
                int minFAnt = 0;
                double totAcuAnt = 0;
                int indice = 0;
                if (Convert.ToInt32(Session["Index"]) == 0)
                    indice = Convert.ToInt32(Session["Index"]);
                else
                    indice = Convert.ToInt32(Session["Index"]) - 1;
                
                if(Convert.ToInt32(Session["Index"]) == 0)
                {
                    TxtMinI.Text = "0";
                    TxtMinF.Text = TxtMinutos.Text;
                    TxtTotalA.Text = txtImporte.Text;
                }
                else
                {
                    minFAnt = Convert.ToInt32(GvTarifas.Rows[indice].Cells[5].Text.ToString());
                    totAcuAnt = Convert.ToDouble(GvTarifas.Rows[indice].Cells[6].Text.ToString());
                    TxtMinI.Text = (minFAnt + 1).ToString();
                    TxtMinF.Text = (minFAnt + Convert.ToInt32(TxtMinutos.Text)).ToString();
                    TxtTotalA.Text = (totAcuAnt + Convert.ToInt32(txtImporte.Text)).ToString();
                }               
            }
            else
            {
                TxtMinI.Text = "0";
                TxtMinF.Text = TxtMinutos.Text;
                TxtTotalA.Text = txtImporte.Text;
            }
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