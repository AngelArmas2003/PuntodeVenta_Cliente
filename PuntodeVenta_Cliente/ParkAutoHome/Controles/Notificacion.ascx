<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Notificacion.ascx.cs" Inherits="ParkAutoHome.Controles.Notificacion" %>
<link href="../Content/bootstrap.css" rel="stylesheet" />
<div class="alert alert-success" role="alert" runat="server" id="DivSuccess">
    <strong><asp:label id="LblMsjsuccess" runat="server"></asp:label></strong>
    <button type="button" class="close" data-dismiss="alert" aria-label="Close">
        <span aria-hidden="true">&times;</span>
    </button>
</div>

<div class="alert alert-warning" role="alert" runat="server" id="DivWarning">
    <strong><asp:label id="LblMsjwarning" runat="server"></asp:label></strong>
    <button type="button" class="close" data-dismiss="alert" aria-label="Close">
        <span aria-hidden="true">&times;</span>
    </button>
</div>

<div class="alert alert-danger" role="alert" runat="server" id="DivDanger">
    <strong><asp:label id="LblMsjdanger" runat="server"></asp:label></strong>
    <button type="button" class="close" data-dismiss="alert" aria-label="Close">
        <span aria-hidden="true">&times;</span>
    </button>
</div>
