<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ParkAutoHome.Pages.Login" %>

<%@ Register Src="~/Controles/Notificacion.ascx" TagPrefix="uc1" TagName="Notificacion" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">

        <h2>Modulo de Configuración Servidor Dedicado</h2>
        <%--<p class="lead"><span style="color: rgb(85, 85, 85); font-family: &quot; helvetica neue&quot; , helvetica, arial, sans-serif; font-size: 15px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: uppercase; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 239, 245); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Capture Usuario y Contraseña</span></p>--%>
        <section class="speciality" style="padding: 30px; margin: 10px">
            <div class="row">
                <div class="col-md-12 text-center">
                    <h3 class="heading">
                        <asp:Label runat="server" ID="LblTitulo" Font-Bold="true" Text="Ingrese Usuario y Contraseña"></asp:Label></h3>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12" style="text-align: center; padding: 20px">
                    <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12" style="display: flex; justify-content: center;">
                    <asp:TextBox ID="txtusuario" runat="server" class="form-control CajaTexto"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12" style="text-align: center; padding: 20px">
                    <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-12" style="display: flex; justify-content: center;">
                    <asp:TextBox ID="txtpass" runat="server" TextMode="Password" class="form-control CajaTexto"></asp:TextBox>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12" style="text-align: center; padding: 20px">
                    <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click1" Width="107px" class="btn btn-primary btn-lg" />
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12" style="text-align: center; padding: 20px">
                    <uc1:Notificacion runat="server" ID="Notificacion" />
                </div>
            </div>
        </section>
    </div>

</asp:Content>
