<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="TarifaExcedente.aspx.cs" Inherits="ParkAutoHome.Pages.TarifaExcedente" %>

<%@ Register Src="~/Controles/Notificacion.ascx" TagPrefix="uc1" TagName="Notificacion" %>
<%@ Register Src="~/Controles/WucSesion.ascx" TagPrefix="uc1" TagName="WucSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:WucSesion runat="server" ID="WucSesion" />
    <asp:UpdatePanel runat="server" ID="UpdatePanel2" UpdateMode="Conditional">
        <ContentTemplate>
            <div class="jumbotron">
                <h2>Tarifas de Plazas o Centros Comerciales</h2>
                <p class="lead"><span style="color: rgb(85, 85, 85); font-family: &quot; helvetica neue&quot; , helvetica, arial, sans-serif; font-size: 15px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: uppercase; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 239, 245); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Seleccione una Plaza o Centro Comercial</span></p>
                <div class="row">
                    <div class="col-md-5" style="display: flex; justify-content: right; padding: 10px;">
                        <asp:Label ID="lblEstamto" runat="server" Text="Estacionamiento"></asp:Label>
                    </div>
                    <div class="col-md-3" style="display: flex; justify-content: left; padding: 10px;">
                        <asp:DropDownList ID="ddlEmpresas" runat="server" Height="30px" Width="395px" AutoPostBack="True" OnTextChanged="ddlEmpresas_TextChanged"></asp:DropDownList>
                    </div>
                </div>
                <p class="lead"><span style="color: rgb(9,3,255); font-family: &quot; helvetica neue&quot; , helvetica, arial, sans-serif; font-size: 15px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: uppercase; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 239, 245); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Información de Tarifas</span></p>
                <asp:GridView ID="GvTarifas" runat="server" AllowPaging="True"
                    AutoGenerateColumns="false"  PageSize="15"
                    OnSelectedIndexChanged="GvTarifas_SelectedIndexChanged"
                    CssClass="mydatagrid" PagerStyle-CssClass="pager"
                    HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="Id">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:BoundField DataField="CveTarifa" HeaderText="CveTarifa">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Minutos" HeaderText="Minutos">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:BoundField DataField="ImporteMinutos" HeaderText="ImporteMinutos">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                            <ItemStyle Width="200px" />
                            <ControlStyle Width="300px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="MinutoInicial" HeaderText="MinutoInicial">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" CssClass="hiddencol" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                            <ItemStyle Width="400px" />
                            <ControlStyle Width="500px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="MinutoFinal" HeaderText="MinutoFinal">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" CssClass="hiddencol" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                            <ItemStyle Width="400px" />
                            <ControlStyle Width="500px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="TotalAcumulado" HeaderText="TotalAcumulado">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" CssClass="hiddencol" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                            <ItemStyle Width="400px" />
                            <ControlStyle Width="500px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="Determinante" HeaderText="Determinante">
                            <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor="Blue" ForeColor="White" Width="100" CssClass="hiddencol" />
                            <ItemStyle Font-Names="Arial" Font-Size="Smaller" />
                            <ItemStyle Width="400px" />
                            <ControlStyle Width="500px" />
                        </asp:BoundField>
                        <asp:CommandField ShowSelectButton="True" HeaderStyle-BackColor="Blue" ControlStyle-ForeColor="Green" />
                    </Columns>
                </asp:GridView>
                <br />
                <br />
                <div align="center">
                    <div class="row">
                        <div class="col-md-7" style="display: flex; justify-content: right; padding: 10px; margin: 4px -37px;">
                            <asp:Label ID="Label7" runat="server" Text="Determinante"></asp:Label>
                        </div>
                        <div class="col-md-2" style="display: flex; justify-content: left; padding: 10px; margin:auto 36px;">
                            <asp:TextBox ID="TxtDeterminante" runat="server" Width="67px" class="form-control CajaTexto"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row" style="display: flex; justify-content: center;">
                        <div class="col-md-2" style="display: flex; justify-content: right; padding: 10px; margin: 4px;">
                            <asp:Label ID="Label1" runat="server" Text="CveTarifa"></asp:Label>
                        </div>
                        <div class="col-md-1" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="txtCveTarifa" runat="server" Width="67px" MaxLength="2" class="form-control CajaTexto"></asp:TextBox>
                        </div>
                        <div class="col-md-2" style="display: flex; justify-content: right; padding: 10px; margin: 4px;">
                            <asp:Label ID="Label3" runat="server" Text="Minutos"></asp:Label>
                        </div>
                        <div class="col-md-1" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="TxtMinutos" runat="server" Width="67px" MaxLength="3" class="form-control CajaTexto"
                                onkeydown="return (!(event.keyCode>=65) && event.keyCode!=32)"></asp:TextBox>
                        </div>
                        <div class="col-md-2" style="display: flex; justify-content: right; padding: 10px; margin: 4px;">
                            <asp:Label ID="Label4" runat="server" Text="Importe por Tiempo"></asp:Label>
                        </div>
                        <div class="col-md-1" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="txtImporte" runat="server" Width="67px" class="form-control CajaTexto"
                                 MaxLength="5"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegexDecimal" runat="server" ErrorMessage="Ingrese números" ForeColor="Red"
                                ValidationExpression="((\d+)((\.\d{1,2})?))$"  ControlToValidate="txtImporte" />
                        </div>
                    </div>
                    <div class="row" style="display: flex; justify-content: center;">
                        <div class="col-md-2">
                            <asp:Panel runat="server" DefaultButton="BtnAsigna">
                                <asp:Button ID="BtnAsigna" runat="server" onclick="BtnAsigna_Click" Visible="true" Width="0px" Height="0px" BorderColor="Transparent" />
                            </asp:Panel>
                        </div>                        
                    </div>
                    <div class="row" style="display: flex; justify-content: center;">
                        <div class="col-md-2" style="display: flex; justify-content: right; padding: 10px; margin: 4px;">
                            <asp:Label ID="Label2" runat="server" Text="Minuto Inicial"></asp:Label>
                        </div>
                        <div class="col-md-1" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="TxtMinI" runat="server" Width="67px" class="form-control CajaTexto"></asp:TextBox>
                        </div>
                        <div class="col-md-2" style="display: flex; justify-content: right; padding: 10px; margin: 4px;">
                            <asp:Label ID="Label5" runat="server" Text="Minuto Final"></asp:Label>
                        </div>
                        <div class="col-md-1" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="TxtMinF" runat="server" Width="67px" class="form-control CajaTexto"></asp:TextBox>
                        </div>
                        <div class="col-md-2" style="display: flex; justify-content: right; padding: 10px; margin: 4px;">
                            <asp:Label ID="Label6" runat="server" Text="Total Acumulado"></asp:Label>
                        </div>
                        <div class="col-md-1" style="display: flex; justify-content: left; padding: 10px;">
                            <asp:TextBox ID="TxtTotalA" runat="server" Width="67px" class="form-control CajaTexto"></asp:TextBox>
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
