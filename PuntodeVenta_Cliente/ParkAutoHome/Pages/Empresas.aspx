<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="Empresas.aspx.cs" Inherits="ParkAutoHome.Pages.Empresas" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Src="~/Controles/Notificacion.ascx" TagPrefix="uc1" TagName="Notificacion" %>
<%@ Register Src="~/Controles/WucSesion.ascx" TagPrefix="uc1" TagName="WucSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:WucSesion runat="server" ID="WucSesion" />
    <div class="jumbotron">
        <h2>Empresas</h2>
        <p class="lead"><span style="color: rgb(85, 85, 85); font-family: &quot; helvetica neue&quot; , helvetica, arial, sans-serif; font-size: 15px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: uppercase; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 239, 245); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Alta de Empresas</span></p>

        <asp:Panel runat="server" DefaultButton="BtnBusqueda">
            <div class="row" style="margin: 3px; border: double;">
                <div class="col-md-3" style="display: flex; justify-content: right; padding: 10px;">
                    <label>Nombre:</label>
                    <asp:TextBox ID="TxtBNombre" runat="server" CssClass="form-control" />
                </div>
                <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                    <label>RFC:</label>
                    <asp:TextBox ID="TxtBRFC" runat="server" CssClass="form-control" />
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
        <asp:UpdatePanel runat="server" ID="UpdatePanel2" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:GridView ID="GVEmpresas" runat="server" AllowPaging="True"
                    AutoGenerateColumns="false" OnPageIndexChanging="GVEmpresas_PageIndexChanging"
                    OnSelectedIndexChanged="GVEmpresas_SelectedIndexChanged" PageSize="15"
                    CssClass="mydatagrid" PagerStyle-CssClass="pager"
                    HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
                    <Columns>
                        <asp:BoundField DataField="IdEmpresa" HeaderText="Clave Empresa">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:BoundField DataField="NombreEmpresa" HeaderText="Nombre Empresa">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="350" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:BoundField DataField="RFC" HeaderText="Rfc">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                            <ItemStyle Width="200px" />
                            <ControlStyle Width="300px" />
                        </asp:BoundField>
                        <asp:CommandField ShowSelectButton="True" HeaderStyle-BackColor="Blue" ControlStyle-ForeColor="Green" />
                    </Columns>
                </asp:GridView>
                <br />
                <br />
                <div align="center">
                    <div class="row">
                        <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Label ID="Label2" runat="server" Text="Nombre de Empresa"></asp:Label>
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="txtnomEmpresa" runat="server" Width="279px" Style="text-transform: uppercase" class="form-control CajaTexto"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Label ID="Label3" runat="server" Text="RFC"></asp:Label>
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="txtrfc" runat="server" Width="148px" Style="text-transform: uppercase" class="form-control CajaTexto"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row" style="padding: 10px; justify-content: center; display: flex;">
                        <div class="col-md-2">
                            <asp:Button ID="btnNuevo" runat="server" Height="43px" Text="Nuevo" Width="112px" OnClick="Button2_Click" class="btn btn-primary btn-lg" />
                        </div>
                        <div class="col-md-2">
                            <%--<asp:Button ID="btnGuardar" runat="server" Text="Guardar" Height="43px" OnClick="btnEditar_Click" Width="114px" class="btn btn-primary btn-lg" />--%>
                            <asp:Button ID="btnGuardar" Text="Guardar" runat="server" OnClick="btnAceptar_Click" Height="43px" Width="114px" class="btn btn-primary btn-lg" />
                        </div>
                        <div class="col-md-2">
                            <asp:Button ID="btnEditar" runat="server" Height="43px" Text="Editar" Width="116px" OnClick="Button1_Click" class="btn btn-primary btn-lg" />
                        </div>
                        <div class="col-md-2">
                            <asp:Button ID="Button1" runat="server" Height="43px" Text="Cancelar" Width="117px" OnClick="Button3_Click" class="btn btn-primary btn-lg" />
                        </div>
                    </div>
                    <div class="row">
                        <asp:Button ID="btnShowPopup" runat="server" Style="display: none" />
                        <asp:ModalPopupExtender ID="ModalMsj" runat="server" PopupControlID="PnlMsj"
                            Enabled="True" DropShadow="true"
                            BackgroundCssClass="modalBackground" TargetControlID="btnShowPopup">
                        </asp:ModalPopupExtender>
                        <asp:Panel ID="PnlMsj" runat="server" CssClass="modalPopup" align="center" Style="display: none">
                            <div class="row">
                                <div class="col-md-11" style="display: flex; justify-content: center; padding: 10px;">
                                    <p class="lead">
                                        <span>¿Están correctos todos los datos?</span>
                                    </p>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-5" style="display: flex; justify-content: center; padding: 10px;">
                                    <asp:Button ID="BtnCloseM" Text="Cancelar" runat="server" OnClick="BtnCloseM_Click" Height="43px" Width="114px" class="btn btn-primary btn-lg" />
                                </div>
                                <div class="row">
                                    <div class="col-md-5" style="display: flex; justify-content: center; padding: 10px;">
                                        <asp:Button ID="BtnContinuar" Text="Continuar" runat="server" OnClick="btnEditar_Click" OnClientClick="SetClientRefresh()" Height="43px" Width="114px" class="btn btn-primary btn-lg" />
                                    </div>
                                </div>
                        </asp:Panel>
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
