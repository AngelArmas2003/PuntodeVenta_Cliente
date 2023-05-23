<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Usuarios.aspx.vb" Inherits="PageHome.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
    <br>
    <asp:TextBox ID="txtusuario" runat="server" Height="22px" Width="129px"></asp:TextBox>
   

    <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
    <br>
    <asp:TextBox ID="txtcontra" runat="server" Height="22px" Width="129px"></asp:TextBox>

     <br>
    <br>
    <asp:Button ID="Button1" runat="server" Text="Aceptar" />


</asp:Content>
