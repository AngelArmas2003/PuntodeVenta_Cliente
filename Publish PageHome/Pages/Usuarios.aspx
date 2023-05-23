<%@ Page Title="" Language="C#" MasterPageFile="~/Site3.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="ParkAutoHome.Pages.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="jumbotron">
        <h2>Usuarios</h2>
        <p class="lead"><span style="color: rgb(85, 85, 85); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 15px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: justify; text-indent: 0px; text-transform: uppercase; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(232, 239, 245); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Activacion de Usuarios</span></p>
      
          <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="false" onpageindexchanging="GridView1_PageIndexChanging" 
            onselectedindexchanged="GridView1_SelectedIndexChanged"  horizontalalign="Center" BorderColor="Blue" ForeColor ="Black" >
            <Columns>
                <asp:BoundField DataField="id" HeaderText="idUsuario" >
                <%--<ControlStyle Font-Names="Arial" Font-Size="Medium" />--%>
                <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White"  Width="100" />   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                </asp:BoundField>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre">
                     <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White"  Width="100"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                    </asp:BoundField>

                <asp:BoundField DataField="Usuario" HeaderText="Usuario" >
                    <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White" Width="100"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                    </asp:BoundField>

                <asp:BoundField DataField="Contraseña" HeaderText="Contraseña" >
                    <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White" Width="100"  CssClass="hiddencol"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                    </asp:BoundField>
                <asp:BoundField DataField="Activo" HeaderText="Activo" >
                    <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White" Width="100"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                    </asp:BoundField>
             <%--  <asp:BoundField DataField="FechaRegistro" HeaderText="FechaRegistro" >
                    <HeaderStyle Font-Names="Arial" Font-Size="Smaller" BackColor ="Blue" ForeColor ="White" Width="200"/>   
                    <ItemStyle Font-Names="Arial" Font-Size="Smaller" /> 
                   </asp:BoundField>--%>
                <asp:CommandField ShowSelectButton="True"  HeaderStyle-BackColor ="Blue"   ControlStyle-ForeColor ="Green"    />
            </Columns>
        </asp:GridView>
         <br />
         <br />


         <div align="center">
     
         <asp:Label ID="Label1" runat="server" Text="IdUsuario"></asp:Label>
             &nbsp;&nbsp;<asp:TextBox ID="txtid" runat="server" Width="46px"></asp:TextBox>
           
             &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
         
        &nbsp;&nbsp;&nbsp;
         
        <asp:TextBox ID="txtnombre" runat="server" Width="203px"></asp:TextBox>
           
             &nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text="Usuario"></asp:Label>
         &nbsp;&nbsp;
        <asp:TextBox ID="txtusuario" runat="server" Width="88px"></asp:TextBox>
         &nbsp;&nbsp;&nbsp;
          <br />
             <br />
         <asp:Label ID="Label4" runat="server" Text="Contraseña"></asp:Label>
         &nbsp;&nbsp;<asp:TextBox ID="txtcontraseña" runat="server" Width="122px" > </asp:TextBox>

              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

              <asp:Label ID="lblcontra2" runat="server" Text="Confirmar Contraseña"></asp:Label>
         &nbsp;&nbsp;<asp:TextBox ID="txtConfirmar" runat="server" Width="122px" ></asp:TextBox>
             <br />
             <br />
          <asp:CheckBox ID="ckEstatus" runat="server"  Text ="  Estatus" Font-Size="Large" TextAlign="right" Font-Bold="false"/>
         
         
           <br />
           <br />
        
         <br />
         
         <asp:Button ID="btnNuevo" runat="server" class="btn btn-primary btn-lg" Height="43px" OnClick="Button2_Click" Text="Nuevo" Width="112px" />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Height="43px" OnClick="btnEditar_Click" Width="114px" class="btn btn-primary btn-lg" />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnEditar" runat="server" Height="43px" Text="Editar" Width="116px" OnClick="Button1_Click" class="btn btn-primary btn-lg"/>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="Button1" runat="server" Height="43px" Text="Cancelar" Width="117px" OnClick="Button3_Click" class="btn btn-primary btn-lg"/>
         <br />
             </div>
        
    </div>





     





     </div>
</asp:Content>
