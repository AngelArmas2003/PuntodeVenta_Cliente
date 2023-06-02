﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="Determinantes.aspx.cs" Inherits="ParkAutoHome.Pages.Determinantes" %>

<%@ Register Src="~/Controles/Notificacion.ascx" TagPrefix="uc1" TagName="Notificacion" %>
<%@ Register Src="~/Controles/WucSesion.ascx" TagPrefix="uc1" TagName="WucSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:WucSesion runat="server" ID="WucSesion" />
    <asp:UpdatePanel runat="server" ID="UpdatePanel2" UpdateMode="Conditional">
        <ContentTemplate>
            <div class="jumbotron">
                <h2>Plazas y Determinantes</h2>
                <p class="lead"><span style="color: rgb(85, 85, 85); font-family: &quot; helvetica neue&quot; , helvetica, arial, sans-serif; font-size: 15px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: uppercase; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 239, 245); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Activación de Plazas y Determinantes</span></p>
                <asp:Panel runat="server" DefaultButton="BtnBusqueda">
                    <div class="row" style="margin: 3px; border: double;">
                        <div class="col-md-3" style="display: flex; justify-content: right; padding: 10px;">
                            <label>Empresa:</label>
                            <asp:TextBox ID="TxtBEmpresa" runat="server" CssClass="form-control" class="form-control CajaTexto" />
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <label>Estacionamiento:</label>
                            <asp:TextBox ID="TxtBEstacionamiento" runat="server" CssClass="form-control" class="form-control CajaTexto" />
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Button ID="BtnBusqueda" runat="server" class="btn btn-primary btn-md" Text="Filtrar búsqueda" OnClick="BtnBusqueda_Click" />
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:Button ID="BtnLimpiar" runat="server" class="btn btn-primary btn-md" Text="Limpiar" OnClick="BtnLimpiar_Click" />
                        </div>
                    </div>
                </asp:Panel>
                <br />
                <asp:GridView ID="GvDeterminantes" runat="server" AllowPaging="True"
                    AutoGenerateColumns="false" OnPageIndexChanging="GvDeterminantes_PageIndexChanging"
                    OnSelectedIndexChanged="GvDeterminantes_SelectedIndexChanged" PageSize="15"
                    CssClass="mydatagrid" PagerStyle-CssClass="pager"
                    HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="40" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Codigo_Proveedor" HeaderText="Proveedor">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="30" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:BoundField DataField="CveEmpresa" HeaderText="CveEmpresa">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="50" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Nombre_Empresa" HeaderText="Nombre Empresa">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="450" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:BoundField DataField="CveEstamto" HeaderText="CveEstamto">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="50" CssClass="hiddencol" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                            <ItemStyle Width="100px" />
                            <ControlStyle Width="500px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Estacionamiento" HeaderText="Estacionamiento">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="350" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Determinante" HeaderText="Determinante">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="50" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                            <ItemStyle Width="100" />
                            <ControlStyle Width="300px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Activo" HeaderText="Activo">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:CommandField ShowSelectButton="True" HeaderStyle-BackColor="Blue" ControlStyle-ForeColor="Green" />
                    </Columns>
                </asp:GridView>
                <br />
                <br />
                <div align="center">
                    <div class="row">
                        <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Label ID="Proveedor" runat="server" Text="Codigo Proveedor"></asp:Label>
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="txtProveedor" runat="server" MaxLength="2" onkeydown="return (!(event.keyCode>=65) && event.keyCode!=32)" Width="68px" class="form-control CajaTexto"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Label ID="Label1" runat="server" Text="Empresa"></asp:Label>
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:DropDownList ID="ddlEmpresa" runat="server" Height="30px" Width="310px"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Label ID="Label5" runat="server" Text="Estacionamiento"></asp:Label>
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:DropDownList ID="ddlEstamto" runat="server" Height="30px" Width="310px"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Label ID="Label3" runat="server" Text="Determinante"></asp:Label>
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="txtDeterminante" runat="server" MaxLength="4" onkeydown="return (!(event.keyCode>=65) && event.keyCode!=32)" Width="68px" Style="text-transform: uppercase" class="form-control CajaTexto"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Label ID="Label2" runat="server" Text="Estatus"></asp:Label>
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:CheckBox ID="ckEstatus" runat="server" Font-Size="Large" TextAlign="right" Font-Bold="false" />
                        </div>
                    </div>
                    <div class="row" style="padding: 10px; justify-content: center; display: flex;">
                        <div class="col-md-2">
                            <asp:Button ID="btnNuevo" runat="server" Height="43px" Text="Nuevo" Width="112px" OnClick="Button2_Click" class="btn btn-primary btn-lg" />
                        </div>
                        <div class="col-md-2">
                            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Height="43px" OnClick="btnEditar_Click" Width="114px" class="btn btn-primary btn-lg" />
                        </div>
                        <div class="col-md-2">
                            <asp:Button ID="btnEditar" runat="server" Height="43px" Text="Editar" Width="116px" OnClick="Button1_Click" class="btn btn-primary btn-lg" />
                        </div>
                        <div class="col-md-2">
                            <asp:Button ID="Button1" runat="server" Height="43px" Text="Cancelar" Width="117px" OnClick="Button3_Click" class="btn btn-primary btn-lg" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-12" style="text-align: center; padding: 20px">
                            <uc1:Notificacion runat="server" ID="Notificacion" />
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>


</asp:Content>
