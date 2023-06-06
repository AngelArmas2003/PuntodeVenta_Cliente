using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ParkAutoHome.Pages
{
    public partial class MinGracia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Inicio();
                ConsultaMin();
            }
        }

        protected void GvMinG_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void GvMinG_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnGuardar.Text = "Actualizar";
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            TxtId.Text = GvMinG.SelectedRow.Cells[0].Text;
            TxtMG.Text = GvMinG.SelectedRow.Cells[1].Text;
            TxtDescripcion.Text = GvMinG.SelectedRow.Cells[2].Text;
            TxtMinP.Text = GvMinG.SelectedRow.Cells[3].Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            btnGuardar.Text = "Guardar";
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            WsPA.MinGracia ent = new WsPA.MinGracia();
            client = new WsPA.WSPanelControlSoapClient();
            ent.Opc = "2";
            ent.Id = TxtId.Text;
            ent.MinutoGracia = TxtMG.Text;
            ent.Descripcion = TxtDescripcion.Text;
            ent.MinGraciaP = TxtMinP.Text;

            string ResponseJson = JsonConvert.SerializeObject(ent);
            var c = client.MinGraciaAct(ResponseJson);
            if (c <= 0)
            {
                Notificacion.VerMensaje("La información no se pudo actualizar.", 3);
            }
            else
            {
                Notificacion.VerMensaje("La información se actualizó correctamente.", 1);
                Inicio();
                ConsultaMin();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TxtMG.Focus();
            TxtMG.Enabled = true;
            TxtDescripcion.Enabled = true;
            TxtMinP.Enabled = true;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Inicio();
            ConsultaMin();
        }
                
        public void Inicio()
        {
            TxtDescripcion.Enabled = false;
            TxtId.Enabled = false;
            TxtMG.Enabled = false;
            TxtMinP.Enabled = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnGuardar.Text = "Guardar";
            TxtDescripcion.Text = "";
            TxtMG.Text = "";
            TxtMinP.Text = "";
            TxtId.Text = "";
        }

        public void ConsultaMin()
        {
            WsPA.WSPanelControlSoapClient client = new WsPA.WSPanelControlSoapClient();
            WsPA.MinGracia ent = new WsPA.MinGracia();
            ent.Opc = "1";            
            GvMinG.DataSource = null;
            GvMinG.DataSource = client.CatalogoMinGracia(ent);
            GvMinG.DataBind();
        }

        protected void DdlCombo_TextChanged(object sender, EventArgs e)
        {
            ConsultaMin();
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if(TxtMG.Text == "" || TxtDescripcion.Text == "" || TxtMinP.Text == "")
            {
                Notificacion.VerMensaje("Capture todos los campor.", 2);
            }
            else
                ModalMsj.Show();
        }
        protected void BtnCloseM_Click(object sender, EventArgs e)
        {
            ModalMsj.Hide();
        }
    }
}