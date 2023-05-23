<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ParkAutoHome.Pages.Login" %>

    <asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
  
     <div class="jumbotron" a>
         
        <h2> Modulo de Configuraciòn Servidor Dedicado  </h2>
        <p class="lead"><span style="color: rgb(85, 85, 85); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 15px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: uppercase; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 239, 245); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Capture Usuario y Contraseña</span></p>
         <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
    <br />

    <asp:TextBox ID="txtusuario" runat="server"></asp:TextBox>

    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Contraseña" ></asp:Label>
    <br />
     <asp:TextBox ID="txtpass" runat="server"  TextMode="Password"></asp:TextBox>
    <br />
    <br />


         <p>
             <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click1" Width="107px"  class="btn btn-primary btn-lg" />
             <%--<asp:LinkButton href="Configuracion.aspx" ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"  class="btn btn-primary btn-lg">Aceptar &raquo;</asp:LinkButton>--%>
         </p>
         <p>


             
             

    </div>


</asp:Content>
