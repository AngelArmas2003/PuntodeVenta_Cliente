using System;

namespace ParkAutoHome.Controles
{
    public partial class Notificacion : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OcultaDiv();
        }
        public void VerMensaje(string ms, int tipoMsj)
        {
            switch (tipoMsj)
            {
                case 1:
                    LblMsjsuccess.Text = ms.ToString();
                    DivSuccess.Visible = true;
                    DivWarning.Visible = false;
                    DivDanger.Visible = false;
                    break;
                case 2:
                    LblMsjwarning.Text = ms.ToString();
                    DivSuccess.Visible = false;
                    DivWarning.Visible = true;
                    DivDanger.Visible = false;
                    break;
                case 3:
                    LblMsjdanger.Text = ms.ToString();
                    DivSuccess.Visible = false;
                    DivWarning.Visible = false;
                    DivDanger.Visible = true;
                    break;
            }
        }

        public void OcultaDiv()
        {
            DivSuccess.Visible = false;
            DivWarning.Visible = false;
            DivDanger.Visible = false;
        }
    }
}