<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Notificacion.ascx.cs" Inherits="ParkAutoHome.Controles.Notificacion" %>
<link href="../Content/bootstrap.css" rel="stylesheet" />
<div runat="server" id="DivGlobal">
    <div class="alert alert-success" role="alert" runat="server" id="DivSuccess" visible="false">
        <button type="button" class="close" data-dismiss="alert" aria-label="Close">
            <span aria-hidden="true">&times;</span>
        </button>
        <strong>
            <asp:Label ID="LblMsjsuccess" runat="server"></asp:Label>
        </strong>
    </div>

    <div class="alert alert-warning" role="alert" runat="server" id="DivWarning" visible="false">
        <button type="button" class="close" data-dismiss="alert" aria-label="Close">
            <span aria-hidden="true">&times;</span>
        </button>
        <strong>
            <asp:Label ID="LblMsjwarning" runat="server"></asp:Label>
        </strong>
    </div>

    <div class="alert alert-danger" role="alert" runat="server" id="DivDanger" visible="false">
        <button type="button" class="close" data-dismiss="alert" aria-label="Close">
            <span aria-hidden="true">&times;</span>
        </button>
        <strong>
            <asp:Label ID="LblMsjdanger" runat="server"></asp:Label>
        </strong>
    </div>
</div>

