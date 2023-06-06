<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="MinGracia.aspx.cs" Inherits="ParkAutoHome.Pages.MinGracia" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Src="~/Controles/Notificacion.ascx" TagPrefix="uc1" TagName="Notificacion" %>
<%@ Register Src="~/Controles/WucSesion.ascx" TagPrefix="uc1" TagName="WucSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:WucSesion runat="server" ID="WucSesion" />
    <asp:UpdatePanel runat="server" ID="UpdatePanel2" UpdateMode="Conditional">
        <ContentTemplate>
            <div class="jumbotron">
                <h2>Minutos de Gracia</h2>
                <p class="lead"><span style="color: rgb(85, 85, 85); font-family: &quot; helvetica neue&quot; , helvetica, arial, sans-serif; font-size: 15px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: uppercase; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 239, 245); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Consulta</span></p>               
                <asp:GridView ID="GvMinG" runat="server" AllowPaging="True"
                    AutoGenerateColumns="false" OnPageIndexChanging="GvMinG_PageIndexChanging"
                    OnSelectedIndexChanged="GvMinG_SelectedIndexChanged" PageSize="15"
                    CssClass="mydatagrid" PagerStyle-CssClass="pager"
                    HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:BoundField DataField="MinutoGracia" HeaderText="Minutos Gracia">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="200" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Descripcion" HeaderText="Descripción">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="400" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                            <ItemStyle Width="200px" />
                            <ControlStyle Width="300px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="MinGraciaP" HeaderText="Minutos Pago">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                            <ItemStyle Width="200px" />
                            <ControlStyle Width="300px" />
                        </asp:BoundField>
                        <asp:CommandField ShowSelectButton="True" HeaderStyle-BackColor="Blue" ControlStyle-ForeColor="Green" />
                    </Columns>
                </asp:GridView>

                <div align="center">
                    <div class="row">
                        <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Label ID="LblId" runat="server" Text="Id"></asp:Label>
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="TxtId" runat="server" Width="67px" class="form-control CajaTexto"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Label ID="Label1" runat="server" Text="Minutos Gracia"></asp:Label>
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="TxtMG" runat="server" Width="67px" class="form-control CajaTexto"
                                MaxLength="3" onkeydown="return (!(event.keyCode>=65) && event.keyCode!=32)"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Label ID="Label2" runat="server" Text="Descripción"></asp:Label>
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="TxtDescripcion" runat="server" Width="467px" class="form-control CajaTexto"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                            <asp:Label ID="Label3" runat="server" Text="Minutos Pago"></asp:Label>
                        </div>
                        <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="TxtMinP" runat="server" Width="67px" class="form-control CajaTexto"
                                MaxLength="3" onkeydown="return (!(event.keyCode>=65) && event.keyCode!=32)"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row" style="padding: 10px; justify-content: center; display: flex;">                        
                        <div class="col-md-2">
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
            </div>
        </ContentTemplate>
        <Triggers>
        </Triggers>
    </asp:UpdatePanel>

</asp:Content>