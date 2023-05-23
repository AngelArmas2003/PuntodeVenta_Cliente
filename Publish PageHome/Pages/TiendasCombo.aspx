<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="TiendasCombo.aspx.cs" Inherits="ParkAutoHome.Pages.TiendasCombo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div class="jumbotron">
        <h2>Tiendas Combo</h2>
        <p class="lead"><span style="color: rgb(85, 85, 85); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 15px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: uppercase; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 239, 245); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Seleccione una combo</span></p>



              <asp:Label ID="Combo" runat="server" Text="COMBO"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="ddlCombo" runat="server" Height="16px" Width="395px" AutoPostBack="True" OnTextChanged="ddlCombo_TextChanged"></asp:DropDownList>
           
              <div class="jumbotron">
        <p class="lead"><span style="color: rgb(9,3,255); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 15px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: uppercase; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 239, 245); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;" >Información de Tarifas</span></p>
           <asp:GridView ID="GvTiendasCombo" runat="server" AllowPaging="True" 
            AutoGenerateColumns="false" onpageindexchanging="GvTarifas_PageIndexChanging" 
            onselectedindexchanged="GvTarifas_SelectedIndexChanged"  horizontalalign="Center"  BorderColor="Blue" ForeColor ="Black" >
            <Columns>




                <asp:BoundField DataField="id" HeaderText="id" >
                <%--<ControlStyle Font-Names="Arial" Font-Size="Medium" />--%>
                <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White"  Width="100"  />   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                </asp:BoundField>

                <asp:BoundField DataField="NumeroCombo" HeaderText="Numero de Combo">
                     <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White"  Width="200"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                    </asp:BoundField>

                <asp:BoundField DataField="Determinante" HeaderText="Determinante" >
                    <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White" Width="100"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                    <ItemStyle Width="200px"/>
                    <ControlStyle Width="300px"/>
                    </asp:BoundField>

                <asp:BoundField DataField="NombrePlaza" HeaderText="Plaza o Estacionamiento" >
                    <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White" Width="100"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                    <ItemStyle Width="200px"/>
                    <ControlStyle Width="300px"/>
                    </asp:BoundField>


                   <asp:BoundField DataField="Activo" HeaderText="Activo" >
                    <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White" Width="100"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                    </asp:BoundField>
                
                
                <asp:CommandField ShowSelectButton="True"  HeaderStyle-BackColor ="Blue"   ControlStyle-ForeColor ="Green"    />
            </Columns>
        </asp:GridView>
           
            <br />
            <br />

          <div align="center">
          
           
               <asp:Label ID="lblDeterminante" runat="server" Text="Determinante"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
               <asp:DropDownList ID="ddlDeterminante" runat="server" Height="16px" Width="395px" AutoPostBack="True" OnTextChanged="ddlCombo_TextChanged"></asp:DropDownList>
        
              <%--<asp:Label ID="Label1" runat="server" Text="Determinates"></asp:Label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="395px" AutoPostBack="True" OnTextChanged="ddlCombo_TextChanged"></asp:DropDownList>--%>
              <br />
              <br />
              <br />
         <br />

         
        
           
                   <asp:Button ID="btnNuevo" runat="server" Height="43px" Text="Nuevo" Width="112px" OnClick="Button2_Click" class="btn btn-primary btn-lg"  />
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Height="43px" OnClick="btnEditar_Click" Width="114px" class="btn btn-primary btn-lg" />


          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;


          <asp:Button ID="btnEditar" runat="server" Height="43px" Text="Editar" Width="116px" OnClick="Button1_Click" class="btn btn-primary btn-lg"/>
         
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         
          <asp:Button ID="Button1" runat="server" Height="43px" Text="Cancelar" Width="117px" OnClick="Button3_Click" class="btn btn-primary btn-lg"/>
         
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         
           <br />
           <br />
        
        </div>

     <br />

      </div>





          </div>
</asp:Content>

