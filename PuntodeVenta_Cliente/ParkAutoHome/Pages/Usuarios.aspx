<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="ParkAutoHome.Pages.Usuarios" %>

<%--smartNavigation="True"
    MaintainScrollPositionOnPostback="true"--%>

<%@ Register Src="~/Controles/Notificacion.ascx" TagPrefix="uc1" TagName="Notificacion" %>
<%@ Register Src="~/Controles/WucSesion.ascx" TagPrefix="uc1" TagName="WucSesion" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h2>Usuarios</h2>
        <p class="lead"><span style="color: rgb(85, 85, 85); font-family: &quot; helvetica neue&quot; , helvetica, arial, sans-serif; font-size: 15px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: uppercase; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 239, 245); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Activacion de Usuarios</span></p>
        <uc1:WucSesion runat="server" id="WucSesion" />
        <asp:UpdatePanel runat="server" ID="UpdatePanel2"
            UpdateMode="Conditional">
            <ContentTemplate>
                
                    <div class="row" style="margin:3px; border:double;">
                        <div class="col-md-3" style="display: flex; justify-content: right; padding: 10px;">
                            <label>Nombre:</label>
                            <asp:TextBox ID="TxtBNombre" runat="server" CssClass="form-control" />
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <label>Usuario:</label>
                            <asp:TextBox ID="TxtBUsuario" runat="server" CssClass="form-control" />
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Button ID="BtnBusqueda" runat="server" class="btn btn-primary btn-md" Text="Filtrar búsqueda" OnClick="BtnBusqueda_Click" />
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:Button ID="BtnLimpiar" runat="server" class="btn btn-primary btn-md" Text="Limpiar" OnClick="BtnLimpiar_Click" />
                        </div>
                    </div>
                <br />
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" PageSize="15"
                    AutoGenerateColumns="false" OnPageIndexChanging="GridView1_PageIndexChanging"
                    OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                    CssClass="mydatagrid" PagerStyle-CssClass="pager" 
                    HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="idUsuario">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Nombre" HeaderText="Nombre">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>

                        <asp:BoundField DataField="Usuario" HeaderText="Usuario">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>

                        <asp:BoundField DataField="Contraseña" HeaderText="Contraseña">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" CssClass="hiddencol" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Activo" HeaderText="Activo">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:CommandField ShowSelectButton="True" HeaderStyle-BackColor="Blue" ControlStyle-ForeColor="Green" />
                    </Columns>
                </asp:GridView>
            </ContentTemplate>
            <Triggers></Triggers>
        </asp:UpdatePanel>

        <br />
        <br />
        <asp:UpdatePanel runat="server" ID="UpdatePanel" UpdateMode="Always">
            <ContentTemplate>
                <div align="center">
                    <div class="row">
                        <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Label ID="Label1" runat="server" Text="IdUsuario"></asp:Label>
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="txtid" runat="server" Width="46px" class="form-control CajaTexto"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="txtnombre" runat="server" Width="450px" class="form-control CajaTexto"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Label ID="Label3" runat="server" Text="Usuario"></asp:Label>
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="txtusuario" runat="server" Width="450px" class="form-control CajaTexto"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Label ID="Label4" runat="server" Text="Contraseña"></asp:Label>
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="txtcontraseña" runat="server" Width="450px" class="form-control CajaTexto" TextMode="Password"> </asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Label ID="lblcontra2" runat="server" Text="Confirmar Contraseña"></asp:Label>
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="txtConfirmar" runat="server" Width="450px" class="form-control CajaTexto" TextMode="Password"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Label ID="Label5" runat="server" Text="Estatus"></asp:Label>
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:CheckBox ID="ckEstatus" runat="server"/>
                        </div>
                    </div>
                    <div class="row" style="padding: 10px; justify-content: center; display: flex;">
                        <div class="col-md-2">
                            <asp:Button ID="btnNuevo" runat="server" class="btn btn-primary btn-lg" Height="43px" OnClick="Button2_Click" Text="Nuevo" Width="112px" />
                        </div>
                        <div class="col-md-2">
                            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Height="43px" OnClick="btnEditar_Click" Width="114px" class="btn btn-primary btn-lg" />
                        </div>
                        <div class="col-md-2">
                            <asp:Button ID="btnEditar" runat="server" Height="43px" Text="Editar" Width="116px" OnClick="Button1_Click" class="btn btn-primary btn-lg" />
                        </div>
                        <div class="col-md-2">
                            <asp:Button ID="Button1" runat="server" Height="43px" Text="Cancelar" Width="117px" OnClick="Button3_Click" class="btn btn-primary btn-lg" ValidationGroup="1" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-12" style="text-align: center; padding: 20px">
                            <uc1:Notificacion runat="server" ID="Notificacion" />
                        </div>
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
